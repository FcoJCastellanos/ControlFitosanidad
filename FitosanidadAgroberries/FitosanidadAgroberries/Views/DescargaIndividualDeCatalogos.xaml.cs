using FitosanidadAgroberries.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescargaIndividualDeCatalogos : ContentPage
    {
        public DescargaIndividualDeCatalogos()
        {
            InitializeComponent();
            BindingContext = new DescargaIndividualDeCatalogosViewModel();
        }
    }
}