using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Shipwreck.BootstrapControls.Demo.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiHandlers(hs => hs.AddBootstrapHandlers());

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
