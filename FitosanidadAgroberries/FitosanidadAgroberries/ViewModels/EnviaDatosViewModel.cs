using FitosanidadAgroberries.Data;
using System;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class EnviaDatosViewModel : BaseViewModel
    {
        #region VARIABLES
        bool _IndicatorVisibility;
        bool _EnviaDatosButtonEnabled;
        #endregion
        #region CONSTRUCTOR
        public EnviaDatosViewModel()
        {
            Title = "Enviar Datos";
        }
        #endregion
        #region OBJETOS
        public bool IndicatorVisibility
        {
            get { return _IndicatorVisibility; }
            set { SetValue(ref _IndicatorVisibility, value); }
        }

        public bool EnviaDatosButtonEnabled
        {
            get { return _EnviaDatosButtonEnabled; }
            set { SetValue(ref _EnviaDatosButtonEnabled, value); }
        }
        #endregion
        #region PROCESOS
        public async void EnviaDatosAsyncrono()
        {
            int V_contCorrecto = 0;
            int V_contIncorrecto = 0;

            EnviaDatosButtonEnabled = false;
            IndicatorVisibility = true;
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                try
                {
                    var funcion = new Dfitosanidad();

                    string[] respuesta;
                    respuesta = new string[1];

                    respuesta[0] = await funcion.SincronizaDatosFitosanidadAsync();

                    for (int i = 0; i < respuesta.Length; i++)
                    {
                        if (respuesta[i].Equals("0"))
                        {
                            V_contIncorrecto++;
                        }
                        else if (respuesta[i].Equals("1"))
                        {
                            V_contCorrecto++;
                        }
                    }

                    EnviaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    if (V_contCorrecto == 1)
                    {
                        await DisplayAlert("Alerta", "Datos enviados con exito.", "Ok");
                    }
                    else if (V_contIncorrecto == 1)
                    {
                        await DisplayAlert("Alerta", "No se envio ningun dato, vuleve a intentarlo.", "Ok");
                    }
                    else if (respuesta[0].Equals("No hay nada que sincronizar."))
                    {
                        await DisplayAlert("Alerta", "No hay nada que enviar.", "Ok");
                    }
                    else if (Regex.IsMatch(respuesta[0], "\\bFallo\\b"))
                    {
                        await DisplayAlert("Alerta", "Hubo un problema con el envio de datos!", "Ok");
                    }
                    else
                    {
                        await DisplayAlert("Alerta", "FED1" + respuesta[0] + "\n\n" + "\n\n Tomar una captura o foto y enviarla a T.I.", "Ok");
                    }
                }
                catch (Exception Ex)
                {
                    EnviaDatosButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Alerta!", Ex.ToString(), "Ok");
                }
            }
            else
            {
                EnviaDatosButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta!", "No cuentas con conexion a internet, revisa tu conexion y vuelve a intentarlo por favor", "Ok");
            }
        }
        #endregion
        #region COMANDOS
        public ICommand EnviaDatosAsyncommand => new Command(EnviaDatosAsyncrono);
        #endregion
    }
}
