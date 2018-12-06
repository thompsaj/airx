// Decompiled with JetBrains decompiler
// Type: AirXDLL.Versions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class Versions
  {
    private int pVersionNumber;
    private bool pNeedUpdate;
    private bool pCompany;
    private bool pCities;
    private bool pCityDesignData;
    private bool pModelData;
    private bool pModel;
    private bool pMonthlyTemperatures;
    private bool pOEMModels;
    private bool pYearlyTemperatures;

    [DebuggerNonUserCode]
    public Versions()
    {
    }

    [XmlElement("VersionNumber")]
    public int VersionNumber
    {
      get
      {
        return this.pVersionNumber;
      }
      set
      {
        this.pVersionNumber = value;
      }
    }

    [XmlElement("NeedUpdate")]
    public bool NeedUpdate
    {
      get
      {
        return this.pNeedUpdate;
      }
      set
      {
        if (this.pNeedUpdate == value)
          return;
        this.pNeedUpdate = value;
      }
    }

    [XmlElement("Company")]
    public bool Company
    {
      get
      {
        return this.pCompany;
      }
      set
      {
        if (this.pCompany == value)
          return;
        this.pCompany = value;
      }
    }

    [XmlElement("Cities")]
    public bool Cities
    {
      get
      {
        return this.pCities;
      }
      set
      {
        if (this.pCities == value)
          return;
        this.pCities = value;
      }
    }

    [XmlElement("CityDesignData")]
    public bool CityDesignData
    {
      get
      {
        return this.pCityDesignData;
      }
      set
      {
        if (this.pCityDesignData == value)
          return;
        this.pCityDesignData = value;
      }
    }

    [XmlElement("ModelData")]
    public bool ModelData
    {
      get
      {
        return this.pModelData;
      }
      set
      {
        if (this.pModelData == value)
          return;
        this.pModelData = value;
      }
    }

    [XmlElement("Model")]
    public bool Model
    {
      get
      {
        return this.pModel;
      }
      set
      {
        if (this.pModel == value)
          return;
        this.pModel = value;
      }
    }

    [XmlElement("MonthlyTemperatures")]
    public bool MonthlyTemperatures
    {
      get
      {
        return this.pMonthlyTemperatures;
      }
      set
      {
        if (this.pMonthlyTemperatures == value)
          return;
        this.pMonthlyTemperatures = value;
      }
    }

    [XmlElement("OEMModels")]
    public bool OEMModels
    {
      get
      {
        return this.pOEMModels;
      }
      set
      {
        if (this.pOEMModels == value)
          return;
        this.pOEMModels = value;
      }
    }

    [XmlElement("YearlyTemperatures")]
    public bool YearlyTemperatures
    {
      get
      {
        return this.pYearlyTemperatures;
      }
      set
      {
        if (this.pYearlyTemperatures == value)
          return;
        this.pYearlyTemperatures = value;
      }
    }
  }
}
