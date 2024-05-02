using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Acerca De...";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://administra-expoberries.com.mx/SAE_WEB/PoliticaDePrivacidad.php"));
        }

        public ICommand OpenWebCommand { get; }
    }
}