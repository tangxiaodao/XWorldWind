//
// ValueType3.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LayerSet
{

	public class ValueType3 : SchemaDecimal
	{

		public ValueType3() : base()
		{
		}

		public ValueType3(string newValue) : base(newValue)
		{
            this.Validate();
		}

		public ValueType3(SchemaDecimal newValue) : base(newValue)
		{
            this.Validate();
		}

		public void Validate()
		{

			if (this.CompareTo(this.GetMinInclusive()) < 0)
				throw new System.Exception("Out of range");

			if (this.CompareTo(this.GetMaxInclusive()) > 0)
				throw new System.Exception("Out of range");
		}
		public SchemaDecimal GetMinInclusive()
		{
			return new SchemaDecimal("-90");
		}
		public SchemaDecimal GetMaxInclusive()
		{
			return new SchemaDecimal("90");
		}
	}
}
