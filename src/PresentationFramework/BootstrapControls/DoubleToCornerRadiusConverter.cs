using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    [ValueConversion(typeof(double), typeof(CornerRadius))]
    internal sealed class DoubleToCornerRadiusConverter : IValueConverter
    {
        public double TopLeft { get; set; } = 1;

        public double TopRight { get; set; } = 1;

        public double BottomRight { get; set; } = 1;

        public double BottomLeft { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = value is double d ? d : ((IConvertible)value).ToDouble(culture);
            return new CornerRadius(v * TopLeft, v * TopRight, v * BottomRight, v * BottomLeft);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
