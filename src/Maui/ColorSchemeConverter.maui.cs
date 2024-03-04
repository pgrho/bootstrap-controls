using System.ComponentModel;
using System.Globalization;

namespace Shipwreck.BootstrapControls;

public partial class ColorSchemeConverter : TypeConverter
{
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string s)
        {
            return ConvertFromStringCore(s);
        }

        return base.ConvertFrom(context, culture, value);
    }
}
