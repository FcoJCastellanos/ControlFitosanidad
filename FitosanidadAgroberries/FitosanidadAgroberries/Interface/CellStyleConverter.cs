using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FitosanidadAgroberries.Interface
{
    public class CellStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals("Red"))
            {
                return Color.Red;
            }
            else if (value.Equals("Yellow"))
            {
                return Color.Yellow;
            }
            else if (value.Equals("Green"))
            {
                return Color.Green;
            }
            return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
