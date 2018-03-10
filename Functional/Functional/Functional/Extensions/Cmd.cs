using Functional.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Functional.Extensions
{
	[ContentProperty("Text")]
	public class CmdExtension : IMarkupExtension
	{

		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			var rootObject = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
			var viewModel = (rootObject.RootObject as Page).BindingContext as IBaseViewModel;
			var controller = viewModel.Controller;
			return controller.GetType().GetProperty(Text).GetValue(controller);
		}
	}
}
