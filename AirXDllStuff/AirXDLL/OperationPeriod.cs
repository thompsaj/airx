// Decompiled with JetBrains decompiler
// Type: AirXDLL.OperationPeriod
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class OperationPeriod
  {
    private bool _period1;
    private bool _period2;
    private bool _period3;
    private bool _period4;
    private bool _period5;
    private bool _period6;

    [DebuggerNonUserCode]
    public OperationPeriod()
    {
    }

    /// <summary>midnight to 4am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period1
    {
      get
      {
        return this._period1;
      }
      set
      {
        this._period1 = value;
      }
    }

    /// <summary>4am to 8am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period2
    {
      get
      {
        return this._period2;
      }
      set
      {
        this._period2 = value;
      }
    }

    /// <summary>8am to noon</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period3
    {
      get
      {
        return this._period3;
      }
      set
      {
        this._period3 = value;
      }
    }

    /// <summary>noon to 4pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period4
    {
      get
      {
        return this._period4;
      }
      set
      {
        this._period4 = value;
      }
    }

    /// <summary>4pm to 8pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period5
    {
      get
      {
        return this._period5;
      }
      set
      {
        this._period5 = value;
      }
    }

    /// <summary>8pm to midnight</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period6
    {
      get
      {
        return this._period6;
      }
      set
      {
        this._period6 = value;
      }
    }
  }
}
