using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace SyspronetApp
{
	class WelcomePage : TabbedPage
	{
		public WelcomePage ()
		{
			
			Children.Add (new HomePage());
			Children.Add (new ServicesPage());
			Children.Add (new AboutUsPage());
			Children.Add (new ContactPage());
			this.Title = "Syspronet";
		}
	}
}


