using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Functional
{
	public class MvvmViewModel : BaseViewModel
	{
		string _labelValue;
		public string LabelValue
		{
			get => _labelValue;
			set => SetProperty(ref _labelValue, value);
		}

		string _randomEntry;
		public string RandomEntry
		{
			get => _randomEntry;
			set => SetProperty(ref _randomEntry, value);
		}

		string _otherEntry;
		public string OtherEntry
		{
			get => _otherEntry;
			set => SetProperty(ref _otherEntry, value);
		}

		public Command UpdateCommand => new Command(() =>
		{
			LabelValue = PureFunction(RandomEntry, OtherEntry);
		});

		string PureFunction(string firstName, string lastName)
		{
			return $"{firstName} {lastName}";
		}
	}




	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name = "")
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


		public void SetProperty<T>(ref T reference, T value, [CallerMemberName]string propertyName = "")
		{
			reference = value;
			OnPropertyChanged(propertyName);
		}

	}

}
