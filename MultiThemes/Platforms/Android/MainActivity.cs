﻿using Android.App;
using Android.Content.PM;

namespace MultiThemes
{
	[Activity(
		//Theme = "@style/Maui.SplashTheme",
		Theme = "@style/SplashTheme",
		MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
	public class MainActivity : MauiAppCompatActivity
	{
	}
}
