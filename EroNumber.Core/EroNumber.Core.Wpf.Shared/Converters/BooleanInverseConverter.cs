using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace EroNumber.Converters
{
    public class BooleanInverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Assert(value != null);
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Assert(value != null);
            return !(bool)value;
        }
    }
}