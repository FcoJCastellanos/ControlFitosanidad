using FitosanidadAgroberries.Data;
using FitosanidadAgroberries.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class RegistroFitosanidadViewModel : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        DateTime _FechaSeleccionada;
        string _CampoSeleccionado;
        public List<Mcampos> _ListaCampos;
        string _SectorSeleccionado;
        public List<Msector> _ListaSectores;
        string _TablaSeleccionada;
        public List<Mtablatunelfitosanidad> _ListaTablas;
        string _TunelSeleccionado;
        public List<Mtablatunelfitosanidad> _ListaTuneles;
        string _TablaTunelSeleccionado;
        public List<Mtablatunelfitosanidad> _ListaTablaTunel;
        string _PlagaSeleccionada;
        public List<Mplagas> _ListaPlagas;
        string _Cantidad;
        string _TemperaturaMaxima;
        string _TemperaturaMinima;
        string _TemperaturaPromedio;
        string _HumedadMaxima;
        string _HumedadMinima;
        string _HumedadPromedio;
        string _Precipitacion;
        string _Viento;
        string _Comentarios;
        bool _IndicatorVisibility;
        bool _GuardaDatosButtonEnabled;
        CancellationTokenSource cts;
        #endregion
        #region CONSTRUCTOR
        public RegistroFitosanidadViewModel()
        {
            CargaDatosAsync();
            Title = "Registro Fitosanidad";
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public DateTime FechaSeleccionada
        {
            get { return _FechaSeleccionada; }
            set { _FechaSeleccionada = value; RaisePropertyChanged("FechaSeleccionada"); }
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
        public string SectorSeleccionado
        {
            get { return _SectorSeleccionado; }
            set { _SectorSeleccionado = value; OnPropertyChanged(); }
        }
        public List<Msector> ListaSectores
        {
            get { return _ListaSectores; }
            set { SetValue(ref _ListaSectores, value); }
        }

        public string TablaSeleccionada
        {
            get { return _TablaSeleccionada; }
            set { _TablaSeleccionada = value; OnPropertyChanged(); }
        }

        public List<Mtablatunelfitosanidad> ListaTablas
        {
            get { return _ListaTablas; }
            set { SetValue(ref _ListaTablas, value); ; }
        }

        public string TunelSeleccionado
        {
            get { return _TunelSeleccionado; }
            set { _TunelSeleccionado = value; OnPropertyChanged(); }
        }

        public List<Mtablatunelfitosanidad> ListaTuneles
        {
            get { return _ListaTuneles; }
            set { SetValue(ref _ListaTuneles, value); }
        }

        public string TablaTunelSeleccionado
        {
            get { return _TablaTunelSeleccionado; }
            set { _TablaTunelSeleccionado = value; OnPropertyChanged(); }
        }
        public List<Mtablatunelfitosanidad> ListaTablaTunel
        {
            get { return _ListaTablaTunel; }
            set { SetValue(ref _ListaTablaTunel, value); }
        }

        public string PlagaSeleccionada
        {
            get { return _PlagaSeleccionada; }
            set { _PlagaSeleccionada = value; OnPropertyChanged(); }
        }

        public List<Mplagas> ListaPlagas
        {
            get { return _ListaPlagas; }
            set { SetValue(ref _ListaPlagas, value); }
        }

        public string Cantidad
        {
            get { return _Cantidad; }
            set { SetValue(ref _Cantidad, value); }
        }

        public string TemperaturaMaxima
        {
            get { return _TemperaturaMaxima; }
            set { SetValue(ref _TemperaturaMaxima, value); }
        }
        public string TemperaturaMinima
        {
            get { return _TemperaturaMinima; }
            set { SetValue(ref _TemperaturaMinima, value); }
        }
        public string TemperaturaPromedio
        {
            get { return _TemperaturaPromedio; }
            set { SetValue(ref _TemperaturaPromedio, value); }
        }
        public string HumedadMaxima
        {
            get { return _HumedadMaxima; }
            set { SetValue(ref _HumedadMaxima, value); }
        }
        public string HumedadMinima
        {
            get { return _HumedadMinima; }
            set { SetValue(ref _HumedadMinima, value); }
        }
        public string HumedadPromedio
        {
            get { return _HumedadPromedio; }
            set { SetValue(ref _HumedadPromedio, value); }
        }
        public string Precipitacion
        {
            get { return _Precipitacion; }
            set { SetValue(ref _Precipitacion, value); }
        }
        public string Viento
        {
            get { return _Viento; }
            set { SetValue(ref _Viento, value); }
        }

        public string Comentarios
        {
            get { return _Comentarios; }
            set { SetValue(ref _Comentarios, value); }
        }

        public bool IndicatorVisibility
        {
            get { return _IndicatorVisibility; }
            set { SetValue(ref _IndicatorVisibility, value); }
        }

        public bool GuardaDatosButtonEnabled
        {
            get { return _GuardaDatosButtonEnabled; }
            set { SetValue(ref _GuardaDatosButtonEnabled, value); }
        }
        #endregion
        #region PROCESOS
        public async void CargaDatosAsync()
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

        public void llenaComboSectoresAsync()
        {
            string CampoSel = "";
            if (CampoSeleccionado != "" && CampoSeleccionado != "-1")
            {
                CampoSel = ListaCampos[Convert.ToInt16(CampoSeleccionado)].codigoCampo.ToString().Trim();
                try
                {
                    ListaSectores = null;
                    ListaTablas = null;
                    ListaTuneles = null;
                    ListaPlagas = null;
                    ListaSectores = App.LocalDB.ConsultaSectoresLocal(CampoSel).Result;
                }
                catch (Exception) { }
            }
        }

        public void llenaComboTablasAsync()
        {
            string CampoSel = "";
            string SectorSel = "";

            if (SectorSeleccionado != "" && SectorSeleccionado != "-1")
            {
                CampoSel = ListaCampos[Convert.ToInt16(CampoSeleccionado)].codigoCampo.ToString().Trim();
                SectorSel = ListaSectores[Convert.ToInt16(SectorSeleccionado)].c_codigo_lot.ToString().Trim();
                try
                {
                    ListaTablas = null;
                    ListaTuneles = null;
                    ListaPlagas = null;
                    ListaTablas = App.LocalDB.BuscaTablasLocal(CampoSel, SectorSel).Result;
                }
                catch (Exception) { }
            }
        }

        public void llenaComboTunelesAsync()
        {
            string CampoSel = "";
            string SectorSel = "";
            string TablaSel = "";

            if (TablaSeleccionada != "" && TablaSeleccionada != "-1")
            {
                CampoSel = ListaCampos[Convert.ToInt16(CampoSeleccionado)].codigoCampo.ToString().Trim();
                SectorSel = ListaSectores[Convert.ToInt16(SectorSeleccionado)].c_codigo_lot.ToString().Trim();
                TablaSel = ListaTablas[Convert.ToInt16(TablaSeleccionada)].c_codigo_tab.ToString().Trim();
                try
                {
                    ListaTuneles = null;
                    ListaPlagas = null;
                    ListaTuneles = App.LocalDB.BuscaTunelesLocal(CampoSel, SectorSel, TablaSel).Result;
                }
                catch (Exception) { }
            }
        }

        public void llenaComboPlagasAsync()
        {
            if (TablaSeleccionada != "" && TablaSeleccionada != "-1")
            {
                try
                {
                    ListaPlagas = null;
                    ListaPlagas = App.LocalDB.ConsultaPlagasLocal().Result;
                }
                catch (Exception) { }
            }
        }

        public async Task GuardaDatos()
        {
            GuardaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string ResultadoGuardado = "";
            //string usuarioLoggeado = ((App)App.Current).VG_usuario.ToString().ToUpper().Trim();
            string usuarioLoggeado = "FITOSDANIDAD";
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location != null)
                {
                    var funcion = new Dfitosanidad();
                    if (string.IsNullOrEmpty(Comentarios)) { Comentarios = ""; }
                    if (string.IsNullOrEmpty(location.Longitude.ToString()) && string.IsNullOrEmpty(location.Latitude.ToString()))
                    {
                        location.Longitude = 19.60373784335319;
                        location.Latitude = -102.47764694036618;
                        location.Altitude = 1324.98374672382736;
                    }

                    if (string.IsNullOrEmpty(Cantidad) || string.IsNullOrEmpty(TemperaturaMaxima) || string.IsNullOrEmpty(TemperaturaMinima) || string.IsNullOrEmpty(TemperaturaPromedio) ||
                        string.IsNullOrEmpty(HumedadMaxima) || string.IsNullOrEmpty(HumedadMinima) || string.IsNullOrEmpty(HumedadPromedio) ||
                        string.IsNullOrEmpty(Precipitacion) || string.IsNullOrEmpty(Viento) || string.IsNullOrEmpty(usuarioLoggeado) || usuarioLoggeado == "")
                    {
                        GuardaDatosButtonEnabled = true;
                        IndicatorVisibility = false;
                        await DisplayAlert("Alerta", "Alguno de los campos se encuentra vacio, revisa los campos y vuelve a intentarlo.", "Ok");
                    }
                    else
                    {
                        DateTime inputDate = DateTime.Now;
                        CultureInfo currentCulture = new CultureInfo("es-MX");
                        var Semana = currentCulture.Calendar.GetWeekOfYear(
                        inputDate,
                        CalendarWeekRule.FirstDay,
                        DayOfWeek.Sunday);

                        ListaTablaTunel = await App.LocalDB.ConsultaTablasTunelesLocal(ListaCampos[Convert.ToInt16(CampoSeleccionado)].codigoCampo.ToString(), ListaSectores[Convert.ToInt16(SectorSeleccionado)].c_codigo_lot.ToString(), ListaTablas[Convert.ToInt16(TablaSeleccionada)].c_codigo_tab.ToString(), ListaTuneles[Convert.ToInt16(TunelSeleccionado)].c_codigo_tun.ToString());
                        string TablaTunel = ListaTablaTunel[Convert.ToInt16(TablaTunelSeleccionado)].c_codigo_ttu.ToString();
                        if (TablaTunel != "")
                        {
                            List<Mz_regfitosanidad> datosLocalesConsultados;
                            datosLocalesConsultados = await App.LocalDB.BuscaRegistroFitosanidad(FechaSeleccionada.ToString("dd/MM/yyyy HH:mm:ss"), TablaTunel.Trim(), Semana.ToString().Trim(), ListaPlagas[Convert.ToInt16(PlagaSeleccionada)].c_codigo_pla.ToString(), Cantidad.Trim(), usuarioLoggeado);
                            if (datosLocalesConsultados.Count > 0)
                            {
                                var response = await DisplayAlert("Alerta", "Los datos ya han sido registrados, esta seguro de volver a guardar este registro?", "Si", "No");
                                if (response == true)
                                {
                                    ResultadoGuardado = await funcion.GuardaDatosFitosanidadLocalAsync(FechaSeleccionada.ToString("dd/MM/yyyy HH:mm:ss").Trim(), TablaTunel.Trim(), Semana.ToString().Trim(), ListaPlagas[Convert.ToInt16(PlagaSeleccionada)].c_codigo_pla.ToString().Trim(), Cantidad.Trim(), TemperaturaMaxima.Trim(), TemperaturaMinima.Trim(), TemperaturaPromedio.Trim(), HumedadMaxima.Trim(), HumedadMinima.Trim(), HumedadPromedio.Trim(), Precipitacion.Trim(), Viento.Trim(), Comentarios.Trim(), location.Longitude.ToString().Trim(), location.Latitude.ToString().Trim(), location.Altitude.ToString().Trim(), usuarioLoggeado.Trim());
                                    await DisplayAlert("Alerta", ResultadoGuardado, "Ok");
                                    ListaCampos.DefaultIfEmpty();
                                    ListaSectores.DefaultIfEmpty();
                                    ListaTablas.DefaultIfEmpty();
                                    ListaTuneles.DefaultIfEmpty();
                                    ListaPlagas.DefaultIfEmpty();
                                    Cantidad = string.Empty;
                                    TemperaturaMaxima = string.Empty;
                                    TemperaturaMinima = string.Empty;
                                    TemperaturaPromedio = string.Empty;
                                    HumedadMaxima = string.Empty;
                                    HumedadMinima = string.Empty;
                                    HumedadPromedio = string.Empty;
                                    Precipitacion = string.Empty;
                                    Viento = string.Empty;
                                    Comentarios = string.Empty;
                                    GuardaDatosButtonEnabled = true;
                                    IndicatorVisibility = false;
                                }
                                else { }//Nothing
                            }
                            else
                            {
                                ResultadoGuardado = await funcion.GuardaDatosFitosanidadLocalAsync(FechaSeleccionada.ToString("dd/MM/yyyy HH:mm:ss").Trim(), TablaTunel.Trim(), Semana.ToString().Trim(), ListaPlagas[Convert.ToInt16(PlagaSeleccionada)].c_codigo_pla.ToString().Trim(), Cantidad.Trim(), TemperaturaMaxima.Trim(), TemperaturaMinima.Trim(), TemperaturaPromedio.Trim(), HumedadMaxima.Trim(), HumedadMinima.Trim(), HumedadPromedio.Trim(), Precipitacion.Trim(), Viento.Trim(), Comentarios.Trim(), location.Longitude.ToString().Trim(), location.Latitude.ToString().Trim(), location.Altitude.ToString().Trim(), usuarioLoggeado.Trim());
                                await DisplayAlert("Alerta", ResultadoGuardado, "Ok");
                                ListaCampos.DefaultIfEmpty();
                                ListaSectores.DefaultIfEmpty();
                                ListaTablas.DefaultIfEmpty();
                                ListaTuneles.DefaultIfEmpty();
                                ListaPlagas.DefaultIfEmpty();
                                Cantidad = string.Empty;
                                TemperaturaMaxima = string.Empty;
                                TemperaturaMinima = string.Empty;
                                TemperaturaPromedio = string.Empty;
                                HumedadMaxima = string.Empty;
                                HumedadMinima = string.Empty;
                                HumedadPromedio = string.Empty;
                                Precipitacion = string.Empty;
                                Viento = string.Empty;
                                Comentarios = string.Empty;
                                GuardaDatosButtonEnabled = true;
                                IndicatorVisibility = false;
                            }
                        }
                        else
                        {
                            GuardaDatosButtonEnabled = true;
                            IndicatorVisibility = false;
                            await DisplayAlert("Alerta!", "Puede que no exista el tunel en la tabla seleccionada.", "Ok");
                        }

                    }
                }
            }
            catch (FeatureNotSupportedException)
            {
                // Handle not supported on device exception
                GuardaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Caracteristica no soportada", "La opcion de ubicacion no esta sosportada en el dispositivo actual.", "Ok");
            }
            catch (FeatureNotEnabledException)
            {
                // Handle not enabled on device exception
                GuardaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Caracteristica no activada", "La ubicacion de su dispositivo esta desactivada. \n\n Es necesario que active la ubicacion de su dispositiov para poder continuar con el guardado de sus datos.", "Ok");
            }
            catch (PermissionException)
            {
                // Handle permission exception
                GuardaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Permisos no concedidos", "No se concedieron los permisos de ubicacion a la app. \n\n Para seguir utilizando la aplicacion deberas de activar los permisos de ubicacion.", "Ok");
            }
            catch (Exception ex)
            {
                // Unable to get location
                GuardaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Excepcion", "Es posible que alguno de los campos este vacio, por favor rellena los campos de manera correcta y vuelve a intentarlo." + ex.ToString(), "Ok");
            }
        }

        public async Task SincronizaDatos()
        {
            var funcion = new Dfitosanidad();
            await funcion.SincronizaDatosFitosanidadAsync();
        }
        #endregion
        #region COMANDOS

        public ICommand MuestraSectorescommand => new Command(llenaComboSectoresAsync);
        public ICommand MuestraTablascommand => new Command(llenaComboTablasAsync);
        public ICommand MuestraTunelescommand => new Command(llenaComboTunelesAsync);
        public ICommand MuestraPlagascommand => new Command(llenaComboPlagasAsync);
        public ICommand GuardaDatoscommand => new Command(async () => await GuardaDatos());
        public ICommand SincronizaDatoscommand => new Command(async () => await SincronizaDatos());
        #endregion
    }
}
