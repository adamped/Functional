using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Framework.Base
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public class PropertyChangedValueEventArgs : PropertyChangedEventArgs
		{
			public object Value { get; set; }
			public PropertyChangedValueEventArgs(string name, object value) : base(name)
			{
				Value = value;
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name, object value)
			=> PropertyChanged?.Invoke(this, new PropertyChangedValueEventArgs(name, value));

		object _lock = new object();
		public void Push(params (string name, string value)[] properties)
		{
			lock (_lock)
				foreach (var expression in properties)
				{
				
					//this.GetType().GetProperty(property.PropertyName).SetValue(this, property.GetValue());
					OnPropertyChanged(expression.name, expression.value);
				}
		}
	}
}
