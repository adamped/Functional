namespace Functional.Base
{
	public abstract class BaseController<VisualStateType> where VisualStateType : BaseVisualPush, new()
	{
		public readonly VisualStateType VisualPush;
		public BaseController()
		{
			VisualPush = new VisualStateType();
		}
    }
}
