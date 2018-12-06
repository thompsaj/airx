// Decompiled with JetBrains decompiler
// Type: AirXDLL.BinData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class BinData
  {
    private int _month;
    private double _midPoint;
    private int _hours;
    private double _db;
    private double _w;
    private double _WinterHours;
    private double _SummerHours;

    [DebuggerNonUserCode]
    public BinData()
    {
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

    public double MidPoint
    {
      get
      {
        return this._midPoint;
      }
      set
      {
        this._midPoint = value;
      }
    }

    public int Hours
    {
      get
      {
        return this._hours;
      }
      set
      {
        this._hours = value;
      }
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

    public double W
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

    public double WinterHours
    {
      get
      {
        return this._WinterHours;
      }
      set
      {
        this._WinterHours = value;
      }
    }

    public double SummerHours
    {
      get
      {
        return this._SummerHours;
      }
      set
      {
        this._SummerHours = value;
      }
    }
  }
}
