using System;
using System.Globalization;

namespace Shipwreck.BootstrapControls
{
    internal sealed partial class IsColorSchemeSetConverter
    {
        private static readonly object TRUE = true;
        private static readonly object FALSE = false;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value != null && value != ColorScheme.Default ? TRUE : FALSE;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
