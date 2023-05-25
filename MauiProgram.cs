using Microsoft.Extensions.Logging;

namespace MAPTEST;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiMaps()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
           ;

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<MapPage>();

        return builder.Build();
	}
}
