using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Framework
{

	public interface IProperty {

		object GetValue();
		string PropertyName { get; }
	}

	public struct Definition<T>: IProperty
	{
		public T Value { get; set; }
		public string PropertyName { get; set; }

		public static Definition<T> New(string propertyName, T value)
		{
			return new Definition<T>()
			{
				Value = value,
				PropertyName = propertyName
			};

			
		}


		object IProperty.GetValue() => Value;
	}
}
