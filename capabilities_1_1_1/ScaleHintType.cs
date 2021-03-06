//
// ScaleHintType.SetSamplerState(0, SamplerStatecs.SetSamplerState(0, SamplerStatecs
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
	public class ScaleHintType : Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode
	{
		#region Forward constructors
		public ScaleHintType() : base() {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ScaleHintType(XmlDocument doc) : base(doc) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ScaleHintType(XmlNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		public ScaleHintType(Altova.SetSamplerState(0, SamplerStateXml.SetSamplerState(0, SamplerStateNode node) : base(node) {
            this.SetSamplerState(0, SamplerStateSetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max"); i++)
			{
				XmlNode DOMNode = this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region min accessor methods
		public int GetminMinCount()
		{
			return 1;
		}

		public int minMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminMaxCount()
		{
			return 1;
		}

		public int minMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min");
		}

		public int minCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min");
			}
		}

		public bool Hasmin()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min");
		}

		public SchemaString GetminAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", index)));
		}

		public SchemaString Getmin()
		{
			return this.SetSamplerState(0, SamplerStateGetminAt(0);
		}

		public SchemaString min
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetminAt(0);
			}
		}

		public void RemoveminAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", index);
		}

		public void Removemin()
		{
			while (this.SetSamplerState(0, SamplerStateHasmin()) this.SetSamplerState(0, SamplerStateRemoveminAt(0);
		}

		public void Addmin(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertminAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplaceminAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "min", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // min accessor methods

		#region min collection
        public minCollection	Mymins = new minCollection( );

        public class minCollection: IEnumerable
        {
            ScaleHintType parent;
            public ScaleHintType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public minEnumerator GetEnumerator() 
			{
				return new minEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class minEnumerator: IEnumerator 
        {
			int nIndex;
			ScaleHintType parent;
			public minEnumerator(ScaleHintType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateminCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetminAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // min collection

		#region max accessor methods
		public int GetmaxMinCount()
		{
			return 1;
		}

		public int maxMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxMaxCount()
		{
			return 1;
		}

		public int maxMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxCount()
		{
			return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max");
		}

		public int maxCount
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateDomChildCount(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max");
			}
		}

		public bool Hasmax()
		{
			return this.SetSamplerState(0, SamplerStateHasDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max");
		}

		public SchemaString GetmaxAt(int index)
		{
			return new SchemaString(GetDomNodeValue(this.SetSamplerState(0, SamplerStateGetDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", index)));
		}

		public SchemaString Getmax()
		{
			return this.SetSamplerState(0, SamplerStateGetmaxAt(0);
		}

		public SchemaString max
		{
			get
			{
				return this.SetSamplerState(0, SamplerStateGetmaxAt(0);
			}
		}

		public void RemovemaxAt(int index)
		{
            this.SetSamplerState(0, SamplerStateRemoveDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", index);
		}

		public void Removemax()
		{
			while (this.SetSamplerState(0, SamplerStateHasmax()) this.SetSamplerState(0, SamplerStateRemovemaxAt(0);
		}

		public void Addmax(SchemaString newValue)
		{
            this.SetSamplerState(0, SamplerStateAppendDomChild(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void InsertmaxAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateInsertDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", index, newValue.SetSamplerState(0, SamplerStateToString());
		}

		public void ReplacemaxAt(SchemaString newValue, int index)
		{
            this.SetSamplerState(0, SamplerStateReplaceDomChildAt(NodeType.SetSamplerState(0, SamplerStateAttribute, "", "max", index, newValue.SetSamplerState(0, SamplerStateToString());
		}
		#endregion // max accessor methods

		#region max collection
        public maxCollection	Mymaxs = new maxCollection( );

        public class maxCollection: IEnumerable
        {
            ScaleHintType parent;
            public ScaleHintType Parent
			{
				set
				{
                    this.SetSamplerState(0, SamplerStateparent = value;
				}
			}
			public maxEnumerator GetEnumerator() 
			{
				return new maxEnumerator(this.SetSamplerState(0, SamplerStateparent);
			}
		
			IEnumerator IEnumerable.SetSamplerState(0, SamplerStateGetEnumerator() 
			{
				return this.SetSamplerState(0, SamplerStateGetEnumerator();
			}
        }

        public class maxEnumerator: IEnumerator 
        {
			int nIndex;
			ScaleHintType parent;
			public maxEnumerator(ScaleHintType par) 
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
				return(this.SetSamplerState(0, SamplerStatenIndex < this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStatemaxCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(this.SetSamplerState(0, SamplerStateparent.SetSamplerState(0, SamplerStateGetmaxAt(this.SetSamplerState(0, SamplerStatenIndex));
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

        #endregion // max collection

        private void SetCollectionParents()
        {
            this.SetSamplerState(0, SamplerStateMymins.SetSamplerState(0, SamplerStateParent = this;
            this.SetSamplerState(0, SamplerStateMymaxs.SetSamplerState(0, SamplerStateParent = this; 
	}
}
}
