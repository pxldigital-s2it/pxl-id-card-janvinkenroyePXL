using System;
using System.Globalization;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Converters
{
    public class IsBlancoToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return "Blanco";
            }
            else
            {
                return "Kopij ingeleverd";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Blanco";
        }
    }
}
