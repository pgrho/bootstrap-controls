using Microsoft.Maui.Hosting;
using Shipwreck.BootstrapControls.Platforms.Android;

namespace Shipwreck.BootstrapControls;

public static class BootstrapControlsModule
{
    public static void Init()
    {
    }

    public static IMauiHandlersCollection AddBootstrapHandlers(this IMauiHandlersCollection handlers)
    {
#if ANDROID
        handlers.AddHandler(typeof(ButtonFrame), typeof(ButtonFrameRenderer));
#endif
        return handlers;
    }
}
