using System;
using System.Globalization;

namespace Shipwreck.BootstrapControls
{
#if IS_WPF
using System.Windows.Data;
#elif IS_XAMARIN_FORMS
using Xamarin.Forms;
#endif
    public sealed class ContainerWidthConverter : IValueConverter
    {
        public double XsOuterWidth { get; set; } = 576;
        public double SmOuterWidth { get; set; } = 768;
        public double MdOuterWidth { get; set; } = 992;
        public double LgOuterWidth { get; set; } = 1200;
        public double XlOuterWidth { get; set; } = 1400;

        public double XsInnerWidth { get; set; } = 540;
        public double SmInnerWidth { get; set; } = 720;
        public double MdInnerWidth { get; set; } = 960;
        public double LgInnerWidth { get; set; } = 1140;
        public double XlInnerWidth { get; set; } = 1320;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is IConvertible c)
            {
                var w = c.ToDouble(culture);
                return w switch
                {
                    double d when d < XsOuterWidth => Math.Min(Math.Max(d, 0), XsInnerWidth),
                    double d when d < SmOuterWidth => XsInnerWidth,
                    double d when d < MdOuterWidth => SmInnerWidth,
                    double d when d < LgOuterWidth => MdInnerWidth,
                    double d when d < XlOuterWidth => LgInnerWidth,
                    _ => XlInnerWidth
                };
            }
            return 0;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
