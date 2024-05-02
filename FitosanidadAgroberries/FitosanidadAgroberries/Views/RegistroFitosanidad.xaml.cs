using FitosanidadAgroberries.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroFitosanidad : ContentPage
    {
        public RegistroFitosanidad()
        {
            InitializeComponent();
            BindingContext = new RegistroFitosanidadViewModel();
            datePicker.Date = DateTime.Now;
        }

        private void TemperaturaMaxima_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal Max = 0;
            decimal Min = 0;
            decimal Prom = 0;

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMaxima))
            {
                Max = 0;
            }
            else
            {
                Max = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMaxima);
            }

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMinima))
            {
                Min = 0;
            }
            else
            {
                Min = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMinima);
            }

            Prom = Max + Min;
            Prom = Prom / 2;
            ((RegistroFitosanidadViewModel)BindingContext).TemperaturaPromedio = Prom.ToString();
        }

        private void TemperaturaMinima_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal Max =0;
            decimal Min =0;
            decimal Prom =0;

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMaxima))
            {
                Max = 0;
            }
            else
            {
                Max = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMaxima);
            }
            
            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMinima))
            {
                Min = 0;
            }
            else
            {
                Min = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).TemperaturaMinima);
            }
            
            Prom = Max + Min;
            Prom = Prom / 2;
            ((RegistroFitosanidadViewModel)BindingContext).TemperaturaPromedio = Prom.ToString();
        }

        private void HumedadMaxima_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal Max = 0;
            decimal Min = 0;
            decimal Prom = 0;

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).HumedadMaxima))
            {
                Max = 0;
            }
            else
            {
                Max = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).HumedadMaxima);
            }

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).HumedadMinima))
            {
                Min = 0;
            }
            else
            {
                Min = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).HumedadMinima);
            }

            Prom = Max + Min;
            Prom = Prom / 2;
            ((RegistroFitosanidadViewModel)BindingContext).HumedadPromedio = Prom.ToString();
        }

        private void HumedadMinima_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal Max = 0;
            decimal Min = 0;
            decimal Prom = 0;

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).HumedadMaxima))
            {
                Max = 0;
            }
            else
            {
                Max = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).HumedadMaxima);
            }

            if (string.IsNullOrEmpty(((RegistroFitosanidadViewModel)BindingContext).HumedadMinima))
            {
                Min = 0;
            }
            else
            {
                Min = Decimal.Parse(((RegistroFitosanidadViewModel)BindingContext).HumedadMinima);
            }

            Prom = Max + Min;
            Prom = Prom / 2;
            ((RegistroFitosanidadViewModel)BindingContext).HumedadPromedio = Prom.ToString();
        }
    }
}