using AppConference.Pages;
using AppConference.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppConference;

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


		builder.Services.AddSingleton<ScheduleDay1Page>();
		builder.Services.AddTransient<ScheduleDay2Page>();
		builder.Services.AddTransient<ScheduleViewModel>();


        return builder.Build();
	}
}
