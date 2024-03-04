using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;

namespace Shipwreck.BootstrapControls;

partial class ColorScheme
{
    public static Color GetColor(int bgra)
        => Color.FromRgba((bgra >> 8) & 0xff, (bgra >> 16) & 0xff, (bgra >> 24) & 0xff, bgra & 0xff);

    internal static Color AsRgb(Color c)
        => Color.FromRgb(
            (c.Red - 1) * c.Alpha + 1,
            (c.Green - 1) * c.Alpha + 1,
            (c.Blue - 1) * c.Alpha + 1);

    internal static Color WithOpacity(Color c, double opacity)
        => Color.FromRgba(c.Red, c.Green, c.Blue, (int)Math.Round(c.Alpha * opacity));
}
