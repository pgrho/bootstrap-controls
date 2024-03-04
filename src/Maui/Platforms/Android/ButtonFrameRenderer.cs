using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;

namespace Shipwreck.BootstrapControls.Platforms.Android;

public class ButtonFrameRenderer : FrameRenderer
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
