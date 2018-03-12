using Xamarin.Forms;

namespace Functional
{
	public partial class FunctionalRevision2Page : ContentPage
	{
		public FunctionalRevision2Page()
		{
			this.BindingContext = new FunctionalRevision2ViewModel();
			// This calls the FSharp version
			//this.BindingContext = new FunctionalFSharp.FunctionalFSharpViewModel();
			InitializeComponent();			
		}

	}
}
