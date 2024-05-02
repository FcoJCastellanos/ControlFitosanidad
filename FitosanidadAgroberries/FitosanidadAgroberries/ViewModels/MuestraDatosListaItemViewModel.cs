using FitosanidadAgroberries.Data;
using FitosanidadAgroberries.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class MuestraDatosListaItemViewModel : BaseViewModel
    {
        #region VARIABLES
        string _Color;
        string _CampoSeleccionado;
        public List<Mcampos> _ListaCampos;
        string _SemanaSeleccionada;
        public List<Msemanas> _ListaSemanas;
        public List<Mplagas> _ListaPlagas;
        public List<Mpinsmapas> _ListaResultados;
        public List<Mmuestradatos> _ListaResultadosFinales;
        public List<Mfitosanidad> _UmbralesInfSup;
        #endregion
        #region CONSTRUCTOR
        public MuestraDatosListaItemViewModel()
        {
            CargaDatos();
            Title = "Consulta";
        }
        #endregion
        #region OBJETOS
        public string Color
        {
            get { return _Color; }
            set { _Color = value; OnPropertyChanged(); }
        }
        public string CampoSeleccionado
        {
            get { return _CampoSeleccionado; }
            set { _CampoSeleccionado = value; OnPropertyChanged(); }
        }
        public List<Mcampos> ListaCampos
        {
            get { return _ListaCampos; }
            set { SetValue(ref _ListaCampos, value); }
        }

        public string SemanaSeleccionada
        {
            get { return _SemanaSeleccionada; }
            set { _SemanaSeleccionada = value; OnPropertyChanged(); }
        }
        public List<Msemanas> ListaSemanas
        {
            get { return _ListaSemanas; }
            set { SetValue(ref _ListaSemanas, value); }
        }

        public List<Mplagas> ListaPlagas
        {
            get { return _ListaPlagas; }
            set { SetValue(ref _ListaPlagas, value); }
        }

        public List<Mpinsmapas> ListaResultados
        {
            get { return _ListaResultados; }
            set { SetValue(ref _ListaResultados, value); }
        }
        public List<Mmuestradatos> ListaResultadosFinales
        {
            get { return _ListaResultadosFinales; }
            set { SetValue(ref _ListaResultadosFinales, value); }
        }

        public List<Mfitosanidad> UmbralesInfSup
        {
            get { return _UmbralesInfSup; }
            set { SetValue(ref _UmbralesInfSup, value); }
        }
        #endregion
        #region PROCESOS
        public async void CargaDatos()
        {
            try
            {
                ListaCampos = await App.LocalDB.ConsultaCamposLocal();
            }
            catch (Exception Ex)
            {
                await DisplayAlert("Alerta!", "Hay un problema para mostrar los campos, vuelve e intentarlo por favor. " + Ex.ToString(), "Ok");
                await Navigation.PopAsync();
            }
        }

        public void llenaComboSemanasAsync()
        {
            if (CampoSeleccionado != "" && CampoSeleccionado != "-1")
            {
                try
                {
                    ListaSemanas = null;
                    ListaSemanas = App.LocalDB.ConsultaSemanasLocal().Result;
                }
                catch (Exception) { }
            }
        }

        public async Task MuestraDatos()
        {
            double PoblacionTotal = 0;
            double AuxPoblacion = 0;
            string CampoSel = "";
            string SemanaSel = "";
            List<Mmuestradatos> AuxList = new List<Mmuestradatos>();
            
            try
            {
                //DateTime inputDate = DateTime.Now;
                //CultureInfo currentCulture = new CultureInfo("es-MX");
                //var Semana = currentCulture.Calendar.GetWeekOfYear(
                //inputDate,
                //CalendarWeekRule.FirstDay,
                //DayOfWeek.Sunday);
                //int day = ((int)inputDate.DayOfWeek == 0) ? 7 : (int)inputDate.DayOfWeek;
                //DateTime mondayOfLastWeek = date.AddDays(-(int)date.DayOfWeek - 6);

                CampoSel = ListaCampos[Convert.ToInt16(CampoSeleccionado)].codigoCampo.ToString().Trim();
                SemanaSel = ListaSemanas[Convert.ToInt16(SemanaSeleccionada)].c_codigo_sem.ToString().Trim();
                ListaPlagas = await App.LocalDB.ConsultaPlagasLocal();

                for (int i = 0; i < ListaPlagas.Count; i++)
                {
                    Mmuestradatos AuxDatos = new Mmuestradatos();
                    ListaResultados = await App.LocalDB.ConsultaPinsMapasLocal(CampoSel, SemanaSel.TrimStart(new Char[] { '0' }), ListaPlagas[i].c_codigo_pla);

                    if (ListaResultados.Count != 0)
                    {
                        
                        for (int j = 0; j < ListaResultados.Count; j++)
                        {
                            PoblacionTotal += Convert.ToDouble(ListaResultados[j].n_poblacion_fit.Trim());
                        }

                        AuxPoblacion = ((PoblacionTotal / ListaResultados.Count)/7);

                        AuxDatos.nombreCampo = ListaResultados[0].v_nombre_cam;
                        AuxDatos.nombreLote = ListaResultados[0].v_nombre_lot;
                        AuxDatos.nombreTabla = ListaResultados[0].c_codigo_tab;
                        AuxDatos.nombreTunel = ListaResultados[0].c_codigo_tun;
                        AuxDatos.fechaCaptura = DateTime.Parse(ListaResultados[0].d_captura_fit).ToString("dd/MM/yyyy");
                        AuxDatos.semana = ListaResultados[0].c_semana_fit;
                        AuxDatos.semanaInicio = FirstDateOfWeekISO8601(2023, Convert.ToInt16(ListaResultados[0].c_semana_fit)).ToString("dd/MM/yy");
                        AuxDatos.semanaFin = LastDateOfWeekISO8601(2023, Convert.ToInt16(ListaResultados[0].c_semana_fit)).ToString("dd/MM/yy");
                        AuxDatos.nombrePlaga = ListaResultados[0].v_nombre_pla;
                        AuxDatos.poblacion = PoblacionTotal.ToString();
                        AuxDatos.latitud = ListaResultados[0].c_latitud_fit;
                        AuxDatos.longitud = ListaResultados[0].c_longitud_fit;
                        AuxDatos.altura = ListaResultados[0].c_altura_fit;
                        AuxDatos.color = await colorAsync(AuxPoblacion, ListaResultados[0].v_nombre_pla);
                        AuxList.Add(AuxDatos);
                    }
                    else
                    {
                        AuxDatos.nombreCampo = "-";
                        AuxDatos.nombreLote = "-";
                        AuxDatos.nombreTabla = "-";
                        AuxDatos.nombreTunel = "-";
                        AuxDatos.fechaCaptura = "-";
                        AuxDatos.semana = "-";
                        AuxDatos.nombrePlaga = ListaPlagas[i].v_nombre_pla;
                        AuxDatos.poblacion = "0";
                        AuxDatos.latitud = "0";
                        AuxDatos.longitud = "0";
                        AuxDatos.altura = "0";
                        AuxDatos.color = await colorAsync(0, ListaPlagas[i].v_nombre_pla);
                        AuxList.Add(AuxDatos);
                    }
                }
                ListaResultadosFinales = AuxList;
            }
            catch (Exception Ex)
            {
                await DisplayAlert("Alerta",Ex.ToString(),"Ok");
            }
        }

        public async Task<string> colorAsync(double V_calculoUmbral, string V_nombrePLaga)
        {
            string colorFinal = "";
            var funcion = new Dfitosanidad();
            UmbralesInfSup = await funcion.VerificaUmbralesAsync(V_nombrePLaga);

            if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior0) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior0))
            {
                colorFinal = "Green";
            }
            else if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior1) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior1))
            {
                colorFinal = "Yellow";
            }
            else if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior2) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior2))
            {
                colorFinal = "Red";
            }
            else
            {
                colorFinal = "Black";
            }
            return colorFinal;
        }

        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }

        public static DateTime LastDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(3);
        }

        #endregion
        #region COMANDOS
        public ICommand MuestraSemanascommand => new Command(llenaComboSemanasAsync);
        public ICommand MuestraDatoscommand => new Command(async () => await MuestraDatos());
        #endregion
    }
}
