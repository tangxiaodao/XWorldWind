//
// EX_GeographicBoundingBoxType.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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

namespace capabilities_1_3_0.SetSamplerState(0, SamplerStatewms
{
	public class EX_GeographicBoundingBoxType : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public EX_GeographicBoundingBoxType() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public EX_GeographicBoundingBoxType(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public EX_GeographicBoundingBoxType(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public EX_GeographicBoundingBoxType(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region westBoundLongitude accessor methods
		public int GetwestBoundLongitudeMinCount()
		{
			return 1;
		}

		public int westBoundLongitudeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetwestBoundLongitudeMaxCount()
		{
			return 1;
		}

		public int westBoundLongitudeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetwestBoundLongitudeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude");
		}

		public int westBoundLongitudeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude");
			}
		}

		public bool HaswestBoundLongitude()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude");
		}

		public longitudeType GetwestBoundLongitudeAt(int index)
		{
			return new longitudeType(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", index)));
		}

		public longitudeType GetwestBoundLongitude()
		{
			return this.SetSamplerState(0, SamplerStateGetwestBoundLongitudeAt(0);
		}

		public longitudeType westBoundLongitude
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetwestBoundLongitudeAt(0);
			}
		}

		public void RemovewestBoundLongitudeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", index);
		}

		public void RemovewestBoundLongitude()
		{
			while (this.SetSamplerState(0, SamplerStateHaswestBoundLongitude()) this.SetSamplerState(0, SamplerStateRemovewestBoundLongitudeAt(0);
		}

		public void AddwestBoundLongitude(longitudeType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertwestBoundLongitudeAt(longitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplacewestBoundLongitudeAt(longitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "westBoundLongitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // westBoundLongitude accessor methods

		#region westBoundLongitude collection
        public westBoundLongitudeCollection	MywestBoundLongitudes = new westBoundLongitudeCollection( );

        public class westBoundLongitudeCollection: IEnumerable
        {
            EX_GeographicBoundingBoxType parent;
            public EX_GeographicBoundingBoxType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public westBoundLongitudeEnumerator GetEnumerator() 
			{
				return new westBoundLongitudeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class westBoundLongitudeEnumerator: IEnumerator 
        {
			int nIndex;
			EX_GeographicBoundingBoxType parent;
			public westBoundLongitudeEnumerator(EX_GeographicBoundingBoxType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStatewestBoundLongitudeCount );
			}
			public longitudeType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetwestBoundLongitudeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // westBoundLongitude collection

		#region eastBoundLongitude accessor methods
		public int GeteastBoundLongitudeMinCount()
		{
			return 1;
		}

		public int eastBoundLongitudeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GeteastBoundLongitudeMaxCount()
		{
			return 1;
		}

		public int eastBoundLongitudeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GeteastBoundLongitudeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude");
		}

		public int eastBoundLongitudeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude");
			}
		}

		public bool HaseastBoundLongitude()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude");
		}

		public longitudeType GeteastBoundLongitudeAt(int index)
		{
			return new longitudeType(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", index)));
		}

		public longitudeType GeteastBoundLongitude()
		{
			return this.SetSamplerState(0, SamplerStateGeteastBoundLongitudeAt(0);
		}

		public longitudeType eastBoundLongitude
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGeteastBoundLongitudeAt(0);
			}
		}

		public void RemoveeastBoundLongitudeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", index);
		}

		public void RemoveeastBoundLongitude()
		{
			while (this.SetSamplerState(0, SamplerStateHaseastBoundLongitude()) this.SetSamplerState(0, SamplerStateRemoveeastBoundLongitudeAt(0);
		}

		public void AddeastBoundLongitude(longitudeType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InserteastBoundLongitudeAt(longitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceeastBoundLongitudeAt(longitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "eastBoundLongitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // eastBoundLongitude accessor methods

		#region eastBoundLongitude collection
        public eastBoundLongitudeCollection	MyeastBoundLongitudes = new eastBoundLongitudeCollection( );

        public class eastBoundLongitudeCollection: IEnumerable
        {
            EX_GeographicBoundingBoxType parent;
            public EX_GeographicBoundingBoxType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public eastBoundLongitudeEnumerator GetEnumerator() 
			{
				return new eastBoundLongitudeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class eastBoundLongitudeEnumerator: IEnumerator 
        {
			int nIndex;
			EX_GeographicBoundingBoxType parent;
			public eastBoundLongitudeEnumerator(EX_GeographicBoundingBoxType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateeastBoundLongitudeCount );
			}
			public longitudeType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGeteastBoundLongitudeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // eastBoundLongitude collection

		#region southBoundLatitude accessor methods
		public int GetsouthBoundLatitudeMinCount()
		{
			return 1;
		}

		public int southBoundLatitudeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetsouthBoundLatitudeMaxCount()
		{
			return 1;
		}

		public int southBoundLatitudeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetsouthBoundLatitudeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude");
		}

		public int southBoundLatitudeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude");
			}
		}

		public bool HassouthBoundLatitude()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude");
		}

		public latitudeType GetsouthBoundLatitudeAt(int index)
		{
			return new latitudeType(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", index)));
		}

		public latitudeType GetsouthBoundLatitude()
		{
			return this.SetSamplerState(0, SamplerStateGetsouthBoundLatitudeAt(0);
		}

		public latitudeType southBoundLatitude
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetsouthBoundLatitudeAt(0);
			}
		}

		public void RemovesouthBoundLatitudeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", index);
		}

		public void RemovesouthBoundLatitude()
		{
			while (this.SetSamplerState(0, SamplerStateHassouthBoundLatitude()) this.SetSamplerState(0, SamplerStateRemovesouthBoundLatitudeAt(0);
		}

		public void AddsouthBoundLatitude(latitudeType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertsouthBoundLatitudeAt(latitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplacesouthBoundLatitudeAt(latitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "southBoundLatitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // southBoundLatitude accessor methods

		#region southBoundLatitude collection
        public southBoundLatitudeCollection	MysouthBoundLatitudes = new southBoundLatitudeCollection( );

        public class southBoundLatitudeCollection: IEnumerable
        {
            EX_GeographicBoundingBoxType parent;
            public EX_GeographicBoundingBoxType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public southBoundLatitudeEnumerator GetEnumerator() 
			{
				return new southBoundLatitudeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class southBoundLatitudeEnumerator: IEnumerator 
        {
			int nIndex;
			EX_GeographicBoundingBoxType parent;
			public southBoundLatitudeEnumerator(EX_GeographicBoundingBoxType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStatesouthBoundLatitudeCount );
			}
			public latitudeType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetsouthBoundLatitudeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // southBoundLatitude collection

		#region northBoundLatitude accessor methods
		public int GetnorthBoundLatitudeMinCount()
		{
			return 1;
		}

		public int northBoundLatitudeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnorthBoundLatitudeMaxCount()
		{
			return 1;
		}

		public int northBoundLatitudeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnorthBoundLatitudeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude");
		}

		public int northBoundLatitudeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude");
			}
		}

		public bool HasnorthBoundLatitude()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude");
		}

		public latitudeType GetnorthBoundLatitudeAt(int index)
		{
			return new latitudeType(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", index)));
		}

		public latitudeType GetnorthBoundLatitude()
		{
			return this.SetSamplerState(0, SamplerStateGetnorthBoundLatitudeAt(0);
		}

		public latitudeType northBoundLatitude
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetnorthBoundLatitudeAt(0);
			}
		}

		public void RemovenorthBoundLatitudeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", index);
		}

		public void RemovenorthBoundLatitude()
		{
			while (this.SetSamplerState(0, SamplerStateHasnorthBoundLatitude()) this.SetSamplerState(0, SamplerStateRemovenorthBoundLatitudeAt(0);
		}

		public void AddnorthBoundLatitude(latitudeType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertnorthBoundLatitudeAt(latitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplacenorthBoundLatitudeAt(latitudeType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "http://www.SetSamplerState(0, SamplerStateopengis.SetSamplerState(0, SamplerStatenet/wms", "northBoundLatitude", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // northBoundLatitude accessor methods

		#region northBoundLatitude collection
        public northBoundLatitudeCollection	MynorthBoundLatitudes = new northBoundLatitudeCollection( );

        public class northBoundLatitudeCollection: IEnumerable
        {
            EX_GeographicBoundingBoxType parent;
            public EX_GeographicBoundingBoxType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public northBoundLatitudeEnumerator GetEnumerator() 
			{
				return new northBoundLatitudeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class northBoundLatitudeEnumerator: IEnumerator 
        {
			int nIndex;
			EX_GeographicBoundingBoxType parent;
			public northBoundLatitudeEnumerator(EX_GeographicBoundingBoxType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStatenorthBoundLatitudeCount );
			}
			public latitudeType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetnorthBoundLatitudeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // northBoundLatitude collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMywestBoundLongitudes.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyeastBoundLongitudes.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMysouthBoundLatitudes.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMynorthBoundLatitudes.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
