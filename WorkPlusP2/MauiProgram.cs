using WorkPlusP2.Views.Startup;
using WorkPlusP2.ViewsModels.Startup;
using WorkPlusP2.Views;
using static WorkPlusP2.Views.Dashboard;

namespace WorkPlusP2;

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

		builder.Services.AddSingleton<LoginPage>();

		builder.Services.AddSingleton<DashboardPage>();

        builder.Services.AddSingleton<LoginPageViewModel>();

		return builder.Build();
	}
}
