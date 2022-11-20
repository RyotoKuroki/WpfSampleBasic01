using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Extras.Views
{
    internal class BoolVisibilityConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            var vis = (bool)value;

            return vis ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            var vis = (Visibility)value;

            return vis == Visibility.Visible;
        }
    }
}
