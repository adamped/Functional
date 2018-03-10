using Functional.Extensions;

namespace Functional.Base
{
	public abstract class BaseController
	{
		BaseViewState ViewState;
		public void Init(BaseViewState viewState) => ViewState = viewState;

		public void Push(Request request) =>
			ViewState.Push(request);

    }
}
