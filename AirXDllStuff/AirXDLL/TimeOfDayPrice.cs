// Decompiled with JetBrains decompiler
// Type: AirXDLL.TimeOfDayPrice
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class TimeOfDayPrice
  {
    private bool _tod;
    private double _tod0;
    private double _tod1;
    private double _tod2;
    private double _tod3;
    private double _tod4;
    private double _tod5;

    [DebuggerNonUserCode]
    public TimeOfDayPrice()
    {
    }

    /// <summary>'TOD pricing, 0 = No, 1 = Yes</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool TOD
    {
      get
      {
        return this._tod;
      }
      set
      {
        this._tod = value;
      }
    }

    /// <summary>cost of electricity in period 0, m - 4am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD0
    {
      get
      {
        return this._tod0;
      }
      set
      {
        this._tod0 = value;
      }
    }

    /// <summary>cost of electricity in period 1, 4am - 8am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD1
    {
      get
      {
        return this._tod1;
      }
      set
      {
        this._tod1 = value;
      }
    }

    /// <summary>cost of electricity in period 2, 8am - n</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD2
    {
      get
      {
        return this._tod2;
      }
      set
      {
        this._tod2 = value;
      }
    }

    /// <summary>cost of electricity in period 3, n - 4pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD3
    {
      get
      {
        return this._tod3;
      }
      set
      {
        this._tod3 = value;
      }
    }

    /// <summary>cost of electricity in period 4, 4pm - 8pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD4
    {
      get
      {
        return this._tod4;
      }
      set
      {
        this._tod4 = value;
      }
    }

    /// <summary>cost of electricity in period 5, 8pm - m</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD5
    {
      get
      {
        return this._tod5;
      }
      set
      {
        this._tod5 = value;
      }
    }
  }
}
