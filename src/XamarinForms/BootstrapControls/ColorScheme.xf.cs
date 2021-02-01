using System;
using Xamarin.Forms;

namespace Shipwreck.BootstrapControls
{
    public partial class ColorScheme
    {
        public static Color GetColor(int bgra)
            => Color.FromRgba((bgra >> 8) & 0xff, (bgra >> 16) & 0xff, (bgra >> 24) & 0xff, bgra & 0xff);

        internal static Color AsRgb(Color c)
            => Color.FromRgb(
                (c.R - 1) * c.A + 1,
                (c.G - 1) * c.A + 1,
                (c.B - 1) * c.A + 1);

        internal static Color WithOpacity(Color c, double opacity)
            => Color.FromRgba(c.R, c.G, c.B, (int)Math.Round(c.A * opacity));
    }
}
