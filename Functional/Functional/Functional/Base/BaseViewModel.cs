namespace Functional.Base
{
	public abstract class BaseViewModel<VisualStateType, ControllerType> where VisualStateType : BaseVisualState, new()
																		 where ControllerType : BaseController<VisualStateType>, new()
	{
		public VisualStateType VisualState { get; private set; }
		public ControllerType Controller { get; private set; }

		public BaseViewModel()
		{
			Controller = new ControllerType();
			VisualState = Controller.VisualState;
		}
	}
}
