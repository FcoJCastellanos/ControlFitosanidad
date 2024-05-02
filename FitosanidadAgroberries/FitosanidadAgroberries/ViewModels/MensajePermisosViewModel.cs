using FitosanidadAgroberries.Data;
using FitosanidadAgroberries.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class MensajePermisosViewModel : BaseViewModel
    {
        #region VARIABLES
        bool _IndicatorVisibility;
        bool _EnteradoButtonEnabled;
        #endregion
        #region CONSTRUCTOR
        public MensajePermisosViewModel()
        {
            EnteradoCommand = new Command(MuestraPermisos);
        }
        #endregion
        #region OBJETOS
        public bool IndicatorVisibility
        {
            get { return _IndicatorVisibility; }
            set { SetValue(ref _IndicatorVisibility, value); }
        }

        public bool EnteradoButtonEnabled
        {
            get { return _EnteradoButtonEnabled; }
            set { SetValue(ref _EnteradoButtonEnabled, value); }
        }
        #endregion
        #region PROCESOS
        public void SigueHiperLink()
        {
            Launcher.OpenAsync(new Uri("http://administra-expoberries.com.mx/SAE_WEB/PoliticaDePrivacidad.php"));
        }

        public async void MuestraPermisos()
        {
            EnteradoButtonEnabled = false;
            try
            {
                var permissionsLocation = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
                var permissionsCamera = await Permissions.CheckStatusAsync<Permissions.Camera>();

                if (permissionsLocation != PermissionStatus.Granted || permissionsCamera != PermissionStatus.Granted)
                {
                    permissionsLocation = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
                    permissionsCamera = await Permissions.RequestAsync<Permissions.Camera>();

                    EnteradoButtonEnabled = false;
                    IndicatorVisibility = true;
                    var SincronizaSoloUnaVez = new Dsincronizacatalogos();
                    await SincronizaSoloUnaVez.DatosLoginUsuarioLocal();
                    await SincronizaSoloUnaVez.CamposLocal();
                    await SincronizaSoloUnaVez.SectoresLocal();
                    await SincronizaSoloUnaVez.SemanasLocal();
                    await SincronizaSoloUnaVez.Tablas();
                    await SincronizaSoloUnaVez.Tuneles();
                    await SincronizaSoloUnaVez.TablaTunel();
                    await SincronizaSoloUnaVez.Plagas();
                    await SincronizaSoloUnaVez.UmbralesFitosanidadLocal();
                    await SincronizaSoloUnaVez.PinsMapa();
                    await SincronizaSoloUnaVez.CreaMapasPolygonos();
                    EnteradoButtonEnabled = true;
                    IndicatorVisibility = false;
                    App.Current.MainPage = new LoginPage();
                }
                else
                {
                    EnteradoButtonEnabled = false;
                    IndicatorVisibility = true;
                    var SincronizaSoloUnaVez = new Dsincronizacatalogos();
                    await SincronizaSoloUnaVez.DatosLoginUsuarioLocal();
                    await SincronizaSoloUnaVez.CamposLocal();
                    await SincronizaSoloUnaVez.SectoresLocal();
                    await SincronizaSoloUnaVez.SemanasLocal();
                    await SincronizaSoloUnaVez.Tablas();
                    await SincronizaSoloUnaVez.Tuneles();
                    await SincronizaSoloUnaVez.TablaTunel();
                    await SincronizaSoloUnaVez.Plagas();
                    await SincronizaSoloUnaVez.UmbralesFitosanidadLocal();
                    await SincronizaSoloUnaVez.PinsMapa();
                    await SincronizaSoloUnaVez.CreaMapasPolygonos();
                    EnteradoButtonEnabled = true;
                    IndicatorVisibility = false;
                    App.Current.MainPage = new LoginPage();
                }
            }
            catch (Exception Ex)
            {
                EnteradoButtonEnabled = true;
                await DisplayAlert("ALerta!", Ex.ToString(), "Ok");
            }
        }
        #endregion
        #region COMANDOS
        public ICommand ClickCommand => new Command(SigueHiperLink);
        public Command EnteradoCommand { get; }
        #endregion
    }
}
