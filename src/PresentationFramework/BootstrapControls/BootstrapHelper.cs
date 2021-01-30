using System.Windows;

namespace Shipwreck.BootstrapControls
{
    public static class BootstrapHelper
    {
        #region Rem

        public static readonly DependencyProperty RemProperty
            = DependencyProperty.RegisterAttached(
                "Rem",
                typeof(double),
                typeof(BootstrapHelper),
                new FrameworkPropertyMetadata(12.0));

        public static double GetRem(DependencyObject obj)
            => (double)obj.GetValue(RemProperty);

        public static void SetRem(DependencyObject obj, double value)
            => obj.SetValue(RemProperty, value);

        #endregion Rem

        #region CornerRadiusMode

        public static readonly DependencyProperty CornerRadiusModeProperty
            = DependencyProperty.RegisterAttached("CornerRadiusMode", typeof(CornerRadiusMode), typeof(BootstrapHelper), new FrameworkPropertyMetadata(CornerRadiusMode.All));

        public static CornerRadiusMode GetCornerRadiusMode(DependencyObject obj)
            => (CornerRadiusMode)obj.GetValue(CornerRadiusModeProperty);

        public static void SetCornerRadiusMode(DependencyObject obj, CornerRadiusMode value)
            => obj.SetValue(CornerRadiusModeProperty, value);

        #endregion CornerRadiusMode
    }
}
