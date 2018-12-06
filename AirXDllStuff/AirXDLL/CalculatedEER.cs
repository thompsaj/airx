// Decompiled with JetBrains decompiler
// Type: AirXDLL.CalculatedEER
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class CalculatedEER
  {
    private double _erveer;
    private double _PercentOALoad;
    private double _CombinedEER;
    private double _oarecoveredsum;

    [DebuggerNonUserCode]
    public CalculatedEER()
    {
    }

    /// <summary>'calculated EER of ERV</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ErvEER
    {
      get
      {
        return this._erveer;
      }
      set
      {
        this._erveer = value;
      }
    }

    /// <summary>'percent of total load due to OA</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PercentOALoad
    {
      get
      {
        return this._PercentOALoad;
      }
      set
      {
        this._PercentOALoad = value;
      }
    }

    /// <summary>'combined EER of ERV and AC</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double CombinedEER
    {
      get
      {
        return this._CombinedEER;
      }
      set
      {
        this._CombinedEER = value;
      }
    }

    public double OARecoveredSum
    {
      get
      {
        return this._oarecoveredsum;
      }
      set
      {
        this._oarecoveredsum = value;
      }
    }
  }
}
