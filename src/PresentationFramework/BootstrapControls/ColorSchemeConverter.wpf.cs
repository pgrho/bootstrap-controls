using System;
using System.ComponentModel;
using System.Globalization;

namespace Shipwreck.BootstrapControls
{
    public partial class ColorSchemeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            => sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);

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
