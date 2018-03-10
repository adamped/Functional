namespace Functional.Base
{

	public interface IBaseViewModel
	{
		BaseController Controller
		{
			get;
		}
	}

	public abstract class DefineViewModel<ViewStateType, ControllerType> : IBaseViewModel where ViewStateType : BaseViewState, new()
																						  where ControllerType : BaseController, new()
	{
		public ViewStateType View { get; private set; }
		public ControllerType Controller { get; private set; }

		BaseController IBaseViewModel.Controller => Controller;

		public DefineViewModel()
		{
			View = new ViewStateType();
			Controller = new ControllerType();
			Controller.Init(View);
		}
	}
}
