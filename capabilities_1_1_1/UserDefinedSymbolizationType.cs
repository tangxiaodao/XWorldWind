//
// UserDefinedSymbolizationType.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class UserDefinedSymbolizationType : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public UserDefinedSymbolizationType() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public UserDefinedSymbolizationType(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public UserDefinedSymbolizationType(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public UserDefinedSymbolizationType(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region SupportSLD accessor methods
		public int GetSupportSLDMinCount()
		{
			return 0;
		}

		public int SupportSLDMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetSupportSLDMaxCount()
		{
			return 1;
		}

		public int SupportSLDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSupportSLDCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD");
		}

		public int SupportSLDCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD");
			}
		}

		public bool HasSupportSLD()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD");
		}

		public SchemaString GetSupportSLDAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", index)));
		}

		public SchemaString GetSupportSLD()
		{
			return this.SetSamplerState(0, SamplerStateGetSupportSLDAt(0);
		}

		public SchemaString SupportSLD
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetSupportSLDAt(0);
			}
		}

		public void RemoveSupportSLDAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", index);
		}

		public void RemoveSupportSLD()
		{
			while (this.SetSamplerState(0, SamplerStateHasSupportSLD()) this.SetSamplerState(0, SamplerStateRemoveSupportSLDAt(0);
		}

		public void AddSupportSLD(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertSupportSLDAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceSupportSLDAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "SupportSLD", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // SupportSLD accessor methods

		#region SupportSLD collection
        public SupportSLDCollection	MySupportSLDs = new SupportSLDCollection( );

        public class SupportSLDCollection: IEnumerable
        {
            UserDefinedSymbolizationType parent;
            public UserDefinedSymbolizationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public SupportSLDEnumerator GetEnumerator() 
			{
				return new SupportSLDEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class SupportSLDEnumerator: IEnumerator 
        {
			int nIndex;
			UserDefinedSymbolizationType parent;
			public SupportSLDEnumerator(UserDefinedSymbolizationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateSupportSLDCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetSupportSLDAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // SupportSLD collection

		#region UserLayer accessor methods
		public int GetUserLayerMinCount()
		{
			return 0;
		}

		public int UserLayerMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetUserLayerMaxCount()
		{
			return 1;
		}

		public int UserLayerMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUserLayerCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer");
		}

		public int UserLayerCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer");
			}
		}

		public bool HasUserLayer()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer");
		}

		public SchemaString GetUserLayerAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", index)));
		}

		public SchemaString GetUserLayer()
		{
			return this.SetSamplerState(0, SamplerStateGetUserLayerAt(0);
		}

		public SchemaString UserLayer
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetUserLayerAt(0);
			}
		}

		public void RemoveUserLayerAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", index);
		}

		public void RemoveUserLayer()
		{
			while (this.SetSamplerState(0, SamplerStateHasUserLayer()) this.SetSamplerState(0, SamplerStateRemoveUserLayerAt(0);
		}

		public void AddUserLayer(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertUserLayerAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceUserLayerAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserLayer", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // UserLayer accessor methods

		#region UserLayer collection
        public UserLayerCollection	MyUserLayers = new UserLayerCollection( );

        public class UserLayerCollection: IEnumerable
        {
            UserDefinedSymbolizationType parent;
            public UserDefinedSymbolizationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public UserLayerEnumerator GetEnumerator() 
			{
				return new UserLayerEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class UserLayerEnumerator: IEnumerator 
        {
			int nIndex;
			UserDefinedSymbolizationType parent;
			public UserLayerEnumerator(UserDefinedSymbolizationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateUserLayerCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetUserLayerAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // UserLayer collection

		#region UserStyle accessor methods
		public int GetUserStyleMinCount()
		{
			return 0;
		}

		public int UserStyleMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetUserStyleMaxCount()
		{
			return 1;
		}

		public int UserStyleMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUserStyleCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle");
		}

		public int UserStyleCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle");
			}
		}

		public bool HasUserStyle()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle");
		}

		public SchemaString GetUserStyleAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", index)));
		}

		public SchemaString GetUserStyle()
		{
			return this.SetSamplerState(0, SamplerStateGetUserStyleAt(0);
		}

		public SchemaString UserStyle
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetUserStyleAt(0);
			}
		}

		public void RemoveUserStyleAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", index);
		}

		public void RemoveUserStyle()
		{
			while (this.SetSamplerState(0, SamplerStateHasUserStyle()) this.SetSamplerState(0, SamplerStateRemoveUserStyleAt(0);
		}

		public void AddUserStyle(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertUserStyleAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceUserStyleAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "UserStyle", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // UserStyle accessor methods

		#region UserStyle collection
        public UserStyleCollection	MyUserStyles = new UserStyleCollection( );

        public class UserStyleCollection: IEnumerable
        {
            UserDefinedSymbolizationType parent;
            public UserDefinedSymbolizationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public UserStyleEnumerator GetEnumerator() 
			{
				return new UserStyleEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class UserStyleEnumerator: IEnumerator 
        {
			int nIndex;
			UserDefinedSymbolizationType parent;
			public UserStyleEnumerator(UserDefinedSymbolizationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateUserStyleCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetUserStyleAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // UserStyle collection

		#region RemoteWFS accessor methods
		public int GetRemoteWFSMinCount()
		{
			return 0;
		}

		public int RemoteWFSMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetRemoteWFSMaxCount()
		{
			return 1;
		}

		public int RemoteWFSMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRemoteWFSCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS");
		}

		public int RemoteWFSCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS");
			}
		}

		public bool HasRemoteWFS()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS");
		}

		public SchemaString GetRemoteWFSAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", index)));
		}

		public SchemaString GetRemoteWFS()
		{
			return this.SetSamplerState(0, SamplerStateGetRemoteWFSAt(0);
		}

		public SchemaString RemoteWFS
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetRemoteWFSAt(0);
			}
		}

		public void RemoveRemoteWFSAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", index);
		}

		public void RemoveRemoteWFS()
		{
			while (this.SetSamplerState(0, SamplerStateHasRemoteWFS()) this.SetSamplerState(0, SamplerStateRemoveRemoteWFSAt(0);
		}

		public void AddRemoteWFS(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertRemoteWFSAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceRemoteWFSAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "RemoteWFS", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // RemoteWFS accessor methods

		#region RemoteWFS collection
        public RemoteWFSCollection	MyRemoteWFSs = new RemoteWFSCollection( );

        public class RemoteWFSCollection: IEnumerable
        {
            UserDefinedSymbolizationType parent;
            public UserDefinedSymbolizationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public RemoteWFSEnumerator GetEnumerator() 
			{
				return new RemoteWFSEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class RemoteWFSEnumerator: IEnumerator 
        {
			int nIndex;
			UserDefinedSymbolizationType parent;
			public RemoteWFSEnumerator(UserDefinedSymbolizationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateRemoteWFSCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetRemoteWFSAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // RemoteWFS collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMySupportSLDs.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyUserLayers.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyUserStyles.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyRemoteWFSs.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}