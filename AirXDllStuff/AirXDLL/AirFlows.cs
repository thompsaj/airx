// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirFlows
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class AirFlows
  {
    private double _freshFlow;
    private double _outFlow;

    [DebuggerNonUserCode]
    public AirFlows()
    {
    }

    /// <summary>desired fresh air to be brought into the conditoned space, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FreshFlow
    {
      get
      {
        return this._freshFlow;
      }
      set
      {
        this._freshFlow = value;
      }
    }

    /// <summary>desired return air actually removed from the conditioned space, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutFlow
    {
      get
      {
        return this._outFlow;
      }
      set
      {
        this._outFlow = value;
      }
    }
  }
}
