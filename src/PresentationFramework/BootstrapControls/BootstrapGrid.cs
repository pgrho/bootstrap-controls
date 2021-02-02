using System.Windows;
using System.Windows.Data;

namespace Shipwreck.BootstrapControls
{
    public static class BootstrapGrid
    {
        #region ContainerWidth

        public static double GetContainerWidth(FrameworkElement obj)
        {
            return (double)obj.GetValue(ContainerWidthProperty);
        }

        public static void SetContainerWidth(FrameworkElement obj, double value)
        {
            obj.SetValue(ContainerWidthProperty, value);
        }

        public static readonly DependencyProperty ContainerWidthProperty
            = DependencyProperty.RegisterAttached("ContainerWidth", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(0.0)
            {
                AffectsMeasure = true,
                Inherits = true
            });

        #endregion ContainerWidth

        #region Xs

        public static double GetXs(FrameworkElement obj)
        {
            return (double)obj.GetValue(XsProperty);
        }

        public static void SetXs(FrameworkElement obj, double value)
        {
            obj.SetValue(XsProperty, value);
        }

        public static readonly DependencyProperty XsProperty =
            DependencyProperty.RegisterAttached("Xs", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Xs

        #region Sm

        public static double GetSm(FrameworkElement obj)
        {
            return (double)obj.GetValue(SmProperty);
        }

        public static void SetSm(FrameworkElement obj, double value)
        {
            obj.SetValue(SmProperty, value);
        }

        public static readonly DependencyProperty SmProperty =
            DependencyProperty.RegisterAttached("Sm", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Sm

        #region Md

        public static double GetMd(FrameworkElement obj)
        {
            return (double)obj.GetValue(MdProperty);
        }

        public static void SetMd(FrameworkElement obj, double value)
        {
            obj.SetValue(MdProperty, value);
        }

        public static readonly DependencyProperty MdProperty =
            DependencyProperty.RegisterAttached("Md", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Md

        #region Lg

        public static double GetLg(FrameworkElement obj)
        {
            return (double)obj.GetValue(LgProperty);
        }

        public static void SetLg(FrameworkElement obj, double value)
        {
            obj.SetValue(LgProperty, value);
        }

        public static readonly DependencyProperty LgProperty =
            DependencyProperty.RegisterAttached("Lg", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Lg

        #region Xl

        public static double GetXl(FrameworkElement obj)
        {
            return (double)obj.GetValue(XlProperty);
        }

        public static void SetXl(FrameworkElement obj, double value)
        {
            obj.SetValue(XlProperty, value);
        }

        public static readonly DependencyProperty XlProperty =
            DependencyProperty.RegisterAttached("Xl", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Xl

        #region Xxl

        public static double GetXxl(FrameworkElement obj)
        {
            return (double)obj.GetValue(XxlProperty);
        }

        public static void SetXxl(FrameworkElement obj, double value)
        {
            obj.SetValue(XxlProperty, value);
        }

        public static readonly DependencyProperty XxlProperty =
            DependencyProperty.RegisterAttached("Xxl", typeof(double), typeof(BootstrapGrid), new FrameworkPropertyMetadata(double.NaN, OnColumnChanged)
            {
                AffectsMeasure = true,
            });

        #endregion Xxl

        #region Converter

        public static readonly DependencyProperty ConverterProperty
            = DependencyProperty.RegisterAttached("Converter", typeof(IMultiValueConverter), typeof(BootstrapGrid), new PropertyMetadata(GridColumnsToWidthConverter.Default, OnColumnChanged));

        public static IMultiValueConverter GetConverter(DependencyObject obj) => (IMultiValueConverter)obj.GetValue(ConverterProperty);

        public static void SetConverter(DependencyObject obj, IMultiValueConverter value) => obj.SetValue(ConverterProperty, value);

        #endregion Converter

        private static void OnColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is double v && v > 0)
            {
                var mb = new MultiBinding()
                {
                    Converter = GetConverter(d) ?? GridColumnsToWidthConverter.Default
                };
                var rs = new RelativeSource(RelativeSourceMode.Self);
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(ContainerWidthProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(XsProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(SmProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(MdProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(LgProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(XlProperty) });
                mb.Bindings.Add(new Binding() { RelativeSource = rs, Path = new PropertyPath(XxlProperty) });
                BindingOperations.SetBinding(d, FrameworkElement.WidthProperty, mb);
            }
        }
    }
}
