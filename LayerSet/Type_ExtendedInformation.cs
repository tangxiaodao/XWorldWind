//
// Type_ExtendedInformation.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class Type_ExtendedInformation : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_ExtendedInformation() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ExtendedInformation(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ExtendedInformation(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ExtendedInformation(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Abstract2 accessor methods
		public int GetAbstract2MinCount()
		{
			return 0;
		}

		public int Abstract2MinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetAbstract2MaxCount()
		{
			return 1;
		}

		public int Abstract2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetAbstract2Count()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract");
		}

		public int Abstract2Count
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract");
			}
		}

		public bool HasAbstract2()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract");
		}

		public SchemaString GetAbstract2At(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", index)));
		}

		public XmlNode GetStartingAbstract2Cursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract" );
		}

		public XmlNode GetAdvancedAbstract2Cursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", curNode );
		}

		public SchemaString GetAbstract2ValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetAbstract2()
		{
			return this.SetSamplerState(0, SamplerStateGetAbstract2At(0);
		}

		public SchemaString Abstract2
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetAbstract2At(0);
			}
		}

		public void RemoveAbstract2At(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", index);
		}

		public void RemoveAbstract2()
		{
			while (this.SetSamplerState(0, SamplerStateHasAbstract2()) this.SetSamplerState(0, SamplerStateRemoveAbstract2At(0);
		}

		public void AddAbstract2(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertAbstract2At(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceAbstract2At(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "Abstract", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // Abstract2 accessor methods

		#region Abstract2 collection
        public Abstract2Collection	MyAbstract2s = new Abstract2Collection( );

        public class Abstract2Collection: IEnumerable
        {
            Type_ExtendedInformation parent;
            public Type_ExtendedInformation Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public Abstract2Enumerator GetEnumerator() 
			{
				return new Abstract2Enumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class Abstract2Enumerator: IEnumerator 
        {
			int nIndex;
			Type_ExtendedInformation parent;
			public Abstract2Enumerator(Type_ExtendedInformation par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateAbstract2Count );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetAbstract2At(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // Abstract2 collection

		#region ToolBarImage accessor methods
		public int GetToolBarImageMinCount()
		{
			return 0;
		}

		public int ToolBarImageMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetToolBarImageMaxCount()
		{
			return 1;
		}

		public int ToolBarImageMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetToolBarImageCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage");
		}

		public int ToolBarImageCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage");
			}
		}

		public bool HasToolBarImage()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage");
		}

		public SchemaString GetToolBarImageAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", index)));
		}

		public XmlNode GetStartingToolBarImageCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage" );
		}

		public XmlNode GetAdvancedToolBarImageCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", curNode );
		}

		public SchemaString GetToolBarImageValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetToolBarImage()
		{
			return this.SetSamplerState(0, SamplerStateGetToolBarImageAt(0);
		}

		public SchemaString ToolBarImage
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetToolBarImageAt(0);
			}
		}

		public void RemoveToolBarImageAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", index);
		}

		public void RemoveToolBarImage()
		{
			while (this.SetSamplerState(0, SamplerStateHasToolBarImage()) this.SetSamplerState(0, SamplerStateRemoveToolBarImageAt(0);
		}

		public void AddToolBarImage(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertToolBarImageAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceToolBarImageAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ToolBarImage", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ToolBarImage accessor methods

		#region ToolBarImage collection
        public ToolBarImageCollection	MyToolBarImages = new ToolBarImageCollection( );

        public class ToolBarImageCollection: IEnumerable
        {
            Type_ExtendedInformation parent;
            public Type_ExtendedInformation Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ToolBarImageEnumerator GetEnumerator() 
			{
				return new ToolBarImageEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ToolBarImageEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ExtendedInformation parent;
			public ToolBarImageEnumerator(Type_ExtendedInformation par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateToolBarImageCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetToolBarImageAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ToolBarImage collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyAbstract2s.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyToolBarImages.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}