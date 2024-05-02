using FitosanidadAgroberries.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuestraDatosListaItem : ContentPage
    {
        public MuestraDatosListaItem()
        {
            InitializeComponent();
            BindingContext = new MuestraDatosListaItemViewModel();
        }
    }
}