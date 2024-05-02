namespace FitosanidadAgroberries.Interface
{
    using Xamarin.Forms;
    using Xamarin.Forms.Maps;

    public class CustomMap : Map
    {
        public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon),typeof(string),typeof(CustomMap),string.Empty,BindingMode.TwoWay);
        public string Icon
        { get { return GetValue(IconProperty).ToString(); }
          set { SetValue(IconProperty, value); }
        }
    }
}
