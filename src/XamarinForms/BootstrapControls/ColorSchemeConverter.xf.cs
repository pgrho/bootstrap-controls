using Xamarin.Forms;

namespace Shipwreck.BootstrapControls
{
    public partial class ColorSchemeConverter : TypeConverter
    {
        public override object ConvertFromInvariantString(string value)
            => ConvertFromStringCore(value) ?? base.ConvertFromInvariantString(value);
    }
}
