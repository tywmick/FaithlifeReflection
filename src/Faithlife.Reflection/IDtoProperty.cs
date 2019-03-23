using System;
using System.Reflection;

namespace Faithlife.Reflection
{
	/// <summary>
	/// Represents a property or field of a DTO.
	/// </summary>
	public interface IDtoProperty
	{
		/// <summary>
		/// The name of the property or field.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The value type of the property or field.
		/// </summary>
		Type ValueType { get; }

		/// <summary>
		/// True if the property or field is read-only.
		/// </summary>
		bool IsReadOnly { get; }

		/// <summary>
		/// The <see cref="PropertyInfo"/> or <see cref="FieldInfo"/> of the property or field.
		/// </summary>
		MemberInfo MemberInfo { get; }

		/// <summary>
		/// Gets the value of the property or field for the specified instance of the DTO.
		/// </summary>
		/// <param name="source">The DTO instance.</param>
		object GetValue(object source);

		/// <summary>
		/// Sets the value of the property or field for the specified instance of the DTO.
		/// </summary>
		/// <param name="source">The DTO instance.</param>
		/// <param name="value">The value to which to set the property or field.</param>
		/// <exception cref="InvalidOperationException">The property or field is read-only.</exception>
		void SetValue(object source, object value);
	}

	/// <summary>
	/// Represents a property or field of a DTO.
	/// </summary>
	/// <typeparam name="T">The type of DTO.</typeparam>
	public interface IDtoProperty<in T> : IDtoProperty
	{
		/// <summary>
		/// Gets the value of the property or field for the specified instance of the DTO.
		/// </summary>
		/// <param name="source">The DTO instance.</param>
		object GetValue(T source);

		/// <summary>
		/// Sets the value of the property or field for the specified instance of the DTO.
		/// </summary>
		/// <param name="source">The DTO instance.</param>
		/// <param name="value">The value to which to set the property or field.</param>
		/// <exception cref="InvalidOperationException">The property or field is read-only.</exception>
		void SetValue(T source, object value);
	}
}
