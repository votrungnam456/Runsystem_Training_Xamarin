using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin;
using Xamarin.Forms;

namespace App_Training_Xamarin.ViewModels
{
    public class ConvertDateTimeToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string convertData = value.ToString();
            return convertData;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (DateTime)value;
        }
    }
}
