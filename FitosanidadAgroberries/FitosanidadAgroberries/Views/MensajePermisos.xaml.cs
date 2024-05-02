using FitosanidadAgroberries.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitosanidadAgroberries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MensajePermisos : ContentPage
    {
        public MensajePermisos()
        {
            InitializeComponent();
            BindingContext = new MensajePermisosViewModel();
        }
    }
}