using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace EroNumber.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public bool IsInversed { get; set; }

        public bool IsReversed { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (IsReversed)
            {
                var boolean = false;
                if (value is Visibility visibility)
                {
                    boolean = visibility == Visibility.Visible;
                }
                if (IsInversed)
                {
                    boolean = !boolean;
                }
                return boolean;
            }
            else
            {
                var visibility = Visibility.Collapsed;
                if (value is bool boolean)
                {
                    visibility = boolean ? Visibility.Visible : Visibility.Collapsed;
                }
                if (IsInversed)
                {
                    visibility = visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
                }
                return visibility;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (IsReversed)
            {
                var visibility = Visibility.Collapsed;
                if (value is bool boolean)
                {
                    visibility = boolean ? Visibility.Visible : Visibility.Collapsed;
                }
                if (IsInversed)
                {
                    visibility = visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
                }
                return visibility;
            }
            else
            {
                var boolean = false;
                if (value is Visibility visibility)
                {
                    boolean = visibility == Visibility.Visible;
                }
                if (IsInversed)
                {
                    boolean = !boolean;
                }
                return boolean;
            }
        }
    }
}