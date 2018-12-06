// Decompiled with JetBrains decompiler
// Type: AirXDLL.CalculatedEnergy
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

namespace AirXDLL
{
  public class CalculatedEnergy
  {
    private double[] _binPreheat;

    public CalculatedEnergy()
    {
      this._binPreheat = new double[31];
    }

    public double[] BinPreHeat
    {
      get
      {
        return this._binPreheat;
      }
      set
      {
        this._binPreheat = value;
      }
    }
  }
}
