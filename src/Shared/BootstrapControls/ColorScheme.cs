#if IS_XAMARIN_FORMS

using Xamarin.Forms;

#elif IS_WPF
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Media;
#else
using Xamarin.Forms;
#endif

namespace Shipwreck.BootstrapControls
{
    [TypeConverter(typeof(ColorSchemeConverter))]
    public partial class ColorScheme
    {
        public static readonly ColorScheme Default = new ColorScheme()
        {
            Name = "Default",
            Foreground = FromRgba(33, 37, 41, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(0, 0, 0, 0),
            ActiveForeground = FromRgba(33, 37, 41, 255),
            ActiveBackground = FromRgba(0, 0, 0, 0),
            ActiveBorder = FromRgba(0, 0, 0, 0),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(0, 0, 0, 0),
            FocusShadow = FromRgba(0, 123, 255, 64),
        };

        public static readonly ColorScheme Primary = new ColorScheme()
        {
            Name = "Primary",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(0, 123, 255, 255),
            Border = FromRgba(0, 123, 255, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(0, 98, 204, 255),
            ActiveBorder = FromRgba(0, 92, 191, 255),
            FocusBackground = FromRgba(0, 105, 217, 255),
            FocusBorder = FromRgba(0, 98, 204, 255),
            FocusShadow = FromRgba(38, 143, 255, 128),
        };

        public static readonly ColorScheme OutlinePrimary = new ColorScheme()
        {
            Name = "OutlinePrimary",
            Foreground = FromRgba(0, 123, 255, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(0, 123, 255, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(0, 123, 255, 255),
            ActiveBorder = FromRgba(0, 123, 255, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(0, 123, 255, 255),
            FocusShadow = FromRgba(0, 123, 255, 128),
        };

        public static readonly ColorScheme Secondary = new ColorScheme()
        {
            Name = "Secondary",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(108, 117, 125, 255),
            Border = FromRgba(108, 117, 125, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(84, 91, 98, 255),
            ActiveBorder = FromRgba(78, 85, 91, 255),
            FocusBackground = FromRgba(90, 98, 104, 255),
            FocusBorder = FromRgba(84, 91, 98, 255),
            FocusShadow = FromRgba(130, 138, 145, 128),
        };

        public static readonly ColorScheme OutlineSecondary = new ColorScheme()
        {
            Name = "OutlineSecondary",
            Foreground = FromRgba(108, 117, 125, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(108, 117, 125, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(108, 117, 125, 255),
            ActiveBorder = FromRgba(108, 117, 125, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(108, 117, 125, 255),
            FocusShadow = FromRgba(108, 117, 125, 128),
        };

        public static readonly ColorScheme Success = new ColorScheme()
        {
            Name = "Success",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(40, 167, 69, 255),
            Border = FromRgba(40, 167, 69, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(30, 126, 52, 255),
            ActiveBorder = FromRgba(28, 116, 48, 255),
            FocusBackground = FromRgba(33, 136, 56, 255),
            FocusBorder = FromRgba(30, 126, 52, 255),
            FocusShadow = FromRgba(72, 180, 97, 128),
        };

        public static readonly ColorScheme OutlineSuccess = new ColorScheme()
        {
            Name = "OutlineSuccess",
            Foreground = FromRgba(40, 167, 69, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(40, 167, 69, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(40, 167, 69, 255),
            ActiveBorder = FromRgba(40, 167, 69, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(40, 167, 69, 255),
            FocusShadow = FromRgba(40, 167, 69, 128),
        };

        public static readonly ColorScheme Danger = new ColorScheme()
        {
            Name = "Danger",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(220, 53, 69, 255),
            Border = FromRgba(220, 53, 69, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(189, 33, 48, 255),
            ActiveBorder = FromRgba(178, 31, 45, 255),
            FocusBackground = FromRgba(200, 35, 51, 255),
            FocusBorder = FromRgba(189, 33, 48, 255),
            FocusShadow = FromRgba(225, 83, 97, 128),
        };

        public static readonly ColorScheme OutlineDanger = new ColorScheme()
        {
            Name = "OutlineDanger",
            Foreground = FromRgba(220, 53, 69, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(220, 53, 69, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(220, 53, 69, 255),
            ActiveBorder = FromRgba(220, 53, 69, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(220, 53, 69, 255),
            FocusShadow = FromRgba(220, 53, 69, 128),
        };

        public static readonly ColorScheme Warning = new ColorScheme()
        {
            Name = "Warning",
            Foreground = FromRgba(33, 37, 41, 255),
            Background = FromRgba(255, 193, 7, 255),
            Border = FromRgba(255, 193, 7, 255),
            ActiveForeground = FromRgba(33, 37, 41, 255),
            ActiveBackground = FromRgba(211, 158, 0, 255),
            ActiveBorder = FromRgba(198, 149, 0, 255),
            FocusBackground = FromRgba(224, 168, 0, 255),
            FocusBorder = FromRgba(211, 158, 0, 255),
            FocusShadow = FromRgba(222, 170, 12, 128),
        };

        public static readonly ColorScheme OutlineWarning = new ColorScheme()
        {
            Name = "OutlineWarning",
            Foreground = FromRgba(255, 193, 7, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(255, 193, 7, 255),
            ActiveForeground = FromRgba(33, 37, 41, 255),
            ActiveBackground = FromRgba(255, 193, 7, 255),
            ActiveBorder = FromRgba(255, 193, 7, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(255, 193, 7, 255),
            FocusShadow = FromRgba(255, 193, 7, 128),
        };

        public static readonly ColorScheme Info = new ColorScheme()
        {
            Name = "Info",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(23, 162, 184, 255),
            Border = FromRgba(23, 162, 184, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(17, 122, 139, 255),
            ActiveBorder = FromRgba(16, 112, 127, 255),
            FocusBackground = FromRgba(19, 132, 150, 255),
            FocusBorder = FromRgba(17, 122, 139, 255),
            FocusShadow = FromRgba(58, 176, 195, 128),
        };

        public static readonly ColorScheme OutlineInfo = new ColorScheme()
        {
            Name = "OutlineInfo",
            Foreground = FromRgba(23, 162, 184, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(23, 162, 184, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(23, 162, 184, 255),
            ActiveBorder = FromRgba(23, 162, 184, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(23, 162, 184, 255),
            FocusShadow = FromRgba(23, 162, 184, 128),
        };

        public static readonly ColorScheme Dark = new ColorScheme()
        {
            Name = "Dark",
            Foreground = FromRgba(255, 255, 255, 255),
            Background = FromRgba(52, 58, 64, 255),
            Border = FromRgba(52, 58, 64, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(29, 33, 36, 255),
            ActiveBorder = FromRgba(23, 26, 29, 255),
            FocusBackground = FromRgba(35, 39, 43, 255),
            FocusBorder = FromRgba(29, 33, 36, 255),
            FocusShadow = FromRgba(82, 88, 93, 128),
        };

        public static readonly ColorScheme OutlineDark = new ColorScheme()
        {
            Name = "OutlineDark",
            Foreground = FromRgba(52, 58, 64, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(52, 58, 64, 255),
            ActiveForeground = FromRgba(255, 255, 255, 255),
            ActiveBackground = FromRgba(52, 58, 64, 255),
            ActiveBorder = FromRgba(52, 58, 64, 255),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(52, 58, 64, 255),
            FocusShadow = FromRgba(52, 58, 64, 128),
        };

        public static readonly ColorScheme Link = new ColorScheme()
        {
            Name = "Link",
            Foreground = FromRgba(0, 123, 255, 255),
            Background = FromRgba(0, 0, 0, 0),
            Border = FromRgba(0, 0, 0, 0),
            ActiveForeground = FromRgba(0, 123, 255, 255),
            ActiveBackground = FromRgba(0, 0, 0, 0),
            ActiveBorder = FromRgba(0, 0, 0, 0),
            FocusBackground = FromRgba(0, 0, 0, 0),
            FocusBorder = FromRgba(0, 0, 0, 0),
            FocusShadow = FromRgba(0, 123, 255, 64),
        };

        public string Name { get; private set; }
        
        public int Foreground { get; private set; }
        public Color ForegroundColor => GetColor(Foreground);

        public int Background { get; private set; }
        public Color BackgroundColor => GetColor(Background);

        public int Border { get; private set; }
        public Color BorderColor => GetColor(Border);

        public int ActiveForeground { get; private set; }
        public Color ActiveForegroundColor => GetColor(ActiveForeground);
    
        public int ActiveBackground { get; private set; }
        public Color ActiveBackgroundColor => GetColor(ActiveBackground);
    
        public int ActiveBorder { get; private set; }
        public Color ActiveBorderColor => GetColor(ActiveBorder);

        //public int HoverBackground { get; private set; }
        //public int HoverBorder { get; private set; }
        public int FocusBackground { get; private set; }
        public Color FocusBackgroundColor => GetColor(FocusBackground);

        public int FocusBorder { get; private set; }
        public Color FocusBorderColor => GetColor(FocusBorder);

        public int FocusShadow { get; private set; }
        public Color FocusShadowColor => GetColor(FocusShadow);

        private static int FromRgba(int r, int g, int b, int a)
             => (b << 24) | (g << 16) | (r << 8) | a;
    }
}
