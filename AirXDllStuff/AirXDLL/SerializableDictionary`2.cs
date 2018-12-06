// Decompiled with JetBrains decompiler
// Type: AirXDLL.SerializableDictionary`2
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
  {
    [DebuggerNonUserCode]
    public SerializableDictionary()
    {
    }

    public XmlSchema GetSchema()
    {
      return (XmlSchema) null;
    }

    public void ReadXml(XmlReader reader)
    {
      XmlSerializer xmlSerializer1 = new XmlSerializer(typeof (TKey));
      XmlSerializer xmlSerializer2 = new XmlSerializer(typeof (TValue));
      bool isEmptyElement = reader.IsEmptyElement;
      reader.Read();
      if (isEmptyElement)
        return;
      while (reader.NodeType != XmlNodeType.EndElement)
      {
        reader.ReadStartElement("item");
        reader.ReadStartElement("key");
        TKey key = (TKey) xmlSerializer1.Deserialize(reader);
        reader.ReadEndElement();
        reader.ReadStartElement("value");
        TValue obj = (TValue) xmlSerializer2.Deserialize(reader);
        reader.ReadEndElement();
        this.Add(key, obj);
        reader.ReadEndElement();
        int content = (int) reader.MoveToContent();
      }
      reader.ReadEndElement();
    }

    public void WriteXml(XmlWriter writer)
    {
      XmlSerializer xmlSerializer1 = new XmlSerializer(typeof (TKey));
      XmlSerializer xmlSerializer2 = new XmlSerializer(typeof (TValue));
      Dictionary<TKey, TValue>.KeyCollection.Enumerator enumerator;
      try
      {
        enumerator = this.Keys.GetEnumerator();
        while (enumerator.MoveNext())
        {
          TKey current = enumerator.Current;
          writer.WriteStartElement("item");
          writer.WriteStartElement("key");
          xmlSerializer1.Serialize(writer, (object) current);
          writer.WriteEndElement();
          writer.WriteStartElement("value");
          TValue obj = this[current];
          xmlSerializer2.Serialize(writer, (object) obj);
          writer.WriteEndElement();
          writer.WriteEndElement();
        }
      }
      finally
      {
        enumerator.Dispose();
      }
    }
  }
}
