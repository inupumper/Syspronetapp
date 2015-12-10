using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SyspronetApp.Droid
{
	[Activity (Theme = "@style/Theme.Syspronet",Label = "SyspronetApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			App.height = Resources.DisplayMetrics.HeightPixels;
			App.width = Resources.DisplayMetrics.WidthPixels;
			App.density = Resources.DisplayMetrics.Density;
			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

