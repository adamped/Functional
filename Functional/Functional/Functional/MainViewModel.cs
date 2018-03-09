using Functional.Base;
using Functional.Extensions;
using Xamarin.Forms;

namespace Functional
{
	public class MainViewModel : BaseViewModel<VisualPush, Controller> { }

	public class VisualPush : BaseVisualPush
	{
		public string LabelValue { get; private set; }
	}

	public class Controller : BaseController<VisualPush>
	{
		public Command<string> UpdateCommand => new Command<string>((text) =>
		{
			var stateChange = ((nameof(VisualPush.LabelValue), text));

			VisualPush.Send(stateChange);
		});
	}

}
