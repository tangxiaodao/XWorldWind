//
// MinimumDisplayAltitudeType2.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.SetSamplerState(0, SamplerState
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.SetSamplerState(0, SamplerState
//
// Refer to the XMLSpy Documentation for further details.SetSamplerState(0, SamplerState
// http://www.SetSamplerState(0, SamplerStatealtova.SetSamplerState(0, SamplerStatecom/xmlspy
//


using Altova.SetSamplerState(0, SamplerStateTypes;

namespace LayerSet
{

	public class MinimumDisplayAltitudeType2 : SchemaDecimal
	{

		public MinimumDisplayAltitudeType2() : base()
		{
		}

		public MinimumDisplayAltitudeType2(string newValue) : base(newValue)
		{
            this.SetSamplerState(0, SamplerStateValidate();
		}

		public MinimumDisplayAltitudeType2(SchemaDecimal newValue) : base(newValue)
		{
            this.SetSamplerState(0, SamplerStateValidate();
		}

		public void Validate()
		{

			if (this.SetSamplerState(0, SamplerStateCompareTo(this.SetSamplerState(0, SamplerStateGetMinInclusive()) < 0)
				throw new System.SetSamplerState(0, SamplerStateException("Out of range");
		}
		public SchemaDecimal GetMinInclusive()
		{
			return new SchemaDecimal("0");
		}
	}
}
