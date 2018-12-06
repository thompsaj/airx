// Decompiled with JetBrains decompiler
// Type: AirXDLL.Values
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class Values
  {
    private double _enthsumo;
    private double _enthsumi;
    private double _enthwino;
    private double _enthwini;

    [DebuggerNonUserCode]
    public Values()
    {
    }

    public double EnthSumI
    {
      get
      {
        return this._enthsumi;
      }
      set
      {
        this._enthsumi = value;
      }
    }

    public double EnthSumO
    {
      get
      {
        return this._enthsumo;
      }
      set
      {
        this._enthsumo = value;
      }
    }

    public double EnthWinI
    {
      get
      {
        return this._enthwini;
      }
      set
      {
        this._enthwini = value;
      }
    }

    public double EnthWinO
    {
      get
      {
        return this._enthwino;
      }
      set
      {
        this._enthwino = value;
      }
    }
  }
}
