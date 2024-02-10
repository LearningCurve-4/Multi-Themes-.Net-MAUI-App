namespace MultiThemes.ViewModels;

public class HomeViewModel : BaseViewModel
{
	public HomeViewModel()
	{
		LoadThemeCommand.Execute(AppThemeService.ReadTheme().Result ?? "Default");
	}

	bool isSignin = false;
	public bool IsSignin
	{
		get => isSignin;
		set
		{
			if (isSignin == value) { return; }
			isSignin = value;
			OnPropertyChanged();
		}
	}

	public Command LoadThemeCommand => new Command<string>((str) =>
	{
		try
		{
			IsBusy = true;
			AppThemeService.LoadTheme(str);
			AppThemeService.WriteTheme(str);

		}
		finally
		{
			IsBusy = false;
		}
	}, (str) => IsNotBusy);

	public Command SigninCommand => new Command<string>((str) =>
	{
		try
		{
			IsBusy = true;
			IsSignin = !IsSignin;
		}
		finally
		{
			IsBusy = false;
		}
	}, (str) => IsNotBusy);
}
