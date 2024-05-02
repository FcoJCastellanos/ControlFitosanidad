using FitosanidadAgroberries.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitosanidadAgroberries.Data
{
    public class Dsincronizacatalogos
    {
        public async Task<string> DatosLoginUsuarioLocal()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/consultaUsuariosExpo");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mlogin>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mlogin
                        {
                            c_codigo_usu = ds.Tables[0].Rows[i]["c_codigo_usu"].ToString().Trim(),
                            v_nombre_usu = ds.Tables[0].Rows[i]["v_nombre_usu"].ToString().Trim(),
                            v_password_usu = ds.Tables[0].Rows[i]["v_password_usu"].ToString().ToLower().Trim(),
                            v_email_usu = ds.Tables[0].Rows[i]["v_email_usu"].ToString().Trim(),
                            c_admin_usu = ds.Tables[0].Rows[i]["c_admin_usu"].ToString().Trim(),
                            c_autorizanom_usu = ds.Tables[0].Rows[i]["c_autorizanom_usu"].ToString(),
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> CamposLocal()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaDatosFertirriegoCampo");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mcampos>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mcampos
                        {
                            codigoCampo = ds.Tables[0].Rows[i]["c_codigo_cam"].ToString().Trim(),
                            nombreCampo = ds.Tables[0].Rows[i]["v_nombre_cam"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> SectoresLocal()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaSector");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Msector>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Msector
                        {
                            c_codigo_tem = ds.Tables[0].Rows[i]["c_codigo_tem"].ToString().Trim(),
                            c_codigo_lot = ds.Tables[0].Rows[i]["c_codigo_lot"].ToString().Trim(),
                            v_nombre_lot = ds.Tables[0].Rows[i]["v_nombre_lot"].ToString().Trim(),
                            c_codigo_cul = ds.Tables[0].Rows[i]["c_codigo_cul"].ToString().Trim(),
                            n_superf_lot = ds.Tables[0].Rows[i]["n_superf_lot"].ToString().Trim(),
                            c_codigo_cam = ds.Tables[0].Rows[i]["c_codigo_cam"].ToString().Trim(),
                            c_codigo_cic = ds.Tables[0].Rows[i]["c_codigo_cic"].ToString().Trim(),
                            c_identificador_lot = ds.Tables[0].Rows[i]["c_identificador_lot"].ToString().Trim(),
                            c_nodisponible_lot = ds.Tables[0].Rows[i]["c_nodisponible_lot"].ToString().Trim(),
                            c_empaque_lot = ds.Tables[0].Rows[i]["c_empaque_lot"].ToString().Trim(),
                            c_activo_lot = ds.Tables[0].Rows[i]["c_activo_lot"].ToString().Trim(),
                            n_superfconvert_lot = ds.Tables[0].Rows[i]["n_superfconvert_lot"].ToString().Trim(),
                            c_unidadmedida_lot = ds.Tables[0].Rows[i]["c_unidadmedida_lot"].ToString().Trim(),
                            c_nivel_lot = ds.Tables[0].Rows[i]["c_nivel_lot"].ToString().Trim(),
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception EX)
            {
                respuesta = EX.ToString();
            }
            return respuesta;
        }

        public async Task<string> SemanasLocal()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaSemanas");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Msemanas>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Msemanas
                        {
                            c_codigo_sem = ds.Tables[0].Rows[i]["c_codigo_sem"].ToString().Trim(),
                            d_ini_sem = ds.Tables[0].Rows[i]["d_ini_sem"].ToString().Trim(),
                            d_fin_sem = ds.Tables[0].Rows[i]["d_fin_sem"].ToString().Trim(),
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception EX)
            {
                respuesta = EX.ToString();
            }
            return respuesta;
        }

        public async Task<string> Tablas()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaTablas");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mtablasfitosanidad>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mtablasfitosanidad
                        {
                            c_codigo_tab = ds.Tables[0].Rows[i]["c_codigo_tab"].ToString().Trim(),
                            v_nombre_tab = ds.Tables[0].Rows[i]["v_nombre_tab"].ToString().Trim(),
                            c_activo_tab = ds.Tables[0].Rows[i]["c_activo_tab"].ToString().Trim(),
                            c_codigo_usu = ds.Tables[0].Rows[i]["c_codigo_usu"].ToString().Trim(),
                            d_creacion_tab = ds.Tables[0].Rows[i]["d_creacion_tab"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> Tuneles()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaTuneles");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mtunelesfitosanidad>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mtunelesfitosanidad
                        {
                            c_codigo_tun = ds.Tables[0].Rows[i]["c_codigo_tun"].ToString().Trim(),
                            v_nombre_tun = ds.Tables[0].Rows[i]["v_nombre_tun"].ToString().Trim(),
                            c_activo_tun = ds.Tables[0].Rows[i]["c_activo_tun"].ToString().Trim(),
                            c_codigo_usu = ds.Tables[0].Rows[i]["c_codigo_usu"].ToString().Trim(),
                            d_creacion_tun = ds.Tables[0].Rows[i]["d_creacion_tun"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> TablaTunel()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaTunelesTablas");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mtablatunelfitosanidad>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mtablatunelfitosanidad
                        {
                            c_codigo_ttu = ds.Tables[0].Rows[i]["c_codigo_ttu"].ToString().Trim(),
                            c_codigo_cam = ds.Tables[0].Rows[i]["c_codigo_cam"].ToString().Trim(),
                            c_codigo_lot = ds.Tables[0].Rows[i]["c_codigo_lot"].ToString().Trim(),
                            c_codigo_tab = ds.Tables[0].Rows[i]["c_codigo_tab"].ToString().Trim(),
                            v_nombre_tab = ds.Tables[0].Rows[i]["v_nombre_tab"].ToString().Trim(),
                            c_codigo_tun = ds.Tables[0].Rows[i]["c_codigo_tun"].ToString().Trim(),
                            v_nombre_tun = ds.Tables[0].Rows[i]["v_nombre_tun"].ToString().Trim(),
                            c_codigo_tem = ds.Tables[0].Rows[i]["c_codigo_tem"].ToString().Trim(),
                            n_ha_ttu = ds.Tables[0].Rows[i]["n_ha_ttu"].ToString().Trim(),
                            n_acres_ttu = ds.Tables[0].Rows[i]["n_acres_ttu"].ToString().Trim(),
                            n_plantas_ttu = ds.Tables[0].Rows[i]["n_plantas_ttu"].ToString().Trim(),
                            c_codigo_usu = ds.Tables[0].Rows[i]["c_codigo_usu"].ToString().Trim(),
                            d_creacion_ttu = ds.Tables[0].Rows[i]["d_creacion_ttu"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> Plagas()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaPlagas");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mplagas>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mplagas
                        {
                            c_codigo_pla = ds.Tables[0].Rows[i]["c_codigo_pla"].ToString().Trim(),
                            v_nombre_pla = ds.Tables[0].Rows[i]["v_nombre_pla"].ToString().Trim(),
                            v_abrevia_pla = ds.Tables[0].Rows[i]["v_abrevia_pla"].ToString().Trim(),
                            c_activo_pla = ds.Tables[0].Rows[i]["c_activo_pla"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> UmbralesFitosanidadLocal()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaUmbralesFitosanidad");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mumbralesfitosanidad>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mumbralesfitosanidad
                        {
                            c_codigo_umb = ds.Tables[0].Rows[i]["c_codigo_umb"].ToString().Trim(),
                            c_codigo_ces = ds.Tables[0].Rows[i]["c_codigo_ces"].ToString().Trim(),
                            c_codigo_pla = ds.Tables[0].Rows[i]["c_codigo_pla"].ToString().Trim(),
                            v_nombre_pla = ds.Tables[0].Rows[i]["v_nombre_pla"].ToString().Trim(),
                            n_liminf0_umb = ds.Tables[0].Rows[i]["n_liminf0_umb"].ToString().Trim(),
                            n_limsup0_umb = ds.Tables[0].Rows[i]["n_limsup0_umb"].ToString().Trim(),
                            n_liminf1_umb = ds.Tables[0].Rows[i]["n_liminf1_umb"].ToString().Trim(),
                            n_limsup1_umb = ds.Tables[0].Rows[i]["n_limsup1_umb"].ToString().Trim(),
                            n_liminf2_umb = ds.Tables[0].Rows[i]["n_liminf2_umb"].ToString().Trim(),
                            n_limsup2_umb = ds.Tables[0].Rows[i]["n_limsup2_umb"].ToString().Trim(),
                            c_codigo_usu = ds.Tables[0].Rows[i]["c_codigo_usu"].ToString().Trim(),
                            d_creacion_umb = ds.Tables[0].Rows[i]["d_creacion_umb"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> PinsMapa()
        {
            string respuesta;
            try
            {
                DataSet ds = new DataSet();
                XElement xml = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/ConsultaRegistroFitosanidadPinMapa");
                IEnumerable<XElement> listaElementos =
                from elemento in xml.Descendants("Table") select elemento;
                ds.ReadXml(new StringReader(new XElement("Table", listaElementos).ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    await App.LocalDB.DeleteAllItems<Mpinsmapas>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        await App.LocalDB.SaveData(new Mpinsmapas
                        {
                            c_codigo_fit = i,
                            v_nombre_cam = ds.Tables[0].Rows[i]["v_nombre_cam"].ToString().Trim(),
                            c_codigo_cam = ds.Tables[0].Rows[i]["c_codigo_cam"].ToString().Trim(),
                            v_nombre_lot = ds.Tables[0].Rows[i]["v_nombre_lot"].ToString().Trim(),
                            c_codigo_lot = ds.Tables[0].Rows[i]["c_codigo_lot"].ToString().Trim(),
                            c_codigo_tab = ds.Tables[0].Rows[i]["c_codigo_tab"].ToString().Trim(),
                            c_codigo_tun = ds.Tables[0].Rows[i]["c_codigo_tun"].ToString().Trim(),
                            d_captura_fit = ds.Tables[0].Rows[i]["d_captura_fit"].ToString().Trim(),
                            c_semana_fit = ds.Tables[0].Rows[i]["c_semana_fit"].ToString().Trim(),
                            c_codigo_pla = ds.Tables[0].Rows[i]["c_codigo_pla"].ToString().Trim(),
                            v_nombre_pla = ds.Tables[0].Rows[i]["v_nombre_pla"].ToString().Trim(),
                            n_poblacion_fit = ds.Tables[0].Rows[i]["n_poblacion_fit"].ToString().Trim(),
                            c_latitud_fit = ds.Tables[0].Rows[i]["c_latitud_fit"].ToString().Trim(),
                            c_longitud_fit = ds.Tables[0].Rows[i]["c_longitud_fit"].ToString().Trim(),
                            c_altura_fit = ds.Tables[0].Rows[i]["c_altura_fit"].ToString().Trim()
                        });
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }

        public async Task<string> CreaMapasPolygonos()
        {
            int auxCont = 0;
            int auxCont2 = 0;
            string respuesta;
            string[] geodata = new string[0];
            string[] coordinates = new string[8];

            List<Msector> Sectors = new List<Msector>();
            List<Mtablatunelfitosanidad> Tables = new List<Mtablatunelfitosanidad>();
            List<Mtablatunelfitosanidad> auxTables = new List<Mtablatunelfitosanidad>();

            try
            {
                string Campo = "";
                await App.LocalDB.DeleteAllItems<Mgeodata>();

                for (int i = 0; i < 51; i++)
                {
                    switch (i)
                    {
                        //case 1://B1 Convencional
                        //    Sectors.Clear();
                        //    Tables.Clear();
                        //    Campo = "";
                        //    Campo = "0001";
                        //    Array.Clear(geodata, 0, geodata.Length);
                        //    Array.Resize(ref geodata, geodata.Length + 172);
                        //    geodata[0] = "20.2467543, -103.6098907"; geodata[1] = "20.2462606, -103.610272"; geodata[2] = "20.2454881, -103.6088987"; geodata[3] = "20.2459227, -103.6084021";
                        //    geodata[4] = "20.2463054, -103.6104058"; geodata[5] = "20.2458701, -103.6107224"; geodata[6] = "20.2450371, -103.6094054"; geodata[7] = "20.2454687, -103.6089038";
                        //    geodata[8] = "20.2483133, -103.603362"; geodata[9] = "20.2478842, -103.6038515"; geodata[10] = "20.2474955, -103.6031447"; geodata[11] = "20.2479937, -103.6027813";
                        //    geodata[12] = "20.2479874, -103.6027705"; geodata[13] = "20.2474867, -103.6031366"; geodata[14] = "20.2467141, -103.6017299"; geodata[15] = "20.2472111, -103.6013584";
                        //    geodata[16] = "20.2471708, -103.6012846"; geodata[17] = "20.2466713, -103.6016454"; geodata[18] = "20.2457616, -103.6000079"; geodata[19] = "20.2462674, -103.5996297";
                        //    geodata[20] = "20.2462624, -103.5996216"; geodata[21] = "20.2457579, -103.5999972"; geodata[22] = "20.2449437, -103.5985246"; geodata[23] = "20.2454521, -103.5981451";
                        //    geodata[24] = "20.2476616, -103.6088943"; geodata[25] = "20.2471747, -103.6092644"; geodata[26] = "20.2463808, -103.6078374"; geodata[27] = "20.2468778, -103.6074754";
                        //    geodata[28] = "20.2468677, -103.607471"; geodata[29] = "20.246377, -103.6078238"; geodata[30] = "20.2456144, -103.6064719"; geodata[31] = "20.2461089, -103.6061138";
                        //    geodata[32] = "20.246104, -103.6061092"; geodata[33] = "20.2456082, -103.6064632"; geodata[34] = "20.244881, -103.6050873"; geodata[35] = "20.2453603, -103.6047413";
                        //    geodata[36] = "20.2453578, -103.6047332"; geodata[37] = "20.2448759, -103.6050792"; geodata[38] = "20.2441398, -103.6036885"; geodata[39] = "20.2446041, -103.6033573";
                        //    geodata[40] = "20.244589, -103.6033258"; geodata[41] = "20.2441197, -103.6036477"; geodata[42] = "20.2431395, -103.6019378"; geodata[43] = "20.2436403, -103.6015864";
                        //    geodata[44] = "20.2472012, -103.6093936"; geodata[45] = "20.2467168, -103.6097691"; geodata[46] = "20.2459443, -103.6083905"; geodata[47] = "20.2463796, -103.6078728";
                        //    geodata[48] = "20.24811, -103.6083846"; geodata[49] = "20.2476281, -103.6087678"; geodata[50] = "20.246897, -103.6074629"; geodata[51] = "20.2474003, -103.6070954";
                        //    geodata[52] = "20.2473915, -103.60709"; geodata[53] = "20.2468958, -103.6074468"; geodata[54] = "20.2461383, -103.6060842"; geodata[55] = "20.2466429, -103.6057235";
                        //    geodata[56] = "20.2466362, -103.6057147"; geodata[57] = "20.246138, -103.6060755"; geodata[58] = "20.2453881, -103.6047143"; geodata[59] = "20.2458876, -103.6043549";
                        //    geodata[60] = "20.2458813, -103.6043461"; geodata[61] = "20.2453831, -103.6047055"; geodata[62] = "20.2446306, -103.6033389"; geodata[63] = "20.2451314, -103.6029795";
                        //    geodata[64] = "20.2451035, -103.6029404"; geodata[65] = "20.244609, -103.6033012"; geodata[66] = "20.2436628, -103.6015631"; geodata[67] = "20.2441636, -103.6012104";
                        //    geodata[68] = "20.244161, -103.6012022"; geodata[69] = "20.244029, -103.6012961"; geodata[70] = "20.2432073, -103.5999657"; geodata[71] = "20.2434124, -103.5998249";
                        //    geodata[72] = "20.2485698, -103.6078363"; geodata[73] = "20.2480766, -103.6082722"; geodata[74] = "20.247421, -103.6070813"; geodata[75] = "20.2479218, -103.6067139";
                        //    geodata[76] = "20.2479181, -103.6067058"; geodata[77] = "20.2474198, -103.6070719"; geodata[78] = "20.2466649, -103.6057107"; geodata[79] = "20.2471719, -103.6053446";
                        //    geodata[80] = "20.2471656, -103.6053352"; geodata[81] = "20.2466569, -103.6057059"; geodata[82] = "20.245907, -103.604338"; geodata[83] = "20.2464141, -103.6039719";
                        //    geodata[84] = "20.2464108, -103.6039636"; geodata[85] = "20.245905, -103.604327"; geodata[86] = "20.2451501, -103.6029618"; geodata[87] = "20.2456471, -103.6025983";
                        //    geodata[88] = "20.2456288, -103.6025593"; geodata[89] = "20.2451293, -103.6029214"; geodata[90] = "20.2441831, -103.6011954"; geodata[91] = "20.2446776, -103.6008333";
                        //    geodata[92] = "20.2446719, -103.600824"; geodata[93] = "20.2441787, -103.6011835"; geodata[94] = "20.2434326, -103.5998088"; geodata[95] = "20.2439195, -103.5994561";
                        //    geodata[96] = "20.2490091, -103.6072555"; geodata[97] = "20.2485096, -103.6076149"; geodata[98] = "20.2479761, -103.6066775"; geodata[99] = "20.2484706, -103.6063114";
                        //    geodata[100] = "20.2484644, -103.6063014"; geodata[101] = "20.24797, -103.6066648"; geodata[102] = "20.24721, -103.6053049"; geodata[103] = "20.2477221, -103.6049388";
                        //    geodata[104] = "20.2477143, -103.6049307"; geodata[105] = "20.2472046, -103.6052955"; geodata[106] = "20.2464522, -103.6039383"; geodata[107] = "20.2469643, -103.6035695";
                        //    geodata[108] = "20.2469595, -103.6035598"; geodata[109] = "20.2464475, -103.60393"; geodata[110] = "20.2456976, -103.6025648"; geodata[111] = "20.2462084, -103.6021973";
                        //    geodata[112] = "20.2461855, -103.6021575"; geodata[113] = "20.2456671, -103.6025276"; geodata[114] = "20.2447196, -103.600799"; geodata[115] = "20.2452342, -103.6004261";
                        //    geodata[116] = "20.2452314, -103.6004179"; geodata[117] = "20.2447117, -103.6007919"; geodata[118] = "20.243958, -103.5994227"; geodata[119] = "20.2444827, -103.5990486";
                        //    geodata[120] = "20.2495189, -103.6068773"; geodata[121] = "20.2490332, -103.6072368"; geodata[122] = "20.2484909, -103.6062993"; geodata[123] = "20.248964, -103.6059533";
                        //    geodata[124] = "20.2489502, -103.605952"; geodata[125] = "20.2484871, -103.6062886"; geodata[126] = "20.247741, -103.6049287"; geodata[127] = "20.248204, -103.6045894";
                        //    geodata[128] = "20.2481985, -103.6045802"; geodata[129] = "20.2477367, -103.6049182"; geodata[130] = "20.2469868, -103.6035556"; geodata[131] = "20.2474901, -103.6031935";
                        //    geodata[132] = "20.2474856, -103.6031824"; geodata[133] = "20.246981, -103.6035458"; geodata[134] = "20.2462287, -103.6021752"; geodata[135] = "20.2467319, -103.6018158";
                        //    geodata[136] = "20.2467078, -103.6017738"; geodata[137] = "20.2462096, -103.6021399"; geodata[138] = "20.2452634, -103.6004086"; geodata[139] = "20.2457616, -103.6000532";
                        //    geodata[140] = "20.2457554, -103.6000416"; geodata[141] = "20.2452547, -103.6004024"; geodata[142] = "20.2444695, -103.5989687"; geodata[143] = "20.2449753, -103.5986133";
                        //    geodata[144] = "20.2496609, -103.6018493"; geodata[145] = "20.249213, -103.6022758"; geodata[146] = "20.248604, -103.6011788"; geodata[147] = "20.2486946, -103.6011117";
                        //    geodata[148] = "20.2492495, -103.6023885"; geodata[149] = "20.2487474, -103.6027707"; geodata[150] = "20.2485575, -103.6024139"; geodata[151] = "20.2490594, -103.6020491";
                        //    geodata[152] = "20.249053, -103.6020405"; geodata[153] = "20.2485522, -103.6024052"; geodata[154] = "20.247762, -103.6009743"; geodata[155] = "20.2482741, -103.6006162";
                        //    geodata[156] = "20.2478807, -103.6007557"; geodata[157] = "20.2477121, -103.6008737"; geodata[158] = "20.2473422, -103.6002099"; geodata[159] = "20.2477146, -103.6004352";
                        //    geodata[160] = "20.2487945, -103.6029078"; geodata[161] = "20.2482925, -103.6032672"; geodata[162] = "20.2480319, -103.6027965"; geodata[163] = "20.248534, -103.6024343";
                        //    geodata[164] = "20.2485273, -103.6024251"; geodata[165] = "20.2480303, -103.6027858"; geodata[166] = "20.2472464, -103.6013562"; geodata[167] = "20.2477358, -103.6009968";
                        //    geodata[168] = "20.2476867, -103.6008966"; geodata[169] = "20.2471897, -103.6012587"; geodata[170] = "20.245671, -103.5985241"; geodata[171] = "20.2472828, -103.6001818";

                        //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                        //    for (int j = 0; j < Sectors.Count; j++)
                        //    {
                        //        auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                        //        for (int k = 0; k < auxTables.Count; k++)
                        //        {
                        //            Tables.Add(auxTables[k]);
                        //        }
                        //    }

                        //    if (geodata.Length != -1 && geodata.Length != 0)
                        //    {
                        //        for (int l = 0; l < geodata.Length; l++)
                        //        {
                        //            string[] temp = geodata[l].Split(',');
                        //            coordinates[2 * auxCont] = temp[0].Trim();
                        //            coordinates[2 * auxCont + 1] = temp[1].Trim();
                        //            if (auxCont == 3)
                        //            {

                        //                await App.LocalDB.SaveData(new Mgeodata
                        //                {
                        //                    controlLog = auxCont2,
                        //                    Campo = Campo,
                        //                    Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                        //                    Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                        //                    lat1 = coordinates[0],
                        //                    lon1 = coordinates[1],
                        //                    lat2 = coordinates[2],
                        //                    lon2 = coordinates[3],
                        //                    lat3 = coordinates[4],
                        //                    lon3 = coordinates[5],
                        //                    lat4 = coordinates[6],
                        //                    lon4 = coordinates[7],
                        //                    acumuladoPlaga = ""
                        //                });
                        //                auxCont = 0;
                        //                auxCont2++;
                        //            }
                        //            else
                        //            {
                        //                auxCont++;
                        //            }
                        //        }
                        //    }
                        //    else { }
                        //    break;

                        //case 2://La Peña Frambuesa
                        //    Sectors.Clear();
                        //    Tables.Clear();
                        //    Campo = "";
                        //    Campo = "0002";
                        //    Array.Clear(geodata, 0, geodata.Length);
                        //    Array.Resize(ref geodata, geodata.Length + 112);
                        //    geodata[0] = " 20.7402124, -103.9058838"; geodata[1] = " 20.7398361, -103.9061252"; geodata[2] = " 20.7390735, -103.904312"; geodata[3] = " 20.7394347, -103.9040492";
                        //    geodata[4] = " 20.7398054, -103.9061691"; geodata[5] = " 20.7393614, -103.9064803"; geodata[6] = " 20.7385939, -103.9046403"; geodata[7] = " 20.7390354, -103.9043238";
                        //    geodata[8] = " 20.7393263, -103.9065366"; geodata[9] = " 20.7388924, -103.906837"; geodata[10] = " 20.7381022, -103.9049943"; geodata[11] = " 20.7385688, -103.9046671";
                        //    geodata[12] = " 20.7388146, -103.9067431"; geodata[13] = " 20.7378664, -103.9058875"; geodata[14] = " 20.7376256, -103.9053377"; geodata[15] = " 20.7380796, -103.9050104";
                        //    geodata[16] = " 20.7377836, -103.9057427"; geodata[17] = " 20.7377285, -103.9057829"; geodata[18] = " 20.7374099, -103.9054825"; geodata[19] = " 20.7376056, -103.9053564";
                        //    geodata[20] = " 20.7394025, -103.9039835"; geodata[21] = " 20.7390363, -103.9042303"; geodata[22] = " 20.7383916, -103.9026987"; geodata[23] = " 20.7387629, -103.9024547";
                        //    geodata[24] = " 20.7390101, -103.9042651"; geodata[25] = " 20.7385598, -103.9045802"; geodata[26] = " 20.7379139, -103.903038"; geodata[27] = " 20.7383503, -103.9026745";
                        //    geodata[28] = " 20.7385335, -103.9046111"; geodata[29] = " 20.7380845, -103.9049289"; geodata[30] = " 20.7375376, -103.9036455"; geodata[31] = " 20.7378901, -103.9030594";
                        //    geodata[32] = " 20.7380425, -103.9049343"; geodata[33] = " 20.7375973, -103.9052588"; geodata[34] = " 20.7371633, -103.9042369"; geodata[35] = " 20.7376186, -103.9039244";
                        //    geodata[36] = " 20.7375546, -103.9052334"; geodata[37] = " 20.7372762, -103.9054359"; geodata[38] = " 20.7365538, -103.9042718"; geodata[39] = " 20.7370015, -103.9039392";
                        //    geodata[40] = " 20.7430196, -103.9038583"; geodata[41] = " 20.74276, -103.9040461"; geodata[42] = " 20.7420063, -103.9022584"; geodata[43] = " 20.7422747, -103.902068";
                        //    geodata[44] = " 20.7427287, -103.9040676"; geodata[45] = " 20.7423048, -103.9043639"; geodata[46] = " 20.741551, -103.9025897"; geodata[47] = " 20.7419824, -103.9022758";
                        //    geodata[48] = " 20.7422747, -103.9043827"; geodata[49] = " 20.7418432, -103.9046992"; geodata[50] = " 20.741097, -103.9029075"; geodata[51] = " 20.7415221, -103.9026071";
                        //    geodata[52] = " 20.7418181, -103.904722"; geodata[53] = " 20.7414682, -103.9049795"; geodata[54] = " 20.7407345, -103.9032481"; geodata[55] = " 20.7410982, -103.9029893";
                        //    geodata[56] = " 20.7441703, -103.9016624"; geodata[57] = " 20.7438304, -103.9023558"; geodata[58] = " 20.7434015, -103.9013473"; geodata[59] = " 20.7438907, -103.9009946";
                        //    geodata[60] = " 20.7441046, -103.9030966"; geodata[61] = " 20.7436807, -103.9034024"; geodata[62] = " 20.7429307, -103.901616"; geodata[63] = " 20.7433685, -103.9013237";
                        //    geodata[64] = " 20.7436496, -103.9034235"; geodata[65] = " 20.7431379, -103.9037976"; geodata[66] = " 20.7423741, -103.9020113"; geodata[67] = " 20.7429059, -103.9016331";
                        //    geodata[68] = " 20.7464026, -103.9011161"; geodata[69] = " 20.7458257, -103.9012368"; geodata[70] = " 20.7453994, -103.9002202"; geodata[71] = " 20.7463073, -103.900577";
                        //    geodata[72] = " 20.7457708, -103.9012406"; geodata[73] = " 20.745244, -103.9013533"; geodata[74] = " 20.7447825, -103.9002402"; geodata[75] = " 20.7453744, -103.9002509";
                        //    geodata[76] = " 20.7452014, -103.9013399"; geodata[77] = " 20.7446696, -103.9014633"; geodata[78] = " 20.7441404, -103.9001946"; geodata[79] = " 20.7447198, -103.9001973";
                        //    geodata[80] = " 20.7446345, -103.9014633"; geodata[81] = " 20.7443084, -103.9016725"; geodata[82] = " 20.7436889, -103.9003636"; geodata[83] = " 20.7440752, -103.9001168";
                        //    geodata[84] = " 20.7438586, -103.9008885"; geodata[85] = " 20.7432892, -103.9012828"; geodata[86] = " 20.7425518, -103.8995393"; geodata[87] = " 20.7431137, -103.899137";
                        //    geodata[88] = " 20.7432692, -103.9013203"; geodata[89] = " 20.7427775, -103.9016636"; geodata[90] = " 20.7420476, -103.8999256"; geodata[91] = " 20.7425317, -103.8995608";
                        //    geodata[92] = " 20.7427522, -103.9016873"; geodata[93] = " 20.7423233, -103.9019984"; geodata[94] = " 20.7415808, -103.9002523"; geodata[95] = " 20.7420148, -103.8999331";
                        //    geodata[96] = " 20.7414524, -103.9001372"; geodata[97] = " 20.7411978, -103.9003142"; geodata[98] = " 20.7405055, -103.8986687"; geodata[99] = " 20.7407601, -103.8984769";
                        //    geodata[100] = " 20.7411589, -103.9003156"; geodata[101] = " 20.7407174, -103.9006012"; geodata[102] = " 20.7400251, -103.8989503"; geodata[103] = " 20.740464, -103.8986539";
                        //    geodata[104] = " 20.7406887, -103.9006104"; geodata[105] = " 20.7402548, -103.9009135"; geodata[106] = " 20.73956, -103.8992707"; geodata[107] = " 20.7399952, -103.8989622";
                        //    geodata[108] = " 20.7402184, -103.9009108"; geodata[109] = " 20.7397895, -103.9012112"; geodata[110] = " 20.7391097, -103.8995912"; geodata[111] = " 20.7395399, -103.8992881";

                        //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                        //    for (int j = 0; j < Sectors.Count; j++)
                        //    {
                        //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                        //      for (int k = 0; k < auxTables.Count; k++)
                        //      {
                        //        Tables.Add(auxTables[k]);
                        //      }
                        //    }

                        //    if (geodata.Length != -1 && geodata.Length != 0)
                        //    {
                        //      for (int l = 0; l < geodata.Length; l++)
                        //      {
                        //          string[] temp = geodata[l].Split(',');
                        //          coordinates[2 * auxCont] = temp[0].Trim();
                        //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                        //          if (auxCont == 3)
                        //          {

                        //              await App.LocalDB.SaveData(new Mgeodata
                        //              {
                        //                  controlLog = auxCont2,
                        //                  Campo = Campo,
                        //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                        //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                        //                  lat1 = coordinates[0],
                        //                  lon1 = coordinates[1],
                        //                  lat2 = coordinates[2],
                        //                  lon2 = coordinates[3],
                        //                  lat3 = coordinates[4],
                        //                  lon3 = coordinates[5],
                        //                  lat4 = coordinates[6],
                        //                  lon4 = coordinates[7],
                        //                  acumuladoPlaga = ""
                        //              });
                        //              auxCont = 0;
                        //              auxCont2++;
                        //          }
                        //          else
                        //          {
                        //              auxCont++;
                        //          }
                        //      }
                        //    }
                        //    else { }
                        //    break;

                        case 6:
                            Sectors.Clear();
                            Tables.Clear();
                            Campo = "";
                            Campo = "0006";
                            Array.Clear(geodata, 0, geodata.Length);
                            Array.Resize(ref geodata, geodata.Length + 208);
                            //B2 Norte
                            geodata[0] = " 20.271927, -103.613534 "; geodata[1] = " 20.2715848, -103.6138371 "; geodata[2] = " 20.2707721, -103.6128393 "; geodata[3] = " 20.2711445, -103.6125094 ";
                            geodata[4] = " 20.2715471, -103.6138639 "; geodata[5] = " 20.2711445, -103.6142099 "; geodata[6] = " 20.2703419, -103.6132416 "; geodata[7] = " 20.270747, -103.6128635 ";
                            geodata[8] = " 20.2711068, -103.6142153 "; geodata[9] = " 20.2706941, -103.6145908 "; geodata[10] = " 20.2699091, -103.6136332 "; geodata[11] = " 20.2703142, -103.6132551 ";
                            geodata[12] = " 20.270669, -103.6146123 "; geodata[13] = " 20.2702563, -103.614969 "; geodata[14] = " 20.2694788, -103.6140222 "; geodata[15] = " 20.2698865, -103.6136467 ";
                            geodata[16] = " 20.2702002, -103.6149552 "; geodata[17] = " 20.2697624, -103.6153575 "; geodata[18] = " 20.2690327, -103.6144321 "; geodata[19] = " 20.2694529, -103.6140432 ";
                            geodata[20] = " 20.2699511, -103.6156257 "; geodata[21] = " 20.2695233, -103.6160066 "; geodata[22] = " 20.2685823, -103.6148533 "; geodata[23] = " 20.269005, -103.6144536 ";
                            geodata[24] = " 20.2695007, -103.6160334 "; geodata[25] = " 20.2690704, -103.6163579 "; geodata[26] = " 20.2681395, -103.6152395 "; geodata[27] = " 20.2685521, -103.6148666 ";
                            geodata[28] = " 20.2689861, -103.6163252 "; geodata[29] = " 20.2685508, -103.6166953 "; geodata[30] = " 20.2676928, -103.6156681 "; geodata[31] = " 20.2681205, -103.615263 ";
                            geodata[32] = " 20.2692075, -103.6141687 "; geodata[33] = " 20.2688779, -103.6144772 "; geodata[34] = " 20.2679847, -103.6133814 "; geodata[35] = " 20.2682539, -103.6131374 ";
                            geodata[36] = " 20.268246, -103.6131305 "; geodata[37] = " 20.2679793, -103.6133732 "; geodata[38] = " 20.2670873, -103.6122802 "; geodata[39] = " 20.2672936, -103.6120992 ";
                            geodata[40] = " 20.2688471, -103.6145093"; geodata[41] = " 20.2684495, -103.6148634"; geodata[42] = " 20.2675538, -103.6137797"; geodata[43] = " 20.2679583, -103.6134097";
                            geodata[44] = " 20.2679514, -103.6134011"; geodata[45] = " 20.2675463, -103.6137713"; geodata[46] = " 20.2666518, -103.6126796"; geodata[47] = " 20.2670632, -103.6123054";
                            geodata[48] = " 20.2684205, -103.6148946"; geodata[49] = " 20.2680104, -103.6152621"; geodata[50] = " 20.2671184, -103.6141717"; geodata[51] = " 20.2675248, -103.6138016";
                            geodata[52] = " 20.2675153, -103.613794"; geodata[53] = " 20.267114, -103.6141628"; geodata[54] = " 20.2662233, -103.6130752"; geodata[55] = " 20.2666284, -103.6127077";
                            geodata[56] = " 20.2679827, -103.6152809"; geodata[57] = " 20.2675826, -103.6156564"; geodata[58] = " 20.2666894, -103.6145701"; geodata[59] = " 20.267092, -103.6141946";
                            geodata[60] = " 20.2670881, -103.6141849"; geodata[61] = " 20.2666805, -103.6145617"; geodata[62] = " 20.2657898, -103.6134647"; geodata[63] = " 20.2661999, -103.6130972";
                            geodata[64] = " 20.2684879, -103.6166873 "; geodata[65] = " 20.2679746, -103.6171218 "; geodata[66] = " 20.2672399, -103.6160785 "; geodata[67] = " 20.2676751, -103.6156788 ";
                            geodata[68] = " 20.267562, -103.6156842 "; geodata[69] = " 20.2673808, -103.6158424 "; geodata[70] = " 20.2665505, -103.6150431 "; geodata[71] = " 20.2667845, -103.6147346 ";
                            geodata[72] = " 20.2664045, -103.6142745 "; geodata[73] = " 20.2659956, -103.6146446 "; geodata[74] = " 20.2653565, -103.6138601 "; geodata[75] = " 20.2657679, -103.6134899 ";
                            geodata[76] = " 20.2659748, -103.6146747 "; geodata[77] = " 20.2657811, -103.6148463 "; geodata[78] = " 20.2649507, -103.6142294 "; geodata[79] = " 20.2653332, -103.6138781 ";

                            //B2 Sur
                            geodata[80] = " 20.2670308, -103.6162073 "; geodata[81] = " 20.2666483, -103.6165586 "; geodata[82] = " 20.2651361, -103.6146784 "; geodata[83] = " 20.2661161, -103.6153409 ";
                            geodata[84] = " 20.2666186, -103.6165775 "; geodata[85] = " 20.2662198, -103.6169543 "; geodata[86] = " 20.2654486, -103.6160196 "; geodata[87] = " 20.2658587, -103.6156387 ";
                            geodata[88] = " 20.2661883, -103.6169798 "; geodata[89] = " 20.2657857, -103.6173513 "; geodata[90] = " 20.264661, -103.6159686 "; geodata[91] = " 20.2646094, -103.6150363 ";
                            geodata[92] = " 20.2657631, -103.6173821 "; geodata[93] = " 20.265358, -103.6177389 "; geodata[94] = " 20.2645956, -103.6168108 "; geodata[95] = " 20.2647114, -103.6160625 ";
                            geodata[96] = " 20.2653374, -103.6177737 "; geodata[97] = " 20.2649273, -103.6181465 "; geodata[98] = " 20.2641573, -103.6172024 "; geodata[99] = " 20.2645725, -103.6168295 ";
                            geodata[100] = " 20.2649021, -103.6181706 "; geodata[101] = " 20.264502, -103.6185408 "; geodata[102] = " 20.2637346, -103.6175993 "; geodata[103] = " 20.2641271, -103.6172184 ";
                            geodata[104] = " 20.2644756, -103.6185622 "; geodata[105] = " 20.2640743, -103.6189391 "; geodata[106] = " 20.2632238, -103.6178917 "; geodata[107] = " 20.2636251, -103.6175148 ";
                            geodata[108] = " 20.2640491, -103.6189605 "; geodata[109] = " 20.2638478, -103.6191456 "; geodata[110] = " 20.2630024, -103.6180942 "; geodata[111] = " 20.2631898, -103.6179239 ";
                            geodata[112] = " 20.2638239, -103.6191644 "; geodata[113] = " 20.2636465, -103.6193307 "; geodata[114] = " 20.2627948, -103.6182846 "; geodata[115] = " 20.2629734, -103.6181183 ";
                            geodata[116] = " 20.2636201, -103.6193535 "; geodata[117] = " 20.2634201, -103.6195412 "; geodata[118] = " 20.2626136, -103.6185435 "; geodata[119] = " 20.2628074, -103.6183637 ";
                            geodata[120] = " 20.2633949, -103.6195654 "; geodata[121] = " 20.2632188, -103.619729 "; geodata[122] = " 20.2624111, -103.6187433 "; geodata[123] = " 20.2625872, -103.6185676 ";
                            geodata[124] = " 20.2631923, -103.6197491 "; geodata[125] = " 20.2629885, -103.6199409 "; geodata[126] = " 20.2621896, -103.6190303 "; geodata[127] = " 20.2624236, -103.618809 ";
                            geodata[128] = " 20.2629671, -103.6199597 "; geodata[129] = " 20.2627847, -103.620126 "; geodata[130] = " 20.2620613, -103.6192355 "; geodata[131] = " 20.2621972, -103.6191054 ";
                            geodata[132] = " 20.2627646, -103.6201474 "; geodata[133] = " 20.2623582, -103.6205216 "; geodata[134] = " 20.2615882, -103.6195748 "; geodata[135] = " 20.2619934, -103.619206 ";
                            geodata[136] = " 20.2623331, -103.620543 "; geodata[137] = " 20.2619783, -103.6208689 "; geodata[138] = " 20.2611794, -103.6198631 "; geodata[139] = " 20.2615228, -103.6195466 ";
                            geodata[140] = " 20.2658587, -103.6156387 "; geodata[141] = " 20.2654486, -103.6160196 "; geodata[142] = " 20.2646377, -103.6150175 "; geodata[143] = " 20.265058, -103.6146474 ";
                            geodata[144] = " 20.2650047, -103.6146034 "; geodata[145] = " 20.2646021, -103.6149803 "; geodata[146] = " 20.2636233, -103.6137679 "; geodata[147] = " 20.2639932, -103.613438 ";
                            geodata[148] = " 20.2646333, -103.6158586 "; geodata[149] = " 20.2645955, -103.6158949 "; geodata[150] = " 20.2641723, -103.6153783 "; geodata[151] = " 20.2645787, -103.6150028 ";
                            geodata[152] = " 20.2645721, -103.6149941 "; geodata[153] = " 20.2641644, -103.6153696 "; geodata[154] = " 20.2631467, -103.614117 "; geodata[155] = " 20.2635556, -103.6137456 ";
                            geodata[156] = " 20.2646806, -103.6160502 "; geodata[157] = " 20.2645862, -103.6168012 "; geodata[158] = " 20.2637445, -103.6157726 "; geodata[159] = " 20.2641472, -103.6153985 ";
                            geodata[160] = " 20.2641435, -103.6153895 "; geodata[161] = " 20.2637383, -103.6157637 "; geodata[162] = " 20.2626728, -103.6144655 "; geodata[163] = " 20.2630842, -103.61409 ";
                            geodata[164] = " 20.2645271, -103.6167825 "; geodata[165] = " 20.2641295, -103.6171633 "; geodata[166] = " 20.2633142, -103.6161669 "; geodata[167] = " 20.2637193, -103.6157954 ";
                            geodata[168] = " 20.2637135, -103.6157851 "; geodata[169] = " 20.263311, -103.6161579 "; geodata[170] = " 20.2622025, -103.6148101 "; geodata[171] = " 20.2626026, -103.6144319 ";
                            geodata[172] = " 20.2640968, -103.6171821 "; geodata[173] = " 20.2636942, -103.6175469 "; geodata[174] = " 20.2628852, -103.6165679 "; geodata[175] = " 20.2632941, -103.6161883 ";
                            geodata[176] = " 20.2632858, -103.6161807 "; geodata[177] = " 20.2628827, -103.6165571 "; geodata[178] = " 20.2617332, -103.6151454 "; geodata[179] = " 20.2621509, -103.6147913 ";
                            geodata[180] = " 20.2635457, -103.6174155 "; geodata[181] = " 20.2631356, -103.617791 "; geodata[182] = " 20.2624588, -103.6169609 "; geodata[183] = " 20.2628613, -103.6165866 ";
                            geodata[184] = " 20.2628577, -103.6165782 "; geodata[185] = " 20.2624538, -103.6169496 "; geodata[186] = " 20.2613014, -103.6155455 "; geodata[187] = " 20.261704, -103.6151727 ";
                            geodata[188] = " 20.2631213, -103.6178235 "; geodata[189] = " 20.2626658, -103.618132 "; geodata[190] = " 20.262028, -103.6173594 "; geodata[191] = " 20.2624305, -103.6169786 ";
                            geodata[192] = " 20.2624246, -103.6169702 "; geodata[193] = " 20.2620219, -103.617347 "; geodata[194] = " 20.2608317, -103.6158906 "; geodata[195] = " 20.2612419, -103.6155124 ";
                            geodata[196] = " 20.2626432, -103.6181615 "; geodata[197] = " 20.2622305, -103.6185262 "; geodata[198] = " 20.2616002, -103.6177523 "; geodata[199] = " 20.2620028, -103.6173823 ";
                            geodata[200] = " 20.2620004, -103.6173737 "; geodata[201] = " 20.2615953, -103.6177439 "; geodata[202] = " 20.2604743, -103.6161238 "; geodata[203] = " 20.2607624, -103.6158596 ";
                            geodata[204] = " 20.2622155, -103.6185562 "; geodata[205] = " 20.2619928, -103.6187493 "; geodata[206] = " 20.2613612, -103.6175946 "; geodata[207] = " 20.261404, -103.6175558 ";

                            Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            for (int j = 0; j < Sectors.Count; j++)
                            {
                                auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                                for (int k = 0; k < auxTables.Count; k++)
                                {
                                    Tables.Add(auxTables[k]);
                                }
                            }

                            if (geodata.Length != -1 && geodata.Length != 0)
                            {
                                for (int l = 0; l < geodata.Length; l++)
                                {
                                    string[] temp = geodata[l].Split(',');
                                    coordinates[2 * auxCont] = temp[0].Trim();
                                    coordinates[2 * auxCont + 1] = temp[1].Trim();
                                    if (auxCont == 3)
                                    {

                                        await App.LocalDB.SaveData(new Mgeodata
                                        {
                                            controlLog = auxCont2,
                                            Campo = Campo,
                                            Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                                            Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                                            lat1 = coordinates[0],
                                            lon1 = coordinates[1],
                                            lat2 = coordinates[2],
                                            lon2 = coordinates[3],
                                            lat3 = coordinates[4],
                                            lon3 = coordinates[5],
                                            lat4 = coordinates[6],
                                            lon4 = coordinates[7],
                                            acumuladoPlaga = ""
                                        });
                                        auxCont = 0;
                                        auxCont2++;
                                    }
                                    else
                                    {
                                        auxCont++;
                                    }
                                }
                            }
                            else { }
                            break;

                            //case 8: //Las Terrazas
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0008";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 232);
                            //    geodata[0] = " 20.736091,-103.9105853 "; geodata[1] = " 20.7356295,-103.9099334 "; geodata[2] = " 20.736106,-103.9094828 "; geodata[3] = " 20.736244,-103.9095096 ";
                            //    geodata[4] = " 20.736604,-103.9106415 "; geodata[5] = " 20.7361211,-103.9105906 "; geodata[6] = " 20.7362666,-103.9094533 "; geodata[7] = " 20.7367583,-103.909511 ";
                            //    geodata[8] = " 20.7371353,-103.9107317 "; geodata[9] = " 20.7366412,-103.9106445 "; geodata[10] = " 20.7367954,-103.9095153 "; geodata[11] = " 20.7372871,-103.9096078 ";
                            //    geodata[12] = " 20.7376521,-103.9108175 "; geodata[13] = " 20.7371554,-103.9107464 "; geodata[14] = " 20.7373034,-103.9096038 "; geodata[15] = " 20.737849,-103.9092859 ";
                            //    geodata[16] = " 20.7379995,-103.9108725 "; geodata[17] = " 20.7376809,-103.9108282 "; geodata[18] = " 20.7378979,-103.9092846 "; geodata[19] = " 20.738382,-103.9093503 ";
                            //    geodata[20] = " 20.7355278,-103.9098474 "; geodata[21] = " 20.7351239,-103.9102135 "; geodata[22] = " 20.7327735,-103.9075581 "; geodata[23] = " 20.7331961,-103.9071598 ";
                            //    geodata[24] = " 20.735995,-103.909491 "; geodata[25] = " 20.7355948,-103.9098744 "; geodata[26] = " 20.7333397,-103.9072512 "; geodata[27] = " 20.7344535,-103.9076844 ";
                            //    geodata[28] = " 20.7363216,-103.9091779 "; geodata[29] = " 20.7360231,-103.9094676 "; geodata[30] = " 20.7354863,-103.9088212 "; geodata[31] = " 20.7359629,-103.9088399 ";
                            //    geodata[32] = " 20.7367304,-103.9085849 "; geodata[33] = " 20.7361133,-103.9083998 "; geodata[34] = " 20.7347274,-103.905959 "; geodata[35] = " 20.7355176,-103.9064404 ";
                            //    geodata[36] = " 20.7359747,-103.9082301 "; geodata[37] = " 20.7357038,-103.9083133 "; geodata[38] = " 20.734521,-103.906653 "; geodata[39] = " 20.7349049,-103.9063687 ";
                            //    geodata[40] = " 20.7347811,-103.90712 "; geodata[41] = " 20.7343521,-103.9072971 "; geodata[42] = " 20.7338015,-103.9070476 "; geodata[43] = " 20.7345402,-103.9066976 ";
                            //    geodata[44] = " 20.7347751,-103.9057972 "; geodata[45] = " 20.7344106,-103.9060619 "; geodata[46] = " 20.7331076,-103.9040008 "; geodata[47] = " 20.7334908,-103.9037333 ";
                            //    geodata[48] = " 20.7344761,-103.9061984 "; geodata[49] = " 20.7340572,-103.906488 "; geodata[50] = " 20.7326788,-103.9043074 "; geodata[51] = " 20.7330826,-103.9040204 ";
                            //    geodata[52] = " 20.7339884,-103.9064561 "; geodata[53] = " 20.7335695,-103.9067284 "; geodata[54] = " 20.7322375,-103.9046336 "; geodata[55] = " 20.7326426,-103.9043358 ";
                            //    geodata[56] = " 20.7334914,-103.9066519 "; geodata[57] = " 20.7330813,-103.9069523 "; geodata[58] = " 20.7318108,-103.9049474 "; geodata[59] = " 20.7322184,-103.9046497 ";
                            //    geodata[60] = " 20.7329464,-103.9067959 "; geodata[61] = " 20.7325199,-103.907099 "; geodata[62] = " 20.7314187,-103.9052201 "; geodata[63] = " 20.7317799,-103.904972 ";
                            //    geodata[64] = " 20.7370961,-103.9144832 "; geodata[65] = " 20.7368954,-103.9135793 "; geodata[66] = " 20.7372993,-103.9127827 "; geodata[67] = " 20.7377483,-103.9130295 ";
                            //    geodata[68] = " 20.7375663,-103.9147909 "; geodata[69] = " 20.7371085,-103.9145494 "; geodata[70] = " 20.7377971,-103.912975 "; geodata[71] = " 20.738497,-103.9127443 ";
                            //    geodata[72] = " 20.7380899,-103.9150085 "; geodata[73] = " 20.7375992,-103.9148021 "; geodata[74] = " 20.7385173,-103.9128065 "; geodata[75] = " 20.7391244,-103.9127851 ";
                            //    geodata[76] = " 20.7385997,-103.9152379 "; geodata[77] = " 20.7381284,-103.9149959 "; geodata[78] = " 20.7391268,-103.9128394 "; geodata[79] = " 20.7395934,-103.9130848 ";
                            //    geodata[80] = " 20.7391126,-103.9155222 "; geodata[81] = " 20.738631,-103.9152673 "; geodata[82] = " 20.7396369,-103.9131162 "; geodata[83] = " 20.7399278,-103.9137345 ";
                            //    geodata[84] = " 20.7396888,-103.9155764 "; geodata[85] = " 20.739157,-103.9154771 "; geodata[86] = " 20.7399296,-103.9137846 "; geodata[87] = " 20.7405204,-103.91379 ";
                            //    geodata[88] = " 20.7401977,-103.9158447 "; geodata[89] = " 20.7397287,-103.9156086 "; geodata[90] = " 20.740569,-103.9138089 "; geodata[91] = " 20.7411434,-103.9137928 ";
                            //    geodata[92] = " 20.7407282,-103.9160371 "; geodata[93] = " 20.7402541,-103.9158011 "; geodata[94] = " 20.7411772,-103.9138096 "; geodata[95] = " 20.7416224,-103.914051 ";
                            //    geodata[96] = " 20.7410559,-103.9162084 "; geodata[97] = " 20.7407562,-103.9160528 "; geodata[98] = " 20.7416579,-103.9140989 "; geodata[99] = " 20.7419037,-103.9145803 ";
                            //    geodata[100] = " 20.7439308,-103.9150469 "; geodata[101] = " 20.7433827,-103.9150067 "; geodata[102] = " 20.7434404,-103.9141417 "; geodata[103] = " 20.7440612,-103.9146459 ";
                            //    geodata[104] = " 20.7433435,-103.9150046 "; geodata[105] = " 20.742665,-103.9149496 "; geodata[106] = " 20.7427026,-103.9143139 "; geodata[107] = " 20.7433861,-103.9143635 ";
                            //    geodata[108] = " 20.7437704,-103.9151851 "; geodata[109] = " 20.7432675,-103.9153487 "; geodata[110] = " 20.743127,-103.9150443 "; geodata[111] = " 20.7437479,-103.9150912 ";
                            //    geodata[112] = " 20.7432015,-103.9153027 "; geodata[113] = " 20.7427425,-103.9155441 "; geodata[114] = " 20.7424603,-103.9149768 "; geodata[115] = " 20.7430823,-103.9150479 ";
                            //    geodata[116] = " 20.7427075,-103.9155705 "; geodata[117] = " 20.742241,-103.9158213 "; geodata[118] = " 20.741812,-103.9149321 "; geodata[119] = " 20.7424328,-103.9149898 ";
                            //    geodata[120] = " 20.7422071,-103.9158321 "; geodata[121] = " 20.741738,-103.9160989 "; geodata[122] = " 20.741521,-103.9156456 "; geodata[123] = " 20.7418308,-103.9150717 ";
                            //    geodata[124] = " 20.7417129,-103.9161137 "; geodata[125] = " 20.7412075,-103.9163712 "; geodata[126] = " 20.7413329,-103.9158575 "; geodata[127] = " 20.7415398,-103.9157301 ";
                            //    geodata[128] = " 20.7463192,-103.9170751 "; geodata[129] = " 20.7458752,-103.9175069 "; geodata[130] = " 20.7451228,-103.9150286 "; geodata[131] = " 20.7458978,-103.9156616 ";
                            //    geodata[132] = " 20.7458439,-103.9175606 "; geodata[133] = " 20.7453309,-103.9177269 "; geodata[134] = " 20.7444568,-103.9148234 "; geodata[135] = " 20.7450751,-103.9150165 ";
                            //    geodata[136] = " 20.7452902,-103.9176769 "; geodata[137] = " 20.744692,-103.9175535 "; geodata[138] = " 20.7439357,-103.9150712 "; geodata[139] = " 20.7443094,-103.9144234 ";
                            //    geodata[140] = " 20.7445978,-103.9174105 "; geodata[141] = " 20.7440485,-103.91744 "; geodata[142] = " 20.7434666,-103.9155222 "; geodata[143] = " 20.7439206,-103.915144 ";
                            //    geodata[144] = " 20.7440209,-103.9174614 "; geodata[145] = " 20.7434941,-103.9175553 "; geodata[146] = " 20.7429348,-103.9157019 "; geodata[147] = " 20.7434377,-103.9155356 ";
                            //    geodata[148] = " 20.7434537,-103.9175915 "; geodata[149] = " 20.7429746,-103.9177256 "; geodata[150] = " 20.7424529,-103.9161592 "; geodata[151] = " 20.742952,-103.9159071 ";
                            //    geodata[152] = " 20.7428003,-103.9173582 "; geodata[153] = " 20.7422321,-103.917208 "; geodata[154] = " 20.7420604,-103.9167265 "; geodata[155] = " 20.7424466,-103.9162142 ";
                            //    geodata[156] = " 20.7411399,-103.9174922 "; geodata[157] = " 20.740647,-103.9171529 "; geodata[158] = " 20.7411085,-103.9163295 "; geodata[159] = " 20.7416077,-103.9166849 ";
                            //    geodata[160] = " 20.7406018,-103.9184605 "; geodata[161] = " 20.7401215,-103.9181225 "; geodata[162] = " 20.7406118,-103.9172227 "; geodata[163] = " 20.7411035,-103.9175566 ";
                            //    geodata[164] = " 20.740087,-103.919329 "; geodata[165] = " 20.7396054,-103.9190044 "; geodata[166] = " 20.7400908,-103.9181931 "; geodata[167] = " 20.7405711,-103.9185109 ";
                            //    geodata[168] = " 20.7396533,-103.9200297 "; geodata[169] = " 20.7389773,-103.9201155 "; geodata[170] = " 20.7395279,-103.9191083 "; geodata[171] = " 20.7400095,-103.9194423 ";
                            //    geodata[172] = " 20.7402798,-103.9203138 "; geodata[173] = " 20.7396777,-103.9200831 "; geodata[174] = " 20.7407789,-103.9182324 "; geodata[175] = " 20.7411928,-103.9185194 ";
                            //    geodata[176] = " 20.7411803,-103.9180822 "; geodata[177] = " 20.7409395,-103.9179347 "; geodata[178] = " 20.7415691,-103.9168698 "; geodata[179] = " 20.7420006,-103.9171756 ";
                            //    geodata[180] = " 20.7357674,-103.9197222 "; geodata[181] = " 20.7352507,-103.9194888 "; geodata[182] = " 20.7357599,-103.918424 "; geodata[183] = " 20.7362416,-103.9186627 ";
                            //    geodata[184] = " 20.7360923,-103.9205 "; geodata[185] = " 20.7356044,-103.9202545 "; geodata[186] = " 20.7362967,-103.9186962 "; geodata[187] = " 20.7367784,-103.918939 ";
                            //    geodata[188] = " 20.7366278,-103.9207722 "; geodata[189] = " 20.7361174,-103.9205161 "; geodata[190] = " 20.7368059,-103.9189524 "; geodata[191] = " 20.7373051,-103.9191938 ";
                            //    geodata[192] = " 20.7371659,-103.9210257 "; geodata[193] = " 20.7366717,-103.9207441 "; geodata[194] = " 20.7373377,-103.9192112 "; geodata[195] = " 20.7378269,-103.9194553 ";
                            //    geodata[196] = " 20.737855,-103.9208857 "; geodata[197] = " 20.7372216,-103.9210064 "; geodata[198] = " 20.7378788,-103.9194708 "; geodata[199] = " 20.7383579,-103.9197216 ";
                            //    geodata[200] = " 20.7383951,-103.9207453 "; geodata[201] = " 20.7379072,-103.9208727 "; geodata[202] = " 20.7383938,-103.9197354 "; geodata[203] = " 20.7388291,-103.919954 ";
                            //    geodata[204] = " 20.7370836,-103.9231044 "; geodata[205] = " 20.7369532,-103.9230426 "; geodata[206] = " 20.7376542,-103.9214776 "; geodata[207] = " 20.7379102,-103.9216318 ";
                            //    geodata[208] = " 20.7369305,-103.9230252 "; geodata[209] = " 20.7364652,-103.9227436 "; geodata[210] = " 20.7371111,-103.9212495 "; geodata[211] = " 20.7375915,-103.9214789 ";
                            //    geodata[212] = " 20.7364379,-103.9227127 "; geodata[213] = " 20.7359738,-103.9223936 "; geodata[214] = " 20.7365984,-103.9208728 "; geodata[215] = " 20.7371126,-103.9211383 ";
                            //    geodata[216] = " 20.7359675,-103.9222998 "; geodata[217] = " 20.7354559,-103.9220584 "; geodata[218] = " 20.7360804,-103.9206101 "; geodata[219] = " 20.7365771,-103.9208702 ";
                            //    geodata[220] = " 20.7354257,-103.9220263 "; geodata[221] = " 20.7349416,-103.9218063 "; geodata[222] = " 20.7355687,-103.9203659 "; geodata[223] = " 20.7360478,-103.9205993 ";
                            //    geodata[224] = " 20.7348125,-103.9220081 "; geodata[225] = " 20.734302,-103.9217639 "; geodata[226] = " 20.7345667,-103.9211739 "; geodata[227] = " 20.7355387,-103.9203437 ";
                            //    geodata[228] = " 20.734255,-103.9218286 "; geodata[229] = " 20.7333068,-103.9218514 "; geodata[230] = " 20.7331651,-103.9214518 "; geodata[231] = " 20.7344908,-103.9212654 ";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 9: //Las Mesas
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0009";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 24);
                            //    geodata[0] = "20.7414013, -103.9050169"; geodata[1] = "20.7410351, -103.905257"; geodata[2] = "20.7403628, -103.9036718"; geodata[3] = "20.7407278, -103.9034196";
                            //    geodata[4] = "20.7410163, -103.9052918"; geodata[5] = "20.7406526, -103.9055547"; geodata[6] = "20.7398913, -103.9037495"; geodata[7] = "20.7402488, -103.903492";
                            //    geodata[8] = "20.7406296, -103.9055823"; geodata[9] = "20.7402671, -103.9058465"; geodata[10] = "20.7395033, -103.904048"; geodata[11] = "20.7398645, -103.9037758";
                            //    geodata[12] = "20.7402669, -103.9024725"; geodata[13] = "20.7399446, -103.9026911"; geodata[14] = "20.7397728, -103.9022915"; geodata[15] = "20.7401578, -103.9022083";
                            //    geodata[16] = "20.7399195, -103.9027233"; geodata[17] = "20.7398468, -103.9036661"; geodata[18] = "20.7393137, -103.9024189"; geodata[19] = "20.7397577, -103.9023371";
                            //    geodata[20] = "20.7398179, -103.9036836"; geodata[21] = "20.7394605, -103.903945"; geodata[22] = "20.7388685, -103.902549"; geodata[23] = "20.7392836, -103.9024269";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 10: //La Parota
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0010";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 96);
                            //    geodata[0] = "20.7437316, -103.9056375"; geodata[1] = "20.7433905, -103.9058788"; geodata[2] = "20.7426882, -103.9042467"; geodata[3] = "20.7430457, -103.9039879";
                            //    geodata[4] = "20.7433592, -103.9059097"; geodata[5] = "20.7429829, -103.9061766"; geodata[6] = "20.7422794, -103.9045297"; geodata[7] = "20.7426506, -103.9042668";
                            //    geodata[8] = "20.742939, -103.9062074"; geodata[9] = "20.7425691, -103.9064716"; geodata[10] = "20.7418617, -103.9048341"; geodata[11] = "20.7422342, -103.9045592";
                            //    geodata[12] = "20.7425365, -103.9065038"; geodata[13] = "20.7421614, -103.9067761"; geodata[14] = "20.7414528, -103.9051211"; geodata[15] = "20.7418266, -103.9048596";
                            //    geodata[16] = "20.7421188, -103.9068029"; geodata[17] = "20.7417476, -103.907063"; geodata[18] = "20.7413086, -103.9060371"; geodata[19] = "20.7416773, -103.9057662";
                            //    geodata[20] = "20.7417049, -103.9070939"; geodata[21] = "20.7413337, -103.90735"; geodata[22] = "20.7406263, -103.9057045"; geodata[23] = "20.7409938, -103.9054323";
                            //    geodata[24] = "20.7412949, -103.9073885"; geodata[25] = "20.7409237, -103.9076487"; geodata[26] = "20.7402126, -103.9060072"; geodata[27] = "20.7405876, -103.9057349";
                            //    geodata[28] = "20.7408785, -103.9076835"; geodata[29] = "20.7405048, -103.9079357"; geodata[30] = "20.7397999, -103.9062915"; geodata[31] = "20.7401712, -103.906038";
                            //    geodata[32] = "20.7404646, -103.9079652"; geodata[33] = "20.7402389, -103.9081355"; geodata[34] = "20.739386, -103.9065838"; geodata[35] = "20.7397623, -103.906321";
                            //    geodata[36] = "20.7397343, -103.9075141"; geodata[37] = "20.7396929, -103.9075315"; geodata[38] = "20.7390545, -103.9068208"; geodata[39] = "20.7393492, -103.9066129";
                            //    geodata[40] = "20.7428934, -103.908606"; geodata[41] = "20.7425221, -103.9088782"; geodata[42] = "20.7417909, -103.9071965"; geodata[43] = "20.7421722, -103.9069216";
                            //    geodata[44] = "20.7424782, -103.9089144"; geodata[45] = "20.7421057, -103.909176"; geodata[46] = "20.7413796, -103.9074808"; geodata[47] = "20.7417583, -103.9072166";
                            //    geodata[48] = "20.7421371, -103.909408"; geodata[49] = "20.7415853, -103.9092028"; geodata[50] = "20.7409682, -103.9077638"; geodata[51] = "20.7413445, -103.9074996";
                            //    geodata[52] = "20.7415075, -103.9091586"; geodata[53] = "20.7408265, -103.9087052"; geodata[54] = "20.7405581, -103.9080561"; geodata[55] = "20.7409293, -103.9077933";
                            //    geodata[56] = "20.743002, -103.9095002"; geodata[57] = "20.7426471, -103.9097537"; geodata[58] = "20.7423774, -103.9091248"; geodata[59] = "20.7427299, -103.9088592";
                            //    geodata[60] = "20.7425318, -103.9096049"; geodata[61] = "20.7424753, -103.9096398"; geodata[62] = "20.7421267, -103.9093086"; geodata[63] = "20.7423424, -103.9091583";
                            //    geodata[64] = "20.746196, -103.9064118"; geodata[65] = "20.7459452, -103.9065754"; geodata[66] = "20.7451325, -103.9048132"; geodata[67] = "20.7454234, -103.9045933";
                            //    geodata[68] = "20.74591, -103.9066049"; geodata[69] = "20.7454912, -103.9068758"; geodata[70] = "20.7447186, -103.9050975"; geodata[71] = "20.7450974, -103.904832";
                            //    geodata[72] = "20.7454448, -103.906908"; geodata[73] = "20.7450748, -103.9071655"; geodata[74] = "20.744311, -103.9053939"; geodata[75] = "20.7446847, -103.9051257";
                            //    geodata[76] = "20.7450359, -103.9072031"; geodata[77] = "20.7447224, -103.9074163"; geodata[78] = "20.7439674, -103.9056393"; geodata[79] = "20.7442759, -103.9054207";
                            //    geodata[80] = "20.74221, -103.9019463"; geodata[81] = "20.7418488, -103.9022427"; geodata[82] = "20.741095, -103.9004831"; geodata[83] = "20.7414738, -103.9002391";
                            //    geodata[84] = "20.7418099, -103.9022829"; geodata[85] = "20.741455, -103.9025753"; geodata[86] = "20.7406849, -103.9007862"; geodata[87] = "20.7410612, -103.90051";
                            //    geodata[88] = "20.741391, -103.9025605"; geodata[89] = "20.7410423, -103.9028636"; geodata[90] = "20.7402447, -103.9010249"; geodata[91] = "20.7406272, -103.9007473";
                            //    geodata[92] = "20.7409746, -103.9028326"; geodata[93] = "20.7406648, -103.9031035"; geodata[94] = "20.7398948, -103.9012635"; geodata[95] = "20.7402058, -103.901049";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 18: //B1 Organico 
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0018";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 60);
                            //    geodata[0] = "20.2507485, -103.6141815"; geodata[1] = "20.2502339, -103.6145529"; geodata[2] = "20.2496388, -103.6129959"; geodata[3] = "20.2499445, -103.6127666";
                            //    geodata[4] = "20.2502079, -103.614502"; geodata[5] = "20.2498116, -103.6147836"; geodata[6] = "20.2491549, -103.6137053"; geodata[7] = "20.249653, -103.6130589";
                            //    geodata[8] = "20.2517911, -103.613429"; geodata[9] = "20.2513017, -103.6137804"; geodata[10] = "20.2503417, -103.6121081"; geodata[11] = "20.250757, -103.6116186";
                            //    geodata[12] = "20.2512801, -103.6138043"; geodata[13] = "20.2507794, -103.6141637"; geodata[14] = "20.2499276, -103.6126657"; geodata[15] = "20.2503528, -103.6121775";
                            //    geodata[16] = "20.2523221, -103.6130491"; geodata[17] = "20.2518251, -103.6134098"; geodata[18] = "20.250918, -103.6118193"; geodata[19] = "20.251415, -103.6114612";
                            //    geodata[20] = "20.2514107, -103.611448"; geodata[21] = "20.2509112, -103.6118101"; geodata[22] = "20.2499914, -103.6102276"; geodata[23] = "20.2504972, -103.6098588";
                            //    geodata[24] = "20.2504902, -103.6098458"; geodata[25] = "20.2499869, -103.6102119"; geodata[26] = "20.249086, -103.6086227"; geodata[27] = "20.2495868, -103.6082606";
                            //    geodata[28] = "20.2495852, -103.6082513"; geodata[29] = "20.2490806, -103.6086134"; geodata[30] = "20.2485446, -103.6076692"; geodata[31] = "20.2490429, -103.6072991";
                            //    geodata[32] = "20.2528408, -103.6126737"; geodata[33] = "20.2523463, -103.6130277"; geodata[34] = "20.2514341, -103.6114425"; geodata[35] = "20.2519349, -103.6110844";
                            //    geodata[36] = "20.2519286, -103.6110737"; geodata[37] = "20.2514278, -103.6114304"; geodata[38] = "20.2505294, -103.6098385"; geodata[39] = "20.2511057, -103.6094135";
                            //    geodata[40] = "20.2510989, -103.6094041"; geodata[41] = "20.2505202, -103.6098279"; geodata[42] = "20.2496105, -103.6082454"; geodata[43] = "20.2501453, -103.6078564";
                            //    geodata[44] = "20.2501363, -103.6078462"; geodata[45] = "20.2496016, -103.6082298"; geodata[46] = "20.2490681, -103.607291"; geodata[47] = "20.2495676, -103.6069155";
                            //    geodata[48] = "20.2541881, -103.611694"; geodata[49] = "20.2533929, -103.6122747"; geodata[50] = "20.2524744, -103.6106775"; geodata[51] = "20.2525285, -103.6106426";
                            //    geodata[52] = "20.2533696, -103.6122922"; geodata[53] = "20.2528714, -103.6126543"; geodata[54] = "20.2519605, -103.6110624"; geodata[55] = "20.2524637, -103.610699";
                            //    geodata[56] = "20.2524584, -103.6106881"; geodata[57] = "20.2519539, -103.6110542"; geodata[58] = "20.2516192, -103.6104682"; geodata[59] = "20.25193, -103.6102402";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //        auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //        for (int k = 0; k < auxTables.Count; k++)
                            //        {
                            //            Tables.Add(auxTables[k]);
                            //        }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //        for (int l = 0; l < geodata.Length; l++)
                            //        {
                            //            string[] temp = geodata[l].Split(',');
                            //            coordinates[2 * auxCont] = temp[0].Trim();
                            //            coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //            if (auxCont == 3)
                            //            {

                            //                await App.LocalDB.SaveData(new Mgeodata
                            //                {
                            //                    controlLog = auxCont2,
                            //                    Campo = Campo,
                            //                    Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                    Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                    lat1 = coordinates[0],
                            //                    lon1 = coordinates[1],
                            //                    lat2 = coordinates[2],
                            //                    lon2 = coordinates[3],
                            //                    lat3 = coordinates[4],
                            //                    lon3 = coordinates[5],
                            //                    lat4 = coordinates[6],
                            //                    lon4 = coordinates[7],
                            //                    acumuladoPlaga = ""
                            //                });
                            //                auxCont = 0;
                            //                auxCont2++;
                            //            }
                            //            else
                            //            {
                            //                auxCont++;
                            //            }
                            //        }
                            //    }
                            //    else { }
                            //    break;

                            //case 20: //La Peña Zarzamora
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0020";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 132);
                            //    geodata[0] = " 20.7388357, -103.9068722"; geodata[1] = " 20.7384131, -103.9071833"; geodata[2] = " 20.737944, -103.9060957"; geodata[3] = " 20.7379791, -103.9060675";
                            //    geodata[4] = " 20.7383792, -103.9072048"; geodata[5] = " 20.737934, -103.907532"; geodata[6] = " 20.7371426, -103.9056652"; geodata[7] = " 20.7378812, -103.9059991";
                            //    geodata[8] = " 20.7379091, -103.9075604"; geodata[9] = " 20.7374551, -103.9078809"; geodata[10] = " 20.7366813, -103.90601"; geodata[11] = " 20.7371227, -103.9056962";
                            //    geodata[12] = " 20.7374288, -103.9079064"; geodata[13] = " 20.7369748, -103.9082148"; geodata[14] = " 20.7361934, -103.9063695"; geodata[15] = " 20.7366461, -103.9060382";
                            //    geodata[16] = " 20.7369547, -103.9082416"; geodata[17] = " 20.7367289, -103.9083851"; geodata[18] = " 20.7357669, -103.9066833"; geodata[19] = " 20.7361733, -103.9063909";
                            //    geodata[20] = " 20.7367921, -103.9048588"; geodata[21] = " 20.7367609, -103.9048936"; geodata[22] = " 20.7363896, -103.9043841"; geodata[23] = " 20.7365325, -103.9042888";
                            //    geodata[24] = " 20.7373162, -103.9055123"; geodata[25] = " 20.7371318, -103.9056344"; geodata[26] = " 20.7369838, -103.905291"; geodata[27] = " 20.7370466, -103.9052548";
                            //    geodata[28] = " 20.7371068, -103.9056527"; geodata[29] = " 20.7366502, -103.9059625"; geodata[30] = " 20.7362389, -103.905005"; geodata[31] = " 20.7365913, -103.9047542";
                            //    geodata[32] = " 20.7366265, -103.905983"; geodata[33] = " 20.7361737, -103.9063196"; geodata[34] = " 20.7356833, -103.9051528"; geodata[35] = " 20.7361411, -103.9048309";
                            //    geodata[36] = " 20.7361418, -103.906337"; geodata[37] = " 20.7357492, -103.9066535"; geodata[38] = " 20.7351823, -103.9054921"; geodata[39] = " 20.7356526, -103.9051783";
                            //    geodata[40] = " 20.7355578, -103.9063421"; geodata[41] = " 20.7355027, -103.906381"; geodata[42] = " 20.7350637, -103.9059438"; geodata[43] = " 20.735302, -103.9057922";
                            //    geodata[44] = " 20.7381257, -103.9021675"; geodata[45] = " 20.737668, -103.9024545"; geodata[46] = " 20.7369794, -103.9008345"; geodata[47] = " 20.737456, -103.9005703";
                            //    geodata[48] = " 20.7376491, -103.9024988"; geodata[49] = " 20.7371951, -103.902822"; geodata[50] = " 20.7364865, -103.9011469"; geodata[51] = " 20.7369493, -103.9008385";
                            //    geodata[52] = " 20.7371437, -103.9027858"; geodata[53] = " 20.7366897, -103.9030996"; geodata[54] = " 20.7360049, -103.9014607"; geodata[55] = " 20.7364652, -103.9011764";
                            //    geodata[56] = " 20.7374375, -103.9005336"; geodata[57] = " 20.7369647, -103.9007831"; geodata[58] = " 20.7365257, -103.8997383"; geodata[59] = " 20.736991, -103.8994581";
                            //    geodata[60] = " 20.7369283, -103.9007925"; geodata[61] = " 20.736458, -103.9010674"; geodata[62] = " 20.7360516, -103.9001139"; geodata[63] = " 20.7365019, -103.8997813";
                            //    geodata[64] = " 20.7364252, -103.9010768"; geodata[65] = " 20.7359573, -103.9013597"; geodata[66] = " 20.7355497, -103.9004035"; geodata[67] = " 20.7360113, -103.9000897";
                            //    geodata[68] = " 20.7359172, -103.9013463"; geodata[69] = " 20.7354506, -103.9016306"; geodata[70] = " 20.7350656, -103.9007147"; geodata[71] = " 20.7355209, -103.9003901";
                            //    geodata[72] = " 20.7354168, -103.9016521"; geodata[73] = " 20.7349703, -103.9019766"; geodata[74] = " 20.7346479, -103.9010191"; geodata[75] = " 20.7350405, -103.9007334";
                            //    geodata[76] = " 20.7401034, -103.9020392"; geodata[77] = " 20.7397397, -103.9022859"; geodata[78] = " 20.738695, -103.8998143"; geodata[79] = " 20.7390562, -103.8995541";
                            //    geodata[80] = " 20.7396635, -103.9022031"; geodata[81] = " 20.7392822, -103.9024097"; geodata[82] = " 20.7383064, -103.9000896"; geodata[83] = " 20.7386676, -103.8998281";
                            //    geodata[84] = " 20.7391671, -103.902225"; geodata[85] = " 20.7388021, -103.902461"; geodata[86] = " 20.737899, -103.9003234"; geodata[87] = " 20.7382615, -103.9000592";
                            //    geodata[88] = " 20.7387272, -103.9023817"; geodata[89] = " 20.7383672, -103.9025936"; geodata[90] = " 20.7375194, -103.9005779"; geodata[91] = " 20.7378643, -103.9003231";
                            //    geodata[92] = " 20.7431019, -103.8969348"; geodata[93] = " 20.7427959, -103.8971226"; geodata[94] = " 20.7415919, -103.8942339"; geodata[95] = " 20.7419255, -103.8940354";
                            //    geodata[96] = " 20.7427173, -103.8970079"; geodata[97] = " 20.7422545, -103.8972949"; geodata[98] = " 20.7411069, -103.8945469"; geodata[99] = " 20.7415722, -103.8942532";
                            //    geodata[100] = " 20.7423324, -103.8975657"; geodata[101] = " 20.7418734, -103.8978835"; geodata[102] = " 20.7406154, -103.8948902"; geodata[103] = " 20.741087, -103.8945643";
                            //    geodata[104] = " 20.7418182, -103.8978285"; geodata[105] = " 20.7413529, -103.8981343"; geodata[106] = " 20.7401263, -103.8952053"; geodata[107] = " 20.7405928, -103.8949009";
                            //    geodata[108] = " 20.7413009, -103.8980997"; geodata[109] = " 20.740867, -103.8983626"; geodata[110] = " 20.7397232, -103.8960437"; geodata[111] = " 20.7401646, -103.8953786";
                            //    geodata[112] = " 20.7459853, -103.9001407"; geodata[113] = " 20.7453118, -103.8985408"; geodata[114] = " 20.7457143, -103.8982685"; geodata[115] = " 20.7459652, -103.8988613";
                            //    geodata[116] = " 20.7459503, -103.9001368"; geodata[117] = " 20.7453923, -103.9002079"; geodata[118] = " 20.7445821, -103.8982874"; geodata[119] = " 20.7451904, -103.8982968";
                            //    geodata[120] = " 20.7453611, -103.9002176"; geodata[121] = " 20.7445634, -103.9001116"; geodata[122] = " 20.7443953, -103.8984419"; geodata[123] = " 20.7445634, -103.8983266";
                            //    geodata[124] = " 20.7458309, -103.8979683"; geodata[125] = " 20.745174, -103.89819"; geodata[126] = " 20.7449082, -103.8975784"; geodata[127] = " 20.7454972, -103.897165";
                            //    geodata[128] = " 20.7451051, -103.898131"; geodata[129] = " 20.744394, -103.8983683"; geodata[130] = " 20.7442296, -103.8978963"; geodata[131] = " 20.7448379, -103.8974819";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 22: //El Verde Frambuesa
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0022";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 60);
                            //    geodata[0] = "19.9067767, -103.6081971"; geodata[1] = "19.9062106, -103.608181"; geodata[2] = "19.9062572, -103.6062619"; geodata[3] = "19.9068284, -103.6062767";
                            //    geodata[4] = "19.9061365, -103.6093432"; geodata[5] = "19.9055514, -103.6089409"; geodata[6] = "19.9056347, -103.6062532"; geodata[7] = "19.9062173, -103.6062613";
                            //    geodata[8] = "19.9055601, -103.6076332"; geodata[9] = "19.9054819, -103.6076412"; geodata[10] = "19.9053911, -103.6062491"; geodata[11] = "19.9055928, -103.6062491";
                            //    geodata[12] = "19.9068358, -103.6061741"; geodata[13] = "19.9062558, -103.6061634"; geodata[14] = "19.9063062, -103.6023841"; geodata[15] = "19.9068837, -103.6023975";
                            //    geodata[16] = "19.9062129, -103.6061634"; geodata[17] = "19.9056303, -103.6061526"; geodata[18] = "19.9057085, -103.602368"; geodata[19] = "19.9062734, -103.6023841";
                            //    geodata[20] = "19.905595, -103.6061526"; geodata[21] = "19.9053857, -103.6061499"; geodata[22] = "19.9052722, -103.6024244"; geodata[23] = "19.9056707, -103.6024351";
                            //    geodata[24] = "19.9117433, -103.6030987"; geodata[25] = "19.9112175, -103.6031014"; geodata[26] = "19.9112162, -103.6015833"; geodata[27] = "19.9116248, -103.6015819";
                            //    geodata[28] = "19.9111734, -103.6030987"; geodata[29] = "19.9106135, -103.6030987"; geodata[30] = "19.9106085, -103.6016638"; geodata[31] = "19.9111797, -103.601649";
                            //    geodata[32] = "19.9105668, -103.6030947"; geodata[33] = "19.9099767, -103.6030987"; geodata[34] = "19.9099919, -103.6017804"; geodata[35] = "19.9105744, -103.6017777";
                            //    geodata[36] = "19.9099351, -103.6030929"; geodata[37] = "19.909354, -103.6030922"; geodata[38] = "19.9093626, -103.6015667"; geodata[39] = "19.9098242, -103.6015667";
                            //    geodata[40] = "19.9098225, -103.6015583"; geodata[41] = "19.9093626, -103.6015573"; geodata[42] = "19.9093774, -103.5999208"; geodata[43] = "19.9096069, -103.5999221";
                            //    geodata[44] = "19.9093178, -103.6030871"; geodata[45] = "19.9087479, -103.6030885"; geodata[46] = "19.9087668, -103.6015717"; geodata[47] = "19.9093292, -103.6015717";
                            //    geodata[48] = "19.9093305, -103.6015623"; geodata[49] = "19.9087605, -103.6015596"; geodata[50] = "19.9087718, -103.5999141"; geodata[51] = "19.9093468, -103.5999235";
                            //    geodata[52] = "19.90871, -103.6030147"; geodata[53] = "19.9083973, -103.6030214"; geodata[54] = "19.9085348, -103.6019754"; geodata[55] = "19.9087239, -103.6019781";
                            //    geodata[56] = "19.9087213, -103.6015737"; geodata[57] = "19.9084464, -103.6015751"; geodata[58] = "19.9082699, -103.5999939"; geodata[59] = "19.9087364, -103.5999832";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 23: //El Verde Zarzamora
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0023";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 20);
                            //    geodata[0] = "19.9159628, -103.6063687"; geodata[1] = "19.9153676, -103.6063794"; geodata[2] = "19.9154181, -103.6034665"; geodata[3] = "19.9156022, -103.6034772";
                            //    geodata[4] = "19.9153273, -103.6063821"; geodata[5] = "19.91477, -103.6063633"; geodata[6] = "19.9148204, -103.6034585"; geodata[7] = "19.9153802, -103.6034746";
                            //    geodata[8] = "19.9147244, -103.606363"; geodata[9] = "19.9141746, -103.6063523"; geodata[10] = "19.9142301, -103.6034475"; geodata[11] = "19.9147874, -103.6034609";
                            //    geodata[12] = "19.9141343, -103.6063469"; geodata[13] = "19.9135795, -103.6063362"; geodata[14] = "19.9136123, -103.6034367"; geodata[15] = "19.9141847, -103.6034501";
                            //    geodata[16] = "19.9135709, -103.6046737"; geodata[17] = "19.9130232, -103.6046587"; geodata[18] = "19.9130358, -103.6034249"; geodata[19] = "19.913578, -103.603441";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 24: //El Verde Arandano
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0024";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 212);
                            //    geodata[0] = "19.9117082, -103.6175753"; geodata[1] = "19.911219, -103.6176182"; geodata[2] = "19.9110601, -103.6151854"; geodata[3] = "19.9112165, -103.6151827";
                            //    geodata[4] = "19.9111736, -103.6176155"; geodata[5] = "19.9106112, -103.6176611"; geodata[6] = "19.9104448, -103.615239"; geodata[7] = "19.9110273, -103.6151934";
                            //    geodata[8] = "19.9105043, -103.6168344"; geodata[9] = "19.9099495, -103.6168746"; geodata[10] = "19.9098309, -103.6152814"; geodata[11] = "19.910411, -103.6152412";
                            //    geodata[12] = "19.9099041, -103.6168639"; geodata[13] = "19.909377, -103.6176283"; geodata[14] = "19.9092206, -103.6153216"; geodata[15] = "19.9097931, -103.6152814";
                            //    geodata[16] = "19.9092996, -103.6174756"; geodata[17] = "19.9087372, -103.6175051"; geodata[18] = "19.9086035, -103.6153674"; geodata[19] = "19.9091709, -103.6153272";
                            //    geodata[20] = "19.9086936, -103.6177653"; geodata[21] = "19.9081438, -103.6178243"; geodata[22] = "19.9079824, -103.6154077"; geodata[23] = "19.9085675, -103.6153701";
                            //    geodata[24] = "19.9080934, -103.6178351"; geodata[25] = "19.9075133, -103.6178753"; geodata[26] = "19.9073721, -103.6154506"; geodata[27] = "19.9079522, -103.6154103";
                            //    geodata[28] = "19.9074629, -103.6178833"; geodata[29] = "19.9068122, -103.6179263"; geodata[30] = "19.9067719, -103.6154908"; geodata[31] = "19.9073418, -103.6154506";
                            //    geodata[32] = "19.906787, -103.6168159"; geodata[33] = "19.906666, -103.6168239"; geodata[34] = "19.9062473, -103.6155391"; geodata[35] = "19.906724, -103.6155042";
                            //    geodata[36] = "19.9110291, -103.6151201"; geodata[37] = "19.9104465, -103.6151604"; geodata[38] = "19.9103205, -103.6131353"; geodata[39] = "19.9108727, -103.6132319";
                            //    geodata[40] = "19.9104014, -103.6151687"; geodata[41] = "19.9098315, -103.6151955"; geodata[42] = "19.9096877, -103.6128861"; geodata[43] = "19.9102728, -103.613098";
                            //    geodata[44] = "19.909781, -103.6152116"; geodata[45] = "19.9092237, -103.6152438"; geodata[46] = "19.9090749, -103.6126716"; geodata[47] = "19.9096474, -103.6128647";
                            //    geodata[48] = "19.9091606, -103.6151124"; geodata[49] = "19.9086033, -103.6151419"; geodata[50] = "19.9084066, -103.6124221"; geodata[51] = "19.9090043, -103.6126286";
                            //    geodata[52] = "19.9085594, -103.6152826"; geodata[53] = "19.9079869, -103.6153309"; geodata[54] = "19.9077877, -103.6122034"; geodata[55] = "19.9083703, -103.6124046";
                            //    geodata[56] = "19.907939, -103.6153282"; geodata[57] = "19.9073766, -103.6153711"; geodata[58] = "19.9071597, -103.6121551"; geodata[59] = "19.9077347, -103.6121256";
                            //    geodata[60] = "19.9073338, -103.6153711"; geodata[61] = "19.9067764, -103.6154113"; geodata[62] = "19.9065494, -103.6121954"; geodata[63] = "19.9071169, -103.6121578";
                            //    geodata[64] = "19.9067335, -103.6154221"; geodata[65] = "19.9062518, -103.6154569"; geodata[66] = "19.9058181, -103.612241"; geodata[67] = "19.9065116, -103.612198";
                            //    geodata[68] = "19.9079544, -103.6110258"; geodata[69] = "19.9074298, -103.6110714"; geodata[70] = "19.9072608, -103.609497"; geodata[71] = "19.9077148, -103.6094621";
                            //    geodata[72] = "19.907383, -103.6110665"; geodata[73] = "19.9068408, -103.6111175"; geodata[74] = "19.9066617, -103.6095323"; geodata[75] = "19.9072191, -103.6094867";
                            //    geodata[76] = "19.9067954, -103.6111255"; geodata[77] = "19.9062431, -103.6111577"; geodata[78] = "19.906064, -103.6095269"; geodata[79] = "19.9066214, -103.6094974";
                            //    geodata[80] = "19.9062002, -103.6111684"; geodata[81] = "19.9056429, -103.6112167"; geodata[82] = "19.9054764, -103.6095779"; geodata[83] = "19.9060212, -103.6095376";
                            //    geodata[84] = "19.914975, -103.6098384"; geodata[85] = "19.9146913, -103.6098384"; geodata[86] = "19.9147568, -103.6064481"; geodata[87] = "19.9154818, -103.6064629";
                            //    geodata[88] = "19.9146506, -103.6100366"; geodata[89] = "19.9140983, -103.6100231"; geodata[90] = "19.9141538, -103.6064317"; geodata[91] = "19.9147237, -103.6064397";
                            //    geodata[92] = "19.9140605, -103.6099561"; geodata[93] = "19.9135006, -103.6099454"; geodata[94] = "19.9135687, -103.6064183"; geodata[95] = "19.914121, -103.606437";
                            //    geodata[96] = "19.9134653, -103.6098783"; geodata[97] = "19.9129181, -103.6098676"; geodata[98] = "19.9129836, -103.6063995"; geodata[99] = "19.9135334, -103.6064263";
                            //    geodata[100] = "19.9128727, -103.6097898"; geodata[101] = "19.9123153, -103.6097791"; geodata[102] = "19.9123784, -103.6063995"; geodata[103] = "19.9129433, -103.6064156";
                            //    geodata[104] = "19.9122649, -103.6097683"; geodata[105] = "19.9117151, -103.6097496"; geodata[106] = "19.9117858, -103.6063861"; geodata[107] = "19.912338, -103.6064075";
                            //    geodata[108] = "19.9116672, -103.6096959"; geodata[109] = "19.9110897, -103.6096798"; geodata[110] = "19.9111528, -103.60637"; geodata[111] = "19.9117303, -103.6063888";
                            //    geodata[112] = "19.9110494, -103.6096128"; geodata[113] = "19.9104719, -103.609602"; geodata[114] = "19.9105223, -103.607459"; geodata[115] = "19.9110973, -103.6074724";
                            //    geodata[116] = "19.9104291, -103.6095338"; geodata[117] = "19.909863, -103.6095204"; geodata[118] = "19.909921, -103.607443"; geodata[119] = "19.9104808, -103.6074618";
                            //    geodata[120] = "19.9098188, -103.609449"; geodata[121] = "19.9092551, -103.6094343"; geodata[122] = "19.9093081, -103.6063269"; geodata[123] = "19.9098906, -103.606343";
                            //    geodata[124] = "19.909216, -103.6092948"; geodata[125] = "19.9086436, -103.6092854"; geodata[126] = "19.9086953, -103.6063216"; geodata[127] = "19.9092702, -103.6063376";
                            //    geodata[128] = "19.9086052, -103.609218"; geodata[129] = "19.9080251, -103.6092006"; geodata[130] = "19.9080731, -103.6063105"; geodata[131] = "19.9086506, -103.6063199";
                            //    geodata[132] = "19.9079798, -103.6091979"; geodata[133] = "19.9074111, -103.6091898"; geodata[134] = "19.9074766, -103.6062917"; geodata[135] = "19.9080365, -103.6063172";
                            //    geodata[136] = "19.9073619, -103.6091881"; geodata[137] = "19.9067818, -103.6091787"; geodata[138] = "19.9068751, -103.6062805"; geodata[139] = "19.9074362, -103.6062966";
                            //    geodata[140] = "19.9067402, -103.6091746"; geodata[141] = "19.9061828, -103.6091599"; geodata[142] = "19.9062068, -103.608193"; geodata[143] = "19.9067742, -103.6082091";
                            //    geodata[144] = "19.9111167, -103.6060811"; geodata[145] = "19.9105352, -103.6060606"; geodata[146] = "19.9105907, -103.6044768"; geodata[147] = "19.9111518, -103.6044875";
                            //    geodata[148] = "19.9104958, -103.6061228"; geodata[149] = "19.9099359, -103.6061094"; geodata[150] = "19.9099359, -103.6052886"; geodata[151] = "19.9105071, -103.6053007";
                            //    geodata[152] = "19.9135407, -103.6062696"; geodata[153] = "19.9129884, -103.6062508"; geodata[154] = "19.9130199, -103.604671"; geodata[155] = "19.9135709, -103.6046844";
                            //    geodata[156] = "19.9129455, -103.6063179"; geodata[157] = "19.9123806, -103.6063125"; geodata[158] = "19.9124361, -103.6034184"; geodata[159] = "19.9129959, -103.6034318";
                            //    geodata[160] = "19.9123466, -103.6063125"; geodata[161] = "19.9117918, -103.6063018"; geodata[162] = "19.9118447, -103.603397"; geodata[163] = "19.912397, -103.6034157";
                            //    geodata[164] = "19.9117337, -103.6062562"; geodata[165] = "19.9111512, -103.6062508"; geodata[166] = "19.9112117, -103.6032655"; geodata[167] = "19.9117817, -103.603279";
                            //    geodata[168] = "19.9111564, -103.6044778"; geodata[169] = "19.9105902, -103.604463"; geodata[170] = "19.9105978, -103.6032574"; geodata[171] = "19.9111715, -103.6032694";
                            //    geodata[172] = "19.9105231, -103.6052932"; geodata[173] = "19.9099346, -103.6052792"; geodata[174] = "19.9099683, -103.6032467"; geodata[175] = "19.9105635, -103.6032601";
                            //    geodata[176] = "19.9098878, -103.606234"; geodata[177] = "19.9093154, -103.6062233"; geodata[178] = "19.9093557, -103.6032273"; geodata[179] = "19.9099282, -103.6032461";
                            //    geodata[180] = "19.9092725, -103.6062179"; geodata[181] = "19.9086824, -103.6062019"; geodata[182] = "19.9087429, -103.6032166"; geodata[183] = "19.9093179, -103.6032246";
                            //    geodata[184] = "19.908642, -103.6062179"; geodata[185] = "19.908067, -103.6061938"; geodata[186] = "19.9081275, -103.6031978"; geodata[187] = "19.908705, -103.6032166";
                            //    geodata[188] = "19.9080342, -103.6061482"; geodata[189] = "19.9074718, -103.6061321"; geodata[190] = "19.9075475, -103.6022724"; geodata[191] = "19.9081174, -103.6022858";
                            //    geodata[192] = "19.9074416, -103.6061911"; geodata[193] = "19.9068741, -103.6061723"; geodata[194] = "19.9069271, -103.6023314"; geodata[195] = "19.9075147, -103.6023422";
                            //    geodata[196] = "19.9135842, -103.6031047"; geodata[197] = "19.9130547, -103.6030993"; geodata[198] = "19.912781, -103.6012419"; geodata[199] = "19.9136284, -103.601026";
                            //    geodata[200] = "19.9141857, -103.603118"; geodata[201] = "19.9136296, -103.603106"; geodata[202] = "19.9136712, -103.6009669"; geodata[203] = "19.9142273, -103.6012244";
                            //    geodata[204] = "19.9147821, -103.6031355"; geodata[205] = "19.9142298, -103.6031207"; geodata[206] = "19.9142677, -103.601321"; geodata[207] = "19.9148048, -103.6019111";
                            //    geodata[208] = "19.9154966, -103.6031556"; geodata[209] = "19.9148309, -103.6031368"; geodata[210] = "19.9148334, -103.6019245"; geodata[211] = "19.9153705, -103.6024877";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            ////case 0025: //El Fuerte Zarzamora (Tehueco Sinaloa)
                            ////    break;

                            //case 26: //Mochicahui Zarzamora (Sinaloa)
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0026";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 212);
                            //    geodata[0] = "25.9467531, 108.9484507"; geodata[1] = "25.9461743, -108.9487029"; geodata[2] = "25.945751, -108.9478714"; geodata[3] = "25.9463805, -108.9476608";
                            //    geodata[4] = "25.9463768, 108.9476327"; geodata[5] = "25.9457428, -108.9478446"; geodata[6] = "25.9452192, -108.9468629"; geodata[7] = "25.9458656, -108.9466107";
                            //    geodata[8] = "25.9461438, 108.9487341"; geodata[9] = "25.9455361, -108.9490359"; geodata[10] = "25.9450344, -108.9480971"; geodata[11] = "25.9457157, -108.9478825";
                            //    geodata[12] = "25.9457043, 108.9478584"; geodata[13] = "25.9450253, -108.9480824"; geodata[14] = "25.9445273, -108.9471114"; geodata[15] = "25.9451833, -108.9468674";
                            //    geodata[16] = "25.9455029, 108.9490766"; geodata[17] = "25.9448782, -108.949365"; geodata[18] = "25.9443199, -108.9483444"; geodata[19] = "25.944994, -108.9481191";
                            //    geodata[20] = "25.9449795, 108.9480896"; geodata[21] = "25.9443126, -108.948327"; geodata[22] = "25.9438279, -108.947356"; geodata[23] = "25.9444803, -108.9471092";
                            //    geodata[24] = "25.9448283, 108.9494064"; geodata[25] = "25.9441855, -108.9496652"; geodata[26] = "25.9436344, -108.9486044"; geodata[27] = "25.9442796, -108.9483576";
                            //    geodata[28] = "25.9442735, 108.9483429"; geodata[29] = "25.9436235, -108.9485896"; geodata[30] = "25.9431243, -108.9476093"; geodata[31] = "25.9437851, -108.9473746";
                            //    geodata[32] = "25.9441505, 108.9496813"; geodata[33] = "25.9435126, -108.9499924"; geodata[34] = "25.9429313, -108.9488766"; geodata[35] = "25.9436006, -108.9486245";
                            //    geodata[36] = "25.9435898, 108.948603"; geodata[37] = "25.9429265, -108.9488646"; geodata[38] = "25.9424067, -108.9478373"; geodata[39] = "25.9430869, -108.947624";
                            //    geodata[40] = "25.9433502, 108.9500513"; geodata[41] = "25.9427074, -108.950307"; geodata[42] = "25.9421261, -108.9491778"; geodata[43] = "25.942792, -108.948913";
                            //    geodata[44] = "25.9427846, 108.9489002"; geodata[45] = "25.9421158, -108.9491575"; geodata[46] = "25.9413751, -108.9477572"; geodata[47] = "25.9420794, -108.947222";
                            //    geodata[48] = "25.9426706, 108.9503325"; geodata[49] = "25.9420435, -108.9506168"; geodata[50] = "25.9414345, -108.9494487"; geodata[51] = "25.9420821, -108.9491953";
                            //    geodata[52] = "25.9420755, 108.9491773"; geodata[53] = "25.9414291, -108.9494294"; geodata[54] = "25.9407526, -108.9481567"; geodata[55] = "25.941329, -108.9477745";
                            //    geodata[56] = "25.9420116, 108.9506447"; geodata[57] = "25.9416039, -108.9508525"; geodata[58] = "25.9407163, -108.9496979"; geodata[59] = "25.9413929, -108.9494578";
                            //    geodata[60] = "25.9413852, 108.9494367"; geodata[61] = "25.9407099, -108.9496768"; geodata[62] = "25.9401117, -108.9485408"; geodata[63] = "25.9407352, -108.9482096";
                            //    geodata[64] = "25.9408385, 108.9500225"; geodata[65] = "25.9398285, -108.9496356"; geodata[66] = "25.939448, -108.9489322"; geodata[67] = "25.9400763, -108.9485821";
                            //    geodata[68] = "25.9453408, 108.9455076"; geodata[69] = "25.9449255, -108.9456241"; geodata[70] = "25.9444239, -108.9440966"; geodata[71] = "25.9446354, -108.9440097";
                            //    geodata[72] = "25.9446245, 108.9439874"; geodata[73] = "25.9444182, -108.9440719"; geodata[74] = "25.943919, -108.9425324"; geodata[75] = "25.943995, -108.9425069";
                            //    geodata[76] = "25.9448815, 108.945629"; geodata[77] = "25.9442364, -108.9458511"; geodata[78] = "25.9437504, -108.9443664"; geodata[79] = "25.9443884, -108.9441103";
                            //    geodata[80] = "25.9443758, 108.9440889"; geodata[81] = "25.9437403, -108.944341"; geodata[82] = "25.9432471, -108.9428027"; geodata[83] = "25.9438803, -108.9425506";
                            //    geodata[84] = "25.944197, 108.9458616"; geodata[85] = "25.9435241, -108.946048"; geodata[86] = "25.9430706, -108.9446251"; geodata[87] = "25.9437134, -108.944377";
                            //    geodata[88] = "25.9437074, 108.9443576"; geodata[89] = "25.9430634, -108.9446044"; geodata[90] = "25.9425581, -108.9430595"; geodata[91] = "25.9432021, -108.9428248";
                            //    geodata[92] = "25.9434891, 108.9460612"; geodata[93] = "25.94278, -108.9462691"; geodata[94] = "25.9423519, -108.9449078"; geodata[95] = "25.9430308, -108.9446423";
                            //    geodata[96] = "25.9430238, 108.9446255"; geodata[97] = "25.9423473, -108.9448857"; geodata[98] = "25.9418685, -108.9433622"; geodata[99] = "25.9425294, -108.9431006";
                            //    geodata[100] = "25.9426611, 108.9463157"; geodata[101] = "25.9420304, -108.9465062"; geodata[102] = "25.9416156, -108.9451999"; geodata[103] = "25.9422439, -108.9449491";
                            //    geodata[104] = "25.9422392, 108.9449328"; geodata[105] = "25.9416085, -108.9451769"; geodata[106] = "25.9411285, -108.9436776"; geodata[107] = "25.9417701, -108.9434067";
                            //    geodata[108] = "25.9421764, 108.9471156"; geodata[109] = "25.9415594, -108.9474814"; geodata[110] = "25.9412518, -108.9465855"; geodata[111] = "25.9419247, -108.9463066";
                            //    geodata[112] = "25.9419175, 108.9462891"; geodata[113] = "25.9412446, -108.9465668"; geodata[114] = "25.9409009, -108.9454617"; geodata[115] = "25.9415835, -108.9452055";
                            //    geodata[116] = "25.9415821, 108.9451904"; geodata[117] = "25.9408935, -108.9454492"; geodata[118] = "25.940428, -108.9439418"; geodata[119] = "25.9410949, -108.9436965";
                            //    geodata[120] = "25.9414345, 108.947579"; geodata[121] = "25.9408486, -108.9479095"; geodata[122] = "25.9405145, -108.9468648"; geodata[123] = "25.9411561, -108.946614";
                            //    geodata[124] = "25.9411537, 108.9466033"; geodata[125] = "25.9405097, -108.9468487"; geodata[126] = "25.9401636, -108.9457449"; geodata[127] = "25.9408027, -108.9454875";
                            //    geodata[128] = "25.940796, 108.9454677"; geodata[129] = "25.9401532, -108.9457265"; geodata[130] = "25.9397094, -108.9443103"; geodata[131] = "25.9403292, -108.9440086";
                            //    geodata[132] = "25.9408164, 108.9479738"; geodata[133] = "25.9402134, -108.948344"; geodata[134] = "25.9398359, -108.9471357"; geodata[135] = "25.9404787, -108.9468795";
                            //    geodata[136] = "25.9404727, 108.9468593"; geodata[137] = "25.9398298, -108.9471102"; geodata[138] = "25.9394741, -108.9460078"; geodata[139] = "25.9401253, -108.9457623";
                            //    geodata[140] = "25.9401221, 108.9457439"; geodata[141] = "25.939466, -108.9459854"; geodata[142] = "25.9390282, -108.9446013"; geodata[143] = "25.9396674, -108.9443465";
                            //    geodata[144] = "25.9401838, 108.9483759"; geodata[145] = "25.9395948, -108.9487222"; geodata[146] = "25.939157, -108.9473972"; geodata[147] = "25.9398003, -108.9471502";
                            //    geodata[148] = "25.9397962, 108.9471316"; geodata[149] = "25.9391522, -108.9473744"; geodata[150] = "25.9387953, -108.9462652"; geodata[151] = "25.9394453, -108.9460172";
                            //    geodata[152] = "25.9394392, 108.9460024"; geodata[153] = "25.9387868, -108.9462505"; geodata[154] = "25.9382501, -108.9445567"; geodata[155] = "25.9390003, -108.9446238";
                            //    geodata[156] = "25.9395471, 108.9487552"; geodata[157] = "25.9391889, -108.948904"; geodata[158] = "25.938809, -108.9475267"; geodata[159] = "25.9391117, -108.9474114";
                            //    geodata[160] = "25.9391064, 108.9473928"; geodata[161] = "25.9388097, -108.9475028"; geodata[162] = "25.938056, -108.9445859"; geodata[163] = "25.9381971, -108.9445336";
                            //    geodata[164] = "25.9439426, 108.9415366"; geodata[165] = "25.9436423, -108.9416479"; geodata[166] = "25.9433818, -108.9408675"; geodata[167] = "25.9437207, -108.9407467";
                            //    geodata[168] = "25.9437207, 108.9407347"; geodata[169] = "25.9433746, -108.9408581"; geodata[170] = "25.94285, -108.9391951"; geodata[171] = "25.943289, -108.9390368";
                            //    geodata[172] = "25.943938, 108.9424774"; geodata[173] = "25.9432321, -108.9427393"; geodata[174] = "25.9427015, -108.9411354"; geodata[175] = "25.943347, -108.9408815";
                            //    geodata[176] = "25.9433402, 108.9408679"; geodata[177] = "25.942701, -108.9411201"; geodata[178] = "25.9421668, -108.9394852"; geodata[179] = "25.9428168, -108.9392318";
                            //    geodata[180] = "25.9431875, 108.9427585"; geodata[181] = "25.942546, -108.9430026"; geodata[182] = "25.942013, -108.941408"; geodata[183] = "25.9426678, -108.9411465";
                            //    geodata[184] = "25.9426654, 108.9411304"; geodata[185] = "25.9420069, -108.9413852"; geodata[186] = "25.9415257, -108.9398684"; geodata[187] = "25.9421456, -108.9395304";
                            //    geodata[188] = "25.9425052, 108.9430194"; geodata[189] = "25.9418612, -108.9432594"; geodata[190] = "25.9413197, -108.9416541"; geodata[191] = "25.9419782, -108.9414194";
                            //    geodata[192] = "25.9419735, 108.9414014"; geodata[193] = "25.9413126, -108.9416374"; geodata[194] = "25.9408797, -108.9402092"; geodata[195] = "25.9414983, -108.939886";
                            //    geodata[196] = "25.9417414, 108.943318"; geodata[197] = "25.9411083, -108.9435795"; geodata[198] = "25.9405849, -108.9419756"; geodata[199] = "25.9412035, -108.9416979";
                            //    geodata[200] = "25.941194, 108.9416784"; geodata[201] = "25.9405826, -108.9419574"; geodata[202] = "25.9401653, -108.9407048"; geodata[203] = "25.9408214, -108.9404553";
                            //    geodata[204] = "25.9410692, 108.9435939"; geodata[205] = "25.940465, -108.9438729"; geodata[206] = "25.940108, -108.9421536"; geodata[207] = "25.9405518, -108.9419873";
                            //    geodata[208] = "25.9405421, 108.9419712"; geodata[209] = "25.9401032, -108.9421334"; geodata[210] = "25.93971, -108.9410954"; geodata[211] = "25.9401767, -108.9408286";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            ////case 0027: //Potrero (Ahualulco)
                            ////    break;

                            ////case 0028: //San Rafael Frambuesa (Lagos de Moreno)
                            ////    break;

                            //case 29: //El Verde 2
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0029";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 152);
                            //    geodata[0] = "19.9121586, -103.6174481"; geodata[1] = "19.9119014, -103.6174843"; geodata[2] = "19.9115685, -103.6160292"; geodata[3] = "19.9119594, -103.6159689";
                            //    geodata[4] = "19.9127752, -103.6174079"; geodata[5] = "19.9122229, -103.6174816"; geodata[6] = "19.912001, -103.6159555"; geodata[7] = "19.9125558, -103.6158804";
                            //    geodata[8] = "19.9133651, -103.617356"; geodata[9] = "19.9128456, -103.6174458"; geodata[10] = "19.9126035, -103.615866"; geodata[11] = "19.9131444, -103.6157788";
                            //    geodata[12] = "19.91394, -103.6172741"; geodata[13] = "19.9134193, -103.6173667"; geodata[14] = "19.9131948, -103.6157721"; geodata[15] = "19.9137295, -103.6156863";
                            //    geodata[16] = "19.9145264, -103.6171253"; geodata[17] = "19.9139842, -103.6172165"; geodata[18] = "19.9137837, -103.6156849"; geodata[19] = "19.9143271, -103.6155911";
                            //    geodata[20] = "19.9151291, -103.6170207"; geodata[21] = "19.914602, -103.6171159"; geodata[22] = "19.9143246, -103.6150922"; geodata[23] = "19.9148353, -103.6148199";
                            //    geodata[24] = "19.9157431, -103.6169255"; geodata[25] = "19.9151846, -103.6170167"; geodata[26] = "19.9148668, -103.6147006"; geodata[27] = "19.9154468, -103.6149527";
                            //    geodata[28] = "19.9163181, -103.6168504"; geodata[29] = "19.9157873, -103.6169322"; geodata[30] = "19.9154922, -103.61495"; geodata[31] = "19.9160924, -103.6151565";
                            //    geodata[32] = "19.9169133, -103.616731"; geodata[33] = "19.9163698, -103.6167913"; geodata[34] = "19.9161479, -103.6151659"; geodata[35] = "19.9167153, -103.6153684";
                            //    geodata[36] = "19.9174693, -103.616668"; geodata[37] = "19.9169612, -103.6167364"; geodata[38] = "19.9167733, -103.6154033"; geodata[39] = "19.9172537, -103.6155709";
                            //    geodata[40] = "19.9119459, -103.6158791"; geodata[41] = "19.911555, -103.6159435"; geodata[42] = "19.9110002, -103.6133203"; geodata[43] = "19.9116256, -103.6135536";
                            //    geodata[44] = "19.9125486, -103.6157906"; geodata[45] = "19.9119988, -103.6158737"; geodata[46] = "19.9116861, -103.6135697"; geodata[47] = "19.9122586, -103.6137816";
                            //    geodata[48] = "19.9131362, -103.6156994"; geodata[49] = "19.912599, -103.6157879"; geodata[50] = "19.912304, -103.6137709"; geodata[51] = "19.9128764, -103.6139908";
                            //    geodata[52] = "19.9137288, -103.6156109"; geodata[53] = "19.9131942, -103.615686"; geodata[54] = "19.9129571, -103.614031"; geodata[55] = "19.9135195, -103.6142268";
                            //    geodata[56] = "19.9081748, -103.6114664"; geodata[57] = "19.9081181, -103.611457"; geodata[58] = "19.9079377, -103.6101883"; geodata[59] = "19.9082958, -103.6102272";
                            //    geodata[60] = "19.9086968, -103.612212"; geodata[61] = "19.9081722, -103.6120028"; geodata[62] = "19.9083513, -103.6101762"; geodata[63] = "19.908949, -103.6096318";
                            //    geodata[64] = "19.9092744, -103.6124159"; geodata[65] = "19.9087498, -103.6122228"; geodata[66] = "19.909002, -103.60968"; geodata[67] = "19.9095316, -103.6097471";
                            //    geodata[68] = "19.9098418, -103.6126063"; geodata[69] = "19.9093223, -103.6124481"; geodata[70] = "19.9095316, -103.6103801"; geodata[71] = "19.9095795, -103.6103855";
                            //    geodata[72] = "19.9101141, -103.6121477"; geodata[73] = "19.9100486, -103.6121396"; geodata[74] = "19.9097586, -103.6098678"; geodata[75] = "19.9103159, -103.6099027";
                            //    geodata[76] = "19.9106387, -103.6129121"; geodata[77] = "19.9100889, -103.6127029"; geodata[78] = "19.9103663, -103.6099402"; geodata[79] = "19.9109211, -103.6100019";
                            //    geodata[80] = "19.9112414, -103.6131267"; geodata[81] = "19.9106765, -103.6129282"; geodata[82] = "19.910964, -103.6100099"; geodata[83] = "19.9115239, -103.610069";
                            //    geodata[84] = "19.9118315, -103.6133493"; geodata[85] = "19.9112868, -103.6131294"; geodata[86] = "19.9115844, -103.6100743"; geodata[87] = "19.9121468, -103.6101414";
                            //    geodata[88] = "19.9125704, -103.6120296"; geodata[89] = "19.912003, -103.6119706"; geodata[90] = "19.9121821, -103.6101333"; geodata[91] = "19.9127571, -103.610195";
                            //    geodata[92] = "19.9131976, -103.6121109"; geodata[93] = "19.9126201, -103.6120505"; geodata[94] = "19.9128017, -103.6101904"; geodata[95] = "19.9133679, -103.6102642";
                            //    geodata[96] = "19.9137978, -103.6121725"; geodata[97] = "19.9132455, -103.6121055"; geodata[98] = "19.913412, -103.6102735"; geodata[99] = "19.9139819, -103.6103379";
                            //    geodata[100] = "19.9144042, -103.6122316"; geodata[101] = "19.9138469, -103.6121672"; geodata[102] = "19.9140284, -103.6103406"; geodata[103] = "19.9145832, -103.6103996";
                            //    geodata[104] = "19.9150245, -103.612304"; geodata[105] = "19.9144496, -103.6122369"; geodata[106] = "19.9146437, -103.6103647"; geodata[107] = "19.9151985, -103.6104184";
                            //    geodata[108] = "19.9156424, -103.6123683"; geodata[109] = "19.9150548, -103.6123013"; geodata[110] = "19.9152591, -103.6103138"; geodata[111] = "19.915824, -103.610303";
                            //    geodata[112] = "19.9162703, -103.6124408"; geodata[113] = "19.9156752, -103.6123764"; geodata[114] = "19.9158996, -103.6100536"; geodata[115] = "19.9163838, -103.6110943";
                            //    geodata[116] = "19.9166172, -103.6150748"; geodata[117] = "19.9160598, -103.6148629"; geodata[118] = "19.9163978, -103.6114002"; geodata[119] = "19.9167836, -103.6133287";
                            //    geodata[120] = "19.9171719, -103.6152867"; geodata[121] = "19.9166499, -103.6150856"; geodata[122] = "19.9167886, -103.6135594"; geodata[123] = "19.9168391, -103.6135755";
                            //    geodata[124] = "19.9124297, -103.6135616"; geodata[125] = "19.911885, -103.6133631"; geodata[126] = "19.9119884, -103.612089"; geodata[127] = "19.9125621, -103.6121521";
                            //    geodata[128] = "19.9130248, -103.6137765"; geodata[129] = "19.91248, -103.613586"; geodata[130] = "19.9126061, -103.6121604"; geodata[131] = "19.9131811, -103.6122181";
                            //    geodata[132] = "19.9136111, -103.6139884"; geodata[133] = "19.9130765, -103.6137966"; geodata[134] = "19.913229, -103.6122181"; geodata[135] = "19.9137851, -103.6122825";
                            //    geodata[136] = "19.9142075, -103.6141949"; geodata[137] = "19.913659, -103.6140112"; geodata[138] = "19.9138343, -103.6122839"; geodata[139] = "19.9143903, -103.6123522";
                            //    geodata[140] = "19.9148278, -103.6143706"; geodata[141] = "19.9142554, -103.6142257"; geodata[142] = "19.9144282, -103.6123536"; geodata[143] = "19.9150056, -103.6124152";
                            //    geodata[144] = "19.9154129, -103.6146468"; geodata[145] = "19.9148644, -103.6144457"; geodata[146] = "19.9150561, -103.6124166"; geodata[147] = "19.9156248, -103.6124756";
                            //    geodata[148] = "19.9160106, -103.6148467"; geodata[149] = "19.9154545, -103.6146562"; geodata[150] = "19.9156701, -103.6124836"; geodata[151] = "19.9162451, -103.6125427";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            ////case 0030: //El Refugio (Tala)
                            ////    break;

                            //case 31: //Camichines (Cocula)
                            //    Sectors.Clear();
                            //    Tables.Clear();
                            //    Campo = "";
                            //    Campo = "0031";
                            //    Array.Clear(geodata, 0, geodata.Length);
                            //    Array.Resize(ref geodata, geodata.Length + 172);
                            //    geodata[0] = "20.5116304, -103.8189025"; geodata[1] = "20.5110715, -103.8187804"; geodata[2] = "20.511084, -103.8183861"; geodata[3] = "20.5116568, -103.8187965";
                            //    geodata[4] = "20.5110437, -103.8187684"; geodata[5] = "20.5104558, -103.8186705"; geodata[6] = "20.5104182, -103.8180026"; geodata[7] = "20.5110575, -103.8183741";
                            //    geodata[8] = "20.5104181, -103.8186527"; geodata[9] = "20.5098453, -103.8185762"; geodata[10] = "20.5098164, -103.8176469"; geodata[11] = "20.510403, -103.8180183";
                            //    geodata[12] = "20.5098124, -103.8185754"; geodata[13] = "20.5092346, -103.818566"; geodata[14] = "20.5091957, -103.8172664"; geodata[15] = "20.509781, -103.8176125";
                            //    geodata[16] = "20.5092045, -103.818562"; geodata[17] = "20.5086066, -103.8185821"; geodata[18] = "20.508589, -103.8168105"; geodata[19] = "20.5091618, -103.8172115";
                            //    geodata[20] = "20.5085801, -103.8185818"; geodata[21] = "20.5079997, -103.8186087"; geodata[22] = "20.5079872, -103.8163435"; geodata[23] = "20.5085512, -103.8167861";
                            //    geodata[24] = "20.5079734, -103.818606"; geodata[25] = "20.5073893, -103.818606"; geodata[26] = "20.5073566, -103.8158527"; geodata[27] = "20.507947, -103.8163274";
                            //    geodata[28] = "20.5073562, -103.8186101"; geodata[29] = "20.5067709, -103.8186101"; geodata[30] = "20.5067269, -103.8153727"; geodata[31] = "20.5073097, -103.8156959";
                            //    geodata[32] = "20.506747, -103.8186115"; geodata[33] = "20.5061604, -103.8186141"; geodata[34] = "20.5061026, -103.8149556"; geodata[35] = "20.5067055, -103.8153714";
                            //    geodata[36] = "20.5061368, -103.8186194"; geodata[37] = "20.5055376, -103.8186288"; geodata[38] = "20.5055162, -103.8161691"; geodata[39] = "20.5061041, -103.8161625";
                            //    geodata[40] = "20.506099, -103.8160259"; geodata[41] = "20.5055112, -103.8160406"; geodata[42] = "20.5055062, -103.8145586"; geodata[43] = "20.5060853, -103.814973";
                            //    geodata[44] = "20.5055041, -103.8186186"; geodata[45] = "20.5049213, -103.8186253"; geodata[46] = "20.5049263, -103.8161764"; geodata[47] = "20.5054803, -103.816171";
                            //    geodata[48] = "20.5054871, -103.8160459"; geodata[49] = "20.5049168, -103.8160499"; geodata[50] = "20.5048704, -103.8141053"; geodata[51] = "20.5054808, -103.8145546";
                            //    geodata[52] = "20.5048918, -103.8186234"; geodata[53] = "20.5043027, -103.8186355"; geodata[54] = "20.5042913, -103.8161907"; geodata[55] = "20.5048805, -103.8161786";
                            //    geodata[56] = "20.5048742, -103.816047"; geodata[57] = "20.5043077, -103.8160564"; geodata[58] = "20.5042688, -103.8140635"; geodata[59] = "20.5048453, -103.8140487";
                            //    geodata[60] = "20.5042831, -103.8186357"; geodata[61] = "20.503699, -103.8186344"; geodata[62] = "20.5036714, -103.8161975"; geodata[63] = "20.5042593, -103.8161922";
                            //    geodata[64] = "20.5042713, -103.8160592"; geodata[65] = "20.5036822, -103.8160713"; geodata[66] = "20.5036696, -103.8154114"; geodata[67] = "20.5042537, -103.8154061";
                            //    geodata[68] = "20.5036721, -103.8186394"; geodata[69] = "20.5030792, -103.8186568"; geodata[70] = "20.503054, -103.8162147"; geodata[71] = "20.5036532, -103.8162012";
                            //    geodata[72] = "20.5036049, -103.8160718"; geodata[73] = "20.5030635, -103.8160811"; geodata[74] = "20.5030534, -103.8148755"; geodata[75] = "20.5035948, -103.8148674";
                            //    geodata[76] = "20.5035493, -103.8148493"; geodata[77] = "20.5030569, -103.8148586"; geodata[78] = "20.5030518, -103.8136772"; geodata[79] = "20.5035443, -103.8136705";
                            //    geodata[80] = "20.5035418, -103.8136584"; geodata[81] = "20.5030469, -103.8136611"; geodata[82] = "20.5030343, -103.8129234"; geodata[83] = "20.5035317, -103.8132346";
                            //    geodata[84] = "20.5030383, -103.8186566"; geodata[85] = "20.5024504, -103.818662"; geodata[86] = "20.5024466, -103.8162266"; geodata[87] = "20.5030282, -103.8162172";
                            //    geodata[88] = "20.5030145, -103.8160829"; geodata[89] = "20.5024492, -103.8160896"; geodata[90] = "20.5024454, -103.8148733"; geodata[91] = "20.5030132, -103.8148759";
                            //    geodata[92] = "20.5030094, -103.8148612"; geodata[93] = "20.5024505, -103.8148598"; geodata[94] = "20.5024002, -103.8123694"; geodata[95] = "20.5030007, -103.8128469";
                            //    geodata[96] = "20.5024242, -103.8186626"; geodata[97] = "20.5018539, -103.8186693"; geodata[98] = "20.5018263, -103.8162405"; geodata[99] = "20.5024167, -103.8162285";
                            //    geodata[100] = "20.5024034, -103.8161031"; geodata[101] = "20.5018381, -103.8161138"; geodata[102] = "20.5018368, -103.8148907"; geodata[103] = "20.5024134, -103.81488";
                            //    geodata[104] = "20.5024122, -103.8148666"; geodata[105] = "20.5018318, -103.814876"; geodata[106] = "20.5017765, -103.8120328"; geodata[107] = "20.502377, -103.8124271";
                            //    geodata[108] = "20.5018203, -103.8186767"; geodata[109] = "20.5012537, -103.8186794"; geodata[110] = "20.5012072, -103.8162265"; geodata[111] = "20.5018014, -103.8162185";
                            //    geodata[112] = "20.501791, -103.8161141"; geodata[113] = "20.5012044, -103.8161262"; geodata[114] = "20.5011969, -103.8149084"; geodata[115] = "20.5017998, -103.8148964";
                            //    geodata[116] = "20.5017986, -103.8148856"; geodata[117] = "20.5011969, -103.814895"; geodata[118] = "20.5010549, -103.8114444"; geodata[119] = "20.5017483, -103.8120197";
                            //    geodata[120] = "20.5012191, -103.818676"; geodata[121] = "20.5003197, -103.8186854"; geodata[122] = "20.5005785, -103.8162365"; geodata[123] = "20.5011852, -103.8162285";
                            //    geodata[124] = "20.5011825, -103.8161289"; geodata[125] = "20.5006411, -103.8161343"; geodata[126] = "20.5007842, -103.8149139"; geodata[127] = "20.5011762, -103.8149058";
                            //    geodata[128] = "20.50118, -103.8148897"; geodata[129] = "20.5007868, -103.8148978"; geodata[130] = "20.5010682, -103.8125495"; geodata[131] = "20.5010958, -103.8125522";
                            //    geodata[132] = "20.5039331, -103.813135"; geodata[133] = "20.5036354, -103.8128655"; geodata[134] = "20.5036316, -103.8105092"; geodata[135] = "20.5039934, -103.8105091";
                            //    geodata[136] = "20.5040009, -103.8104613"; geodata[137] = "20.5036241, -103.8104667"; geodata[138] = "20.5035927, -103.8083652"; geodata[139] = "20.5040449, -103.8080956";
                            //    geodata[140] = "20.5035915, -103.8128528"; geodata[141] = "20.5030188, -103.8124196"; geodata[142] = "20.5030187, -103.8105246"; geodata[143] = "20.5035815, -103.8105219";
                            //    geodata[144] = "20.5035827, -103.8104615"; geodata[145] = "20.5030099, -103.8104708"; geodata[146] = "20.5029772, -103.8087006"; geodata[147] = "20.5035325, -103.8084082";
                            //    geodata[148] = "20.5029656, -103.8123842"; geodata[149] = "20.5023903, -103.8119846"; geodata[150] = "20.5023865, -103.8105389"; geodata[151] = "20.5029606, -103.8105335";
                            //    geodata[152] = "20.502963, -103.8104692"; geodata[153] = "20.5023851, -103.8104866"; geodata[154] = "20.5023713, -103.8090436"; geodata[155] = "20.5029316, -103.8087137";
                            //    geodata[156] = "20.5023386, -103.8119524"; geodata[157] = "20.5017795, -103.8115299"; geodata[158] = "20.5017733, -103.8105455"; geodata[159] = "20.502331, -103.8105442";
                            //    geodata[160] = "20.5023307, -103.810477"; geodata[161] = "20.5017755, -103.8104864"; geodata[162] = "20.5017403, -103.8093545"; geodata[163] = "20.5023157, -103.8090742";
                            //    geodata[164] = "20.5017273, -103.8114965"; geodata[165] = "20.5011645, -103.811078"; geodata[166] = "20.5011608, -103.8105577"; geodata[167] = "20.5017286, -103.8105523";
                            //    geodata[168] = "20.5017185, -103.8104839"; geodata[169] = "20.5011645, -103.8104853"; geodata[170] = "20.501157, -103.8096886"; geodata[171] = "20.5016846, -103.8093882";

                            //    Sectors = await App.LocalDB.ConsultaSectoresLocal(Campo);

                            //    for (int j = 0; j < Sectors.Count; j++)
                            //    {
                            //      auxTables = await App.LocalDB.BuscaTablasLocal(Campo, Sectors[j].c_codigo_lot.ToString().Trim());
                            //      for (int k = 0; k < auxTables.Count; k++)
                            //      {
                            //        Tables.Add(auxTables[k]);
                            //      }
                            //    }

                            //    if (geodata.Length != -1 && geodata.Length != 0)
                            //    {
                            //      for (int l = 0; l < geodata.Length; l++)
                            //      {
                            //          string[] temp = geodata[l].Split(',');
                            //          coordinates[2 * auxCont] = temp[0].Trim();
                            //          coordinates[2 * auxCont + 1] = temp[1].Trim();
                            //          if (auxCont == 3)
                            //          {

                            //              await App.LocalDB.SaveData(new Mgeodata
                            //              {
                            //                  controlLog = auxCont2,
                            //                  Campo = Campo,
                            //                  Sector = Tables[auxCont2].c_codigo_lot.ToString().Trim(),
                            //                  Tabla = Tables[auxCont2].c_codigo_tab.ToString().Trim(),
                            //                  lat1 = coordinates[0],
                            //                  lon1 = coordinates[1],
                            //                  lat2 = coordinates[2],
                            //                  lon2 = coordinates[3],
                            //                  lat3 = coordinates[4],
                            //                  lon3 = coordinates[5],
                            //                  lat4 = coordinates[6],
                            //                  lon4 = coordinates[7],
                            //                  acumuladoPlaga = ""
                            //              });
                            //              auxCont = 0;
                            //              auxCont2++;
                            //          }
                            //          else
                            //          {
                            //              auxCont++;
                            //          }
                            //      }
                            //    }
                            //    else { }
                            //    break;

                            //case 0043: //El Mezquital Zarzamora (Lagos de Moreno)
                            //    break;

                            //case 0044: //Mochicahui Arándano (Sinaloa)
                            //    break;

                            //case 0045: //El Fuerte Arándano (Tehueco Sinaloa)
                            //    break;

                            //case 0048: //Los Venados (Lagos de Moreno)
                            //    break;

                            //case 0049: //El anima (Sayula)
                            //    break;

                            //case 0051: //Chilares (Sayula)
                            //    break;
                    }
                }
                respuesta = "1";
            }
            catch (Exception)
            {
                respuesta = "0";
            }
            return respuesta;
        }
    }
}
