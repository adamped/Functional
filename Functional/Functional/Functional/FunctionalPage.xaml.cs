using Xamarin.Forms;

namespace Functional
{
	public partial class FunctionalPage : ContentPage
	{
		public FunctionalPage()
		{
			this.BindingContext = new FunctionalViewModel();
			// This calls the FSharp version
			//this.BindingContext = new FunctionalFSharp.FunctionalFSharpViewModel();
			InitializeComponent();			
		}

	}
}
