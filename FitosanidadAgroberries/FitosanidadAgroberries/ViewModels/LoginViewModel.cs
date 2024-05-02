using FitosanidadAgroberries.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region VARIABLES
        string _V_usuario;
        string _V_contrasenia;
        string _ButtonText;
        bool _IndicatorVisibility;
        bool _LoginButtonEnabled;
        bool _IsUserRemembered;
        string _IsChecked;
        public Command LoginCommand { get; }
        #endregion
        #region CONSTRUCTOR
        public LoginViewModel()
        {
            if (SecureStorage.GetAsync("Username").Result != null && SecureStorage.GetAsync("Password").Result != null)
            {
                IsChecked = "True";
                V_usuario = SecureStorage.GetAsync("Username").Result;
                V_contrasenia = SecureStorage.GetAsync("Password").Result;
            }
            else
            {
                if (SecureStorage.GetAsync("Username").Result != null && SecureStorage.GetAsync("Password").Result != null)
                {
                    SecureStorage.Remove("Username");
                    SecureStorage.Remove("Password");
                }
                IsChecked = "False";
            }

            ButtonText = "Ingresar";
        }
        #endregion
        #region OBJETOS
        public string V_usuario
        {
            get { return _V_usuario; }
            set { SetValue(ref _V_usuario, value); }
        }

        public string V_contrasenia
        {
            get { return _V_contrasenia; }
            set { SetValue(ref _V_contrasenia, value); }
        }

        public string ButtonText
        {
            get { return _ButtonText; }
            set { SetValue(ref _ButtonText, value); }
        }

        public bool IndicatorVisibility
        {
            get { return _IndicatorVisibility; }
            set { SetValue(ref _IndicatorVisibility, value); }
        }

        public bool LoginButtonEnabled
        {
            get { return _LoginButtonEnabled; }
            set { SetValue(ref _LoginButtonEnabled, value); }
        }

        public bool IsUserRemembered
        {
            get { return _IsUserRemembered; }
            set { SetValue(ref _IsUserRemembered, value); }
        }

        public string IsChecked
        {
            get { return _IsChecked; }
            set { SetValue(ref _IsChecked, value); }
        }
        #endregion
        #region PROCESOS
        public async Task NavegarMainPage()
        {
            LoginButtonEnabled = false;
            IndicatorVisibility = true;
            var funcion = new Dlogin();
            try
            {
                if (V_usuario == "" || V_usuario == null || V_contrasenia == "" || V_contrasenia == null)
                {
                    LoginButtonEnabled = true;
                    IndicatorVisibility = false;
                    await DisplayAlert("Atencion", "El usuario o la contraseña estan vacios, vuelve a intentarlo.", "Ok");
                }
                else
                {
                    if (IsChecked.Equals("True"))
                    {
                        await SecureStorage.SetAsync("Username", V_usuario);
                        await SecureStorage.SetAsync("Password", V_contrasenia);
                    }
                    else
                    {
                        if (SecureStorage.GetAsync("Username").Result != null && SecureStorage.GetAsync("Password").Result != null)
                        {
                            SecureStorage.Remove("Username");
                            SecureStorage.Remove("Password");
                        }
                        IsChecked = "False";
                    }

                    string respuesta = await funcion.LoginUsuarioAppAsync(V_usuario.ToUpper().Trim(), V_contrasenia);
                    if (respuesta.Equals("1"))
                    {
                        V_usuario = "";
                        V_contrasenia = "";
                        App.Current.MainPage = new AppShell();
                        LoginButtonEnabled = true;
                        IndicatorVisibility = false;
                    }
                    else
                    {
                        LoginButtonEnabled = true;
                        IndicatorVisibility = false;
                        await DisplayAlert("Error", "El usuario o la contraseña son incorrectos o no has sincronizado los catalogos de tu equipo, vuelve a intentarlo", "Ok");
                    }
                }
            }
            catch (Exception Ex)
            {
                LoginButtonEnabled = true;
                IndicatorVisibility = false;
                await DisplayAlert("Alerta!", "Revisa tu conexion a internet y vuelve a intentarlo por favor!" + Ex.ToString(), "Ok");
            }
        }
        #endregion
        #region COMANDOS
        public ICommand NavegarMainPageAsynccommand => new Command(async () => await NavegarMainPage());
        #endregion
    }
}
