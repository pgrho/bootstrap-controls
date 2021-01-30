using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    [ValueConversion(typeof(double), typeof(Thickness))]
    internal sealed class DoubleToThicknessConverter : IValueConverter
    {
        public double Left { get; set; } = 1;

        public double Top { get; set; } = 1;

        public double Right { get; set; } = 1;

        public double Bottom { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = value is double d ? d : ((IConvertible)value).ToDouble(culture);
            return new Thickness(v * Left, v * Top, v * Right, v * Bottom);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
