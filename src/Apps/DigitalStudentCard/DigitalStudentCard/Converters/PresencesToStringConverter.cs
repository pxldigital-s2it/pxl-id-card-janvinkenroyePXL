using DigitalStudentCard.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Converters
{
    public class PresencesToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var presences = (List<Presence>) value;
            if (presences.Count > 0)
            {
                return presences[0].IsBlanco ? "Blanco" : "Kopij ingeleverd";
            }
            else
            {
                return "Niet aanwezig";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Blanco";
        }
       
    }
}
