using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Shipwreck.BootstrapControls
{
    public sealed class ButtonFrameRenderer : FrameRenderer
    {
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            if (Element is ButtonFrame c && c.IsEnabled)
            {
                c.IsPressed = true;
            }
            base.TouchesBegan(touches, evt);
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            if (Element is ButtonFrame c)
            {
                c.IsPressed = false;
            }
            base.TouchesEnded(touches, evt);
        }

        public override void TouchesCancelled(NSSet touches, UIEvent evt)
        {
            if (Element is ButtonFrame c)
            {
                c.IsPressed = false;
            }
            base.TouchesCancelled(touches, evt);
        }
    }
}
