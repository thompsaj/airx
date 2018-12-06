// Decompiled with JetBrains decompiler
// Type: AirXDLL.EnergyCosts
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class EnergyCosts
  {
    private int _heatingindex;
    private double _heatingefficiency;
    private double _heatingEER;
    private double _coolingEER;
    private double _wintereleccost;
    private double _fuelcost;
    private double _summereleccost;
    private double _summerdemandcost;

    [DebuggerNonUserCode]
    public EnergyCosts()
    {
    }

    /// <summary>'0 = fossil fuel, 1 = heat pump, 2 = resistance</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public int HeatingIndex
    {
      get
      {
        return this._heatingindex;
      }
      set
      {
        this._heatingindex = value;
      }
    }

    /// <summary>'efficiency of a fuel-based heating system, %</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double HeatingEfficiency
    {
      get
      {
        return this._heatingefficiency;
      }
      set
      {
        this._heatingefficiency = value;
      }
    }

    public double HeatingEER
    {
      get
      {
        return this._heatingEER;
      }
      set
      {
        this._heatingEER = value;
      }
    }

    /// <summary>'EER of A/C cooling, Btu/Whr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double CoolingEER
    {
      get
      {
        return this._coolingEER;
      }
      set
      {
        this._coolingEER = value;
      }
    }

    /// <summary>'cost of electricity during winter, $/kWh</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double WinterElecCost
    {
      get
      {
        return this._wintereleccost;
      }
      set
      {
        this._wintereleccost = value;
      }
    }

    /// <summary>'cost of fuel, $/mmBtu</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FuelCost
    {
      get
      {
        return this._fuelcost;
      }
      set
      {
        this._fuelcost = value;
      }
    }

    /// <summary>'cost of electricity during summer, $/kWhc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SummerElecCost
    {
      get
      {
        return this._summereleccost;
      }
      set
      {
        this._summereleccost = value;
      }
    }

    /// <summary>'cost of incrementatl electrical dema</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SummerDemandCost
    {
      get
      {
        return this._summerdemandcost;
      }
      set
      {
        this._summerdemandcost = value;
      }
    }
  }
}
