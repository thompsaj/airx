// Decompiled with JetBrains decompiler
// Type: AirXDLL.UnitPressures
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class UnitPressures
  {
    private double _sspress;
    private double _espress;
    private string _ssprest;
    private string _esprest;

    [DebuggerNonUserCode]
    public UnitPressures()
    {
    }

    /// <summary>the supply side plenum pressure, for the plenum specified in "ssprespt"</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SSPress
    {
      get
      {
        return this._sspress;
      }
      set
      {
        this._sspress = value;
      }
    }

    /// <summary>the exhaust side plenum pressure, for the plenum specified in "esprespt"</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ESPress
    {
      get
      {
        return this._espress;
      }
      set
      {
        this._espress = value;
      }
    }

    /// <summary>
    /// the supply side plenum for which the static pressure is given.  "sa" for the supply plenum.  "oa" for the outdoor plenum
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string SSPresT
    {
      get
      {
        return this._ssprest;
      }
      set
      {
        this._ssprest = value;
      }
    }

    /// <summary>
    /// the exhaust side plenum for which the static pressure is given.  "ra" for thereturn plenum.  "ea" for the exhaust plenum
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string ESPresT
    {
      get
      {
        return this._esprest;
      }
      set
      {
        this._esprest = value;
      }
    }
  }
}
