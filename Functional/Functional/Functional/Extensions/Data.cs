using Xamarin.Forms;

namespace Functional.Extensions
{
	public class Data : BindableObject
	{
		public static readonly BindableProperty ValueProperty =
		BindableProperty.Create(nameof(Text), typeof(Entry), typeof(Data), default(Entry));

		public Entry Text
		{
			get => (Entry)GetValue(ValueProperty);
			set => SetValue(ValueProperty, value);
		}

		public string Value => Text?.Text;
		
	}
}
