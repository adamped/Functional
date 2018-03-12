using Framework;
using Functional.Extensions;
using Xamarin.Forms;

namespace Functional
{
	public class FunctionalRevision3ViewModel : Framework.Base.BaseViewModel {
				
		public Command<Data[]> UpdateCommand => new Command<Data[]>((data) =>
		{
			var newValue = PureFunction(data[0].Value, data[1].Value);

			Push(("LabelValue", newValue));
		});

		string PureFunction(string firstString, string lastString)
		{
			return $"{firstString} {lastString}";
		}
	}

}
