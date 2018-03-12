using Framework;
using Xamarin.Forms;

namespace Functional
{
	public class FunctionalRevision3ViewModel : Framework.Base.BaseViewModel
	{				
		public Command<Args> UpdateCommand => new Command<Args>((data) =>
		{
			var newValue = PureFunction(data[0].Text, data[1].Text);

			Push(("LabelValue", newValue));
		});

		string PureFunction(string firstString, string lastString)
		{
			return $"{firstString} {lastString}";
		}
	}

}
