// Decompiled with JetBrains decompiler
// Type: AirXDLL.Model
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;
using System.Xml.Serialization;

namespace AirXDLL
{
  /// <summary>An AIRX Model base type</summary>
  /// <remarks></remarks>
  public class Model
  {
    private int pID;
    private string pModelName;
    private ModelData pModelData;
    private int pListOrder;
    private bool pIsCustom;

    [DebuggerNonUserCode]
    public Model()
    {
    }

    [XmlElement("ID")]
    public int ID
    {
      get
      {
        return this.pID;
      }
      set
      {
        this.pID = value;
      }
    }

    [XmlElement("ModelName")]
    public string ModelName
    {
      get
      {
        if (this.pModelName == null)
          this.pModelName = "";
        return this.pModelName;
      }
      set
      {
        this.pModelName = value;
      }
    }

    [XmlElement("ModelData")]
    public ModelData ModelData
    {
      get
      {
        if (this.pModelData == null)
          this.pModelData = new ModelData();
        return this.pModelData;
      }
      set
      {
        this.pModelData = value;
      }
    }

    [XmlElement("ListOrder")]
    public int ListOrder
    {
      get
      {
        return this.pListOrder;
      }
      set
      {
        this.pListOrder = value;
      }
    }

    [XmlElement("IsCustom")]
    public bool IsCustom
    {
      get
      {
        return this.pIsCustom;
      }
      set
      {
        this.pIsCustom = value;
      }
    }
  }
}
