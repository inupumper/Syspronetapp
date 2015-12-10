using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SyspronetApp
{
	public class ServicesPage:ContentPage
	{
		public ServicesPage ()
		{
			Title = "Services";
			BackgroundColor = Color.White;
			//Services
			var CC = new DataTemplate(typeof(CustomImageView));
			var list = new List<imgcellvalues> ();
			list.Add (new imgcellvalues("database.png","Base de Datos","Diseño y Procedimientos almacenados"));
			list.Add (new imgcellvalues("lan.png","Redes LAN","Diseño de redes locales"));
			var Servicelist = new ListView()
			{
				HasUnevenRows = true,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Fill,
				ItemsSource = list,
				ItemTemplate = CC,
				BackgroundColor = Color.White,

			};

			Servicelist.ItemSelected += async (sender, e) => 
			{
				Navigation.PushAsync(new ServiceDetailPage());
			};

			Content = Servicelist;
		}
	}
}

