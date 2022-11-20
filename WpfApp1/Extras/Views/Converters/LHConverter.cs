using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfApp1.Extras.Views
{
    internal class LHConverter : IValueConverter
    {
        private const string Less10 = "< 10";
        private const string Less20 = "< 20";
        private const string Less30 = "< 30";
        private const string Less40 = "< 40";
        private const string Less50 = "< 50";
        private const string MoreEq50 = ">= 50";

        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            var num = value as int?;

            if (!num.HasValue)
                return string.Empty;

            if (num < 10)
                return Less10;
            if (num < 20)
                return Less20;
            if (num < 30)
                return Less30;
            if (num < 40)
                return Less40;
            if (num < 50)
                return Less50;

            return MoreEq50;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            var text = value as string;
            if (string.IsNullOrEmpty(text)) return 0;
            if (text == Less10) return 9;
            if (text == Less20) return 19;
            if (text == Less30) return 29;
            if (text == Less40) return 39;
            if (text == Less50) return 49;
            return 50;
        }
    }
}
