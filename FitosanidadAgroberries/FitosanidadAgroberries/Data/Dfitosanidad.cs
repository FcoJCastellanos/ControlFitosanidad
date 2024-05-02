using FitosanidadAgroberries.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitosanidadAgroberries.Data
{
    public class Dfitosanidad
    {
        public async Task<string> GuardaDatosFitosanidadLocalAsync(string capturaFit, string codigoTtu, string semanaFit, string codigoPla,
            string poblacionFit, string tempMaxFit, string tempMinFit, string tempPromFit, string humMaxFit, string humMinFit, string humPromFit,
            string precipFit, string vientoFot, string observacionFit, string longitud, string latitud, string altura, string codigoUsu)
        {
            string V_mensajeRespuesta;
            if (!string.IsNullOrWhiteSpace(codigoTtu) || !string.IsNullOrWhiteSpace(codigoPla) || !string.IsNullOrWhiteSpace(poblacionFit))
            {
                await App.LocalDB.SaveData(new Mz_regfitosanidad
                {
                    d_captura_fit = capturaFit,
                    c_codigo_ttu = codigoTtu,
                    c_semana_fit = semanaFit,
                    c_codigo_pla = codigoPla,
                    n_poblacion_fit = poblacionFit,
                    n_tempmax_fit = tempMaxFit,
                    n_tempmin_fit = tempMinFit,
                    n_tempprom_fit = tempPromFit,
                    n_hummax_fit = humMaxFit,
                    n_hummin_fit = humMinFit,
                    n_humprom_fit = humPromFit,
                    n_precip_fit = precipFit,
                    n_viento_fit = vientoFot,
                    v_observacion_fit = observacionFit,
                    c_longitud_fit = longitud,
                    c_latitud_fit = latitud,
                    c_altura_fit = altura,
                    c_codigo_usu = codigoUsu,
                    c_sincronizado_fit = "0"
                });
                V_mensajeRespuesta = "Los datos se guardaron con exito!";
            }
            else
            {
                V_mensajeRespuesta = "Fallo el guardado de datos";
            }
            return V_mensajeRespuesta;
        }

        public async Task<List<Mfitosanidad>> VerificaUmbralesAsync(string V_NombrePlaga)
        {
            List<Mumbralesfitosanidad> listA = await App.LocalDB.ConsultaUmbralesLocal(V_NombrePlaga);
            //Eliminar desde aqui
            if (listA.Count == 0)
            {
                Mfitosanidad aux = new Mfitosanidad();
                List<Mfitosanidad> listaC = new List<Mfitosanidad>();
                aux.limiteInferior0 = "0";
                aux.limiteSuperior0 = "0";
                aux.limiteInferior1 = "0";
                aux.limiteSuperior1 = "0";
                aux.limiteInferior2 = "0";
                aux.limiteSuperior2 = "0";
                listaC.Add(aux);

                return listaC;
            }
            //Hasta aqui cuando se agreguen todos los umbrales en la tabla de umbrales
            List<Mfitosanidad> listaB = listA.ConvertAll(x => new Mfitosanidad
            {
                limiteInferior0 = x.n_liminf0_umb,
                limiteSuperior0 = x.n_limsup0_umb,
                limiteInferior1 = x.n_liminf1_umb,
                limiteSuperior1 = x.n_limsup1_umb,
                limiteInferior2 = x.n_liminf2_umb,
                limiteSuperior2 = x.n_limsup2_umb
            });
            return listaB;
        }

        public async Task<string> SincronizaDatosFitosanidadAsync()
        {
            string respuesta = null;
            string V_aux = null;
            List<Mz_regfitosanidad> datosLocalesConsultados;
            datosLocalesConsultados = await App.LocalDB.GetRegistrosFitosanidaAsync();
            try
            {
                if (datosLocalesConsultados.Count == 0)
                {
                    respuesta = "No hay nada que sincronizar.";
                }
                else
                {
                    for (int i = 0; i < datosLocalesConsultados.Count; i++)
                    {
                        if (datosLocalesConsultados[i].c_sincronizado_fit.ToString().Trim().Equals("0"))
                        {
                            XElement xml = XElement.Load("http://54.165.41.23:5054/GuardaCotizacion.asmx/GuardaDatosFitosanidadApp?V_fechaCaptura=" + datosLocalesConsultados[i].d_captura_fit.ToString().Trim() +
                                "&V_codigoTablaTunel=" + datosLocalesConsultados[i].c_codigo_ttu.ToString().Trim() + "&V_numeroSemana=" + datosLocalesConsultados[i].c_semana_fit.ToString().Trim() + "&V_codigoPlaga=" +
                                datosLocalesConsultados[i].c_codigo_pla.ToString().Trim() + "&V_poblacionPlaga=" + datosLocalesConsultados[i].n_poblacion_fit.ToString().Trim() + "&V_temperaturaMaxima=" +
                                datosLocalesConsultados[i].n_tempmax_fit.ToString().Trim() + "&V_temperaturaMinima=" + datosLocalesConsultados[i].n_tempmin_fit.ToString().Trim() + "&V_temperaturaPromedio=" +
                                datosLocalesConsultados[i].n_tempprom_fit.ToString().Trim() + "&V_humedadMaxima=" + datosLocalesConsultados[i].n_hummax_fit.ToString().Trim() + "&V_humedadMinima=" +
                                datosLocalesConsultados[i].n_hummin_fit.ToString().Trim() + "&V_humedadPromedio=" + datosLocalesConsultados[i].n_humprom_fit.ToString().Trim() + "&V_precipitacion=" +
                                datosLocalesConsultados[i].n_precip_fit.ToString().Trim() + "&V_viento=" + datosLocalesConsultados[i].n_viento_fit.ToString().Trim() + "&V_observacion=" +
                                datosLocalesConsultados[i].v_observacion_fit.ToString().Trim() + "&V_longitud=" + datosLocalesConsultados[i].c_longitud_fit.ToString().Trim() + "&V_latitud=" +
                                datosLocalesConsultados[i].c_latitud_fit.ToString().Trim() + "&V_altitud=" + datosLocalesConsultados[i].c_altura_fit.ToString().Trim() + "&V_codigoUsuario=" +
                                datosLocalesConsultados[i].c_codigo_usu.ToString().Trim());
                            if (xml.Value.ToString().Trim().Equals("1"))
                            {
                                try
                                {
                                    await App.LocalDB.ActualizaMz_regfitosanidadLocal(datosLocalesConsultados[i].c_codigo_fit.ToString().Trim());
                                    V_aux = xml.Value.ToString().Trim();
                                }
                                catch (Exception ex)
                                {
                                    V_aux = ex.ToString();
                                }
                            }
                            else
                            {
                                V_aux = "0";
                            }
                        }
                        else
                        {
                            V_aux = "No hay nada que sincronizar.";
                        }
                    }
                    respuesta = V_aux;
                }
            }
            catch (Exception EX)
            {
                respuesta = EX.ToString();
            }
            return respuesta;
        }
    }
}
