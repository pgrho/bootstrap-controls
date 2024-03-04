using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls.Handlers.Compatibility;

namespace Shipwreck.BootstrapControls.Platforms.Android;

public class ButtonFrameRenderer : FrameRenderer
{
    public ButtonFrameRenderer(Context context)
        : base(context)
    {
        Touch += ButtonFrameRenderer_Touch;
    }

    private void ButtonFrameRenderer_Touch(object sender, TouchEventArgs e)
    {
        e.Handled = OnTouchEvent(e.Event);
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
