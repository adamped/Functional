using Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Functional.Extensions
{
	[ContentProperty("Items")]
	[AcceptEmptyServiceProvider]
	public class SnapshotExtension : IMarkupExtension<Args>
	{
		public SnapshotExtension()
		{
			Items = new List<object>();
		}

		public IList Items { get; }

		public Args ProvideValue(IServiceProvider serviceProvider)
		{
			if (Items == null)
				return null;

			var snapshot = new Args();
			for (var i = 0; i < Items.Count; i++)
				snapshot.Add(((Data)Items[i]));

			return snapshot;
		}

		object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
		{
			return (this as IMarkupExtension<Args>).ProvideValue(serviceProvider);
		}
	}
}
