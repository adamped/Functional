using Xamarin.Forms;

namespace Functional.Extensions
{
	/// <summary>
	/// This is just my failed attempt at trying to get an array through
	/// to the Command parameter. Currently you can't bind to an item in 
	/// an array in XAML for some reason. Likely a XAML short fall, will
	/// need to investigate.
	/// </summary>
	public class TupleCollection : View
	{
		//public static readonly BindableProperty CollectionProperty =
		//BindableProperty.Create(nameof(Collection), typeof(Data[]), typeof(TupleCollection), default(Data[]));

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if (Collection != null)
				foreach (var item in _collection)
				{
					item.BindingContext = this.BindingContext;
				}
		}

		private Data[] _collection;
		public Data[] Collection
		{
			get => _collection;
			set
			{
				_collection = value;
				foreach (var item in _collection)
					item.BindingContext = this.BindingContext;
			}
		}
		//{
		//	get => (Data[])GetValue(CollectionProperty);
		//	set => SetValue(CollectionProperty, value);
		//}
	}

	public class Data : BindableObject
	{
		public static readonly BindableProperty ValueProperty =
		BindableProperty.Create(nameof(Value), typeof(object), typeof(Data), default(object), BindingMode.OneWayToSource);

		public object Value
		{
			get => (object)GetValue(ValueProperty);
			set => SetValue(ValueProperty, value);
		}
	}

}
