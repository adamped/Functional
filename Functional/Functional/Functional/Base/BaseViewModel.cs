namespace Functional.Base
{
	public abstract class BaseViewModel<VisualPushType, ControllerType> where VisualPushType : BaseVisualPush, new()
																		 where ControllerType : BaseController<VisualPushType>, new()
	{
		public VisualPushType VisualPush { get; private set; }
		public ControllerType Controller { get; private set; }

		public BaseViewModel()
		{
			Controller = new ControllerType();
			VisualPush = Controller.VisualPush;
		}
	}
}
