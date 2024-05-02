using FitosanidadAgroberries.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FitosanidadAgroberries.ViewModels
{
    public class MapaFitosanidadUbicacionExactaViewModel : BaseViewModel
    {
        #region VARIABLES
        string _CampoSeleccionado;
        public List<Mcampos> _ListaCampos;
        string _SemanaSeleccionada;
        public List<Msemanas> _ListaSemanas;
        string _PlagaSeleccionada;
        public List<Mplagas> _ListaPlagas;
        #endregion
        #region CONSTRUCTOR
        public MapaFitosanidadUbicacionExactaViewModel()
        {
            CargaDatosAsync();
            Title = "Mapa";
            //Control de voz
            //TextToSpeech.SpeakAsync("Selecciona tu rancho, por favor.");
        }
        #endregion
        #region OBJETOS
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
        public string SemanaSeleccionada
        {
            get { return _SemanaSeleccionada; }
            set { _SemanaSeleccionada = value; OnPropertyChanged(); }
        }

        public List<Msemanas> ListaSemanas
        {
            get { return _ListaSemanas; }
            set { SetValue(ref _ListaSemanas, value); }
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

        public void llenaComboSemanasAsync()
        {
            if (CampoSeleccionado != "" && CampoSeleccionado != "-1")
            {
                try
                {
                    ListaSemanas = null;
                    ListaPlagas = null;
                    ListaSemanas = App.LocalDB.ConsultaSemanasLocal().Result;
                }
                catch (Exception) { }
            }
        }

        public void llenaComboPlagasAsync()
        {
            if (SemanaSeleccionada != "" && SemanaSeleccionada != "-1")
            {
                try
                {
                    ListaPlagas = null;
                    ListaPlagas = App.LocalDB.ConsultaPlagasLocal().Result;
                }
                catch (Exception) { }
            }
        }
        #endregion
        #region COMANDOS
        public ICommand MuestraSemanascommand => new Command(llenaComboSemanasAsync);
        public ICommand MuestraPlagascommand => new Command(llenaComboPlagasAsync);
        #endregion
    }
}
