using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using System.ComponentModel;
using Android.Graphics.Drawables;
using SyspronetApp.Droid;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(tabrender))]
namespace SyspronetApp.Droid
{
	public class tabrender:TabbedRenderer
	{
		//private Activity activity;
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
//			activity = this.Context as Activity;
//
//			ActionBar actionBar = activity.ActionBar;
//			ColorDrawable colorDrawable = new ColorDrawable(global::Android.Graphics.Color.Rgb(13,59,95));
//			actionBar.SetStackedBackgroundDrawable(colorDrawable);
		}


	}
}

