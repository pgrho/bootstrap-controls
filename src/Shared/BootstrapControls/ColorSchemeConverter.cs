using System;
using System.Globalization;

namespace Shipwreck.BootstrapControls
{
    public partial class ColorSchemeConverter
    {
        private static object ConvertFromStringCore(string s)
            => s switch
            {
                nameof(ColorScheme.Primary) => ColorScheme.Primary,
                nameof(ColorScheme.Secondary) => ColorScheme.Secondary,
                nameof(ColorScheme.Success) => ColorScheme.Success,
                nameof(ColorScheme.Danger) => ColorScheme.Danger,
                nameof(ColorScheme.Warning) => ColorScheme.Warning,
                nameof(ColorScheme.Info) => ColorScheme.Info,
                nameof(ColorScheme.Dark) => ColorScheme.Dark,
                nameof(ColorScheme.OutlinePrimary) => ColorScheme.OutlinePrimary,
                nameof(ColorScheme.OutlineSecondary) => ColorScheme.OutlineSecondary,
                nameof(ColorScheme.OutlineSuccess) => ColorScheme.OutlineSuccess,
                nameof(ColorScheme.OutlineDanger) => ColorScheme.OutlineDanger,
                nameof(ColorScheme.OutlineWarning) => ColorScheme.OutlineWarning,
                nameof(ColorScheme.OutlineInfo) => ColorScheme.OutlineInfo,
                nameof(ColorScheme.OutlineDark) => ColorScheme.OutlineDark,
                nameof(ColorScheme.Link) => ColorScheme.Link,
                _ => null,
            };
    }
}
