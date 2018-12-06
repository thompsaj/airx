// Decompiled with JetBrains decompiler
// Type: AirXDLL.OperationMonth
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class OperationMonth
  {
    private bool _january;
    private bool _feb;
    private bool _march;
    private bool _apr;
    private bool _may;
    private bool _june;
    private bool _july;
    private bool _aug;
    private bool _sept;
    private bool _oct;
    private bool _nov;
    private bool _dec;

    [DebuggerNonUserCode]
    public OperationMonth()
    {
    }

    public bool January
    {
      get
      {
        return this._january;
      }
      set
      {
        this._january = value;
      }
    }

    public bool February
    {
      get
      {
        return this._feb;
      }
      set
      {
        this._feb = value;
      }
    }

    public bool March
    {
      get
      {
        return this._march;
      }
      set
      {
        this._march = value;
      }
    }

    public bool April
    {
      get
      {
        return this._apr;
      }
      set
      {
        this._apr = value;
      }
    }

    public bool May
    {
      get
      {
        return this._may;
      }
      set
      {
        this._may = value;
      }
    }

    public bool June
    {
      get
      {
        return this._june;
      }
      set
      {
        this._june = value;
      }
    }

    public bool July
    {
      get
      {
        return this._july;
      }
      set
      {
        this._july = value;
      }
    }

    public bool August
    {
      get
      {
        return this._aug;
      }
      set
      {
        this._aug = value;
      }
    }

    public bool September
    {
      get
      {
        return this._sept;
      }
      set
      {
        this._sept = value;
      }
    }

    public bool October
    {
      get
      {
        return this._oct;
      }
      set
      {
        this._oct = value;
      }
    }

    public bool November
    {
      get
      {
        return this._nov;
      }
      set
      {
        this._nov = value;
      }
    }

    public bool December
    {
      get
      {
        return this._dec;
      }
      set
      {
        this._dec = value;
      }
    }
  }
}
