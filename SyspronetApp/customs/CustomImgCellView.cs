using System;
using Xamarin.Forms;
namespace SyspronetApp
{
	public class imgcellvalues
	{
		public string imgsource{ get; set;}
		public string imgdetail{ get; set;}
		public string imgtext{ get; set;}
		public imgcellvalues(string src,string txt,string dtl)
		{
			this.imgsource = src;
			this.imgtext = txt;
			this.imgdetail = dtl;
		}
	}

	public class CustomImageView:ViewCell
	{
		public CustomImageView ()
		{
			var serviceimg = new Image {
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
			};
			serviceimg.SetBinding (Image.SourceProperty,"imgsource");
			var text = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.FromHex("#333333")
			};
			text.SetBinding (Label.TextProperty,"imgtext");

			var detail = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 12,
				TextColor = Color.FromHex("#333333")
			};
			detail.SetBinding (Label.TextProperty,"imgdetail");
			var textcells = new StackLayout {
				Spacing = 0,
				Padding = new Thickness(15,0),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { text, detail }
			};
			var imgcell = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (15,5,15,5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { serviceimg,textcells}
			};

			View = imgcell;
		}
	}
}

