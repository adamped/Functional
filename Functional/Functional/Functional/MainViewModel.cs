using Functional.Base;
using Xamarin.Forms;

namespace Functional
{
	public class MainViewModel : BaseViewModel<VisualState, Controller> { }

	public class VisualState : BaseVisualState
	{
		public string LabelValue { get; private set; } = "Starting";
	}

	public class Controller : BaseController<VisualState>
	{
		public Command<string> UpdateCommand => new Command<string>((text) =>
		{
			VisualState.Assign(((nameof(VisualState.LabelValue), text)));
		});
	}

}
