using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    public sealed class GridColumnsToWidthConverter : IMultiValueConverter
    {
        public static readonly GridColumnsToWidthConverter Default = new GridColumnsToWidthConverter();

        public double XsOuterWidth { get; set; } = 576;
        public double SmOuterWidth { get; set; } = 768;
        public double MdOuterWidth { get; set; } = 992;
        public double LgOuterWidth { get; set; } = 1200;
        public double XlOuterWidth { get; set; } = 1400;

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.FirstOrDefault() is double cw)
            {
                var ei = cw < XsOuterWidth ? 1 : cw < SmOuterWidth ? 2 : cw < MdOuterWidth ? 3 : cw < LgOuterWidth ? 4 : cw < XlOuterWidth ? 5 : 6;

                for (var i = ei; i > 0; i--)
                {
                    var col = values.ElementAtOrDefault(i);
                    if (col is double d && d > 0)
                    {
                        return cw * d / 12;
                    }
                }
                return cw;
            }
            return DependencyProperty.UnsetValue;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
