using Functional.Extensions;
using System.ComponentModel;

namespace Functional.Base
{
	public abstract class BaseViewState: INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name = "")
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		object _lock = new object();
		public void Push(Request request)
		{
			lock (_lock)
				foreach (var update in request)
				{
					this.GetType().GetProperty(update.Key).SetValue(this, update.Value);
					OnPropertyChanged(update.Key);
				}
		}

	}
}
