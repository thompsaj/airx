// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirInlets
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class AirInlets
  {
    private double _outDBSum;
    private double _outWBSum;
    private double _outDBWin;
    private double _outWBWin;
    private double _inDBSum;
    private double _inWBSum;
    private double _inDBWin;
    private double _inWBWin;

    [DebuggerNonUserCode]
    public AirInlets()
    {
    }

    /// <summary>the outdoor dry bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutDBSum
    {
      get
      {
        return this._outDBSum;
      }
      set
      {
        this._outDBSum = value;
      }
    }

    /// <summary>the outdoor wet bulb temperature at summer design conditons, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutWBSum
    {
      get
      {
        return this._outWBSum;
      }
      set
      {
        this._outWBSum = value;
      }
    }

    /// <summary>the outdoor dry bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutDBWin
    {
      get
      {
        return this._outDBWin;
      }
      set
      {
        this._outDBWin = value;
      }
    }

    /// <summary>the outdoor wet bulb temperature at winter design conditons, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutWBWin
    {
      get
      {
        return this._outWBWin;
      }
      set
      {
        this._outWBWin = value;
      }
    }

    /// <summary>vthe indoor dry bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InDBSum
    {
      get
      {
        return this._inDBSum;
      }
      set
      {
        this._inDBSum = value;
      }
    }

    /// <summary>the indoor wet bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InWBSum
    {
      get
      {
        return this._inWBSum;
      }
      set
      {
        this._inWBSum = value;
      }
    }

    /// <summary>the indoor dry bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InDBWin
    {
      get
      {
        return this._inDBWin;
      }
      set
      {
        this._inDBWin = value;
      }
    }

    /// <summary>the indoor wet bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InWBWin
    {
      get
      {
        return this._inWBWin;
      }
      set
      {
        this._inWBWin = value;
      }
    }
  }
}
