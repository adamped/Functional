using Xamarin.Forms;

namespace Functional
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			this.BindingContext = new MvvmViewModel();
			InitializeComponent();
		}

	}
}
