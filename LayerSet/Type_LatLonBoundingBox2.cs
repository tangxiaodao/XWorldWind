//
// Type_LatLonBoundingBox2.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class Type_LatLonBoundingBox2 : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_LatLonBoundingBox2() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatLonBoundingBox2(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatLonBoundingBox2(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_LatLonBoundingBox2(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "North"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "North", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LatitudeCoordinate2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "South"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "South", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LatitudeCoordinate2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "West"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "West", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LongitudeCoordinate2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "East"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "East", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LongitudeCoordinate2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}
		}


		#region North accessor methods
		public int GetNorthMinCount()
		{
			return 1;
		}

		public int NorthMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNorthMaxCount()
		{
			return 1;
		}

		public int NorthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNorthCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "North");
		}

		public int NorthCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "North");
			}
		}

		public bool HasNorth()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "North");
		}

		public Type_LatitudeCoordinate2 GetNorthAt(int index)
		{
			return new Type_LatitudeCoordinate2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "North", index));
		}

		public XmlNode GetStartingNorthCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "North" );
		}

		public XmlNode GetAdvancedNorthCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "North", curNode );
		}

		public Type_LatitudeCoordinate2 GetNorthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new Type_LatitudeCoordinate2( curNode );
		}


		public Type_LatitudeCoordinate2 GetNorth()
		{
			return this.SetSamplerState(0, SamplerStateGetNorthAt(0);
		}

		public Type_LatitudeCoordinate2 North
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetNorthAt(0);
			}
		}

		public void RemoveNorthAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "North", index);
		}

		public void RemoveNorth()
		{
			while (this.SetSamplerState(0, SamplerStateHasNorth()) this.SetSamplerState(0, SamplerStateRemoveNorthAt(0);
		}

		public void AddNorth(Type_LatitudeCoordinate2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "North", newValue);
		}

		public void InsertNorthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "North", index, newValue);
		}

		public void ReplaceNorthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "North", index, newValue);
		}
		#endregion // North accessor methods

		#region North collection
        public NorthCollection	MyNorths = new NorthCollection( );

        public class NorthCollection: IEnumerable
        {
            Type_LatLonBoundingBox2 parent;
            public Type_LatLonBoundingBox2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public NorthEnumerator GetEnumerator() 
			{
				return new NorthEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class NorthEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox2 parent;
			public NorthEnumerator(Type_LatLonBoundingBox2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateNorthCount );
			}
			public Type_LatitudeCoordinate2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetNorthAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // North collection

		#region South accessor methods
		public int GetSouthMinCount()
		{
			return 1;
		}

		public int SouthMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSouthMaxCount()
		{
			return 1;
		}

		public int SouthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSouthCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "South");
		}

		public int SouthCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "South");
			}
		}

		public bool HasSouth()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "South");
		}

		public Type_LatitudeCoordinate2 GetSouthAt(int index)
		{
			return new Type_LatitudeCoordinate2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "South", index));
		}

		public XmlNode GetStartingSouthCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "South" );
		}

		public XmlNode GetAdvancedSouthCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "South", curNode );
		}

		public Type_LatitudeCoordinate2 GetSouthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new Type_LatitudeCoordinate2( curNode );
		}


		public Type_LatitudeCoordinate2 GetSouth()
		{
			return this.SetSamplerState(0, SamplerStateGetSouthAt(0);
		}

		public Type_LatitudeCoordinate2 South
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetSouthAt(0);
			}
		}

		public void RemoveSouthAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "South", index);
		}

		public void RemoveSouth()
		{
			while (this.SetSamplerState(0, SamplerStateHasSouth()) this.SetSamplerState(0, SamplerStateRemoveSouthAt(0);
		}

		public void AddSouth(Type_LatitudeCoordinate2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "South", newValue);
		}

		public void InsertSouthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "South", index, newValue);
		}

		public void ReplaceSouthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "South", index, newValue);
		}
		#endregion // South accessor methods

		#region South collection
        public SouthCollection	MySouths = new SouthCollection( );

        public class SouthCollection: IEnumerable
        {
            Type_LatLonBoundingBox2 parent;
            public Type_LatLonBoundingBox2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public SouthEnumerator GetEnumerator() 
			{
				return new SouthEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class SouthEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox2 parent;
			public SouthEnumerator(Type_LatLonBoundingBox2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateSouthCount );
			}
			public Type_LatitudeCoordinate2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetSouthAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // South collection

		#region West accessor methods
		public int GetWestMinCount()
		{
			return 1;
		}

		public int WestMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetWestMaxCount()
		{
			return 1;
		}

		public int WestMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetWestCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "West");
		}

		public int WestCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "West");
			}
		}

		public bool HasWest()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "West");
		}

		public Type_LongitudeCoordinate2 GetWestAt(int index)
		{
			return new Type_LongitudeCoordinate2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "West", index));
		}

		public XmlNode GetStartingWestCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "West" );
		}

		public XmlNode GetAdvancedWestCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "West", curNode );
		}

		public Type_LongitudeCoordinate2 GetWestValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new Type_LongitudeCoordinate2( curNode );
		}


		public Type_LongitudeCoordinate2 GetWest()
		{
			return this.SetSamplerState(0, SamplerStateGetWestAt(0);
		}

		public Type_LongitudeCoordinate2 West
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetWestAt(0);
			}
		}

		public void RemoveWestAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "West", index);
		}

		public void RemoveWest()
		{
			while (this.SetSamplerState(0, SamplerStateHasWest()) this.SetSamplerState(0, SamplerStateRemoveWestAt(0);
		}

		public void AddWest(Type_LongitudeCoordinate2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "West", newValue);
		}

		public void InsertWestAt(Type_LongitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "West", index, newValue);
		}

		public void ReplaceWestAt(Type_LongitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "West", index, newValue);
		}
		#endregion // West accessor methods

		#region West collection
        public WestCollection	MyWests = new WestCollection( );

        public class WestCollection: IEnumerable
        {
            Type_LatLonBoundingBox2 parent;
            public Type_LatLonBoundingBox2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public WestEnumerator GetEnumerator() 
			{
				return new WestEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class WestEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox2 parent;
			public WestEnumerator(Type_LatLonBoundingBox2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateWestCount );
			}
			public Type_LongitudeCoordinate2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetWestAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // West collection

		#region East accessor methods
		public int GetEastMinCount()
		{
			return 1;
		}

		public int EastMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEastMaxCount()
		{
			return 1;
		}

		public int EastMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEastCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "East");
		}

		public int EastCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "East");
			}
		}

		public bool HasEast()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "East");
		}

		public Type_LongitudeCoordinate2 GetEastAt(int index)
		{
			return new Type_LongitudeCoordinate2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "East", index));
		}

		public XmlNode GetStartingEastCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "East" );
		}

		public XmlNode GetAdvancedEastCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "East", curNode );
		}

		public Type_LongitudeCoordinate2 GetEastValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new Type_LongitudeCoordinate2( curNode );
		}


		public Type_LongitudeCoordinate2 GetEast()
		{
			return this.SetSamplerState(0, SamplerStateGetEastAt(0);
		}

		public Type_LongitudeCoordinate2 East
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetEastAt(0);
			}
		}

		public void RemoveEastAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "East", index);
		}

		public void RemoveEast()
		{
			while (this.SetSamplerState(0, SamplerStateHasEast()) this.SetSamplerState(0, SamplerStateRemoveEastAt(0);
		}

		public void AddEast(Type_LongitudeCoordinate2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "East", newValue);
		}

		public void InsertEastAt(Type_LongitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "East", index, newValue);
		}

		public void ReplaceEastAt(Type_LongitudeCoordinate2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "East", index, newValue);
		}
		#endregion // East accessor methods

		#region East collection
        public EastCollection	MyEasts = new EastCollection( );

        public class EastCollection: IEnumerable
        {
            Type_LatLonBoundingBox2 parent;
            public Type_LatLonBoundingBox2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public EastEnumerator GetEnumerator() 
			{
				return new EastEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class EastEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox2 parent;
			public EastEnumerator(Type_LatLonBoundingBox2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateEastCount );
			}
			public Type_LongitudeCoordinate2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetEastAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // East collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyNorths.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMySouths.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyWests.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyEasts.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
