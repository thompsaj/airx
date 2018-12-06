// Decompiled with JetBrains decompiler
// Type: AirXDLL.WeatherDesignData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class WeatherDesignData
  {
    private int _elev;
    private double _db04;
    private double _mcwb04;
    private double _db996;
    private double _mcwb996;
    private string _fileName;

    [DebuggerNonUserCode]
    public WeatherDesignData()
    {
    }

    public double DB04
    {
      get
      {
        return this._db04;
      }
      set
      {
        this._db04 = value;
      }
    }

    public double DB996
    {
      get
      {
        return this._db996;
      }
      set
      {
        this._db996 = value;
      }
    }

    public double MCWB04
    {
      get
      {
        return this._mcwb04;
      }
      set
      {
        this._mcwb04 = value;
      }
    }

    public double MCWB996
    {
      get
      {
        return this._mcwb996;
      }
      set
      {
        this._mcwb996 = value;
      }
    }

    public int Elev
    {
      get
      {
        return this._elev;
      }
      set
      {
        this._elev = value;
      }
    }

    public string FileName
    {
      get
      {
        return this._fileName;
      }
      set
      {
        this._fileName = value;
      }
    }
  }
}
