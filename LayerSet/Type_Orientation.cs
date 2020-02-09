//
// Type_Orientation.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class Type_Orientation : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_Orientation() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_Orientation(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_Orientation(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_Orientation(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region RotationX accessor methods
		public int GetRotationXMinCount()
		{
			return 1;
		}

		public int RotationXMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationXMaxCount()
		{
			return 1;
		}

		public int RotationXMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationXCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX");
		}

		public int RotationXCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX");
			}
		}

		public bool HasRotationX()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX");
		}

		public SchemaDecimal GetRotationXAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", index)));
		}

		public XmlNode GetStartingRotationXCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX" );
		}

		public XmlNode GetAdvancedRotationXCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", curNode );
		}

		public SchemaDecimal GetRotationXValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaDecimal( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaDecimal GetRotationX()
		{
			return this.SetSamplerState(0, SamplerStateGetRotationXAt(0);
		}

		public SchemaDecimal RotationX
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetRotationXAt(0);
			}
		}

		public void RemoveRotationXAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", index);
		}

		public void RemoveRotationX()
		{
			while (this.SetSamplerState(0, SamplerStateHasRotationX()) this.SetSamplerState(0, SamplerStateRemoveRotationXAt(0);
		}

		public void AddRotationX(SchemaDecimal newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertRotationXAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceRotationXAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationX", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // RotationX accessor methods

		#region RotationX collection
        public RotationXCollection	MyRotationXs = new RotationXCollection( );

        public class RotationXCollection: IEnumerable
        {
            Type_Orientation parent;
            public Type_Orientation Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public RotationXEnumerator GetEnumerator() 
			{
				return new RotationXEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class RotationXEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Orientation parent;
			public RotationXEnumerator(Type_Orientation par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateRotationXCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetRotationXAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // RotationX collection

		#region RotationY accessor methods
		public int GetRotationYMinCount()
		{
			return 1;
		}

		public int RotationYMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationYMaxCount()
		{
			return 1;
		}

		public int RotationYMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationYCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY");
		}

		public int RotationYCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY");
			}
		}

		public bool HasRotationY()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY");
		}

		public SchemaDecimal GetRotationYAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", index)));
		}

		public XmlNode GetStartingRotationYCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY" );
		}

		public XmlNode GetAdvancedRotationYCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", curNode );
		}

		public SchemaDecimal GetRotationYValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaDecimal( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaDecimal GetRotationY()
		{
			return this.SetSamplerState(0, SamplerStateGetRotationYAt(0);
		}

		public SchemaDecimal RotationY
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetRotationYAt(0);
			}
		}

		public void RemoveRotationYAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", index);
		}

		public void RemoveRotationY()
		{
			while (this.SetSamplerState(0, SamplerStateHasRotationY()) this.SetSamplerState(0, SamplerStateRemoveRotationYAt(0);
		}

		public void AddRotationY(SchemaDecimal newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertRotationYAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceRotationYAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationY", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // RotationY accessor methods

		#region RotationY collection
        public RotationYCollection	MyRotationYs = new RotationYCollection( );

        public class RotationYCollection: IEnumerable
        {
            Type_Orientation parent;
            public Type_Orientation Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public RotationYEnumerator GetEnumerator() 
			{
				return new RotationYEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class RotationYEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Orientation parent;
			public RotationYEnumerator(Type_Orientation par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateRotationYCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetRotationYAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // RotationY collection

		#region RotationZ accessor methods
		public int GetRotationZMinCount()
		{
			return 1;
		}

		public int RotationZMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationZMaxCount()
		{
			return 1;
		}

		public int RotationZMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRotationZCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ");
		}

		public int RotationZCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ");
			}
		}

		public bool HasRotationZ()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ");
		}

		public SchemaDecimal GetRotationZAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", index)));
		}

		public XmlNode GetStartingRotationZCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ" );
		}

		public XmlNode GetAdvancedRotationZCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", curNode );
		}

		public SchemaDecimal GetRotationZValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaDecimal( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaDecimal GetRotationZ()
		{
			return this.SetSamplerState(0, SamplerStateGetRotationZAt(0);
		}

		public SchemaDecimal RotationZ
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetRotationZAt(0);
			}
		}

		public void RemoveRotationZAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", index);
		}

		public void RemoveRotationZ()
		{
			while (this.SetSamplerState(0, SamplerStateHasRotationZ()) this.SetSamplerState(0, SamplerStateRemoveRotationZAt(0);
		}

		public void AddRotationZ(SchemaDecimal newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertRotationZAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceRotationZAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "RotationZ", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // RotationZ accessor methods

		#region RotationZ collection
        public RotationZCollection	MyRotationZs = new RotationZCollection( );

        public class RotationZCollection: IEnumerable
        {
            Type_Orientation parent;
            public Type_Orientation Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public RotationZEnumerator GetEnumerator() 
			{
				return new RotationZEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class RotationZEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Orientation parent;
			public RotationZEnumerator(Type_Orientation par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateRotationZCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetRotationZAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // RotationZ collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyRotationXs.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyRotationYs.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyRotationZs.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}