using System;
using Xamarin.Forms;

namespace SyspronetApp
{
	public class HomePage: ContentPage
	{
		public HomePage ()
		{
			Title = "Home";
			//Home
			var logo = new Image
			{
				HorizontalOptions = LayoutOptions.Center,
				Source = "logo.png"
			};
			this.Appearing += async (sender, e) => 
			{
				await Navigation.PushModalAsync(new MainTourPage(){Opacity=0.1});
			};
			var HomeContent = new StackLayout () 
			{
				Padding = new Thickness(15,10),
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Fill,
				BackgroundColor = Color.White,
				Children = 
				{
					logo
				}		
				};
			
			Content = HomeContent;
		}
	}
}

