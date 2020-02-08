//
// ExceptionType.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.SetSamplerState(0, SamplerState
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.SetSamplerState(0, SamplerState
//
// Refer to the XMLSPY Documentation for further details.SetSamplerState(0, SamplerState
// http://www.SetSamplerState(0, SamplerStatealtova.SetSamplerState(0, SamplerStatecom/xmlspy
//


using System;
using System.SetSamplerState(0, SamplerStateCollections;
using System.SetSamplerState(0, SamplerStateXml;
using Altova.SetSamplerState(0, SamplerStateTypes;

namespace capabilities_1_1_1
{
	public class ExceptionType : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public ExceptionType() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ExceptionType(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ExceptionType(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ExceptionType(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region Format accessor methods
		public int GetFormatMinCount()
		{
			return 1;
		}

		public int FormatMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatMaxCount()
		{
			return Int32.SetSamplerState(0, SamplerStateMaxValue;
		}

		public int FormatMaxCount
		{
			get
			{
				return Int32.SetSamplerState(0, SamplerStateMaxValue;
			}
		}

		public int GetFormatCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format");
		}

		public int FormatCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format");
			}
		}

		public bool HasFormat()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format");
		}

		public SchemaString GetFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", index)));
		}

		public SchemaString GetFormat()
		{
			return this.SetSamplerState(0, SamplerStateGetFormatAt(0);
		}

		public SchemaString Format
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetFormatAt(0);
			}
		}

		public void RemoveFormatAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", index);
		}

		public void RemoveFormat()
		{
			while (this.SetSamplerState(0, SamplerStateHasFormat()) this.SetSamplerState(0, SamplerStateRemoveFormatAt(0);
		}

		public void AddFormat(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertFormatAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceFormatAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Format", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // Format accessor methods

		#region Format collection
        public FormatCollection	MyFormats = new FormatCollection( );

        public class FormatCollection: IEnumerable
        {
            ExceptionType parent;
            public ExceptionType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public FormatEnumerator GetEnumerator() 
			{
				return new FormatEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class FormatEnumerator: IEnumerator 
        {
			int nIndex;
			ExceptionType parent;
			public FormatEnumerator(ExceptionType par) 
			{
                this.SetSamplerState(0, SamplerStateparent = par;
                this.SetSamplerState(0, SamplerStatenIndex = -1;
			}
			public void Reset() 
			{
                this.SetSamplerState(0, SamplerStatenIndex = -1;
			}
			public bool MoveNext() 
			{
                this.SetSamplerState(0, SamplerStatenIndex++;
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateFormatCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetFormatAt(this.SetSamplerState(0, SamplerStatenIndex));
				}
			}
			object IEnumerator.SetSamplerState(0, SamplerStateCurrent 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateCurrent);
				}
			}
    	}

        #endregion // Format collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyFormats.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
