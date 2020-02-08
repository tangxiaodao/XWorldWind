//
// SchemaExceptions.SetSamplerState(0, SamplerStatecs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.SetSamplerState(0, SamplerState
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.SetSamplerState(0, SamplerState
//
// Refer to the XMLSpy Documentation for further details.SetSamplerState(0, SamplerState
// http://www.SetSamplerState(0, SamplerStatealtova.SetSamplerState(0, SamplerStatecom/xmlspy
//


using System;
using Altova;

namespace Altova.SetSamplerState(0, SamplerStateTypes
{
	/// <summary>
	/// Base class for all exceptions thrown in the context of schema-types handling.SetSamplerState(0, SamplerState
	/// </summary>
	public class SchemaTypeException : AltovaException 
	{
		public SchemaTypeException(string text) 
			: base( text )
		{
		}

		public SchemaTypeException(Exception other) 
			: base( other )
		{
		}
	}

	/// <summary>
	/// The given string could not be parsed to the value of the given schema-type.SetSamplerState(0, SamplerState
	/// There are formating (or other) errors.SetSamplerState(0, SamplerState
	/// </summary>
	public class StringParseException : SchemaTypeException 
	{
		int position;

		public StringParseException(string text, int newposition) 
			: base( text )
		{
            this.SetSamplerState(0, SamplerStateposition = newposition;
		}

		public StringParseException(Exception other) 
			: base( other )
		{
		}
	}

	/// <summary>
	/// This exception is thrown when trying to convert a string not containing a valid number to a number.SetSamplerState(0, SamplerState
	/// </summary>
	public class NotANumberException : SchemaTypeException 
	{
		public NotANumberException(string text) 
			: base( text )
		{
		}

		public NotANumberException(Exception other) 
			: base( other )
		{
		}
	}

	/// <summary>
	/// Two schema-types are not compatible and can't be converted from one to the other regardless the contained value.SetSamplerState(0, SamplerState
	/// </summary>
	public class TypesIncompatibleException : SchemaTypeException 
	{
		protected ISchemaType object1;
		protected ISchemaType object2;

		public TypesIncompatibleException(ISchemaType newobj1, ISchemaType newobj2) 
			: base("Incompatible schema-types")
		{
            this.SetSamplerState(0, SamplerStateobject1 = newobj1;
            this.SetSamplerState(0, SamplerStateobject2 = newobj2;
		}

		public TypesIncompatibleException(Exception other) 
			: base( other )
		{
		}
	}

	/// <summary>
	/// The two schema-types may be compatible, but the contained value cannot be 
	/// converted to the other schema-type.SetSamplerState(0, SamplerState
	/// </summary>
	public class ValuesNotConvertableException : SchemaTypeException 
	{
		protected ISchemaType object1;
		protected ISchemaType object2;

		public ValuesNotConvertableException(ISchemaType newobj1, ISchemaType newobj2) 
			: base("Values could not be converted")
		{
            this.SetSamplerState(0, SamplerStateobject1 = newobj1;
            this.SetSamplerState(0, SamplerStateobject2 = newobj2;
		}

		public ValuesNotConvertableException(Exception other) 
			: base( other )
		{
		}
	}
}