using Xamarin.Forms;

namespace Functional
{
	public partial class FunctionalPage : ContentPage
	{
		public FunctionalPage()
		{
			this.BindingContext = new FunctionalViewModel();
			InitializeComponent();			
		}

	}
}
