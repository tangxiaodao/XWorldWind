//
// Type_DisplayFont2.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class Type_DisplayFont2 : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_DisplayFont2() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_DisplayFont2(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_DisplayFont2(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_DisplayFont2(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style", i);
				InternalAdjustPrefix(DOMNode, true);
				new StyleType2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}
		}


		#region Family accessor methods
		public int GetFamilyMinCount()
		{
			return 1;
		}

		public int FamilyMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFamilyMaxCount()
		{
			return 1;
		}

		public int FamilyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFamilyCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family");
		}

		public int FamilyCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family");
			}
		}

		public bool HasFamily()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family");
		}

		public SchemaString GetFamilyAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", index)));
		}

		public XmlNode GetStartingFamilyCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Family" );
		}

		public XmlNode GetAdvancedFamilyCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", curNode );
		}

		public SchemaString GetFamilyValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetFamily()
		{
			return this.SetSamplerState(0, SamplerStateGetFamilyAt(0);
		}

		public SchemaString Family
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetFamilyAt(0);
			}
		}

		public void RemoveFamilyAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", index);
		}

		public void RemoveFamily()
		{
			while (this.SetSamplerState(0, SamplerStateHasFamily()) this.SetSamplerState(0, SamplerStateRemoveFamilyAt(0);
		}

		public void AddFamily(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertFamilyAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceFamilyAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Family", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // Family accessor methods

		#region Family collection
        public FamilyCollection	MyFamilys = new FamilyCollection( );

        public class FamilyCollection: IEnumerable
        {
            Type_DisplayFont2 parent;
            public Type_DisplayFont2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public FamilyEnumerator GetEnumerator() 
			{
				return new FamilyEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class FamilyEnumerator: IEnumerator 
        {
			int nIndex;
			Type_DisplayFont2 parent;
			public FamilyEnumerator(Type_DisplayFont2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateFamilyCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetFamilyAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // Family collection

		#region Size accessor methods
		public int GetSizeMinCount()
		{
			return 1;
		}

		public int SizeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSizeMaxCount()
		{
			return 1;
		}

		public int SizeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSizeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size");
		}

		public int SizeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size");
			}
		}

		public bool HasSize()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size");
		}

		public SchemaDecimal GetSizeAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", index)));
		}

		public XmlNode GetStartingSizeCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Size" );
		}

		public XmlNode GetAdvancedSizeCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", curNode );
		}

		public SchemaDecimal GetSizeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaDecimal( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaDecimal GetSize()
		{
			return this.SetSamplerState(0, SamplerStateGetSizeAt(0);
		}

		public SchemaDecimal Size
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetSizeAt(0);
			}
		}

		public void RemoveSizeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", index);
		}

		public void RemoveSize()
		{
			while (this.SetSamplerState(0, SamplerStateHasSize()) this.SetSamplerState(0, SamplerStateRemoveSizeAt(0);
		}

		public void AddSize(SchemaDecimal newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertSizeAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceSizeAt(SchemaDecimal newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Size", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // Size accessor methods

		#region Size collection
        public SizeCollection	MySizes = new SizeCollection( );

        public class SizeCollection: IEnumerable
        {
            Type_DisplayFont2 parent;
            public Type_DisplayFont2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public SizeEnumerator GetEnumerator() 
			{
				return new SizeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class SizeEnumerator: IEnumerator 
        {
			int nIndex;
			Type_DisplayFont2 parent;
			public SizeEnumerator(Type_DisplayFont2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateSizeCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetSizeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // Size collection

		#region Style accessor methods
		public int GetStyleMinCount()
		{
			return 0;
		}

		public int StyleMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetStyleMaxCount()
		{
			return 1;
		}

		public int StyleMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetStyleCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style");
		}

		public int StyleCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style");
			}
		}

		public bool HasStyle()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style");
		}

		public StyleType2 GetStyleAt(int index)
		{
			return new StyleType2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style", index));
		}

		public XmlNode GetStartingStyleCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Style" );
		}

		public XmlNode GetAdvancedStyleCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Style", curNode );
		}

		public StyleType2 GetStyleValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new StyleType2( curNode );
		}


		public StyleType2 GetStyle()
		{
			return this.SetSamplerState(0, SamplerStateGetStyleAt(0);
		}

		public StyleType2 Style
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetStyleAt(0);
			}
		}

		public void RemoveStyleAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Style", index);
		}

		public void RemoveStyle()
		{
			while (this.SetSamplerState(0, SamplerStateHasStyle()) this.SetSamplerState(0, SamplerStateRemoveStyleAt(0);
		}

		public void AddStyle(StyleType2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "Style", newValue);
		}

		public void InsertStyleAt(StyleType2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "Style", index, newValue);
		}

		public void ReplaceStyleAt(StyleType2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "Style", index, newValue);
		}
		#endregion // Style accessor methods

		#region Style collection
        public StyleCollection	MyStyles = new StyleCollection( );

        public class StyleCollection: IEnumerable
        {
            Type_DisplayFont2 parent;
            public Type_DisplayFont2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public StyleEnumerator GetEnumerator() 
			{
				return new StyleEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class StyleEnumerator: IEnumerator 
        {
			int nIndex;
			Type_DisplayFont2 parent;
			public StyleEnumerator(Type_DisplayFont2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateStyleCount );
			}
			public StyleType2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetStyleAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // Style collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyFamilys.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMySizes.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyStyles.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
