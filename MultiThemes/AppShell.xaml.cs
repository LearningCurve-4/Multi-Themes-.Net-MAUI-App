namespace MultiThemes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		InitializeRouting();
		InitializeAppFiles();
	}

	public void InitializeRouting()
	{
		Routing.RegisterRoute(nameof(AboutAppPage), typeof(AboutAppPage));
	}

	public static void InitializeAppFiles()
	{
		if (!File.Exists(AppThemeService.themeFile))
		{
			File.WriteAllText(AppThemeService.themeFile, AppThemeService.defaultTheme);
		}
	}
}
