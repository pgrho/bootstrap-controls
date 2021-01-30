using System;
using System.Globalization;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    [ValueConversion(typeof(double), typeof(double))]
    public sealed class DoubleMultiplicationConverter : IValueConverter
    {
        public double Coefficient { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => ((value is double d) ? d : ((IConvertible)value).ToDouble(culture)) * Coefficient;

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
