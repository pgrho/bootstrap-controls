using System.ComponentModel;
using System.Globalization;

namespace Shipwreck.BootstrapControls
{
    public partial class ColorSchemeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string s && ConvertFromStringCore(s) is var r)
            {
                return r;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
