using System;

using Xamarin.Forms;

namespace SyspronetApp
{
	public class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			Title = "Contact";
			BackgroundColor = Color.White;

			var Name = new Entry 
			{
				HorizontalOptions = LayoutOptions.Fill,
				BackgroundColor = Color.FromHex("f2f2f2"),
				Placeholder="Your name example: Jorge Rios"	
			};

			var Email = new Entry
			{
				HorizontalOptions = LayoutOptions.Fill,
				BackgroundColor = Color.FromHex("f2f2f2"),
				Placeholder = "Email address"
			};

			var TextArea = new Entry
			{
				HorizontalOptions = LayoutOptions.Fill,
				Placeholder = "your comment",
				HeightRequest = App.PixelstoDpi(App.height*0.040),
				BackgroundColor = Color.FromHex("f2f2f2")
			};

			var Submit = new Button
			{
				HorizontalOptions = LayoutOptions.Fill,
				Text = "Send",
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
				FontFamily = "HelveticaNeue-Medium",
				BackgroundColor = Color.FromHex("#3399ff"),
				TextColor = Color.White,
				HeightRequest = App.PixelstoDpi(App.height*0.02)
			};

			var ContactForm = new StackLayout 
			{
				Spacing = 10,
				Children = 
				{
					new Label 
					{
						Text = "Contact Us",
						FontAttributes = FontAttributes.Bold,
						TextColor = Color.FromHex ("333333")
					},
					Name,
					Email,
					TextArea,
					Submit
				}	
			};

			var Location = new Image 
			{
				HorizontalOptions = LayoutOptions.Fill,
				Source = "staticmap.png"				
			};

			var PlaceLay = new StackLayout 
			{
				Spacing = 10,
				HorizontalOptions = LayoutOptions.Fill,
				Children = 
				{
					new Label 
					{
						Text = "Visit Us",
						FontAttributes = FontAttributes.Bold,
						TextColor = Color.FromHex ("333333")
					},
					Location
				}
			};

			var ContactContent = new StackLayout
			{
				Spacing = 10,
				Padding = new Thickness(15,10),
				HorizontalOptions = LayoutOptions.Fill,
				Children = 
				{
					ContactForm,
					PlaceLay
				}
			};

			Content = new ScrollView
			{
				HorizontalOptions = LayoutOptions.Fill,
				Content = ContactContent
			};
		}
	}
}


