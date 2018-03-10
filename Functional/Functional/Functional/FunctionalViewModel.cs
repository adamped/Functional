using Functional.Base;
using Functional.Extensions;
using Xamarin.Forms;

namespace Functional
{
	public class FunctionalViewModel : DefineViewModel<ViewState, Controller> { }

	public class ViewState : BaseViewState
	{
		public string LabelValue { get; set; }
	}

	public class Controller : BaseController
	{
		public Command<Data[]> UpdateCommand => new Command<Data[]>((data) =>
		{
			var request = new Request()
			{
				{ nameof(ViewState.LabelValue), PureFunction(data[0].Value, 
															 data[1].Value) }
			};

			Push(request);
		});
		
		string PureFunction(string firstString, string lastString)
		{
			return $"{firstString} {lastString}";
		}
	}

}
