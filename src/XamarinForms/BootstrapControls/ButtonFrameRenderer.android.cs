using Android.Content;
using Android.Views;
using Shipwreck.BootstrapControls;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(ButtonFrame), typeof(ButtonFrameRenderer))]
namespace Shipwreck.BootstrapControls
{
    public class ButtonFrameRenderer : Xamarin.Forms.Platform.Android.FastRenderers.FrameRenderer
    {
        public ButtonFrameRenderer(Context context)
            : base(context)
        {
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    {
                        if (Element is ButtonFrame c && c.IsEnabled)
                        {
                            c.IsPressed = true;
                        }
                    }
                    break;

                case MotionEventActions.Up:
                case MotionEventActions.Cancel:
                    {
                        if (Element is ButtonFrame c)
                        {
                            c.IsPressed = false;
                        }
                    }
                    break;
            }

            return base.OnTouchEvent(e);
        }
    }
}
