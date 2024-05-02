using FitosanidadAgroberries.Data;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class DescargaDatosViewModel : BaseViewModel
    {
        #region VARIABLES
        bool _IndicatorVisibility;
        bool _DescargaDatosButtonEnabled;
        #endregion
        #region CONSTRUCTOR
        public DescargaDatosViewModel()
        {
            Title = "Descarga Datos";
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
        public async Task SincronizaDatosAsyncronoAsync()
        {
            DescargaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            var funcion = new Dsincronizacatalogos();
            string[] respuesta;
            respuesta = new string[11];

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                respuesta[0] = await funcion.DatosLoginUsuarioLocal();
                respuesta[1] = await funcion.CamposLocal();
                respuesta[2] = await funcion.SectoresLocal();
                respuesta[3] = await funcion.SemanasLocal();
                respuesta[4] = await funcion.Tablas();
                respuesta[5] = await funcion.Tuneles();
                respuesta[6] = await funcion.TablaTunel();
                respuesta[7] = await funcion.Plagas();
                respuesta[9] = await funcion.UmbralesFitosanidadLocal();
                respuesta[10] = await funcion.PinsMapa();

                for (int i = 0; i < respuesta.Length; i++)
                {
                    if (respuesta[i].Equals("0"))
                    {
                        DescargaDatosButtonEnabled = true;
                        IndicatorVisibility = false;
                        await DisplayAlert("Alerta", "No todos los catalogos se sincronizaron con exito.", "Ok");
                        return;
                    }
                }
                DescargaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta", "Catalogos sincronizados con exito.", "Ok");
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
        public ICommand SincronizaDatosAsyncommand => new Command(async () => await SincronizaDatosAsyncronoAsync());
        #endregion
    }
}
