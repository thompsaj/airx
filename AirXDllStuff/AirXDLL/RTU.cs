// Decompiled with JetBrains decompiler
// Type: AirXDLL.RTU
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class RTU
  {
    private double _rtuCapacity;
    private double _rtuEER;

    [DebuggerNonUserCode]
    public RTU()
    {
    }

    /// <summary>'capacity of associated A/C, Btu/hr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RTUcapacity
    {
      get
      {
        return this._rtuCapacity;
      }
      set
      {
        this._rtuCapacity = value;
      }
    }

    /// <summary>'EER of associated A/C, Btu/Wh</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RTUeer
    {
      get
      {
        return this._rtuEER;
      }
      set
      {
        this._rtuEER = value;
      }
    }
  }
}
