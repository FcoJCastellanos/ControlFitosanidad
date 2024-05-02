using FitosanidadAgroberries.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescargaDatos : ContentPage
    {
        public DescargaDatos()
        {
            InitializeComponent();
            BindingContext = new DescargaDatosViewModel();
        }
    }
}