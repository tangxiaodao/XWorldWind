//
// Type_SimpleTimeSpan.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace LayerSet
{
	public class Type_SimpleTimeSpan : Altova.Xml.Node
	{
		#region Forward constructors
		public Type_SimpleTimeSpan() : base() {
            this.SetCollectionParents(); }
		public Type_SimpleTimeSpan(XmlDocument doc) : base(doc) {
            this.SetCollectionParents(); }
		public Type_SimpleTimeSpan(XmlNode node) : base(node) {
            this.SetCollectionParents(); }
		public Type_SimpleTimeSpan(Altova.Xml.Node node) : base(node) {
            this.SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < this.DomChildCount(NodeType.Element, "", "Days"); i++)
			{
				XmlNode DOMNode = this.GetDomChildAt(NodeType.Element, "", "Days", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.DomChildCount(NodeType.Element, "", "Hours"); i++)
			{
				XmlNode DOMNode = this.GetDomChildAt(NodeType.Element, "", "Hours", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.DomChildCount(NodeType.Element, "", "Mins"); i++)
			{
				XmlNode DOMNode = this.GetDomChildAt(NodeType.Element, "", "Mins", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < this.DomChildCount(NodeType.Element, "", "Seconds"); i++)
			{
				XmlNode DOMNode = this.GetDomChildAt(NodeType.Element, "", "Seconds", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Days accessor methods
		public int GetDaysMinCount()
		{
			return 1;
		}

		public int DaysMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDaysMaxCount()
		{
			return 1;
		}

		public int DaysMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDaysCount()
		{
			return this.DomChildCount(NodeType.Element, "", "Days");
		}

		public int DaysCount
		{
			get
			{
				return this.DomChildCount(NodeType.Element, "", "Days");
			}
		}

		public bool HasDays()
		{
			return this.HasDomChild(NodeType.Element, "", "Days");
		}

		public SchemaInt GetDaysAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(this.GetDomChildAt(NodeType.Element, "", "Days", index)));
		}

		public XmlNode GetStartingDaysCursor()
		{
			return this.GetDomFirstChild( NodeType.Element, "", "Days" );
		}

		public XmlNode GetAdvancedDaysCursor( XmlNode curNode )
		{
			return this.GetDomNextChild( NodeType.Element, "", "Days", curNode );
		}

		public SchemaInt GetDaysValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetDays()
		{
			return this.GetDaysAt(0);
		}

		public SchemaInt Days
		{
			get
			{
				return this.GetDaysAt(0);
			}
		}

		public void RemoveDaysAt(int index)
		{
            this.RemoveDomChildAt(NodeType.Element, "", "Days", index);
		}

		public void RemoveDays()
		{
			while (this.HasDays()) this.RemoveDaysAt(0);
		}

		public void AddDays(SchemaInt newValue)
		{
            this.AppendDomChild(NodeType.Element, "", "Days", newValue.ToString());
		}

		public void InsertDaysAt(SchemaInt newValue, int index)
		{
            this.InsertDomChildAt(NodeType.Element, "", "Days", index, newValue.ToString());
		}

		public void ReplaceDaysAt(SchemaInt newValue, int index)
		{
            this.ReplaceDomChildAt(NodeType.Element, "", "Days", index, newValue.ToString());
		}
		#endregion // Days accessor methods

		#region Days collection
        public DaysCollection	MyDayss = new DaysCollection( );

        public class DaysCollection: IEnumerable
        {
            Type_SimpleTimeSpan parent;
            public Type_SimpleTimeSpan Parent
			{
				set
				{
                    this.parent = value;
				}
			}
			public DaysEnumerator GetEnumerator() 
			{
				return new DaysEnumerator(this.parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return this.GetEnumerator();
			}
        }

        public class DaysEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan parent;
			public DaysEnumerator(Type_SimpleTimeSpan par) 
			{
                this.parent = par;
                this.nIndex = -1;
			}
			public void Reset() 
			{
                this.nIndex = -1;
			}
			public bool MoveNext() 
			{
                this.nIndex++;
				return(this.nIndex < this.parent.DaysCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(this.parent.GetDaysAt(this.nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(this.Current);
				}
			}
    	}

        #endregion // Days collection

		#region Hours accessor methods
		public int GetHoursMinCount()
		{
			return 1;
		}

		public int HoursMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetHoursMaxCount()
		{
			return 1;
		}

		public int HoursMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetHoursCount()
		{
			return this.DomChildCount(NodeType.Element, "", "Hours");
		}

		public int HoursCount
		{
			get
			{
				return this.DomChildCount(NodeType.Element, "", "Hours");
			}
		}

		public bool HasHours()
		{
			return this.HasDomChild(NodeType.Element, "", "Hours");
		}

		public SchemaLong GetHoursAt(int index)
		{
			return new SchemaLong(GetDomNodeValue(this.GetDomChildAt(NodeType.Element, "", "Hours", index)));
		}

		public XmlNode GetStartingHoursCursor()
		{
			return this.GetDomFirstChild( NodeType.Element, "", "Hours" );
		}

		public XmlNode GetAdvancedHoursCursor( XmlNode curNode )
		{
			return this.GetDomNextChild( NodeType.Element, "", "Hours", curNode );
		}

		public SchemaLong GetHoursValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaLong( curNode.InnerText );
		}


		public SchemaLong GetHours()
		{
			return this.GetHoursAt(0);
		}

		public SchemaLong Hours
		{
			get
			{
				return this.GetHoursAt(0);
			}
		}

		public void RemoveHoursAt(int index)
		{
            this.RemoveDomChildAt(NodeType.Element, "", "Hours", index);
		}

		public void RemoveHours()
		{
			while (this.HasHours()) this.RemoveHoursAt(0);
		}

		public void AddHours(SchemaLong newValue)
		{
            this.AppendDomChild(NodeType.Element, "", "Hours", newValue.ToString());
		}

		public void InsertHoursAt(SchemaLong newValue, int index)
		{
            this.InsertDomChildAt(NodeType.Element, "", "Hours", index, newValue.ToString());
		}

		public void ReplaceHoursAt(SchemaLong newValue, int index)
		{
            this.ReplaceDomChildAt(NodeType.Element, "", "Hours", index, newValue.ToString());
		}
		#endregion // Hours accessor methods

		#region Hours collection
        public HoursCollection	MyHourss = new HoursCollection( );

        public class HoursCollection: IEnumerable
        {
            Type_SimpleTimeSpan parent;
            public Type_SimpleTimeSpan Parent
			{
				set
				{
                    this.parent = value;
				}
			}
			public HoursEnumerator GetEnumerator() 
			{
				return new HoursEnumerator(this.parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return this.GetEnumerator();
			}
        }

        public class HoursEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan parent;
			public HoursEnumerator(Type_SimpleTimeSpan par) 
			{
                this.parent = par;
                this.nIndex = -1;
			}
			public void Reset() 
			{
                this.nIndex = -1;
			}
			public bool MoveNext() 
			{
                this.nIndex++;
				return(this.nIndex < this.parent.HoursCount );
			}
			public SchemaLong  Current 
			{
				get 
				{
					return(this.parent.GetHoursAt(this.nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(this.Current);
				}
			}
    	}

        #endregion // Hours collection

		#region Mins accessor methods
		public int GetMinsMinCount()
		{
			return 1;
		}

		public int MinsMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMinsMaxCount()
		{
			return 1;
		}

		public int MinsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMinsCount()
		{
			return this.DomChildCount(NodeType.Element, "", "Mins");
		}

		public int MinsCount
		{
			get
			{
				return this.DomChildCount(NodeType.Element, "", "Mins");
			}
		}

		public bool HasMins()
		{
			return this.HasDomChild(NodeType.Element, "", "Mins");
		}

		public SchemaInt GetMinsAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(this.GetDomChildAt(NodeType.Element, "", "Mins", index)));
		}

		public XmlNode GetStartingMinsCursor()
		{
			return this.GetDomFirstChild( NodeType.Element, "", "Mins" );
		}

		public XmlNode GetAdvancedMinsCursor( XmlNode curNode )
		{
			return this.GetDomNextChild( NodeType.Element, "", "Mins", curNode );
		}

		public SchemaInt GetMinsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetMins()
		{
			return this.GetMinsAt(0);
		}

		public SchemaInt Mins
		{
			get
			{
				return this.GetMinsAt(0);
			}
		}

		public void RemoveMinsAt(int index)
		{
            this.RemoveDomChildAt(NodeType.Element, "", "Mins", index);
		}

		public void RemoveMins()
		{
			while (this.HasMins()) this.RemoveMinsAt(0);
		}

		public void AddMins(SchemaInt newValue)
		{
            this.AppendDomChild(NodeType.Element, "", "Mins", newValue.ToString());
		}

		public void InsertMinsAt(SchemaInt newValue, int index)
		{
            this.InsertDomChildAt(NodeType.Element, "", "Mins", index, newValue.ToString());
		}

		public void ReplaceMinsAt(SchemaInt newValue, int index)
		{
            this.ReplaceDomChildAt(NodeType.Element, "", "Mins", index, newValue.ToString());
		}
		#endregion // Mins accessor methods

		#region Mins collection
        public MinsCollection	MyMinss = new MinsCollection( );

        public class MinsCollection: IEnumerable
        {
            Type_SimpleTimeSpan parent;
            public Type_SimpleTimeSpan Parent
			{
				set
				{
                    this.parent = value;
				}
			}
			public MinsEnumerator GetEnumerator() 
			{
				return new MinsEnumerator(this.parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return this.GetEnumerator();
			}
        }

        public class MinsEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan parent;
			public MinsEnumerator(Type_SimpleTimeSpan par) 
			{
                this.parent = par;
                this.nIndex = -1;
			}
			public void Reset() 
			{
                this.nIndex = -1;
			}
			public bool MoveNext() 
			{
                this.nIndex++;
				return(this.nIndex < this.parent.MinsCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(this.parent.GetMinsAt(this.nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(this.Current);
				}
			}
    	}

        #endregion // Mins collection

		#region Seconds accessor methods
		public int GetSecondsMinCount()
		{
			return 1;
		}

		public int SecondsMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSecondsMaxCount()
		{
			return 1;
		}

		public int SecondsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSecondsCount()
		{
			return this.DomChildCount(NodeType.Element, "", "Seconds");
		}

		public int SecondsCount
		{
			get
			{
				return this.DomChildCount(NodeType.Element, "", "Seconds");
			}
		}

		public bool HasSeconds()
		{
			return this.HasDomChild(NodeType.Element, "", "Seconds");
		}

		public SchemaInt GetSecondsAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(this.GetDomChildAt(NodeType.Element, "", "Seconds", index)));
		}

		public XmlNode GetStartingSecondsCursor()
		{
			return this.GetDomFirstChild( NodeType.Element, "", "Seconds" );
		}

		public XmlNode GetAdvancedSecondsCursor( XmlNode curNode )
		{
			return this.GetDomNextChild( NodeType.Element, "", "Seconds", curNode );
		}

		public SchemaInt GetSecondsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetSeconds()
		{
			return this.GetSecondsAt(0);
		}

		public SchemaInt Seconds
		{
			get
			{
				return this.GetSecondsAt(0);
			}
		}

		public void RemoveSecondsAt(int index)
		{
            this.RemoveDomChildAt(NodeType.Element, "", "Seconds", index);
		}

		public void RemoveSeconds()
		{
			while (this.HasSeconds()) this.RemoveSecondsAt(0);
		}

		public void AddSeconds(SchemaInt newValue)
		{
            this.AppendDomChild(NodeType.Element, "", "Seconds", newValue.ToString());
		}

		public void InsertSecondsAt(SchemaInt newValue, int index)
		{
            this.InsertDomChildAt(NodeType.Element, "", "Seconds", index, newValue.ToString());
		}

		public void ReplaceSecondsAt(SchemaInt newValue, int index)
		{
            this.ReplaceDomChildAt(NodeType.Element, "", "Seconds", index, newValue.ToString());
		}
		#endregion // Seconds accessor methods

		#region Seconds collection
        public SecondsCollection	MySecondss = new SecondsCollection( );

        public class SecondsCollection: IEnumerable
        {
            Type_SimpleTimeSpan parent;
            public Type_SimpleTimeSpan Parent
			{
				set
				{
                    this.parent = value;
				}
			}
			public SecondsEnumerator GetEnumerator() 
			{
				return new SecondsEnumerator(this.parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return this.GetEnumerator();
			}
        }

        public class SecondsEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan parent;
			public SecondsEnumerator(Type_SimpleTimeSpan par) 
			{
                this.parent = par;
                this.nIndex = -1;
			}
			public void Reset() 
			{
                this.nIndex = -1;
			}
			public bool MoveNext() 
			{
                this.nIndex++;
				return(this.nIndex < this.parent.SecondsCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(this.parent.GetSecondsAt(this.nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(this.Current);
				}
			}
    	}

        #endregion // Seconds collection

        private void SetCollectionParents()
        {
            this.MyDayss.Parent = this;
            this.MyHourss.Parent = this;
            this.MyMinss.Parent = this;
            this.MySecondss.Parent = this; 
	}
}
}
