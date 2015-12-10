using System;

using Xamarin.Forms;

namespace SyspronetApp
{
	public class MainTourPage : ContentPage
	{
		public MainTourPage ()
		{
			
			//Home
			var HomeContent = new StackLayout () 
			{
				Padding = new Thickness(15,10),
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Fill,
				BackgroundColor = Color.Blue,
				};
			Content = HomeContent;
		}
	}
}


