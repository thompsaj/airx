// Decompiled with JetBrains decompiler
// Type: AirXDLL.OEMModel
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;
using System.Xml.Serialization;

namespace AirXDLL
{
  /// <summary>An AIRX Model base type</summary>
  /// <remarks></remarks>
  public class OEMModel
  {
    private int pID;
    private string pOEMModelName;
    private int pAirXModelID;
    private string pModelName;
    private string pSupplyPlenum;
    private string pExhaustPlenum;
    private double pPurgeAngle;
    private double pSupplyPressure;
    private double pExhaustPressure;
    private double pMaxCFM;
    private string pFanSetup;
    private bool pPurge;
    private int pWheels;
    private double pMinCFM;
    private int pListOrder;
    private bool pIsCustom;

    [DebuggerNonUserCode]
    public OEMModel()
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

    [XmlElement("OEMModelName")]
    public string OEMModelName
    {
      get
      {
        if (this.pOEMModelName == null)
          this.pOEMModelName = "";
        return this.pOEMModelName;
      }
      set
      {
        this.pOEMModelName = value;
      }
    }

    [XmlElement("AirXModelID")]
    public int AirXModelID
    {
      get
      {
        return this.pAirXModelID;
      }
      set
      {
        this.pAirXModelID = value;
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

    [XmlElement("SupplyPlenum")]
    public string SupplyPlenum
    {
      get
      {
        return this.pSupplyPlenum;
      }
      set
      {
        this.pSupplyPlenum = value;
      }
    }

    [XmlElement("ExhaustPlenum")]
    public string ExhaustPlenum
    {
      get
      {
        return this.pExhaustPlenum;
      }
      set
      {
        this.pExhaustPlenum = value;
      }
    }

    [XmlElement("PurgeAngle")]
    public double PurgeAngle
    {
      get
      {
        return this.pPurgeAngle;
      }
      set
      {
        this.pPurgeAngle = value;
      }
    }

    [XmlElement("SupplyPressure")]
    public double SupplyPressure
    {
      get
      {
        return this.pSupplyPressure;
      }
      set
      {
        this.pSupplyPressure = value;
      }
    }

    [XmlElement("ExhaustPressure")]
    public double ExhaustPressure
    {
      get
      {
        return this.pExhaustPressure;
      }
      set
      {
        this.pExhaustPressure = value;
      }
    }

    [XmlElement("MaxCFM")]
    public double MaxCFM
    {
      get
      {
        return this.pMaxCFM;
      }
      set
      {
        this.pMaxCFM = value;
      }
    }

    [XmlElement("FanSetup")]
    public string FanSetup
    {
      get
      {
        return this.pFanSetup;
      }
      set
      {
        this.pFanSetup = value;
      }
    }

    [XmlElement("Purge")]
    public bool Purge
    {
      get
      {
        return this.pPurge;
      }
      set
      {
        this.pPurge = value;
      }
    }

    [XmlElement("Wheels")]
    public int Wheels
    {
      get
      {
        return this.pWheels;
      }
      set
      {
        this.pWheels = value;
      }
    }

    [XmlElement("MinCFM")]
    public double MinCFM
    {
      get
      {
        return this.pMinCFM;
      }
      set
      {
        this.pMinCFM = value;
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
