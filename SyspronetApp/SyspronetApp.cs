using System;

using Xamarin.Forms;

namespace SyspronetApp
{
	public class App : Application
	{
		public static double width;
		public static double height;
		public static double density;
		public App ()
		{
			// The root page of your application
			var nav = new NavigationPage(new WelcomePage());
			nav.BarTextColor = Color.White;
			MainPage = nav;
		}

		public static double PixelstoDpi(double pixels)
		{
			return pixels * App.density;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

