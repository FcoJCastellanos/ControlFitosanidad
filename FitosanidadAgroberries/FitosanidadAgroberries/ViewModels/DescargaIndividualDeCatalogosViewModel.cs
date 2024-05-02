using FitosanidadAgroberries.Data;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class DescargaIndividualDeCatalogosViewModel : BaseViewModel
    {
        #region VARIABLES
        bool _IndicatorVisibility;
        bool _DescargaDatosButtonEnabled;
        #endregion
        #region CONSTRUCTOR
        public DescargaIndividualDeCatalogosViewModel()
        {
            Title = "Descarga Individual De Catalogos";
        }
        #endregion
        #region OBJETOS
        public bool IndicatorVisibility
        {
            get { return _IndicatorVisibility; }
            set { SetValue(ref _IndicatorVisibility, value); }
        }

        public bool DescargaDatosButtonEnabled
        {
            get { return _DescargaDatosButtonEnabled; }
            set { SetValue(ref _DescargaDatosButtonEnabled, value); }
        }
        #endregion
        #region PROCESOS
        public async Task SincronizaDatosLoginUsuarioLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta="";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.DatosLoginUsuarioLocal();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar ninguno de tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaCamposLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.CamposLocal();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaSectoresLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.SectoresLocal();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaSemanasLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.SemanasLocal();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaTablasLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.Tablas();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaTunelesLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.Tuneles();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaTablaTunelLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.TablaTunel();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaPlagas()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.Plagas();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaUmbralesFitosanidadLocal()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.UmbralesFitosanidadLocal();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaPinsMapa()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.PinsMapa();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }

        public async Task SincronizaPoligonosMapa()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            string respuesta = "";
            var funcion = new Dsincronizacatalogos();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                respuesta = await funcion.CreaMapasPolygonos();

                if (respuesta.Equals("0"))
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta", "No se sincronizo el catalogo.", "Ok");
                }
                else
                {
                    DescargaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Correcto", "Se sincronizo el catalogo de manera correcta.", "Ok");
                }
            }
            else
            {
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "No puedes sincronizar tus catalogos sin conexion a internet, vuelve a intentarlo por favor", "Ok");
            }
        }
        #endregion
        #region COMANDOS
        public ICommand SincronizaDatosLoginAsyncommand => new Command(async () => await SincronizaDatosLoginUsuarioLocal());
        public ICommand SincronizaCamposAsyncommand => new Command(async () => await SincronizaCamposLocal());
        public ICommand SincronizaSectoresAsyncommand => new Command(async () => await SincronizaSectoresLocal());
        public ICommand SincronizaSemanasAsyncommand => new Command(async () => await SincronizaSemanasLocal());
        public ICommand SincronizaTablasAsyncommand => new Command(async () => await SincronizaTablasLocal());
        public ICommand SincronizaTunelesAsyncommand => new Command(async () => await SincronizaTunelesLocal());
        public ICommand SincronizaTablaTunelAsyncommand => new Command(async () => await SincronizaTablaTunelLocal());
        public ICommand SincronizaPlagasAsyncommand => new Command(async () => await SincronizaPlagas());
        public ICommand SincronizaUmbralesAsyncommand => new Command(async () => await SincronizaUmbralesFitosanidadLocal());
        //public ICommand SincronizaRegistrosAsyncommand => new Command(async () => await SincronizaRegistrosAsyncommand());
        public ICommand SincronizaPinsAsyncommand => new Command(async () => await SincronizaPinsMapa());
        public ICommand SincronizaPoligonosAsyncommand => new Command(async () => await SincronizaPoligonosMapa());
        #endregion
    }
}
