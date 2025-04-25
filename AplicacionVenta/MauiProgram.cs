using AplicacionVenta.DataAccess;
using AplicacionVenta.Views;
using Microsoft.Extensions.Logging;

namespace AplicacionVenta
{
    // Creado por XXX
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            var dbContext = new VentaDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();

            Routing.RegisterRoute(nameof(ProductoDetallePage), typeof(ProductoDetallePage));

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
