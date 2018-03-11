using Functional.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Functional.Extensions
{
	[ContentProperty("Text")]
	public class RefExtension : IMarkupExtension
	{

		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			var rootObject = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
			var page = (rootObject.RootObject as Page);
			return page.FindByName<Element>(Text);
		}
	}
}
