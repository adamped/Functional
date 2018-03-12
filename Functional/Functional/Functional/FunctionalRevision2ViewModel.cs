using Functional.Base;
using Functional.Extensions;
using Xamarin.Forms;

namespace Functional
{
	public class FunctionalRevision2ViewModel : DefineViewModel<View, Controller> { }

	public class View : BaseViewState
	{
		public string LabelValue { get; set; }
	}

	public class Controller : BaseController
	{
		public Command<Data[]> UpdateCommand => new Command<Data[]>((data) =>
		{
			Push(new Request()
			{
				{ nameof(View.LabelValue), PureFunction(data[0].Value, data[1].Value) }
			});
		});

		string PureFunction(string firstString, string lastString)
		{
			return $"{firstString} {lastString}";
		}
	}

}
