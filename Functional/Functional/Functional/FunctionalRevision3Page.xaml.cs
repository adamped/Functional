using Xamarin.Forms;

namespace Functional
{
	public partial class FunctionalRevision3Page : ContentPage
	{
		public FunctionalRevision3Page()
		{
			this.BindingContext = new FunctionalRevision3ViewModel();
			InitializeComponent();			
		}

	}
}
