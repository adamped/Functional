using Functional.Base;

namespace Functional
{
	public class MainViewModel : BaseViewModel<VisualState, Controller> { }

	public class VisualState : BaseVisualState
	{
		string _labelValue;
		public string LabelValue {
			get => _labelValue;
			set => SetValue(ref _labelValue, value);
		}
	}

	public class Controller : BaseController<VisualState>
	{
		public override void Initialize()
		{
			VisualState.LabelValue = "Hello";
		}
	}

}
