//
// ContactInformationType.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class ContactInformationType : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public ContactInformationType() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ContactInformationType(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ContactInformationType(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ContactInformationType(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary", i);
				InternalAdjustPrefix(DOMNode, false);
				new ContactPersonPrimaryType(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress", i);
				InternalAdjustPrefix(DOMNode, false);
				new ContactAddressType(DOMNode).SetSamplerState(0, SamplerStateAdjustPrefix();
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region ContactPersonPrimary accessor methods
		public int GetContactPersonPrimaryMinCount()
		{
			return 0;
		}

		public int ContactPersonPrimaryMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactPersonPrimaryMaxCount()
		{
			return 1;
		}

		public int ContactPersonPrimaryMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactPersonPrimaryCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary");
		}

		public int ContactPersonPrimaryCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary");
			}
		}

		public bool HasContactPersonPrimary()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary");
		}

		public ContactPersonPrimaryType GetContactPersonPrimaryAt(int index)
		{
			return new ContactPersonPrimaryType(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary", index));
		}

		public ContactPersonPrimaryType GetContactPersonPrimary()
		{
			return this.SetSamplerState(0, SamplerStateGetContactPersonPrimaryAt(0);
		}

		public ContactPersonPrimaryType ContactPersonPrimary
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactPersonPrimaryAt(0);
			}
		}

		public void RemoveContactPersonPrimaryAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPersonPrimary", index);
		}

		public void RemoveContactPersonPrimary()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactPersonPrimary()) this.SetSamplerState(0, SamplerStateRemoveContactPersonPrimaryAt(0);
		}

		public void AddContactPersonPrimary(ContactPersonPrimaryType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "ContactPersonPrimary", newValue);
		}

		public void InsertContactPersonPrimaryAt(ContactPersonPrimaryType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "ContactPersonPrimary", index, newValue);
		}

		public void ReplaceContactPersonPrimaryAt(ContactPersonPrimaryType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "ContactPersonPrimary", index, newValue);
		}
		#endregion // ContactPersonPrimary accessor methods

		#region ContactPersonPrimary collection
        public ContactPersonPrimaryCollection	MyContactPersonPrimarys = new ContactPersonPrimaryCollection( );

        public class ContactPersonPrimaryCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactPersonPrimaryEnumerator GetEnumerator() 
			{
				return new ContactPersonPrimaryEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactPersonPrimaryEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactPersonPrimaryEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactPersonPrimaryCount );
			}
			public ContactPersonPrimaryType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactPersonPrimaryAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactPersonPrimary collection

		#region ContactPosition accessor methods
		public int GetContactPositionMinCount()
		{
			return 0;
		}

		public int ContactPositionMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactPositionMaxCount()
		{
			return 1;
		}

		public int ContactPositionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactPositionCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition");
		}

		public int ContactPositionCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition");
			}
		}

		public bool HasContactPosition()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition");
		}

		public SchemaString GetContactPositionAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", index)));
		}

		public SchemaString GetContactPosition()
		{
			return this.SetSamplerState(0, SamplerStateGetContactPositionAt(0);
		}

		public SchemaString ContactPosition
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactPositionAt(0);
			}
		}

		public void RemoveContactPositionAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", index);
		}

		public void RemoveContactPosition()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactPosition()) this.SetSamplerState(0, SamplerStateRemoveContactPositionAt(0);
		}

		public void AddContactPosition(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertContactPositionAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceContactPositionAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactPosition", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ContactPosition accessor methods

		#region ContactPosition collection
        public ContactPositionCollection	MyContactPositions = new ContactPositionCollection( );

        public class ContactPositionCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactPositionEnumerator GetEnumerator() 
			{
				return new ContactPositionEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactPositionEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactPositionEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactPositionCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactPositionAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactPosition collection

		#region ContactAddress accessor methods
		public int GetContactAddressMinCount()
		{
			return 0;
		}

		public int ContactAddressMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactAddressMaxCount()
		{
			return 1;
		}

		public int ContactAddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactAddressCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress");
		}

		public int ContactAddressCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress");
			}
		}

		public bool HasContactAddress()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress");
		}

		public ContactAddressType GetContactAddressAt(int index)
		{
			return new ContactAddressType(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress", index));
		}

		public ContactAddressType GetContactAddress()
		{
			return this.SetSamplerState(0, SamplerStateGetContactAddressAt(0);
		}

		public ContactAddressType ContactAddress
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactAddressAt(0);
			}
		}

		public void RemoveContactAddressAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactAddress", index);
		}

		public void RemoveContactAddress()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactAddress()) this.SetSamplerState(0, SamplerStateRemoveContactAddressAt(0);
		}

		public void AddContactAddress(ContactAddressType newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomElement("", "ContactAddress", newValue);
		}

		public void InsertContactAddressAt(ContactAddressType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomElementAt("", "ContactAddress", index, newValue);
		}

		public void ReplaceContactAddressAt(ContactAddressType newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomElementAt("", "ContactAddress", index, newValue);
		}
		#endregion // ContactAddress accessor methods

		#region ContactAddress collection
        public ContactAddressCollection	MyContactAddresss = new ContactAddressCollection( );

        public class ContactAddressCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactAddressEnumerator GetEnumerator() 
			{
				return new ContactAddressEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactAddressEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactAddressEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactAddressCount );
			}
			public ContactAddressType  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactAddressAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactAddress collection

		#region ContactVoiceTelephone accessor methods
		public int GetContactVoiceTelephoneMinCount()
		{
			return 0;
		}

		public int ContactVoiceTelephoneMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactVoiceTelephoneMaxCount()
		{
			return 1;
		}

		public int ContactVoiceTelephoneMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactVoiceTelephoneCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone");
		}

		public int ContactVoiceTelephoneCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone");
			}
		}

		public bool HasContactVoiceTelephone()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone");
		}

		public SchemaString GetContactVoiceTelephoneAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", index)));
		}

		public SchemaString GetContactVoiceTelephone()
		{
			return this.SetSamplerState(0, SamplerStateGetContactVoiceTelephoneAt(0);
		}

		public SchemaString ContactVoiceTelephone
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactVoiceTelephoneAt(0);
			}
		}

		public void RemoveContactVoiceTelephoneAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", index);
		}

		public void RemoveContactVoiceTelephone()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactVoiceTelephone()) this.SetSamplerState(0, SamplerStateRemoveContactVoiceTelephoneAt(0);
		}

		public void AddContactVoiceTelephone(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertContactVoiceTelephoneAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceContactVoiceTelephoneAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactVoiceTelephone", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ContactVoiceTelephone accessor methods

		#region ContactVoiceTelephone collection
        public ContactVoiceTelephoneCollection	MyContactVoiceTelephones = new ContactVoiceTelephoneCollection( );

        public class ContactVoiceTelephoneCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactVoiceTelephoneEnumerator GetEnumerator() 
			{
				return new ContactVoiceTelephoneEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactVoiceTelephoneEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactVoiceTelephoneEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactVoiceTelephoneCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactVoiceTelephoneAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactVoiceTelephone collection

		#region ContactFacsimileTelephone accessor methods
		public int GetContactFacsimileTelephoneMinCount()
		{
			return 0;
		}

		public int ContactFacsimileTelephoneMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactFacsimileTelephoneMaxCount()
		{
			return 1;
		}

		public int ContactFacsimileTelephoneMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactFacsimileTelephoneCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone");
		}

		public int ContactFacsimileTelephoneCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone");
			}
		}

		public bool HasContactFacsimileTelephone()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone");
		}

		public SchemaString GetContactFacsimileTelephoneAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", index)));
		}

		public SchemaString GetContactFacsimileTelephone()
		{
			return this.SetSamplerState(0, SamplerStateGetContactFacsimileTelephoneAt(0);
		}

		public SchemaString ContactFacsimileTelephone
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactFacsimileTelephoneAt(0);
			}
		}

		public void RemoveContactFacsimileTelephoneAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", index);
		}

		public void RemoveContactFacsimileTelephone()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactFacsimileTelephone()) this.SetSamplerState(0, SamplerStateRemoveContactFacsimileTelephoneAt(0);
		}

		public void AddContactFacsimileTelephone(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertContactFacsimileTelephoneAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceContactFacsimileTelephoneAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactFacsimileTelephone", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ContactFacsimileTelephone accessor methods

		#region ContactFacsimileTelephone collection
        public ContactFacsimileTelephoneCollection	MyContactFacsimileTelephones = new ContactFacsimileTelephoneCollection( );

        public class ContactFacsimileTelephoneCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactFacsimileTelephoneEnumerator GetEnumerator() 
			{
				return new ContactFacsimileTelephoneEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactFacsimileTelephoneEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactFacsimileTelephoneEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactFacsimileTelephoneCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactFacsimileTelephoneAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactFacsimileTelephone collection

		#region ContactElectronicMailAddress accessor methods
		public int GetContactElectronicMailAddressMinCount()
		{
			return 0;
		}

		public int ContactElectronicMailAddressMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetContactElectronicMailAddressMaxCount()
		{
			return 1;
		}

		public int ContactElectronicMailAddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactElectronicMailAddressCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress");
		}

		public int ContactElectronicMailAddressCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress");
			}
		}

		public bool HasContactElectronicMailAddress()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress");
		}

		public SchemaString GetContactElectronicMailAddressAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", index)));
		}

		public SchemaString GetContactElectronicMailAddress()
		{
			return this.SetSamplerState(0, SamplerStateGetContactElectronicMailAddressAt(0);
		}

		public SchemaString ContactElectronicMailAddress
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetContactElectronicMailAddressAt(0);
			}
		}

		public void RemoveContactElectronicMailAddressAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", index);
		}

		public void RemoveContactElectronicMailAddress()
		{
			while (this.SetSamplerState(0, SamplerStateHasContactElectronicMailAddress()) this.SetSamplerState(0, SamplerStateRemoveContactElectronicMailAddressAt(0);
		}

		public void AddContactElectronicMailAddress(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertContactElectronicMailAddressAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceContactElectronicMailAddressAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateElement, "", "ContactElectronicMailAddress", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // ContactElectronicMailAddress accessor methods

		#region ContactElectronicMailAddress collection
        public ContactElectronicMailAddressCollection	MyContactElectronicMailAddresss = new ContactElectronicMailAddressCollection( );

        public class ContactElectronicMailAddressCollection: IEnumerable
        {
            ContactInformationType parent;
            public ContactInformationType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public ContactElectronicMailAddressEnumerator GetEnumerator() 
			{
				return new ContactElectronicMailAddressEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class ContactElectronicMailAddressEnumerator: IEnumerator 
        {
			int nIndex;
			ContactInformationType parent;
			public ContactElectronicMailAddressEnumerator(ContactInformationType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateContactElectronicMailAddressCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetContactElectronicMailAddressAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // ContactElectronicMailAddress collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMyContactPersonPrimarys.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyContactPositions.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyContactAddresss.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyContactVoiceTelephones.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyContactFacsimileTelephones.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMyContactElectronicMailAddresss.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
