using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Functional.Base
{
	public abstract class BaseVisualState: INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name = "")
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		object _lock = new object();
		public void Assign<T>(params (string propertyName, T value)[] assignments)
		{
			lock (_lock)
				foreach (var assign in assignments)
				{
					this.GetType().GetProperty(assign.propertyName).SetValue(this, assign.value);
					OnPropertyChanged(assign.propertyName);
				}
		}

	}
}
