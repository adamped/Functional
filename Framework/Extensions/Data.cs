using Xamarin.Forms;

namespace Functional.Extensions
{
	public class Data : BindableObject
	{
		public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(Text), typeof(string), typeof(Data), default(string));

		public string Text
		{
			get => (string)GetValue(TextProperty);
			set => SetValue(TextProperty, value);
		}

		public string Value => Text;



	}
}
