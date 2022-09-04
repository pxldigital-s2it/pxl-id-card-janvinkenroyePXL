using System;
using System.Globalization;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Converters
{
    public class DateTimeToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime) value).ToString("dd/MM/yy H:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Parse((string) value);
        }
    }
}
