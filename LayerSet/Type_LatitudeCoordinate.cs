//
// Type_LatitudeCoordinate.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
using System.SetSamplerState(0, SamplerStateCollections;
using System.SetSamplerState(0, SamplerStateXml;
using Altova.SetSamplerState(0, SamplerStateTypes;

namespace LayerSet
{
	public class Type_LatitudeCoordinate : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_LatitudeCoordinate() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatitudeCoordinate(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatitudeCoordinate(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatitudeCoordinate(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Value2 accessor methods
		public int GetValue2MinCount()
		{
			return 1;
		}

		public int Value2MinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValue2MaxCount()
		{
			return 1;
		}

		public int Value2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValue2Count()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value");
		}

		public int Value2Count
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value");
			}
		}

		public bool HasValue2()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value");
		}

		public ValueType GetValue2At(int index)
		{
			return new ValueType(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", index)));
		}

		public XmlNode GetStartingValue2Cursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Value" );
		}

		public XmlNode GetAdvancedValue2Cursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", curNode );
		}

		public ValueType GetValue2ValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new ValueType( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public ValueType GetValue2()
		{
			return this.SetSamplerState(0, SamplerStateGetValue2At(0);
		}

		public ValueType Value2
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetValue2At(0);
			}
		}

		public void RemoveValue2At(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", index);
		}

		public void RemoveValue2()
		{
			while (this.SetSamplerState(0, SamplerStateHasValue2()) this.SetSamplerState(0, SamplerStateRemoveValue2At(0);
		}

		public void AddValue2(ValueType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertValue2At(ValueType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceValue2At(ValueType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Value", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // Value2 accessor methods

		#region Value2 collection
        public Value2Collection	MyValue2s = new Value2Collection( );

        public class Value2Collection: IEnumerable
        {
            Type_LatitudeCoordinate parent;
            public Type_LatitudeCoordinate Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public Value2Enumerator GetEnumerator() 
			{
				return new Value2Enumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class Value2Enumerator: IEnumerator 
        {
			int nIndex;
			Type_LatitudeCoordinate parent;
			public Value2Enumerator(Type_LatitudeCoordinate par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateValue2Count );
			}
			public ValueType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetValue2At(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // Value2 collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyValue2s.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
