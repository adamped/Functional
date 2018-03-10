using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Functional.Extensions
{
	[ContentProperty("Items")]
	[AcceptEmptyServiceProvider]
	public class SnapshotExtension : IMarkupExtension<Array>
	{
		public SnapshotExtension()
		{
			Items = new List<object>();
		}

		public IList Items { get; }

		public Type Type => typeof(Data);

		public Array ProvideValue(IServiceProvider serviceProvider)
		{
			if (Items == null)
				return null;

			var array = Array.CreateInstance(Type, Items.Count);
			for (var i = 0; i < Items.Count; i++)
				((IList)array)[i] = Items[i];

			return array;
		}

		object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
		{
			return (this as IMarkupExtension<Array>).ProvideValue(serviceProvider);
		}
	}
}
