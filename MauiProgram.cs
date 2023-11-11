using Telerik.Maui.Controls.Compatibility;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace IdeaGeneratorPersona;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseTelerik()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers((handlers) =>
				{
#if WINDOWS
					// The default look and feel of ImageButton was changed with preview 11.
					// The custom RadImageButtonHandler brings back the old look from preview 10.
					// Remove or improve that implementation if the new look of ImageButton is needed in WinUI.
					handlers.AddHandler(typeof(ImageButton), typeof(IdeaGeneratorPersona.WinUI.RadImageButtonHandler));
#endif
				});

		return builder.Build();
	}
}

