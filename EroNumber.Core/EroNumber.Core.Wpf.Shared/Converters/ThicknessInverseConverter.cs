using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace EroNumber.Converters
{
    public class ThicknessInverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Assert(value != null);
            var thickness = (Thickness)value;
            return Inverse(thickness);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Assert(value != null);
            var thickness = (Thickness)value;
            return Inverse(thickness);
        }

        private static Thickness Inverse(Thickness thickness)
        {
            return new Thickness(0 - thickness.Left, 0 - thickness.Top, 0 - thickness.Right, 0 - thickness.Bottom);
        }
    }
}