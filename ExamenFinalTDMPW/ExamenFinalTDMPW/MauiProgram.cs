using Microsoft.Extensions.Logging;

namespace ExamenFinalTDMPW;

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
                fonts.AddFont("Starjedi.ttf", "jedi");
                fonts.AddFont("roboto.ttf", "roboto");
                fonts.AddFont("minecraft.ttf", "minecraft");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

