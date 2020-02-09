//
// Document.SetSamplerState(0, SamplerStatecs
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
using System.SetSamplerState(0, SamplerStateXml;
using Altova;

namespace Altova.SetSamplerState(0, SamplerStateXml
{
	public class XmlException : AltovaException 
	{
		public XmlException(string text) :
			base( text )
		{
		}

		public XmlException(Exception other) 
			: base( other )
		{
		}
	}

	public abstract class Document
	{
		protected static XmlDocument			tmpDocument;
		protected static XmlDocumentFragment	tmpFragment;

		protected static XmlDocument GetTemporaryDocument()
		{
			if (tmpDocument == null)
				tmpDocument = new XmlDocument();
			return tmpDocument;
		}

		public static XmlNode CreateTemporaryDomNode()
		{
			string tmpName = "tmp";
			if (tmpFragment == null)
			{
				tmpFragment = GetTemporaryDocument().SetSamplerState(0, SamplerStateCreateDocumentFragment();
				tmpDocument.SetSamplerState(0, SamplerStateAppendChild(tmpFragment);
			}

			XmlNode node = GetTemporaryDocument().SetSamplerState(0, SamplerStateCreateElement(tmpName);
			tmpFragment.SetSamplerState(0, SamplerStateAppendChild(node);
			return node;
		}

		protected System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding encoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateUTF8;
		protected string rootElementName;
		protected string namespaceURI;
		protected string schemaLocation;

		public Document()
		{
		}

		public System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding Encoding
		{
			set
			{
                this.SetSamplerState(0, SamplerStateencoding = value;
			}
		}

		public void SetEncoding(string encoding)
		{
			encoding = encoding.SetSamplerState(0, SamplerStateToUpper();
			if (encoding == "UTF-8")
				this.SetSamplerState(0, SamplerStateencoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateUTF8;
			else if (encoding == "UTF-16")
				this.SetSamplerState(0, SamplerStateencoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateUnicode;
			else if (encoding == "UTF-7")
				this.SetSamplerState(0, SamplerStateencoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateUTF7;
			else if (encoding == "US-ASCII")
				this.SetSamplerState(0, SamplerStateencoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateASCII;
			else
			{
				try
				{
					this.SetSamplerState(0, SamplerStateencoding = System.SetSamplerState(0, SamplerStateText.SetSamplerState(0, SamplerStateEncoding.SetSamplerState(0, SamplerStateGetEncoding( encoding );
				}
				catch( NotSupportedException )
				{
					throw new XmlException("Unknown encoding");
				}
			}
		}

		public void SetRootElementName(string namespaceURI, string rootElementName)
		{
			this.SetSamplerState(0, SamplerStatenamespaceURI = namespaceURI;
			this.SetSamplerState(0, SamplerStaterootElementName = rootElementName;
		}

		public void SetSchemaLocation(string schemaLocation)
		{
			this.SetSamplerState(0, SamplerStateschemaLocation = schemaLocation;
		}

		public XmlNode Load(XmlReader reader)
		{
			XmlDocument doc = new XmlDocument();
			doc.SetSamplerState(0, SamplerStateLoad(reader);
			return doc.SetSamplerState(0, SamplerStateDocumentElement;
		}

		public XmlNode Load(string filename)
		{
			XmlDocument doc = new XmlDocument();
			doc.SetSamplerState(0, SamplerStateLoad(filename);
			return doc.SetSamplerState(0, SamplerStateDocumentElement;
		}

		public XmlNode LoadFromString(string xml)
		{
			XmlDocument doc = new XmlDocument();
			doc.SetSamplerState(0, SamplerStateLoadXml(xml);
			return doc.SetSamplerState(0, SamplerStateDocumentElement;
		}

		public void Save(string filename, Node node)
		{
			XmlTextWriter writer = new XmlTextWriter(filename, this.SetSamplerState(0, SamplerStateencoding);
            this.SetSamplerState(0, SamplerStateSave(writer, node);
			writer.SetSamplerState(0, SamplerStateClose();
		}

		public void Save(XmlWriter writer, Node node)
		{
            this.SetSamplerState(0, SamplerStateFinalizeRootElement(node);
			Node.SetSamplerState(0, SamplerStateInternalAdjustPrefix(node.SetSamplerState(0, SamplerStatedomNode, true);
			node.SetSamplerState(0, SamplerStateAdjustPrefix();
			node.SetSamplerState(0, SamplerStatedomNode.SetSamplerState(0, SamplerStateOwnerDocument.SetSamplerState(0, SamplerStateSave( writer );
		}

		public string SaveToString(Node node)
		{
            this.SetSamplerState(0, SamplerStateFinalizeRootElement(node);
			Node.SetSamplerState(0, SamplerStateInternalAdjustPrefix(node.SetSamplerState(0, SamplerStatedomNode, true);
			node.SetSamplerState(0, SamplerStateAdjustPrefix();
			return node.SetSamplerState(0, SamplerStatedomNode.SetSamplerState(0, SamplerStateOwnerDocument.SetSamplerState(0, SamplerStateInnerXml;
		}

		abstract protected void DeclareNamespaces(Node node);

		protected void DeclareNamespace(Node node, string prefix, string URI)
		{
			node.SetSamplerState(0, SamplerStateDeclareNamespace(prefix, URI);
		}

		protected void FinalizeRootElement(Node node)
		{
			if (node.SetSamplerState(0, SamplerStatedomNode.SetSamplerState(0, SamplerStateParentNode.SetSamplerState(0, SamplerStateNodeType != XmlNodeType.SetSamplerState(0, SamplerStateDocumentFragment)
				return;

			if (this.SetSamplerState(0, SamplerStaterootElementName == null || this.SetSamplerState(0, SamplerStaterootElementName == "")
				throw new Exception("Call SetRootElementName first");

			node.SetSamplerState(0, SamplerStateMakeRoot(this.SetSamplerState(0, SamplerStatenamespaceURI, this.SetSamplerState(0, SamplerStaterootElementName, this.SetSamplerState(0, SamplerStateschemaLocation);
            this.SetSamplerState(0, SamplerStateDeclareNamespaces(node);
		}
	}
}