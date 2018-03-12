//using Framework;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Functional.Extensions
//{
//	[ContentProperty("Items")]
//	public class MultiExtension : IMarkupExtension<Args>
//	{
//		public MultiExtension()
//		{
//			Items = new List<object>();
//		}

//		public IList Items { get; }

//		public string[] Text { get; set; }

//		public object ProvideValue(IServiceProvider serviceProvider)
//		{
//			return (this as IMarkupExtension<Args>).ProvideValue(serviceProvider);
			
//		}

//		Args IMarkupExtension<Args>.ProvideValue(IServiceProvider serviceProvider)
//		{
//			var rootObject = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
//			var page = (rootObject.RootObject as Page);

//			var snapshot = new Args();
//			foreach (var item in Items)
//			{
//				snapshot.Add(page.FindByName<Entry>((string)item).Text);
//			}

//			return snapshot;
//		}
//	}
//}
