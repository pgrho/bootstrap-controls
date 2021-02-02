using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    internal sealed class CornerRadiusMinusThicknessConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values?.Length == 2
                && values[0] is CornerRadius r
                && values[1] is Thickness t)
            {
                return new CornerRadius(
                    Math.Max(0, r.TopLeft - 0.5 * (t.Top + t.Left)),
                    Math.Max(0, r.TopRight - 0.5 * (t.Top + t.Right)),
                    Math.Max(0, r.BottomRight - 0.5 * (t.Bottom + t.Right)),
                    Math.Max(0, r.BottomLeft - 0.5 * (t.Bottom + t.Left)));
            }
            throw new NotSupportedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
