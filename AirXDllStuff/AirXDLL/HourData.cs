// Decompiled with JetBrains decompiler
// Type: AirXDLL.HourData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class HourData
  {
    private double _db;
    private double _w;
    private int _month;

    [DebuggerNonUserCode]
    public HourData()
    {
    }

    public double DB
    {
      get
      {
        return this._db;
      }
      set
      {
        this._db = value;
      }
    }

    public double HumRatio
    {
      get
      {
        return this._w;
      }
      set
      {
        this._w = value;
      }
    }

    public int Month
    {
      get
      {
        return this._month;
      }
      set
      {
        this._month = value;
      }
    }
  }
}
