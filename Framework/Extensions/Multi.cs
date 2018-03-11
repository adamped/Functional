using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Functional.Extensions
{
	[ContentProperty("Items")]
	public class MultiExtension : IMarkupExtension<Array>
	{
		public MultiExtension()
		{
			Items = new List<object>();
		}

		public IList Items { get; }

		public string[] Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			return (this as IMarkupExtension<Array>).ProvideValue(serviceProvider);
			
		}

		Array IMarkupExtension<Array>.ProvideValue(IServiceProvider serviceProvider)
		{
			var rootObject = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
			var page = (rootObject.RootObject as Page);

			var snapshot = new List<Data>();
			foreach (var item in Items)
			{
				snapshot.Add(new Data() { Text = page.FindByName<Entry>((string)item) });
			}

			return snapshot.ToArray();
		}
	}
}
