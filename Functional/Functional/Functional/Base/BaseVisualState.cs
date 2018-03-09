using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Functional.Base
{
	public abstract class BaseVisualState
    {
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name = "")
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		public void SetValue<T>(ref T referenceValue, T newValue, [CallerMemberName]string name = "")
		{
			referenceValue = newValue;
			OnPropertyChanged(name);
		}

	}
}
