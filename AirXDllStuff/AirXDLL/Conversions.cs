// Decompiled with JetBrains decompiler
// Type: AirXDLL.Conversions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class Conversions
  {
    [DebuggerNonUserCode]
    public Conversions()
    {
    }

    public static double EnthalpyToEnthalpyMetricOffset(double H, double W, bool metric)
    {
      double num;
      if (metric)
      {
        H -= 7.68 + W / 7000.0 * 14.208;
        num = H;
      }
      else
        num = H;
      return num;
    }
  }
}
