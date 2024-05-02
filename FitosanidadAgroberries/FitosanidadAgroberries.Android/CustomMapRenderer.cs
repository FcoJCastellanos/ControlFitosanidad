[assembly:Xamarin.Forms.ExportRenderer(typeof(FitosanidadAgroberries.Interface.CustomMap), typeof(FitosanidadAgroberries.Droid.CustomMapRenderer))]
namespace FitosanidadAgroberries.Droid
{
    using Android.Gms.Maps;
    using Android.Gms.Maps.Model;
    using Android.Graphics;
    using Android.Graphics.Drawables;
    using FitosanidadAgroberries.Interface;
    using System.ComponentModel;
    using System.Linq;
    using Xamarin.Forms.Maps;
    using Xamarin.Forms.Maps.Android;
    using Xamarin.Forms.Platform.Android;
    using Context = Android.Content.Context;

    public class CustomMapRenderer : MapRenderer
    {
        private CustomMap formsMap;
        private GoogleMap nativeMap;

        public CustomMapRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                this.formsMap = (CustomMap)e.NewElement;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            switch(e.PropertyName)
            {
                case nameof(CustomMap.IconProperty):
                case nameof(CustomMap.Icon):
                case nameof(CustomMap.Pins):
                    IconPropertyChanged();
                    break;
                default:
                    break;
            }
        }

        protected override void OnMapReady(GoogleMap map)
        {
            this.nativeMap = map;
            IconPropertyChanged();
        }

        private void IconPropertyChanged()
        {
            if (this.nativeMap == null)
                return;

            if (!formsMap.Pins?.Any() ?? true)
                return;

            MarkerOptions markerOption = new MarkerOptions();
            markerOption.SetPosition(new LatLng(formsMap[0].Position.Latitude, formsMap.Pins[0].Position.Longitude));
            markerOption.SetIcon(BitmapDescriptorFactory.FromBitmap(GetImageBitmap(this.formsMap.Icon)));
        }

        private Bitmap GetImageBitmap(string image)
        {
            //Bitmap bitMapImage = BitmapFactory.DecodeResource(this.Resources, Resource.Drawable.pin);

            //return bitMapImage;
            string imagefileName = "imgimge.png";
            // Remove the file extention from the image filename
            imagefileName = imagefileName.Replace(".jpg", "").Replace(".png", "");

            // Retrieving the local Resource ID from the name
            int id = (int)typeof(Resource.Drawable).GetField(imagefileName).GetValue(null);

            // Converting Drawable Resource to Bitmap
            var originalImage = BitmapFactory.DecodeResource(Context.Resources, id);
            return originalImage;
        }
    }
}