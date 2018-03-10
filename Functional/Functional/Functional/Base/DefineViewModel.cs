namespace Functional.Base
{
	public abstract class DefineViewModel<ViewStateType, ControllerType> where ViewStateType : BaseViewState, new()
																	   where ControllerType : BaseController, new()
	{
		public ViewStateType View { get; private set; }
		public ControllerType Controller { get; private set; }

		public DefineViewModel()
		{
			View = new ViewStateType();
			Controller = new ControllerType();
			Controller.Init(View);
		}
	}
}
