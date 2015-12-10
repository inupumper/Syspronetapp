using System;

using Xamarin.Forms;

namespace SyspronetApp
{
	public class ServiceDetailPage : ContentPage
	{
		public ServiceDetailPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


