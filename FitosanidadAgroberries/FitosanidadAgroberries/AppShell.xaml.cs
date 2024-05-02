using FitosanidadAgroberries.ViewModels;
using FitosanidadAgroberries.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FitosanidadAgroberries
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ControlFitosanidad), typeof(ControlFitosanidad));
            Routing.RegisterRoute(nameof(ControlSincronizacion), typeof(ControlSincronizacion));
            Routing.RegisterRoute(nameof(RegistroFitosanidad), typeof(RegistroFitosanidad));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
