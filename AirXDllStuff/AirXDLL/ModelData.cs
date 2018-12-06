// Decompiled with JetBrains decompiler
// Type: AirXDLL.ModelData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class ModelData
  {
    private string pID;
    private bool pPurge;
    private double pMINSUGGFLOW;
    private double pMAXSUGGFLOW;
    private double pMINFLOW;
    private double pMAXFLOW;
    private double pMAXDELTA;
    private double pA1LAT;
    private double pA2LAT;
    private double pA3LAT;
    private double pA4LAT;
    private double pA5LAT;
    private double pA1SENS;
    private double pA2SENS;
    private double pA3SENS;
    private double pA4SENS;
    private double pA5SENS;
    private double pB1;
    private double pWHEELOD;
    private double pWHEELID;
    private double pWHEELDEPTH;
    private double pSEALDIM;
    private int pNUMSPOKES;
    private double pWHEELRPM;
    private double pVOIDFRACTION;
    private double pSPACING;
    private double pAREA;

    [DebuggerNonUserCode]
    public ModelData()
    {
    }

    [XmlElement("ID")]
    public string ID
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

    [XmlElement("MINSUGGFLOW")]
    public double MINSUGGFLOW
    {
      get
      {
        return this.pMINSUGGFLOW;
      }
      set
      {
        this.pMINSUGGFLOW = value;
      }
    }

    [XmlElement("MAXSUGGFLOW")]
    public double MAXSUGGFLOW
    {
      get
      {
        return this.pMAXSUGGFLOW;
      }
      set
      {
        this.pMAXSUGGFLOW = value;
      }
    }

    [XmlElement("MINFLOW")]
    public double MINFLOW
    {
      get
      {
        return this.pMINFLOW;
      }
      set
      {
        this.pMINFLOW = value;
      }
    }

    [XmlElement("MAXFLOW")]
    public double MAXFLOW
    {
      get
      {
        return this.pMAXFLOW;
      }
      set
      {
        this.pMAXFLOW = value;
      }
    }

    [XmlElement("MAXDELTA")]
    public double MAXDELTA
    {
      get
      {
        return this.pMAXDELTA;
      }
      set
      {
        this.pMAXDELTA = value;
      }
    }

    [XmlElement("A1LAT")]
    public double A1LAT
    {
      get
      {
        return this.pA1LAT;
      }
      set
      {
        this.pA1LAT = value;
      }
    }

    [XmlElement("A2LAT")]
    public double A2LAT
    {
      get
      {
        return this.pA2LAT;
      }
      set
      {
        this.pA2LAT = value;
      }
    }

    [XmlElement("A3LAT")]
    public double A3LAT
    {
      get
      {
        return this.pA3LAT;
      }
      set
      {
        this.pA3LAT = value;
      }
    }

    [XmlElement("A4LAT")]
    public double A4LAT
    {
      get
      {
        return this.pA4LAT;
      }
      set
      {
        this.pA4LAT = value;
      }
    }

    [XmlElement("A5LAT")]
    public double A5LAT
    {
      get
      {
        return this.pA5LAT;
      }
      set
      {
        this.pA5LAT = value;
      }
    }

    [XmlElement("A1SENS")]
    public double A1SENS
    {
      get
      {
        return this.pA1SENS;
      }
      set
      {
        this.pA1SENS = value;
      }
    }

    [XmlElement("A2SENS")]
    public double A2SENS
    {
      get
      {
        return this.pA2SENS;
      }
      set
      {
        this.pA2SENS = value;
      }
    }

    [XmlElement("A3SENS")]
    public double A3SENS
    {
      get
      {
        return this.pA3SENS;
      }
      set
      {
        this.pA3SENS = value;
      }
    }

    [XmlElement("A4SENS")]
    public double A4SENS
    {
      get
      {
        return this.pA4SENS;
      }
      set
      {
        this.pA4SENS = value;
      }
    }

    [XmlElement("A5SENS")]
    public double A5SENS
    {
      get
      {
        return this.pA5SENS;
      }
      set
      {
        this.pA5SENS = value;
      }
    }

    [XmlElement("B1")]
    public double B1
    {
      get
      {
        return this.pB1;
      }
      set
      {
        this.pB1 = value;
      }
    }

    [XmlElement("WHEELOD")]
    public double WHEELOD
    {
      get
      {
        return this.pWHEELOD;
      }
      set
      {
        this.pWHEELOD = value;
      }
    }

    [XmlElement("WHEELID")]
    public double WHEELID
    {
      get
      {
        return this.pWHEELID;
      }
      set
      {
        this.pWHEELID = value;
      }
    }

    [XmlElement("WHEELDEPTH")]
    public double WHEELDEPTH
    {
      get
      {
        return this.pWHEELDEPTH;
      }
      set
      {
        this.pWHEELDEPTH = value;
      }
    }

    [XmlElement("SEALDIM")]
    public double SEALDIM
    {
      get
      {
        return this.pSEALDIM;
      }
      set
      {
        this.pSEALDIM = value;
      }
    }

    [XmlElement("NUMSPOKES")]
    public int NUMSPOKES
    {
      get
      {
        return this.pNUMSPOKES;
      }
      set
      {
        this.pNUMSPOKES = value;
      }
    }

    [XmlElement("WHEELRPM")]
    public double WHEELRPM
    {
      get
      {
        return this.pWHEELRPM;
      }
      set
      {
        this.pWHEELRPM = value;
      }
    }

    [XmlElement("VOIDFRACTION")]
    public double VOIDFRACTION
    {
      get
      {
        return this.pVOIDFRACTION;
      }
      set
      {
        this.pVOIDFRACTION = value;
      }
    }

    [XmlElement("SPACING")]
    public double SPACING
    {
      get
      {
        return this.pSPACING;
      }
      set
      {
        this.pSPACING = value;
      }
    }

    [XmlElement("AREA")]
    public double AREA
    {
      get
      {
        return this.pAREA;
      }
      set
      {
        this.pAREA = value;
      }
    }
  }
}
