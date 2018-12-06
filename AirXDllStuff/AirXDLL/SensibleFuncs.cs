// Decompiled with JetBrains decompiler
// Type: AirXDLL.SensibleFuncs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace AirXDLL
{
  public class SensibleFuncs
  {
    [DebuggerNonUserCode]
    public SensibleFuncs()
    {
    }

    public void GetSensibleWheelEFF(double OATdb, double OAW, double RATdb, double RAW, double RATwb, ref double SupplyFlow, ref double ExhaustFlow, double Alt, int frostControl, double TFrost, double frostControlCapacity, ref double EFFSs, ref double EFFSl)
    {
      double num1 = EFFSs * ExhaustFlow / SupplyFlow;
      double num2 = Psychrometrics.Enthalpy(RATdb, RAW);
      if (Psychrometrics.SaturationHR(RATdb - num1 * (RATdb - OATdb), Alt) >= RAW)
      {
        EFFSl = 0.0;
      }
      else
      {
        if (frostControl == 1)
        {
          double FrostTemp;
          double FrostCapacity;
          GlobalFunctions.Preheat2(RATdb, RATwb, OATdb, Alt, ref FrostTemp, ref FrostCapacity);
          OATdb += Math.Min(frostControlCapacity, FrostCapacity);
        }
        double T1 = RATdb - num1 * (RATdb - OATdb);
        double W1 = RAW - num1 * (RAW - OAW);
        double num3 = Psychrometrics.Enthalpy(T1, W1);
        if (Psychrometrics.HumidityRatio(97.0, T1, Alt) < W1)
        {
          bool flag1 = true;
          double num4 = 1.0;
          double T2 = T1;
          double num5 = 7000.0 * ((num3 - 0.24 * T2) / (1061.0 + 0.444 * T2));
          while (flag1)
          {
            T2 += num4;
            num5 = 7000.0 * ((num3 - 0.24 * T2) / (1061.0 + 0.444 * T2));
            if (num5 < Psychrometrics.HumidityRatio(97.0, T2, Alt))
            {
              T2 -= num4;
              num4 *= 0.1;
            }
            if (Math.Abs(num5 - Psychrometrics.HumidityRatio(97.0, T2, Alt)) <= 0.001)
              flag1 = false;
          }
          double T3 = T2;
          double W2 = num5;
          double num6 = Psychrometrics.Enthalpy(OATdb, OAW);
          double num7 = Psychrometrics.Enthalpy(T3, W2);
          double num8 = num6 + (num2 - num7) * ExhaustFlow / SupplyFlow;
          double num9 = OAW + (RAW - W2) * ExhaustFlow / SupplyFlow;
          double T4 = (num8 - 1061.0 * num9 / 7000.0) / (0.24 + 0.444 * num9 / 7000.0);
          if (Psychrometrics.HumidityRatio(97.0, T4, Alt) < num9)
          {
            double num10 = num8;
            double T5 = T4;
            double num11 = num9;
            bool flag2 = true;
            while (flag2)
            {
              T5 += num4;
              num11 = 7000.0 * ((num10 - 0.24 * T5) / (1061.0 + 0.444 * T5));
              if (num11 < Psychrometrics.HumidityRatio(97.0, T5, Alt))
              {
                T5 -= num4;
                num4 *= 0.1;
              }
              if (Math.Abs(num11 - Psychrometrics.HumidityRatio(97.0, T5, Alt)) <= 0.001)
                flag2 = false;
            }
            T4 = T5;
            num9 = num11;
          }
          EFFSs = (T4 - OATdb) / (RATdb - OATdb);
          EFFSl = (num9 - OAW) / (RAW - OAW);
        }
      }
    }

    public void GetSensibleWheelEFF(Inputs inputObj, bool isSummer, ref Outputs outputObj, ref double EFFSs, ref double EFFSl)
    {
      ModelData modelData1 = new ModelData();
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      ModelData modelData2 = modelDbFunctions.GetModelData(inputObj.ConfigFileLocation, inputObj.ModelID, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) == 0)
        ;
      double num1 = 0.0;
      double num2 = 0.0;
      double T1;
      double TWB1;
      double T2;
      double TWB2;
      if (isSummer)
      {
        T1 = inputObj.InDBSum;
        TWB1 = inputObj.InWBSum;
        T2 = inputObj.OutDBSum;
        TWB2 = inputObj.OutWBSum;
      }
      else
      {
        T1 = inputObj.InDBWin;
        TWB1 = inputObj.InWBWin;
        T2 = inputObj.OutDBWin;
        TWB2 = inputObj.OutWBWin;
      }
      double W1 = Psychrometrics.WetBulbHR(T1, TWB1, inputObj.Elevation);
      double W2 = Psychrometrics.WetBulbHR(T2, TWB2, inputObj.Elevation);
      int num3 = 1;
      int integer;
      double num4;
      double num5;
      double num6;
      double num7;
      do
      {
        ModelData modelData3 = modelData2;
        integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData3.ID);
        ref int local1 = ref integer;
        ref double local2 = ref num4;
        ref double local3 = ref num5;
        ref double local4 = ref num6;
        ref double local5 = ref num7;
        double num8 = num1 / inputObj.Wheels;
        ref double local6 = ref num8;
        double num9 = num2 / inputObj.Wheels;
        ref double local7 = ref num9;
        ModelData modelData4 = modelData2;
        GlobalFunctions.Effectivenesses(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, modelData4);
        modelData3.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
        double T3 = T2 - num5 * (T2 - T1);
        double W3 = W2;
        num1 = Psychrometrics.AcfmToScfm(inputObj.FreshFlow, T3, W3, inputObj.Elevation);
        num2 = Psychrometrics.AcfmToScfm(inputObj.OutFlow, T1, W1, inputObj.Elevation);
        checked { ++num3; }
      }
      while (num3 <= 5);
      ModelData modelData5 = modelData2;
      integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData5.ID);
      ref int local8 = ref integer;
      ref double local9 = ref num4;
      ref double local10 = ref num5;
      ref double local11 = ref num6;
      ref double local12 = ref num7;
      double num10 = num1 / inputObj.Wheels;
      ref double local13 = ref num10;
      double num11 = num2 / inputObj.Wheels;
      ref double local14 = ref num11;
      ModelData modelData6 = modelData2;
      GlobalFunctions.Effectivenesses(ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, modelData6);
      modelData5.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
      double T4 = T2 - num5 * (T2 - T1);
      double W4 = W2;
      double num12 = Psychrometrics.Enthalpy(T4, W4);
      double num13 = Psychrometrics.Enthalpy(T2, W2);
      double h1 = Psychrometrics.Enthalpy(T1, W1) - (num12 - num13) * num1 / num2;
      double tdb = Psychrometrics.W_hToTdb(W1 - (W4 - W2) * num1 / num2, h1, inputObj.Elevation);
      double num14 = (T1 - tdb) / (T1 - T2);
      Psychrometrics.SetAirProperties(inputObj.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double num15 = T1 - num14 * (T1 - T2);
      double num16 = T2;
      double W5 = W2;
      double num17 = T1;
      double W6 = W1;
      double elevation = inputObj.Elevation;
      double H = Psychrometrics.Enthalpy(num17, W6);
      double RATwb = Psychrometrics.WetBulbTemp(num17, H, num17, airPressure);
      double RH = 90.0;
      double num18 = Psychrometrics.SaturationHR(num17 - num14 * (num17 - num16), elevation);
      outputObj.CondEvap = false;
      if (num18 >= W6)
      {
        EFFSl = 0.0;
      }
      else
      {
        if (inputObj.Capacity > 0.0)
        {
          double FrostTemp;
          double FrostCapacity;
          GlobalFunctions.Preheat2(num17, RATwb, num16, elevation, ref FrostTemp, ref FrostCapacity);
          num16 += Math.Min(inputObj.Capacity, FrostCapacity);
        }
        double T3 = num17 - num14 * (num17 - num16);
        double W3 = W6 - num14 * (W6 - W5);
        double num8 = Psychrometrics.Enthalpy(T3, W3);
        outputObj.CondEvap = true;
        if (Psychrometrics.HumidityRatio(RH, T3, elevation) < W3)
        {
          bool flag1 = true;
          double num9 = 1.0;
          double T5 = T3;
          double num19 = 7000.0 * ((num8 - 0.24 * T5) / (1061.0 + 0.444 * T5));
          while (flag1)
          {
            T5 += num9;
            num19 = 7000.0 * ((num8 - 0.24 * T5) / (1061.0 + 0.444 * T5));
            if (num19 < Psychrometrics.HumidityRatio(RH, T5, elevation))
            {
              T5 -= num9;
              num9 *= 0.1;
            }
            if (Math.Abs(num19 - Psychrometrics.HumidityRatio(RH, T5, elevation)) <= 0.001)
              flag1 = false;
          }
          double T6 = T5;
          double W7 = num19;
          double num20 = Psychrometrics.Enthalpy(num16, W5);
          double num21 = Psychrometrics.Enthalpy(T6, W7);
          double h2 = num20 + (H - num21) * num2 / num1;
          double w = W5 + (W6 - W7) * num2 / num1;
          double T7 = Psychrometrics.W_hToTdb(w, h2, elevation);
          if (Psychrometrics.HumidityRatio(97.0, T7, elevation) < w)
          {
            double num22 = h2;
            double T8 = T7;
            double num23 = w;
            bool flag2 = true;
            double num24 = 1.0;
            while (flag2)
            {
              T8 += num24;
              num23 = 7000.0 * ((num22 - 0.24 * T8) / (1061.0 + 0.444 * T8));
              if (num23 < Psychrometrics.HumidityRatio(97.0, T8, elevation))
              {
                T8 -= num24;
                num24 *= 0.1;
              }
              if (Math.Abs(num23 - Psychrometrics.HumidityRatio(97.0, T8, elevation)) <= 0.001)
                flag2 = false;
            }
            T7 = T8;
            w = num23;
          }
          EFFSs = (T7 - num16) / (num17 - num16);
          EFFSl = (w - W5) / (W6 - W5);
        }
      }
    }
  }
}
