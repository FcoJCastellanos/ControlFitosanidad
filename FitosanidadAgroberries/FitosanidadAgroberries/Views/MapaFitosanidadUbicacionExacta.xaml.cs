using FitosanidadAgroberries.Data;
using FitosanidadAgroberries.Models;
using FitosanidadAgroberries.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapaFitosanidadUbicacionExacta : ContentPage
    {
        public List<Mpinsmapas> _ListaDatosPins;
        public List<Mgeodata> _ListaGeodata;
        string _Umbral;
        string _UmbralesColocados;
        public List<Mfitosanidad> _UmbralesInfSup;
        Mcolorpolygono _ColorAsignado;
        public List<Mpinsmapas> ListaDatosPins
        {
            get { return _ListaDatosPins; }
            set { _ListaDatosPins = value; }
        }
        public List<Mgeodata> ListaGeodata
        {
            get { return _ListaGeodata; }
            set { _ListaGeodata = value; }
        }

        public string Umbral
        {
            get { return _Umbral; }
            set { _Umbral = value; }
        }
        public string UmbralesColocados
        {
            get { return _UmbralesColocados; }
            set { _UmbralesColocados = value; }
        }
        public List<Mfitosanidad> UmbralesInfSup
        {
            get { return _UmbralesInfSup; }
            set { _UmbralesInfSup = value; }
        }
        public Mcolorpolygono ColorAsignado
        {
            get { return _ColorAsignado; }
            set { _ColorAsignado = value; }
        }
        public MapaFitosanidadUbicacionExacta()
        {
            InitializeComponent();
            BindingContext = new MapaFitosanidadUbicacionExactaViewModel();
            var currentLocation = Geolocation.GetLastKnownLocationAsync().Result;
            if (currentLocation != null)
            {
                MiMapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentLocation.Latitude, currentLocation.Longitude), Distance.FromMiles(0.6)));
            }
        }

        public async void cargaVistaPins(string CampoSel, string SemanaSel, string PlagaSel)
        {
            MiMapa.Pins.Clear();
            MiMapa.MapElements.Clear();

            ListaDatosPins = await App.LocalDB.ConsultaPinsMapasLocal(CampoSel, SemanaSel.TrimStart(new Char[] { '0' }), PlagaSel);
            if (ListaDatosPins.Count != 0)
            {
                for (int i = 0; i < ListaDatosPins.Count; i++)
                {
                    var markerPosition = new Position(double.Parse(ListaDatosPins[i].c_latitud_fit), double.Parse(ListaDatosPins[i].c_longitud_fit)); // Cambia estas coordenadas según tus necesidades
                    Pin customPin = new Pin
                    {
                        Type = PinType.Place,
                        Position = markerPosition,
                        Label = ListaDatosPins[i].v_nombre_pla,
                        Address = "Poblacion:" + ListaDatosPins[i].n_poblacion_fit + " " + ListaDatosPins[i].v_nombre_lot + " Tabla:" + ListaDatosPins[i].c_codigo_tab + " Tunel:" + ListaDatosPins[i].c_codigo_tun,
                    };
                    MiMapa.Pins.Add(customPin);
                    MiMapa.Icon = ;
                }
                if (Device.RuntimePlatform == Device.Android)
                {
                    await Task.Delay(2000).ContinueWith(task => Device.BeginInvokeOnMainThread(() => MiMapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(double.Parse(ListaDatosPins[0].c_latitud_fit), double.Parse(ListaDatosPins[0].c_longitud_fit)), Distance.FromMiles(0.6)))));
                } else
                {
                    MiMapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(double.Parse(ListaDatosPins[0].c_latitud_fit), double.Parse(ListaDatosPins[0].c_longitud_fit)), Distance.FromMiles(0.6)));
                }
            }
            else
            {
                await DisplayAlert("Alerta", "No hay datos para mostrar en el mapa.", "Ok");
            }
        }

        public async void cargaVistaPolygons(string CampoSel, string SemanaSel, string PlagaSel)
        {
            try
            {
                double V_poblacion = 0;
                double capturasTotales = 0;
                string[] geodata = new string[0];
                string[] coordinates = new string[8];

                ListaGeodata = App.LocalDB.ConsultaGeoDataLocal().Result;
                ListaDatosPins = await App.LocalDB.ConsultaPinsMapasLocal(CampoSel, SemanaSel.TrimStart(new Char[] { '0' }), PlagaSel);

                if (ListaGeodata.Count != -1 && ListaGeodata.Count != 0)
                {
                    for (int g = 0; g < ListaGeodata.Count; g++)
                    {
                        for (int h = 0; h < ListaDatosPins.Count; h++)
                        {
                            if (ListaDatosPins[h].c_codigo_lot == ListaGeodata[g].Sector)
                            {
                                V_poblacion += Convert.ToDouble(ListaDatosPins[h].n_poblacion_fit.Trim());
                                capturasTotales++;
                            }
                        }

                        if (V_poblacion!=0)
                        {
                            ListaGeodata[g].acumuladoPlaga = ((V_poblacion/capturasTotales)/7).ToString().Trim();
                            V_poblacion = 0;
                            capturasTotales = 0;
                        }
                        else
                        {
                            ListaGeodata[g].acumuladoPlaga = "0.00";
                        }
                    }

                    for (int j = 0; j < ListaGeodata.Count; j++)
                    {
                        ColorAsignado = await colorAsync(Convert.ToDouble(ListaGeodata[j].acumuladoPlaga.ToString().Trim()), PlagaSel);

                        Polygon polygon = new Polygon
                        {
                            StrokeWidth = 5,
                            StrokeColor = Color.FromRgba(ColorAsignado.R, ColorAsignado.G, ColorAsignado.B,100),
                            FillColor = Color.FromRgba(ColorAsignado.R, ColorAsignado.G, ColorAsignado.B,70),
                            Geopath =
                                        {
                                            new Position(Convert.ToDouble(ListaGeodata[j].lat1), Convert.ToDouble(ListaGeodata[j].lon1)),
                                            new Position(Convert.ToDouble(ListaGeodata[j].lat2), Convert.ToDouble(ListaGeodata[j].lon2)),
                                            new Position(Convert.ToDouble(ListaGeodata[j].lat3), Convert.ToDouble(ListaGeodata[j].lon3)),
                                            new Position(Convert.ToDouble(ListaGeodata[j].lat4), Convert.ToDouble(ListaGeodata[j].lon4))
                                        }
                        };
                        MiMapa.MapElements.Add(polygon);
                    }
                }
                else
                {
                    await DisplayAlert("Alerta", "El mapa aun no cuenta con poligonos para mostrarse", "Ok");
                }
            }
            catch (Exception Ex)
            {
                await DisplayAlert("Alerta", "Tomar una captura y enviar al equipo de T.I.\n\n" + Ex.ToString(), "Ok");
            }
        }

        private void PlagasPckr_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (PlagasPckr.SelectedIndex.ToString() != "" && PlagasPckr.SelectedIndex.ToString() != "-1")
            {
                string SemanaSel = "";
                string PlagaSel = "";
                string CampoSel = "";

                CampoSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaCampos[Convert.ToInt16(CamposPckr.SelectedIndex.ToString())].codigoCampo.ToString().Trim();
                SemanaSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaSemanas[Convert.ToInt16(SemanasPckr.SelectedIndex.ToString())].c_codigo_sem.ToString().Trim();
                PlagaSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaPlagas[Convert.ToInt16(PlagasPckr.SelectedIndex.ToString())].c_codigo_pla.ToString().Trim();

                cargaVistaPins(CampoSel, SemanaSel, PlagaSel);
                //cargaVistaPolygons();   
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

            string SemanaSel = "";
            string PlagaSel = "";
            string CampoSel = "";

            CampoSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaCampos[Convert.ToInt16(CamposPckr.SelectedIndex.ToString())].codigoCampo.ToString().Trim();
            SemanaSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaSemanas[Convert.ToInt16(SemanasPckr.SelectedIndex.ToString())].c_codigo_sem.ToString().Trim();
            PlagaSel = ((MapaFitosanidadUbicacionExactaViewModel)BindingContext).ListaPlagas[Convert.ToInt16(PlagasPckr.SelectedIndex.ToString())].c_codigo_pla.ToString().Trim();

            if (PlagasPckr.SelectedIndex.ToString() != "" && PlagasPckr.SelectedIndex.ToString() != "-1")
            {
                if (MiMapa.Pins.Count != 0)
                {
                    MiMapa.Pins.Clear();
                    cargaVistaPolygons(CampoSel, SemanaSel, PlagaSel);
                }
                else if (MiMapa.MapElements.Count != 0)
                {
                    MiMapa.MapElements.Clear();
                    cargaVistaPins(CampoSel, SemanaSel, PlagaSel);
                }
                else
                {
                    DisplayAlert("Alerta", "No hay datos para mostrarse en el mapa, vuelve a intentarlo", "Ok");
                }
            }
            else
            {
                DisplayAlert("Alerta", "No has llenado los campos en la parte superior de la pantalla, vuelve a intentarlo", "Ok");
            }
        }

        public async Task<Mcolorpolygono> colorAsync(double V_calculoUmbral, string V_nombrePLaga)
        {
            Mcolorpolygono colorFinal = new Mcolorpolygono();
            var funcion = new Dfitosanidad();
            UmbralesInfSup = await funcion.VerificaUmbralesAsync(V_nombrePLaga);

            if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior0) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior0))
            {
                colorFinal.R = 0;
                colorFinal.G = 128;
                colorFinal.B = 0;
            }
            else if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior1) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior1))
            {
                colorFinal.R = 255;
                colorFinal.G = 255;
                colorFinal.B = 0;
            }
            else if (V_calculoUmbral > Convert.ToDouble(UmbralesInfSup[0].limiteInferior2) && V_calculoUmbral < Convert.ToDouble(UmbralesInfSup[0].limiteSuperior2))
            {
                colorFinal.R = 255;
                colorFinal.G = 0;
                colorFinal.B = 0;
            }
            else
            {
                colorFinal.R = 0;
                colorFinal.G = 0;
                colorFinal.B = 0;
            }
            return colorFinal;
        }
    }
}