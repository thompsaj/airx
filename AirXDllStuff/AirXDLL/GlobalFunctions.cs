// Decompiled with JetBrains decompiler
// Type: AirXDLL.GlobalFunctions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AirXDLL
{
  public class GlobalFunctions
  {
    [DebuggerNonUserCode]
    public GlobalFunctions()
    {
    }

    public static void Preheat2(Inputs inputObj, ref Outputs outputObj, List<ErrFlags> errsList)
    {
      int num1 = 0;
      int num2 = 100;
      if ((inputObj.OutDBWin + inputObj.InDBWin) / 2.0 > 30.0)
      {
        outputObj.Capacity = 0.0;
        outputObj.TFrost = inputObj.OutDBWin;
      }
      else
      {
        double num3;
        try
        {
          num3 = Psychrometrics.SaturationHR(inputObj.OutDBWin, inputObj.Elevation);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        double num4 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
        double num5 = (inputObj.InDBWin - inputObj.OutDBWin) / (num4 - num3);
        double T1 = inputObj.OutDBWin;
        bool flag = true;
        double num6;
        double num7;
        double num8;
        do
        {
          try
          {
            num6 = T1;
            num7 = num5;
            num8 = num3;
            T1 = num6 + 1.0;
            num3 = Psychrometrics.SaturationHR(T1, inputObj.Elevation);
            num5 = (inputObj.InDBWin - T1) / (num4 - num3);
            if (flag)
            {
              if (num5 > num7)
              {
                outputObj.Capacity = 0.0;
                outputObj.TFrost = inputObj.OutDBWin;
                return;
              }
              flag = false;
            }
            checked { ++num1; }
            if (num1 > num2)
            {
              outputObj.Capacity = 0.0;
              outputObj.TFrost = inputObj.OutDBWin;
              return;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        while (num5 < num7);
        int num9 = 0;
        double T2 = num6;
        double num10 = num7;
        double num11 = num8;
        double num12;
        double num13;
        double num14;
        do
        {
          num12 = T2;
          num13 = num10;
          num14 = num11;
          T2 = num12 + 0.01;
          num11 = Psychrometrics.SaturationHR(T2, inputObj.Elevation);
          num10 = (inputObj.InDBWin - T2) / (num4 - num11);
          checked { ++num9; }
          if (num9 > num2)
          {
            outputObj.Capacity = 0.0;
            outputObj.TFrost = inputObj.OutDBWin;
            return;
          }
        }
        while (num10 < num13);
        double num15 = num13;
        double num16 = Psychrometrics.HumidityRatio(85.0, inputObj.OutDBWin, inputObj.Elevation);
        outputObj.Capacity = inputObj.InDBWin - num15 * (num4 - num16) - inputObj.OutDBWin;
        if (outputObj.Capacity <= 0.0)
        {
          outputObj.Capacity = 0.0;
          outputObj.TFrost = inputObj.OutDBWin;
        }
        else
        {
          double num17 = num16;
          double T3 = inputObj.OutDBWin;
          double num18 = (inputObj.InDBWin - T3) / (num4 - num17);
          int num19 = 0;
          int num20 = 100;
          while (num18 > num15)
          {
            num12 = T3;
            num13 = num18;
            num14 = num17;
            T3 = num12 + 1.0;
            num17 = Psychrometrics.HumidityRatio(85.0, T3, inputObj.Elevation);
            num18 = (inputObj.InDBWin - T3) / (num4 - num17);
            checked { ++num19; }
            if (num19 > num20)
            {
              outputObj.Capacity = 0.0;
              outputObj.TFrost = inputObj.OutDBWin;
              return;
            }
          }
          int num21 = 0;
          int num22 = 100;
          double T4 = num12;
          double num23 = num13;
          double num24 = num14;
          while (num23 > num15)
          {
            T4 += 0.01;
            num24 = Psychrometrics.HumidityRatio(85.0, T4, inputObj.Elevation);
            num23 = (inputObj.InDBWin - T4) / (num4 - num24);
            checked { ++num21; }
            if (num21 > num22)
            {
              outputObj.Capacity = 0.0;
              outputObj.TFrost = inputObj.OutDBWin;
              return;
            }
          }
          outputObj.TFrost = T4;
        }
      }
    }

    public static void Preheat2(double RATdb, double RATwb, double OATdb, double Elevation, ref double FrostTemp, ref double FrostCapacity)
    {
      double num1;
      try
      {
        num1 = Psychrometrics.SaturationHR(OATdb, Elevation);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = Psychrometrics.WetBulbHR(RATdb, RATwb, Elevation);
      double num3 = (RATdb - OATdb) / (num2 - num1);
      double T1 = OATdb;
      bool flag = true;
      double num4;
      double num5;
      double num6;
      do
      {
        try
        {
          num4 = T1;
          num5 = num3;
          num6 = num1;
          T1 = num4 + 1.0;
          num1 = Psychrometrics.SaturationHR(T1, Elevation);
          num3 = (RATdb - T1) / (num2 - num1);
          if (flag)
          {
            if (num3 > num5)
            {
              FrostCapacity = 0.0;
              FrostTemp = OATdb;
              return;
            }
            flag = false;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      while (num3 < num5);
      double T2 = num4;
      double num7 = num5;
      double num8 = num6;
      double num9;
      double num10;
      double num11;
      do
      {
        num9 = T2;
        num10 = num7;
        num11 = num8;
        T2 = num9 + 0.01;
        num8 = Psychrometrics.SaturationHR(T2, Elevation);
        num7 = (RATdb - T2) / (num2 - num8);
      }
      while (num7 < num10);
      double num12 = num10;
      double num13 = Psychrometrics.HumidityRatio(85.0, OATdb, Elevation);
      FrostCapacity = RATdb - num12 * (num2 - num13) - OATdb;
      if (FrostCapacity <= 0.0)
      {
        FrostCapacity = 0.0;
        FrostTemp = OATdb;
      }
      else
      {
        double num14 = num13;
        double T3 = OATdb;
        for (double num15 = (RATdb - T3) / (num2 - num14); num15 > num12; num15 = (RATdb - T3) / (num2 - num14))
        {
          num9 = T3;
          num10 = num15;
          num11 = num14;
          T3 = num9 + 1.0;
          num14 = Psychrometrics.HumidityRatio(85.0, T3, Elevation);
        }
        double T4 = num9;
        double num16 = num10;
        double num17 = num11;
        for (; num16 > num12; num16 = (RATdb - T4) / (num2 - num17))
        {
          T4 += 0.01;
          num17 = Psychrometrics.HumidityRatio(85.0, T4, Elevation);
        }
        FrostTemp = T4;
      }
    }

    public static void PreheatSensible(Inputs inputObj, ref Outputs outputObj, List<ErrFlags> errsList)
    {
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      ModelData modelData1 = new ModelData();
      ModelData modelData2 = modelDbFunctions.GetModelData(inputObj.ConfigFileLocation, inputObj.ModelID, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsList.Add(errs);
      }
      else
      {
        double W1 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
        double num1 = Psychrometrics.WetBulbHR(inputObj.OutDBWin, inputObj.OutWBWin, inputObj.Elevation);
        int num2 = 1;
        double num3;
        double num4;
        double num5;
        double num6;
        do
        {
          ModelData modelData3 = modelData2;
          int integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData3.ID);
          ref int local1 = ref integer;
          ref double local2 = ref num3;
          ref double local3 = ref num4;
          ref double local4 = ref num5;
          ref double local5 = ref num6;
          double num7 = inputObj.ExhaustSCFM / inputObj.Wheels;
          ref double local6 = ref num7;
          double num8 = inputObj.FreshSCFM / inputObj.Wheels;
          ref double local7 = ref num8;
          ModelData modelData4 = modelData2;
          GlobalFunctions.Effectivenesses(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, modelData4);
          modelData3.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
          double T = inputObj.OutDBWin - num4 * (inputObj.OutDBWin - inputObj.InDBWin);
          double W2 = num1 - num3 * (num1 - W1);
          inputObj.FreshSCFM = Psychrometrics.AcfmToScfm(inputObj.FreshFlow, T, W2, inputObj.Elevation);
          inputObj.ExhaustSCFM = Psychrometrics.AcfmToScfm(inputObj.OutFlow, inputObj.InDBWin, W1, inputObj.Elevation);
          checked { ++num2; }
        }
        while (num2 <= 5);
        ModelData modelData5 = modelData2;
        int integer1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData5.ID);
        ref int local8 = ref integer1;
        ref double local9 = ref num3;
        ref double local10 = ref num4;
        ref double local11 = ref num5;
        ref double local12 = ref num6;
        double num9 = inputObj.ExhaustSCFM / inputObj.Wheels;
        ref double local13 = ref num9;
        double num10 = inputObj.FreshSCFM / inputObj.Wheels;
        ref double local14 = ref num10;
        ModelData modelData6 = modelData2;
        GlobalFunctions.Effectivenesses(ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, modelData6);
        modelData5.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer1);
        double num11 = inputObj.ExhaustSCFM >= inputObj.FreshSCFM ? num4 : num6;
        Psychrometrics.Enthalpy(inputObj.InDBWin, W1);
        double T1 = inputObj.InDBWin - num11 * (inputObj.InDBWin - inputObj.OutDBWin);
        double outDbWin = inputObj.OutDBWin;
        double num12 = num1;
        double inDbWin = inputObj.InDBWin;
        double num13 = W1;
        double elevation = inputObj.Elevation;
        if (Psychrometrics.SaturationHR(T1, inputObj.Elevation) >= W1)
        {
          outputObj.Capacity = 0.0;
          outputObj.TFrost = inputObj.OutDBWin;
        }
        else
        {
          double T2 = inDbWin - num11 * (inDbWin - outDbWin);
          double W2 = num13 - num11 * (num13 - num12);
          Psychrometrics.Enthalpy(T2, W2);
          bool flag1 = true;
          if ((T2 + outDbWin) / 2.0 >= 32.0)
            flag1 = false;
          double num7 = 1.0;
          while (flag1)
          {
            outDbWin += num7;
            double T3 = inDbWin - num11 * (inDbWin - outDbWin);
            double W3 = num13 - num11 * (num13 - num12);
            double num8 = Psychrometrics.Enthalpy(T3, W3);
            outputObj.Condensation = false;
            if (Psychrometrics.HumidityRatio(97.0, T3, elevation) < W3)
            {
              outputObj.Condensation = true;
              bool flag2 = true;
              double num14 = 1.0;
              double T4 = T3;
              double num15 = 7000.0 * ((num8 - 0.24 * T4) / (1061.0 + 0.444 * T4));
              while (flag2)
              {
                T4 += num14;
                num15 = 7000.0 * ((num8 - 0.24 * T4) / (1061.0 + 0.444 * T4));
                if (num15 < Psychrometrics.HumidityRatio(97.0, T4, elevation))
                {
                  T4 -= num14;
                  num14 *= 0.1;
                }
                if (Math.Abs(num15 - Psychrometrics.HumidityRatio(97.0, T4, elevation)) <= 0.001)
                  flag2 = false;
              }
              T3 = T4;
            }
            if (Math.Abs((T3 + outDbWin) / 2.0 - 32.0) <= 0.001)
              flag1 = false;
            if ((T3 + outDbWin) / 2.0 >= 32.0)
            {
              outDbWin -= num7;
              num7 *= 0.1;
            }
          }
          outputObj.Capacity = outDbWin - inputObj.OutDBWin;
          outputObj.TFrost = outDbWin;
        }
      }
    }

    public static void Effectivenesses(ref int Model, ref double RecEffLsup, ref double RecEffSSup, ref double RecEFFL, ref double RecEffS, ref double SupplyFlow, ref double ExhaustFlow, ModelData modelData)
    {
      double num1;
      if (ExhaustFlow != 0.0)
        num1 = SupplyFlow / ExhaustFlow;
      double num2;
      double num3;
      if (num1 > 1.0)
      {
        num2 = 1.0 / num1;
        num3 = ExhaustFlow;
      }
      else
      {
        num2 = num1;
        num3 = SupplyFlow;
      }
      RecEFFL = modelData.A1LAT + modelData.A2LAT * num2 + modelData.A3LAT * num3 + modelData.A4LAT * Math.Pow(num2 * num3, 0.5) + modelData.A5LAT * Math.Pow(num2 * num3, 0.25);
      RecEffS = modelData.A1SENS + modelData.A2SENS * num2 + modelData.A3SENS * num3 + modelData.A4SENS * Math.Pow(num2 * num3, 0.5) + modelData.A5SENS * Math.Pow(num2 * num3, 0.25);
      if (RecEFFL >= 0.99)
        RecEFFL = 0.99;
      if (RecEffS >= 0.99)
        RecEffS = 0.99;
      if (num1 > 1.0)
      {
        RecEffLsup = RecEFFL / num1;
        RecEffSSup = RecEffS / num1;
      }
      else
      {
        RecEffLsup = RecEFFL;
        RecEffSSup = RecEffS;
      }
    }

    public void RecalculateOutputs(Inputs inputObj, ref Outputs outputObj, ref List<ErrFlags> errsList, bool callSingle)
    {
      EffectivenessValues effectivenessValues = new EffectivenessValues();
      Psychrometrics.SetAirProperties(inputObj.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double airDensity = Psychrometrics.AirDensity;
      double WinterFreshSCFM = 0.0;
      double WinterExhaustSCFM = 0.0;
      ModelData modelData1 = new ModelData();
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      ModelData modelData2 = modelDbFunctions.GetModelData(inputObj.ConfigFileLocation, inputObj.ModelID, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsList.Add(errs);
      }
      else
      {
        double W1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
        double W2 = Psychrometrics.WetBulbHR(inputObj.OutDBSum, inputObj.OutWBSum, inputObj.Elevation);
        double W3 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
        double W4 = Psychrometrics.WetBulbHR(inputObj.OutDBWin, inputObj.OutWBWin, inputObj.Elevation);
        ModelData modelData3 = modelData2;
        int num1 = 1;
        int integer;
        double EFFSl1;
        double EFFSs1;
        double num2;
        double num3;
        double num4;
        do
        {
          ModelData modelData4 = modelData3;
          integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData4.ID);
          ref int local1 = ref integer;
          ref double local2 = ref EFFSl1;
          ref double local3 = ref EFFSs1;
          ref double local4 = ref num2;
          ref double local5 = ref num3;
          double num5 = inputObj.FreshSCFM / inputObj.Wheels;
          ref double local6 = ref num5;
          num4 = inputObj.ExhaustSCFM / inputObj.Wheels;
          ref double local7 = ref num4;
          ModelData modelData5 = modelData2;
          GlobalFunctions.Effectivenesses(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, modelData5);
          modelData4.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
          double T = inputObj.OutDBSum - EFFSs1 * (inputObj.OutDBSum - inputObj.InDBSum);
          double W5 = W2 - EFFSl1 * (W2 - W1);
          inputObj.FreshSCFM = Psychrometrics.AcfmToScfm(inputObj.FreshFlow, T, W5, inputObj.Elevation);
          inputObj.ExhaustSCFM = Psychrometrics.AcfmToScfm(inputObj.OutFlow, inputObj.InDBSum, W1, inputObj.Elevation);
          checked { ++num1; }
        }
        while (num1 <= 5);
        ModelData modelData6 = modelData3;
        integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData6.ID);
        ref int local8 = ref integer;
        ref double local9 = ref EFFSl1;
        ref double local10 = ref EFFSs1;
        ref double local11 = ref num2;
        ref double local12 = ref num3;
        num4 = inputObj.FreshSCFM / inputObj.Wheels;
        ref double local13 = ref num4;
        double num6 = inputObj.ExhaustSCFM / inputObj.Wheels;
        ref double local14 = ref num6;
        ModelData modelData7 = modelData2;
        GlobalFunctions.Effectivenesses(ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, modelData7);
        modelData6.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
        outputObj.EffValues.LatentEffectiveness = num2;
        outputObj.EffValues.SensibleEffectiveness = num3;
        outputObj.EffValues.SupLatentEffectiveness = EFFSl1;
        outputObj.EffValues.SupSensibleEffectiveness = EFFSs1;
        if (inputObj.Sensible)
        {
          new SensibleFuncs().GetSensibleWheelEFF(inputObj, true, ref outputObj, ref EFFSs1, ref EFFSl1);
          if (EFFSl1 == 0.0)
            num2 = 0.0;
          outputObj.EffValues.LatentEffectiveness = num2;
          outputObj.EffValues.SensibleEffectiveness = num3;
          outputObj.EffValues.SupLatentEffectiveness = EFFSl1;
          outputObj.EffValues.SupSensibleEffectiveness = EFFSs1;
        }
        int num7 = 1;
        double EFFSl2;
        double EFFSs2;
        double num8;
        double num9;
        do
        {
          ModelData modelData4 = modelData3;
          integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData4.ID);
          ref int local1 = ref integer;
          ref double local2 = ref EFFSl2;
          ref double local3 = ref EFFSs2;
          ref double local4 = ref num8;
          ref double local5 = ref num9;
          num4 = WinterFreshSCFM / inputObj.Wheels;
          ref double local6 = ref num4;
          num6 = WinterExhaustSCFM / inputObj.Wheels;
          ref double local7 = ref num6;
          ModelData modelData5 = modelData2;
          GlobalFunctions.Effectivenesses(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, modelData5);
          modelData4.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
          double T = inputObj.OutDBWin - EFFSs2 * (inputObj.OutDBWin - inputObj.InDBWin);
          double W5 = W4 - EFFSl2 * (W4 - W3);
          WinterFreshSCFM = Psychrometrics.AcfmToScfm(inputObj.FreshFlow, T, W5, inputObj.Elevation);
          WinterExhaustSCFM = Psychrometrics.AcfmToScfm(inputObj.OutFlow, inputObj.InDBWin, W3, inputObj.Elevation);
          checked { ++num7; }
        }
        while (num7 <= 5);
        ModelData modelData8 = modelData3;
        integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(modelData8.ID);
        ref int local15 = ref integer;
        ref double local16 = ref EFFSl2;
        ref double local17 = ref EFFSs2;
        ref double local18 = ref num8;
        ref double local19 = ref num9;
        num4 = WinterFreshSCFM / inputObj.Wheels;
        ref double local20 = ref num4;
        num6 = WinterExhaustSCFM / inputObj.Wheels;
        ref double local21 = ref num6;
        ModelData modelData9 = modelData2;
        GlobalFunctions.Effectivenesses(ref local15, ref local16, ref local17, ref local18, ref local19, ref local20, ref local21, modelData9);
        modelData8.ID = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(integer);
        outputObj.EffValues.WinterLatentEffectiveness = num8;
        outputObj.EffValues.WinterSensibleEffectiveness = num9;
        outputObj.EffValues.WinterSupLatentEffectiveness = EFFSl2;
        outputObj.EffValues.WinterSupSensibleEffectiveness = EFFSs2;
        if (inputObj.Sensible)
        {
          new SensibleFuncs().GetSensibleWheelEFF(inputObj, false, ref outputObj, ref EFFSs2, ref EFFSl2);
          if (EFFSl2 == 0.0)
            num8 = 0.0;
          outputObj.EffValues.WinterLatentEffectiveness = num8;
          outputObj.EffValues.WinterSensibleEffectiveness = num9;
          outputObj.EffValues.WinterSupLatentEffectiveness = EFFSl2;
          outputObj.EffValues.WinterSupSensibleEffectiveness = EFFSs2;
        }
        outputObj.PreHeater = 1.08 * WinterFreshSCFM * inputObj.OACF * (1.0 + inputObj.EATR / 100.0) * inputObj.Capacity;
        outputObj.NeededValues.EnthSumO = Psychrometrics.Enthalpy(inputObj.OutDBSum, W2);
        outputObj.NeededValues.EnthSumI = Psychrometrics.Enthalpy(inputObj.InDBSum, W1);
        outputObj.NeededValues.EnthWinO = Psychrometrics.Enthalpy(inputObj.OutDBWin, W4);
        outputObj.NeededValues.EnthWinI = Psychrometrics.Enthalpy(inputObj.InDBWin, W3);
        outputObj.FreshSCFM = inputObj.FreshSCFM;
        outputObj.ExhaustSCFM = inputObj.ExhaustSCFM;
        if (callSingle)
          this.SingleDesign(inputObj, ref outputObj, ref errsList, WinterFreshSCFM, WinterExhaustSCFM);
      }
    }

    public void SingleDesign(Inputs inputObj, ref Outputs outputobj, ref List<ErrFlags> errsList, double WinterFreshSCFM, double WinterExhaustSCFM)
    {
      double num1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
      double num2 = Psychrometrics.WetBulbHR(inputObj.OutDBSum, inputObj.OutWBSum, inputObj.Elevation);
      double num3 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
      double num4 = Psychrometrics.WetBulbHR(inputObj.OutDBWin, inputObj.OutWBWin, inputObj.Elevation);
      Psychrometrics.SetAirProperties(inputObj.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double airDensity = Psychrometrics.AirDensity;
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      ModelData modelData1 = new ModelData();
      ModelData modelData2 = new ModelDBFunctions().GetModelData(inputObj.ConfigFileLocation, inputObj.ModelID, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsList.Add(errs);
      }
      else
      {
        double num5 = this.EffLAdjustedForRPM(modelData2.WHEELRPM, modelData2.WHEELDEPTH, outputobj.EffValues.SupLatentEffectiveness, modelData2.WHEELRPM * (double) inputObj.PercentRatedRPM / 100.0);
        double num6 = this.EffSAdjustedForRPM(modelData2.WHEELRPM, modelData2.WHEELDEPTH, outputobj.EffValues.SupSensibleEffectiveness, modelData2.WHEELRPM * (double) inputObj.PercentRatedRPM / 100.0);
        double num7 = this.EffLAdjustedForRPM(modelData2.WHEELRPM, modelData2.WHEELDEPTH, outputobj.EffValues.WinterSupLatentEffectiveness, modelData2.WHEELRPM * (double) inputObj.PercentRatedRPM / 100.0);
        double num8 = this.EffSAdjustedForRPM(modelData2.WHEELRPM, modelData2.WHEELDEPTH, outputobj.EffValues.WinterSupSensibleEffectiveness, modelData2.WHEELRPM * (double) inputObj.PercentRatedRPM / 100.0);
        outputobj.SupDBSum = inputObj.OutDBSum - num6 * (inputObj.OutDBSum - inputObj.InDBSum);
        outputobj.SupHRSum = num2 - num5 * (num2 - num1);
        outputobj.SupEnthSum = Psychrometrics.Enthalpy(outputobj.SupDBSum, outputobj.SupHRSum);
        double num9 = Math.Abs(outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI) <= 0.1 ? 0.0 : (outputobj.NeededValues.EnthSumO - outputobj.SupEnthSum) / (outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI);
        if (inputObj.EATR > 0.0)
        {
          outputobj.DBSupSNet = (outputobj.SupDBSum + inputObj.EATR / 100.0 * inputObj.InDBSum) / (1.0 + inputObj.EATR / 100.0);
          outputobj.HRSupSNet = (outputobj.SupHRSum + inputObj.EATR / 100.0 * num1) / (1.0 + inputObj.EATR / 100.0);
        }
        else
        {
          outputobj.DBSupSNet = outputobj.SupDBSum;
          outputobj.HRSupSNet = outputobj.SupHRSum;
        }
        outputobj.EnthSupSNet = Psychrometrics.Enthalpy(outputobj.DBSupSNet, outputobj.HRSupSNet);
        outputobj.TwbEsts = inputObj.OutWBSum - num6 * (inputObj.OutWBSum - inputObj.InWBSum);
        outputobj.WBSupSNet = Psychrometrics.WetBulbTemp(outputobj.DBSupSNet, outputobj.EnthSupSNet, outputobj.TwbEsts, airPressure);
        outputobj.RHSupSNet = Psychrometrics.RelativeHumidity(outputobj.DBSupSNet, outputobj.HRSupSNet, inputObj.Elevation);
        if (outputobj.WBSupSNet > outputobj.DBSupSNet)
        {
          ErrFlags errFlags = new ErrFlags()
          {
            ErrType = 6
          };
          errFlags.ErrText = errFlags.rhIssueText;
          errsList.Add(errFlags);
        }
        else
        {
          if (inputObj.OptFrost == 1)
          {
            outputobj.TempWIn = inputObj.OutDBWin >= inputObj.ControlTemp ? inputObj.OutDBWin : (inputObj.ControlTemp - inputObj.OutDBWin <= inputObj.Capacity ? inputObj.ControlTemp : inputObj.OutDBWin + inputObj.Capacity);
            outputobj.EnthWIn = outputobj.NeededValues.EnthWinO + 0.24 * (outputobj.TempWIn - inputObj.OutDBWin);
          }
          else
          {
            outputobj.TempWIn = inputObj.OutDBWin;
            outputobj.EnthWIn = outputobj.NeededValues.EnthWinO;
          }
          outputobj.SupDBWin = outputobj.TempWIn - num8 * (outputobj.TempWIn - inputObj.InDBWin);
          outputobj.SupHRWin = num4 - num7 * (num4 - num3);
          outputobj.SupEnthWin = Psychrometrics.Enthalpy(outputobj.SupDBWin, outputobj.SupHRWin);
          double num10 = outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI == 0.0 ? 0.0 : (outputobj.NeededValues.EnthWinO - outputobj.SupEnthWin) / (outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI);
          if (inputObj.EATR > 0.0)
          {
            outputobj.DbsupwNet = (outputobj.SupDBWin + inputObj.EATR / 100.0 * inputObj.InDBWin) / (1.0 + inputObj.EATR / 100.0);
            outputobj.HRsupwNet = (outputobj.SupHRWin + inputObj.EATR / 100.0 * num3) / (1.0 + inputObj.EATR / 100.0);
          }
          else
          {
            outputobj.DbsupwNet = outputobj.SupDBWin;
            outputobj.HRsupwNet = outputobj.SupHRWin;
          }
          outputobj.EnthsupwNet = Psychrometrics.Enthalpy(outputobj.DbsupwNet, outputobj.HRsupwNet);
          outputobj.TwbEstw = inputObj.OutWBWin - num8 * (inputObj.OutWBWin - inputObj.InWBWin);
          outputobj.WBsupwNet = Psychrometrics.WetBulbTemp(outputobj.DbsupwNet, outputobj.EnthsupwNet, outputobj.TwbEstw, airPressure);
          outputobj.RHsupwNet = Psychrometrics.RelativeHumidity(outputobj.DbsupwNet, outputobj.HRsupwNet, inputObj.Elevation);
          if (outputobj.WBsupwNet > outputobj.DbsupwNet)
          {
            ErrFlags errFlags = new ErrFlags()
            {
              ErrType = 19
            };
            errFlags.ErrText = errFlags.FrostText;
            errsList.Add(errFlags);
          }
          else
          {
            outputobj.OASensSum = 1.08 * inputObj.FreshSCFM * (inputObj.OutDBSum - inputObj.InDBSum);
            outputobj.OATotalSum = 4.5 * inputObj.FreshSCFM * (outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI);
            outputobj.OALatentSum = outputobj.OATotalSum - outputobj.OASensSum;
            outputobj.OARecoveredSensibleSum = 1.08 * inputObj.FreshSCFM * (inputObj.OutDBSum - outputobj.SupDBSum);
            outputobj.OARecoveredSum = outputobj.EffValues.LatentEffectiveness != 0.0 ? 4.5 * inputObj.FreshSCFM * (outputobj.NeededValues.EnthSumO - outputobj.SupEnthSum) : outputobj.OARecoveredSensibleSum;
            outputobj.OARecoveredLatentSum = outputobj.OARecoveredSum - outputobj.OARecoveredSensibleSum;
            outputobj.OANetSum = outputobj.OATotalSum - outputobj.OARecoveredSum;
            outputobj.OASensibleWin = 1.08 * WinterFreshSCFM * (inputObj.OutDBWin - inputObj.InDBWin);
            outputobj.OATotalWin = 4.5 * WinterFreshSCFM * (outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI);
            outputobj.OALatentWin = outputobj.OATotalWin - outputobj.OASensibleWin;
            outputobj.PreHeater = 1.08 * WinterFreshSCFM * inputObj.OACF * (1.0 + inputObj.EATR / 100.0) * (outputobj.TempWIn - inputObj.OutDBWin);
            outputobj.OARecoveredSensibleWin = 1.08 * WinterFreshSCFM * (outputobj.TempWIn - outputobj.SupDBWin);
            outputobj.OARecoveredWin = outputobj.EffValues.WinterLatentEffectiveness != 0.0 ? 4.5 * WinterFreshSCFM * (outputobj.EnthWIn - outputobj.SupEnthWin) : outputobj.OARecoveredSensibleWin;
            outputobj.OARecoveredLatentWin = outputobj.OARecoveredWin - outputobj.OARecoveredSensibleWin;
            outputobj.OANetWin = outputobj.OATotalWin - outputobj.OARecoveredWin + Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(outputobj.PreHeater > 0.0, (object) outputobj.PreHeater, (object) 0));
            outputobj.CLGSav = outputobj.OARecoveredSum / 12000.0;
            outputobj.HTGSav = Math.Abs(outputobj.OARecoveredWin) + Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(outputobj.PreHeater > 0.0, (object) outputobj.PreHeater, (object) 0));
            double num11 = num2 - num1 == 0.0 ? 0.0 : (num2 - outputobj.HRSupSNet) / (num2 - num1);
            double num12 = inputObj.OutDBSum - inputObj.InDBSum == 0.0 ? 0.0 : (inputObj.OutDBSum - outputobj.DBSupSNet) / (inputObj.OutDBSum - inputObj.InDBSum);
            double num13 = outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI == 0.0 ? 0.0 : (outputobj.NeededValues.EnthSumO - outputobj.EnthSupSNet) / (outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI);
            double num14 = num4 - num3 == 0.0 ? 0.0 : (num4 - outputobj.HRsupwNet) / (num4 - num3);
            double num15 = inputObj.OutDBWin - inputObj.InDBWin == 0.0 ? 0.0 : (inputObj.OutDBWin - outputobj.DbsupwNet) / (inputObj.OutDBWin - inputObj.InDBWin);
            double num16 = outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI == 0.0 ? 0.0 : (outputobj.NeededValues.EnthWinO - outputobj.EnthsupwNet) / (outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI);
            double num17 = inputObj.FreshSupplyFlow <= inputObj.ExhaustReturnFlow ? inputObj.FreshSupplyFlow : inputObj.ExhaustReturnFlow;
            double num18 = inputObj.FreshSCFM / (1.0 - inputObj.EATR / 100.0) - inputObj.FreshSCFM;
            if (inputObj.FreshSCFM / inputObj.ExhaustSCFM < 1.0)
              ;
            double num19 = (inputObj.FreshSCFM + num18) / (inputObj.ExhaustSCFM + num18);
            if (num19 < 1.0)
              num19 = 1.0;
            double num20 = WinterFreshSCFM / (1.0 - inputObj.EATR / 100.0) - WinterFreshSCFM;
            double num21 = (WinterFreshSCFM + num20) / (WinterExhaustSCFM + num20);
            if (num21 < 1.0)
              num21 = 1.0;
            outputobj.ESSM = inputObj.OutDBSum - inputObj.InDBSum == 0.0 ? 0.0 : num19 * (inputObj.OutDBSum - outputobj.DBSupSNet) / (inputObj.OutDBSum - inputObj.InDBSum);
            outputobj.ELSM = num2 - num1 == 0.0 ? 0.0 : num19 * (num2 - outputobj.HRSupSNet) / (num2 - num1);
            outputobj.ETSM = outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI == 0.0 ? 0.0 : num19 * (outputobj.NeededValues.EnthSumO - outputobj.EnthSupSNet) / (outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI);
            outputobj.ESSN = inputObj.OutDBSum - inputObj.InDBSum == 0.0 ? 0.0 : num19 * (inputObj.OutDBSum - (outputobj.DBSupSNet - inputObj.EATR * inputObj.InDBSum / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (inputObj.OutDBSum - inputObj.InDBSum);
            outputobj.ELSN = num2 - num1 == 0.0 ? 0.0 : num19 * (num2 - (outputobj.HRSupSNet - inputObj.EATR * num1 / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (num2 - num1);
            outputobj.ETSN = Math.Abs(outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI) <= 0.1 ? 0.0 : num19 * (outputobj.NeededValues.EnthSumO - (outputobj.EnthSupSNet - inputObj.EATR * outputobj.NeededValues.EnthSumI / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (outputobj.NeededValues.EnthSumO - outputobj.NeededValues.EnthSumI);
            outputobj.ESWM = inputObj.OutDBWin - inputObj.InDBWin == 0.0 ? 0.0 : num21 * (outputobj.TempWIn - outputobj.DbsupwNet) / (inputObj.OutDBWin - inputObj.InDBWin);
            outputobj.ELWM = num4 - num3 == 0.0 ? 0.0 : num21 * (num4 - outputobj.HRsupwNet) / (num4 - num3);
            outputobj.ETWM = outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI == 0.0 ? 0.0 : num21 * (outputobj.EnthWIn - outputobj.EnthsupwNet) / (outputobj.EnthWIn - outputobj.NeededValues.EnthWinI);
            outputobj.ESWN = inputObj.OutDBWin - inputObj.InDBWin == 0.0 ? 0.0 : num21 * (inputObj.OutDBWin - (outputobj.DbsupwNet - inputObj.EATR * inputObj.InDBWin / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (inputObj.OutDBWin - inputObj.InDBWin);
            outputobj.ELWN = num4 - num3 == 0.0 ? 0.0 : num21 * (num4 - (outputobj.HRsupwNet - inputObj.EATR * num3 / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (num4 - num3);
            outputobj.ETwN = outputobj.NeededValues.EnthWinO - outputobj.NeededValues.EnthWinI == 0.0 ? 0.0 : num21 * (outputobj.EnthWIn - (outputobj.EnthsupwNet - inputObj.EATR * outputobj.NeededValues.EnthWinI / 100.0) / (1.0 - inputObj.EATR / 100.0)) / (outputobj.EnthWIn - outputobj.NeededValues.EnthWinI);
            outputobj.DbexhsNet = (inputObj.FreshSCFM * inputObj.OutDBSum + inputObj.ExhaustSCFM * inputObj.InDBSum - inputObj.FreshSCFM * outputobj.SupDBSum) / inputObj.ExhaustSCFM;
            outputobj.HrexhsNet = (inputObj.FreshSCFM * num2 + inputObj.ExhaustSCFM * num1 - inputObj.FreshSCFM * outputobj.SupHRSum) / inputObj.ExhaustSCFM;
            outputobj.EnthexhsNet = Psychrometrics.Enthalpy(outputobj.DbexhsNet, outputobj.HrexhsNet);
            outputobj.WbexhsNet = Psychrometrics.WetBulbTemp(outputobj.DbexhsNet, outputobj.EnthexhsNet, outputobj.DbexhsNet - 2.0, airPressure);
            outputobj.RhexhsNet = Psychrometrics.RelativeHumidity(outputobj.DbexhsNet, outputobj.HrexhsNet, inputObj.Elevation);
            outputobj.DbexhwNet = (WinterFreshSCFM * outputobj.TempWIn + WinterExhaustSCFM * inputObj.InDBWin - WinterFreshSCFM * outputobj.SupDBWin) / WinterExhaustSCFM;
            outputobj.HrexhwNet = (WinterFreshSCFM * num4 + WinterExhaustSCFM * num3 - WinterFreshSCFM * outputobj.SupHRWin) / WinterExhaustSCFM;
            outputobj.EnthexhwNet = Psychrometrics.Enthalpy(outputobj.DbexhwNet, outputobj.HrexhwNet);
            if (Psychrometrics.SaturationHR(outputobj.DbexhwNet, inputObj.Elevation) < outputobj.HrexhwNet)
            {
              outputobj.DbexhwNet = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(this.RH_hToTdb(99.0, outputobj.EnthexhwNet, outputobj.DbexhwNet, inputObj.Elevation));
              double num22 = (outputobj.HrexhwNet - Psychrometrics.HumidityRatio(99.0, outputobj.DbexhwNet, inputObj.Elevation)) * 4.5 * WinterExhaustSCFM / 7000.0;
              outputobj.HrexhwNet = Psychrometrics.HumidityRatio(99.0, outputobj.DbexhwNet, inputObj.Elevation);
            }
            outputobj.DbexhwNet = Psychrometrics.W_hToTdb(outputobj.HrexhwNet, outputobj.EnthexhwNet, inputObj.Elevation);
            outputobj.WbexhwNet = Psychrometrics.WetBulbTemp(outputobj.DbexhwNet, outputobj.EnthexhwNet, outputobj.DbexhwNet - 2.0, airPressure);
            outputobj.RhexhwNet = Psychrometrics.RelativeHumidity(outputobj.DbexhwNet, outputobj.HrexhwNet, inputObj.Elevation);
            outputobj.DbexhsNet += inputObj.OACF * (inputObj.FreshSCFM / inputObj.ExhaustSCFM) / 100.0;
            outputobj.HrexhsNet = (outputobj.HrexhsNet + inputObj.OACF / 100.0 * (inputObj.FreshSCFM / inputObj.ExhaustSCFM) * num2) / (1.0 + inputObj.OACF * (inputObj.FreshSCFM / inputObj.ExhaustSCFM) / 100.0);
            outputobj.EnthexhsNet = Psychrometrics.Enthalpy(outputobj.DbexhsNet, outputobj.HrexhsNet);
            outputobj.WbexhsNet = Psychrometrics.WetBulbTemp(outputobj.DbexhsNet, outputobj.EnthexhsNet, outputobj.DbexhsNet - 2.0, airPressure);
            outputobj.RhexhsNet = Psychrometrics.RelativeHumidity(outputobj.DbexhsNet, outputobj.HrexhsNet, inputObj.Elevation);
            outputobj.DbexhwNet = (outputobj.DbexhwNet + inputObj.OACF * (WinterFreshSCFM / WinterExhaustSCFM) / 100.0 * inputObj.OutDBWin) / (1.0 + inputObj.OACF * (WinterFreshSCFM / WinterExhaustSCFM) / 100.0);
            outputobj.HrexhwNet = (outputobj.HrexhwNet + inputObj.OACF * (WinterFreshSCFM / WinterExhaustSCFM) / 100.0 * num4) / (1.0 + inputObj.OACF * (WinterFreshSCFM / WinterExhaustSCFM) / 100.0);
            outputobj.EnthexhwNet = Psychrometrics.Enthalpy(outputobj.DbexhwNet, outputobj.HrexhwNet);
            outputobj.WbexhwNet = Psychrometrics.WetBulbTemp(outputobj.DbexhwNet, outputobj.EnthexhwNet, outputobj.DbexhwNet - 2.0, airPressure);
            outputobj.RhexhwNet = Psychrometrics.RelativeHumidity(outputobj.DbexhwNet, outputobj.HrexhwNet, inputObj.Elevation);
          }
        }
      }
    }

    public object RH_hToTdb(double RH, double h, double T, double Elev)
    {
      bool flag = true;
      double num1 = 1.0;
      while (flag)
      {
        T += num1;
        double num2 = 7000.0 * ((h - 0.24 * T) / (1061.0 + 0.444 * T));
        if (num2 < Psychrometrics.HumidityRatio(RH, T, Elev))
        {
          T -= num1;
          num1 *= 0.1;
        }
        if (Math.Abs(num2 - Psychrometrics.HumidityRatio(RH, T, Elev)) <= 0.001)
          flag = false;
      }
      return (object) T;
    }

    public double EffSAdjustedForRPM(double wheelRPM, double wheelDepth, double ratedeff, double newRPM)
    {
      double num1 = 0.0;
      double d = 50.0 * newRPM / wheelRPM;
      double num2 = wheelDepth;
      double num3;
      double num4;
      if (num2 == 1.0 || num2 == 1.5 || num2 == 2.0)
      {
        double num5 = ratedeff - 8.2169 * Math.Log(wheelRPM);
        num3 = 8.2169 * Math.Log(newRPM) + num5;
        num1 = 8.2169 * Math.Log(newRPM) + 44.26;
        double num6 = 8.2169 * Math.Log(50.0) + 44.26;
        double num7 = 8.2169 * Math.Log(d) + 44.26;
        num4 = ratedeff * num7 / num6;
      }
      else if (num2 == 3.0)
      {
        double num5 = ratedeff - 6.1182 * Math.Log(wheelRPM);
        num3 = 6.1182 * Math.Log(newRPM) + num5;
        num1 = 6.1882 * Math.Log(newRPM) + 42.75;
        double num6 = 6.1882 * Math.Log(50.0) + 42.75;
        double num7 = 6.1882 * Math.Log(d) + 42.75;
        num4 = ratedeff * num7 / num6;
      }
      else
        num4 = ratedeff;
      return num4;
    }

    public double EffLAdjustedForRPM(double wheelRPM, double wheelDepth, double ratedeff, double newRPM)
    {
      double num1 = 0.0;
      double x = 50.0 * newRPM / wheelRPM;
      double num2 = wheelDepth;
      double num3;
      if (num2 == 1.0 || num2 == 1.5 || num2 == 2.0)
      {
        double num4 = 70.21688898713;
        double num5 = 0.000167894243060587 * Math.Pow(x, 3.0) - 0.0388279795454908 * Math.Pow(x, 2.0) + 2.96883203890475 * x - 2.14154447695383;
        num3 = ratedeff * num5 / num4;
        num1 = 0.000167894243060587 * Math.Pow(newRPM, 3.0) - 0.0388279795454908 * Math.Pow(newRPM, 2.0) + 2.96883203890475 * newRPM - 2.14154447695383;
      }
      else if (num2 == 3.0)
      {
        num1 = 7.61460761460782E-05 * Math.Pow(newRPM, 3.0) - 0.0223076923076935 * Math.Pow(newRPM, 2.0) + 2.11231546231554 * newRPM - 335.0 / 143.0;
        num3 = ratedeff * 1.0;
      }
      else
        num3 = ratedeff;
      return num3;
    }

    public double RPMAdjustedForTemp(double wheelRPM, double wheelDepth, double ratedeff, double newTemp)
    {
      return wheelRPM;
    }

    public double RPMAdjustedForFrostControl(double wheelRPM, double wheelDepth, double ratedeff, double newTemp)
    {
      return wheelRPM;
    }
  }
}
