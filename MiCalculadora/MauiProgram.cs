using MiCalculadora.Services;
using MiCalculadora.Services.Interfaces;
using MiCalculadora.ViewModels;
using MiCalculadora.Views;
using Microsoft.Extensions.Logging;

namespace MiCalculadora
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<CalculadoraPage>();
            builder.Services.AddSingleton<CalculadoraPageViewModel>();
            builder.Services.AddSingleton<ICalculadoraService, CalculadoraService>();
            return builder.Build();
        }
    }
}
