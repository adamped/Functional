namespace Functional.Base
{
	public abstract class BaseController<VisualStateType> where VisualStateType : BaseVisualState, new()
	{
		public readonly VisualStateType VisualState;
		public BaseController()
		{
			VisualState = new VisualStateType();
		}

		public abstract void Initialize();
    }
}
