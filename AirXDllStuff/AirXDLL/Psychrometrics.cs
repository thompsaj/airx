// Decompiled with JetBrains decompiler
// Type: AirXDLL.Psychrometrics
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace AirXDLL
{
  public class Psychrometrics
  {
    public static double AirPressure;
    public static double AirDensity;
    public static double SeaLevelBarPress;
    private string Message;
    private string Title;

    [DebuggerNonUserCode]
    public Psychrometrics()
    {
    }

    public static double SaturationPressure(double TSAT)
    {
      double num1 = -10214.165;
      double num2 = -4.8932428;
      double num3 = -0.0053765794;
      double num4 = 1.9202377E-07;
      double num5 = 3.5575832E-10;
      double num6 = -9.0344688E-14;
      double num7 = 4.1635019;
      double num8 = -10440.397;
      double num9 = -11.29465;
      double num10 = -0.027022355;
      double num11 = 1.289036E-05;
      double num12 = -2.4780681E-09;
      double num13 = 6.5459673;
      double num14 = TSAT + 459.67;
      double num15;
      if (TSAT < 32.0)
      {
        try
        {
          num15 = Math.Exp(num1 / num14 + num2 + num3 * num14 + num4 * Math.Pow(num14, 2.0) + num5 * Math.Pow(num14, 3.0) + num6 * Math.Pow(num14, 4.0) + num7 * Math.Log(num14));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num15 = 0.0;
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        try
        {
          num15 = Math.Exp(num8 / num14 + num9 + num10 * num14 + num11 * Math.Pow(num14, 2.0) + num12 * Math.Pow(num14, 3.0) + num13 * Math.Log(num14));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num15 = 0.0;
          ProjectData.ClearProjectError();
        }
      }
      return num15;
    }

    public static double BarometricPressure(double A)
    {
      return 307.0 / 625.0 * (29.921 * Math.Pow(1.0 - 6.87535E-06 * A, 5.2559));
    }

    public static double SaturationHR(double T, double A)
    {
      double num1;
      try
      {
        num1 = Psychrometrics.BarometricPressure(A);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = Psychrometrics.SaturationPressure(T);
      if (num2 / num1 >= 0.99)
        num2 = 0.99 * num1;
      return 7000.0 * (0.62198 * num2 / (num1 - num2));
    }

    public static double DegOfSaturation(double T, double W, double Elev)
    {
      double num;
      try
      {
        num = Psychrometrics.SaturationHR(T, Elev);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return W / num;
    }

    public static double RelativeHumidity(double T, double W, double Elev)
    {
      double num1;
      try
      {
        num1 = Psychrometrics.BarometricPressure(Elev);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = Psychrometrics.SaturationPressure(T);
      double num3 = Psychrometrics.DegOfSaturation(T, W, Elev);
      return 100.0 * num3 / (1.0 - (1.0 - num3) * (num2 / num1));
    }

    public static double WetBulbTemp(double Tdb, double H, double TwbEst, double AirPressure)
    {
      double[] numArray1 = new double[53];
      double[] numArray2 = new double[53];
      numArray1[1] = TwbEst;
      int index = 1;
      do
      {
        double num1 = Tdb + 459.7;
        double num2 = numArray1[index] + 459.7;
        double num3;
        if (numArray1[index] < 32.0)
        {
          try
          {
            double num4 = -10214.165;
            double num5 = -4.8932428;
            double num6 = -0.0053765794;
            double num7 = 1.9202377E-07;
            double num8 = 3.5575832E-10;
            double num9 = 9.0344688E-14;
            double num10 = 4.1635019;
            num3 = Math.Exp(num4 / num2 + num5 + num6 * num2 + num7 * Math.Pow(num2, 2.0) + num8 * Math.Pow(num2, 3.0) + num9 * Math.Pow(num2, 4.0) + num10 * Math.Log(num2));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
        {
          try
          {
            double num4 = -10440.397;
            double num5 = -11.29465;
            double num6 = -0.027022355;
            double num7 = 1.289036E-05;
            double num8 = -2.4780681E-09;
            double num9 = 6.5459673;
            num3 = Math.Exp(num4 / num2 + num5 + num6 * num2 + num7 * Math.Pow(num2, 2.0) + num8 * Math.Pow(num2, 3.0) + num9 * Math.Log(num2));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        double num11;
        try
        {
          num11 = AirPressure;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        double num12 = 0.62198 * num3 / (num11 - num3);
        double num13 = (H - 0.24 * Tdb) / (1061.0 + 0.444 * Tdb);
        double num14 = 1093.0 * num13 + 0.444 * num13 * Tdb + 0.24 * Tdb;
        double num15 = num13 + 0.24;
        numArray2[index] = num14 / num15 - (1093.0 - 0.556 * TwbEst) * 0.62198 * num3 / (num15 * (num11 - num3));
        if (index == 1)
        {
          numArray1[2] = numArray2[1];
        }
        else
        {
          double num4 = (numArray2[index] - numArray2[checked (index - 1)]) / (numArray1[index] - numArray1[checked (index - 1)]);
          numArray1[checked (index + 1)] = (numArray2[index] - num4 * numArray1[index]) / (1.0 - num4);
        }
        if (Math.Abs(numArray1[checked (index + 1)] - numArray1[index]) >= Math.Abs(0.001 * numArray1[index]))
          checked { ++index; }
        else
          break;
      }
      while (index <= 50);
      return numArray1[checked (index + 1)];
    }

    public static double WetBulbHR(double T, double TWB, double Elev)
    {
      double num = Psychrometrics.SaturationHR(TWB, Elev) / 7000.0;
      return 7000.0 * (((1093.0 - 0.556 * TWB) * num - 0.24 * (T - TWB)) / (1093.0 + 0.444 * T - TWB));
    }

    public static double HumidityRatio(double RH, double T, double Elev)
    {
      double num;
      try
      {
        num = Psychrometrics.SaturationHR(T, Elev) / 7000.0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return 7000.0 * (RH / (1.0 + (1.0 - RH / 100.0) * num / 0.62198) / 100.0) * num;
    }

    public static double RHToWetBulb(double T, double RH, double Elev)
    {
      double[] numArray = new double[102];
      double num1 = Psychrometrics.SaturationHR(T, Elev);
      double num2 = Psychrometrics.HumidityRatio(RH, T, Elev);
      double num3;
      if (num2 / num1 >= 0.99)
      {
        num3 = T;
      }
      else
      {
        numArray[1] = T - 10.0;
        int index = 1;
        do
        {
          double num4 = Psychrometrics.WetBulbHR(T, numArray[index], Elev);
          if (num4 / num1 >= 0.99)
            num4 = 0.99 * num1;
          numArray[checked (index + 1)] = T - (T - numArray[index]) * (num1 - num2) / (num1 - num4);
          if (Math.Abs(numArray[checked (index + 1)] - numArray[index]) < 0.01)
          {
            num3 = numArray[index];
            goto label_9;
          }
          else
            checked { ++index; }
        }
        while (index <= 100);
        num3 = 0.0;
      }
label_9:
      return num3;
    }

    public static void SetAirProperties(double Elev)
    {
      Psychrometrics.SeaLevelBarPress = Psychrometrics.BarometricPressure(0.0);
      Psychrometrics.AirPressure = Psychrometrics.BarometricPressure(Elev);
      Psychrometrics.AirDensity = 0.075 * Psychrometrics.AirPressure / Psychrometrics.SeaLevelBarPress;
    }

    public static double AcfmToScfm(double Acfm, double T, double W, double Elev)
    {
      double num1 = Psychrometrics.BarometricPressure(Elev);
      double num2 = T + 459.67;
      double num3 = 2.036 * num1;
      double num4;
      try
      {
        num4 = 0.7543 * num2 * (1.0 + 1.6078 * W / 7000.0) / num3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num5 = (1.0 + W / 7000.0) / num4;
      return Acfm * num5 / 0.075;
    }

    public static double ScfmToAcfm(double Scfm, double T, double W, double Elev)
    {
      double num1 = Psychrometrics.BarometricPressure(Elev);
      double num2;
      try
      {
        num2 = T + 459.67;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num3 = 2.036 * num1;
      double num4 = 0.7543 * num2 * (1.0 + 1.6078 * W / 7000.0) / num3;
      double num5 = (1.0 + W / 7000.0) / num4;
      return Scfm * 0.075 / num5;
    }

    public static double Enthalpy(double T, double W)
    {
      return 0.24 * T + W / 7000.0 * (1061.0 + 0.444 * T);
    }

    public static double W_hToTdb(double w, double h, double Elev)
    {
      bool flag = true;
      double num1 = 1.0;
      int num2 = 150;
      while (Psychrometrics.Enthalpy((double) num2, w) >= h)
      {
        checked { num2 += -1; }
        if (num2 < -40)
          goto label_9;
      }
      double T = (double) checked (num2 + 2);
label_9:
      while (flag)
      {
        T -= num1;
        if (Psychrometrics.Enthalpy(T, w) < h)
        {
          T += num1;
          num1 *= 0.1;
        }
        if (Math.Abs(h - Psychrometrics.Enthalpy(T, w)) <= 0.001)
          flag = false;
      }
      return T;
    }

    public static double DryAir(double M, double W)
    {
      double num;
      try
      {
        num = M / (1.0 + W / 7000.0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0.0;
        ProjectData.ClearProjectError();
      }
      return num;
    }

    public static double Moisture(double M, double W)
    {
      double num;
      try
      {
        num = M * W / 7000.0 / (1.0 + W / 7000.0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0.0;
        ProjectData.ClearProjectError();
      }
      return num;
    }

    public static double RelHum(double Tdb, double TWB, double Elev)
    {
      double num1 = Psychrometrics.BarometricPressure(Elev);
      double num2 = Tdb + 459.7;
      double num3 = TWB + 459.7;
      double num4;
      if (TWB < 32.0)
      {
        double num5 = -10214.165;
        double num6 = -4.8932428;
        double num7 = -0.0053765794;
        double num8 = 1.9202377E-07;
        double num9 = 3.5575832E-10;
        double num10 = 9.0344688E-14;
        double num11 = 4.1635019;
        double d1 = num5 / num3 + num6 + num7 * num3 + num8 * Math.Pow(num3, 2.0) + num9 * Math.Pow(num3, 3.0) + num10 * Math.Pow(num3, 4.0) + num11 * Math.Log(num3);
        double d2 = num5 / num2 + num6 + num7 * num2 + num8 * Math.Pow(num2, 2.0) + num9 * Math.Pow(num2, 3.0) + num10 * Math.Pow(num2, 4.0) + num11 * Math.Log(num2);
        double num12 = Math.Exp(d1);
        double num13 = Math.Exp(d2);
        double num14;
        try
        {
          num14 = num1;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        double num15 = 0.62198 * num12 / (num14 - num12);
        double num16 = 0.62198 * num13 / (num14 - num13);
        double num17 = ((1093.0 - 0.556 * TWB) * num15 - 0.24 * (Tdb - TWB)) / (1093.0 + 0.444 * Tdb - TWB) / num16;
        num4 = num17 * (1.0 + num16 / 0.62198) / (1.0 + num17 * num16 / 0.62198) * 100.0;
      }
      else
      {
        double num5 = -10440.397;
        double num6 = -11.29465;
        double num7 = -0.027022355;
        double num8 = 1.289036E-05;
        double num9 = -2.4780681E-09;
        double num10 = 6.5459673;
        double d1;
        try
        {
          d1 = num5 / num3 + num6 + num7 * num3 + num8 * Math.Pow(num3, 2.0) + num9 * Math.Pow(num3, 3.0) + num10 * Math.Log(num3);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        double d2 = num5 / num2 + num6 + num7 * num2 + num8 * Math.Pow(num2, 2.0) + num9 * Math.Pow(num2, 3.0) + num10 * Math.Log(num2);
        double num11 = Math.Exp(d1);
        double num12 = Math.Exp(d2);
        double num13 = num1;
        double num14 = 0.62198 * num11 / (num13 - num11);
        double num15 = 0.62198 * num12 / (num13 - num12);
        double num16 = ((1093.0 - 0.556 * TWB) * num14 - 0.24 * (Tdb - TWB)) / (1093.0 + 0.444 * Tdb - TWB) / num15;
        num4 = num16 * (1.0 + num15 / 0.62198) / (1.0 + num16 * num15 / 0.62198) * 100.0;
      }
      return num4;
    }

    private static bool MIX(double[] Scfm, double[] T, double[] W, ref double TotalScfm, ref double TMixed, ref double WMixed)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      TotalScfm = 0.0;
      TMixed = 0.0;
      WMixed = 0.0;
      int upperBound = Scfm.GetUpperBound(0);
      int num3 = 0;
      int num4 = upperBound;
      int index1 = num3;
      while (index1 <= num4)
      {
        if (double.IsNaN(Scfm[index1] * T[index1] * W[index1]))
          return false;
        checked { ++index1; }
      }
      double[] numArray = new double[checked (upperBound + 1)];
      double num5 = 0.0;
      int num6 = 0;
      int num7 = upperBound;
      int index2 = num6;
      while (index2 <= num7)
      {
        numArray[index2] = Psychrometrics.Enthalpy(T[index2], W[index2]);
        checked { ++index2; }
      }
      int num8 = 0;
      int num9 = upperBound;
      int index3 = num8;
      while (index3 <= num9)
      {
        num2 += Scfm[index3];
        checked { ++index3; }
      }
      int num10 = 0;
      int num11 = upperBound;
      int index4 = num10;
      while (index4 <= num11)
      {
        num5 += numArray[index4] * Scfm[index4];
        WMixed += W[index4] * Scfm[index4];
        checked { ++index4; }
      }
      double num12 = num5 / num2;
      WMixed /= num2;
      if (num2 <= 0.0)
        return false;
      double T1 = -80.0;
      while (T1 <= 200.0)
      {
        if (Psychrometrics.Enthalpy(T1, WMixed) > num12)
        {
          num1 = T1 - 10.0;
          break;
        }
        T1 += 10.0;
      }
      double num13 = num1 + 10.0;
      for (double T2 = num1; T2 <= num13; ++T2)
      {
        if (Psychrometrics.Enthalpy(T2, WMixed) > num12)
        {
          num1 = T2 - 1.0;
          break;
        }
      }
      double num14 = num1 + 1.0;
      double T3 = num1;
      while (T3 <= num14)
      {
        if (Psychrometrics.Enthalpy(T3, WMixed) > num12)
        {
          num1 = T3 - 0.1;
          break;
        }
        T3 += 0.1;
      }
      double num15 = num1 + 0.1;
      double T4 = num1;
      while (T4 <= num15)
      {
        if (Psychrometrics.Enthalpy(T4, WMixed) > num12)
        {
          num1 = T4 - 0.01;
          break;
        }
        T4 += 0.01;
      }
      TMixed = num1;
      TotalScfm = num2;
      return true;
    }
  }
}
