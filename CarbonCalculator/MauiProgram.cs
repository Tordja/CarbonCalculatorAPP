using Microsoft.Maui.LifecycleEvents;
using CarbonCalculator.Pages.Startup;
using CarbonCalculator.Pages.Dashboard;
using CarbonCalculator.ViewModels;

namespace CarbonCalculator;

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

		var services = builder.Services;
        services.AddTransient<LoginPage>();
        services.AddTransient<HomePage>();

        services.AddTransient<HomeViewModel>();
        services.AddTransient<LoginViewModel>();


        return builder.Build();
	}
}
