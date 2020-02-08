//
// Type_ImageTileService2.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class Type_ImageTileService2 : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public Type_ImageTileService2() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ImageTileService2(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ImageTileService2(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public Type_ImageTileService2(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_SimpleTimeSpan2(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region ServerUrl accessor methods
		public int GetServerUrlMinCount()
		{
			return 1;
		}

		public int ServerUrlMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlMaxCount()
		{
			return 1;
		}

		public int ServerUrlMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl");
		}

		public int ServerUrlCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl");
			}
		}

		public bool HasServerUrl()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl");
		}

		public SchemaString GetServerUrlAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", index)));
		}

		public XmlNode GetStartingServerUrlCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl" );
		}

		public XmlNode GetAdvancedServerUrlCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", curNode );
		}

		public SchemaString GetServerUrlValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetServerUrl()
		{
			return this.SetSamplerState(0, SamplerStateGetServerUrlAt(0);
		}

		public SchemaString ServerUrl
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetServerUrlAt(0);
			}
		}

		public void RemoveServerUrlAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", index);
		}

		public void RemoveServerUrl()
		{
			while (this.SetSamplerState(0, SamplerStateHasServerUrl()) this.SetSamplerState(0, SamplerStateRemoveServerUrlAt(0);
		}

		public void AddServerUrl(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertServerUrlAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceServerUrlAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerUrl", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ServerUrl accessor methods

		#region ServerUrl collection
        public ServerUrlCollection	MyServerUrls = new ServerUrlCollection( );

        public class ServerUrlCollection: IEnumerable
        {
            Type_ImageTileService2 parent;
            public Type_ImageTileService2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ServerUrlEnumerator GetEnumerator() 
			{
				return new ServerUrlEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ServerUrlEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService2 parent;
			public ServerUrlEnumerator(Type_ImageTileService2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateServerUrlCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetServerUrlAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ServerUrl collection

		#region DataSetName accessor methods
		public int GetDataSetNameMinCount()
		{
			return 1;
		}

		public int DataSetNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataSetNameMaxCount()
		{
			return 1;
		}

		public int DataSetNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataSetNameCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName");
		}

		public int DataSetNameCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName");
			}
		}

		public bool HasDataSetName()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName");
		}

		public SchemaString GetDataSetNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", index)));
		}

		public XmlNode GetStartingDataSetNameCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName" );
		}

		public XmlNode GetAdvancedDataSetNameCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", curNode );
		}

		public SchemaString GetDataSetNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetDataSetName()
		{
			return this.SetSamplerState(0, SamplerStateGetDataSetNameAt(0);
		}

		public SchemaString DataSetName
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetDataSetNameAt(0);
			}
		}

		public void RemoveDataSetNameAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", index);
		}

		public void RemoveDataSetName()
		{
			while (this.SetSamplerState(0, SamplerStateHasDataSetName()) this.SetSamplerState(0, SamplerStateRemoveDataSetNameAt(0);
		}

		public void AddDataSetName(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertDataSetNameAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceDataSetNameAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "DataSetName", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // DataSetName accessor methods

		#region DataSetName collection
        public DataSetNameCollection	MyDataSetNames = new DataSetNameCollection( );

        public class DataSetNameCollection: IEnumerable
        {
            Type_ImageTileService2 parent;
            public Type_ImageTileService2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public DataSetNameEnumerator GetEnumerator() 
			{
				return new DataSetNameEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class DataSetNameEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService2 parent;
			public DataSetNameEnumerator(Type_ImageTileService2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateDataSetNameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetDataSetNameAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // DataSetName collection

		#region CacheExpirationTime accessor methods
		public int GetCacheExpirationTimeMinCount()
		{
			return 0;
		}

		public int CacheExpirationTimeMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetCacheExpirationTimeMaxCount()
		{
			return 1;
		}

		public int CacheExpirationTimeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCacheExpirationTimeCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime");
		}

		public int CacheExpirationTimeCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime");
			}
		}

		public bool HasCacheExpirationTime()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime");
		}

		public Type_SimpleTimeSpan2 GetCacheExpirationTimeAt(int index)
		{
			return new Type_SimpleTimeSpan2(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime", index));
		}

		public XmlNode GetStartingCacheExpirationTimeCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime" );
		}

		public XmlNode GetAdvancedCacheExpirationTimeCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime", curNode );
		}

		public Type_SimpleTimeSpan2 GetCacheExpirationTimeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new Type_SimpleTimeSpan2( curNode );
		}


		public Type_SimpleTimeSpan2 GetCacheExpirationTime()
		{
			return this.SetSamplerState(0, SamplerStateGetCacheExpirationTimeAt(0);
		}

		public Type_SimpleTimeSpan2 CacheExpirationTime
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetCacheExpirationTimeAt(0);
			}
		}

		public void RemoveCacheExpirationTimeAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "CacheExpirationTime", index);
		}

		public void RemoveCacheExpirationTime()
		{
			while (this.SetSamplerState(0, SamplerStateHasCacheExpirationTime()) this.SetSamplerState(0, SamplerStateRemoveCacheExpirationTimeAt(0);
		}

		public void AddCacheExpirationTime(Type_SimpleTimeSpan2 newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "CacheExpirationTime", newValue);
		}

		public void InsertCacheExpirationTimeAt(Type_SimpleTimeSpan2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "CacheExpirationTime", index, newValue);
		}

		public void ReplaceCacheExpirationTimeAt(Type_SimpleTimeSpan2 newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "CacheExpirationTime", index, newValue);
		}
		#endregion // CacheExpirationTime accessor methods

		#region CacheExpirationTime collection
        public CacheExpirationTimeCollection	MyCacheExpirationTimes = new CacheExpirationTimeCollection( );

        public class CacheExpirationTimeCollection: IEnumerable
        {
            Type_ImageTileService2 parent;
            public Type_ImageTileService2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public CacheExpirationTimeEnumerator GetEnumerator() 
			{
				return new CacheExpirationTimeEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class CacheExpirationTimeEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService2 parent;
			public CacheExpirationTimeEnumerator(Type_ImageTileService2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateCacheExpirationTimeCount );
			}
			public Type_SimpleTimeSpan2  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetCacheExpirationTimeAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // CacheExpirationTime collection

		#region ServerLogoFilePath accessor methods
		public int GetServerLogoFilePathMinCount()
		{
			return 0;
		}

		public int ServerLogoFilePathMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetServerLogoFilePathMaxCount()
		{
			return 1;
		}

		public int ServerLogoFilePathMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerLogoFilePathCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath");
		}

		public int ServerLogoFilePathCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath");
			}
		}

		public bool HasServerLogoFilePath()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath");
		}

		public SchemaString GetServerLogoFilePathAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", index)));
		}

		public XmlNode GetStartingServerLogoFilePathCursor()
		{
			return this.SetSamplerState(0, SamplerStateGetDomFirstChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath" );
		}

		public XmlNode GetAdvancedServerLogoFilePathCursor( XmlNode curNode )
		{
			return this.SetSamplerState(0, SamplerStateGetDomNextChild( NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", curNode );
		}

		public SchemaString GetServerLogoFilePathValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateXmlException("Out of range");
			else
				return new SchemaString( curNode.SetSamplerState(0, SamplerStateInnerText );
		}


		public SchemaString GetServerLogoFilePath()
		{
			return this.SetSamplerState(0, SamplerStateGetServerLogoFilePathAt(0);
		}

		public SchemaString ServerLogoFilePath
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetServerLogoFilePathAt(0);
			}
		}

		public void RemoveServerLogoFilePathAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", index);
		}

		public void RemoveServerLogoFilePath()
		{
			while (this.SetSamplerState(0, SamplerStateHasServerLogoFilePath()) this.SetSamplerState(0, SamplerStateRemoveServerLogoFilePathAt(0);
		}

		public void AddServerLogoFilePath(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertServerLogoFilePathAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceServerLogoFilePathAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ServerLogoFilePath", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ServerLogoFilePath accessor methods

		#region ServerLogoFilePath collection
        public ServerLogoFilePathCollection	MyServerLogoFilePaths = new ServerLogoFilePathCollection( );

        public class ServerLogoFilePathCollection: IEnumerable
        {
            Type_ImageTileService2 parent;
            public Type_ImageTileService2 Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ServerLogoFilePathEnumerator GetEnumerator() 
			{
				return new ServerLogoFilePathEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ServerLogoFilePathEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService2 parent;
			public ServerLogoFilePathEnumerator(Type_ImageTileService2 par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateServerLogoFilePathCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetServerLogoFilePathAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ServerLogoFilePath collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyServerUrls.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyDataSetNames.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyCacheExpirationTimes.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyServerLogoFilePaths.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
