using System;

using Xamarin.Forms;

namespace SyspronetApp
{
	public class AboutUsPage : ContentPage
	{
		public AboutUsPage ()
		{
			Title = "AboutUs";
			var Mision = new StackLayout () 
			{
				Children = 
				{
					new Label()
					{
						Text = "Mision",
						FontAttributes = FontAttributes.Bold,
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontFamily = "HelveticaNeue-Medium",
						TextColor = Color.FromHex("#333333")
					},
					new Label()
					{
						Text = "Nuestra misión es ser conocidos y reconocidos por nuestro liderazgo a través de nuestra pasión por los altos estándares, nuestro respeto por la diversidad y nuestro compromiso para crear oportunidades excepcionales para el crecimiento personal, para que nuestros asociados puedan alcanzar su más alto potencial tanto en su carrera como en lo personal.",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						FontFamily = "HelveticaNeue-Medium",
						TextColor = Color.FromHex("#333333"),
					}
				}	
			};

			var Vision = new StackLayout () 
			{
				Children=
				{
					new Label()
					{
						Text = "Vision",
						TextColor = Color.FromHex("#333333"),
						FontAttributes = FontAttributes.Bold,
						FontFamily = "HelveticaNeue-Medium",
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
					},
					new Label()
					{
						TextColor = Color.FromHex("#333333"),
						FontFamily = "HelveticaNeue-Medium",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						Text = "Nuestra visión representa nuestra mayor aspiración. Es nuestro propósito y nuestra razón de existir como empresa y se refleja en la historia que escribimos en todo el mundo.\n"
					}
				}	
			};

			var Valores = new StackLayout () 
			{
				Children=
				{
					new Label()
					{
						Text = "Valores",
						TextColor = Color.FromHex("#333333"),
						FontAttributes = FontAttributes.Bold,
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontFamily = "HelveticaNeue-Medium",

					},
					new Label()
					{
						TextColor = Color.FromHex("#333333"),
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						FontFamily = "HelveticaNeue-Medium",
						Text = "Nuestros valores son servir a la comunidad, a la sociedad y al beneficio de todos los miembros de la empresa. Apoyamos al mantenimiento de la cultura educación y formación de las personas, enfocando nuestra empresa a su logro y apoyo.\n"
					}
				}	
			};

			var AboutUSContent = new StackLayout ()
			{
				Spacing = 10,
				Padding=new Thickness(15,10),
				BackgroundColor = Color.White,
				Children = 
				{
					Mision,
					Vision,
					Valores
				}
			};

			Content = AboutUSContent;
		}
	}
}


