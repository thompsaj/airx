// Decompiled with JetBrains decompiler
// Type: AirXDLL.AIRXAppConfig
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class AIRXAppConfig
  {
    private DateTime pLastUpdate;
    private string pRegCode;
    private DateTime pLastUpdateCheck;
    private int pCurrentVersionNumber;

    [DebuggerNonUserCode]
    public AIRXAppConfig()
    {
    }

    [XmlElement("LastUpdate")]
    public DateTime LastUpdate
    {
      get
      {
        return this.pLastUpdate;
      }
      set
      {
        this.pLastUpdate = value;
      }
    }

    [XmlElement("RegCode")]
    public string RegCode
    {
      get
      {
        return this.pRegCode;
      }
      set
      {
        this.pRegCode = value;
      }
    }

    [XmlElement("LastUpdateCheck")]
    public DateTime LastUpdateCheck
    {
      get
      {
        return this.pLastUpdateCheck;
      }
      set
      {
        this.pLastUpdateCheck = value;
      }
    }

    [XmlElement("CurrentVersionNumber")]
    public int CurrentVersionNumber
    {
      get
      {
        return this.pCurrentVersionNumber;
      }
      set
      {
        this.pCurrentVersionNumber = value;
      }
    }
  }
}
