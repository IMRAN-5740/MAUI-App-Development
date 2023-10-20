using LoginPageMAUI.Views.StartUp;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using LoginPageMAUI.ViewModels.StartUp;

namespace LoginPageMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();



            //Views
            builder.Services.AddSingleton<LoginPage>();

            //ViewModels
            builder.Services.AddSingleton<LoginPageViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}