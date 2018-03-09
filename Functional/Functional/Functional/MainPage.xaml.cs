using Xamarin.Forms;

namespace Functional
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{			
			var vm = new MainViewModel();
			this.BindingContext = vm;
			vm.Controller.Initialize();

			InitializeComponent();
		}

	}
}
