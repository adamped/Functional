using Framework.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Framework.Base.BaseViewModel;

namespace Functional.Extensions
{
	[ContentProperty("Text")]
	public class PullExtension : IMarkupExtension
	{
		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			var rootObject = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
			var pvt = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));
			var page = (rootObject.RootObject as Page);

			var viewModel = page.BindingContext as BaseViewModel;

			viewModel.PropertyChanged += (s, e) =>
			{
				var args = e as PropertyChangedValueEventArgs;

				if (args.PropertyName == "LabelValue") // Just here for testing atm.
					pvt.TargetObject.GetType().GetProperty((pvt.TargetProperty as BindableProperty).PropertyName).SetValue(pvt.TargetObject, args.Value);

			};

			return null;
		}

	}
}
