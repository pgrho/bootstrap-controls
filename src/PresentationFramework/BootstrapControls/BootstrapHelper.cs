using System.Windows;
using System.Windows.Documents;

namespace Shipwreck.BootstrapControls
{
    public static class BootstrapHelper
    {
        public static double GetRem(DependencyObject obj) => (double)obj.GetValue(RemProperty);

        public static void SetRem(DependencyObject obj, double value) => obj.SetValue(RemProperty, value);

        public static readonly DependencyProperty RemProperty
            = DependencyProperty.RegisterAttached(
                "Rem",
                typeof(double),
                typeof(BootstrapHelper),
                new FrameworkPropertyMetadata(12.0));
    }
}
