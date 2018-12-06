// Decompiled with JetBrains decompiler
// Type: AirXDLL.EnergyCalc
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AirXDLL
{
  public class EnergyCalc
  {
    [DebuggerNonUserCode]
    public EnergyCalc()
    {
    }

    public void CalculateBinData(Inputs inputObj, ref Outputs outputObj, ref List<BinData> binData)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 9999.0 + 5.0;
      int num4 = 0;
      BinData binData1 = new BinData();
      HourData hourData = new HourData();
      double num5 = Conversion.Int(inputObj.HourData[0].DB / 5.0) * 5.0;
      double num6 = num5 + 5.0;
      double num7 = 0.0;
      double num8 = 0.0;
      List<HourData>.Enumerator enumerator;
      try
      {
        enumerator = inputObj.HourData.GetEnumerator();
        while (enumerator.MoveNext())
        {
          HourData current = enumerator.Current;
          if (current.DB < num6 & current.DB >= num5)
          {
            double num9 = Psychrometrics.Enthalpy(current.DB, current.HumRatio);
            if (num9 > inputObj.NeededValues.EnthSumI & current.DB > inputObj.InDBSum | num9 < inputObj.NeededValues.EnthWinI & current.DB < inputObj.InDBWin)
            {
              num1 += current.HumRatio;
              num2 += current.DB;
              checked { ++num4; }
              if (current.Month < 5 | current.Month >= 10)
                ++num7;
              else
                ++num8;
            }
          }
          else
          {
            binData.Add(new BinData()
            {
              MidPoint = Math.Round((num5 + num6) / 2.0, 2),
              W = num1 / (double) num4,
              DB = num2 / (double) num4,
              Hours = num4,
              WinterHours = num7,
              SummerHours = num8
            });
            num5 = Conversion.Int(current.DB / 5.0) * 5.0;
            num6 = num5 + 5.0;
            num1 = 0.0;
            num2 = 0.0;
            num4 = 0;
            num7 = 0.0;
            num8 = 0.0;
            double num9 = Psychrometrics.Enthalpy(current.DB, current.HumRatio);
            if (num9 > inputObj.NeededValues.EnthSumI & current.DB > inputObj.InDBSum | num9 < inputObj.NeededValues.EnthWinI & current.DB < inputObj.InDBWin)
            {
              num1 += current.HumRatio;
              num2 += current.DB;
              checked { ++num4; }
              if (current.Month < 5 | current.Month >= 10)
                ++num7;
              else
                ++num8;
            }
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
      binData.Add(new BinData()
      {
        MidPoint = Math.Round((num5 + num6) / 2.0, 2),
        W = num1 / (double) num4,
        DB = num2 / (double) num4,
        Hours = num4,
        WinterHours = num7,
        SummerHours = num8
      });
    }

    public void CalculateBinDataByMonth(Inputs inputObj, ref Outputs outputObj, ref List<BinData> binData)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 9999.0 + 5.0;
      int num4 = 0;
      BinData binData1 = new BinData();
      HourData hourData = new HourData();
      double num5 = Conversion.Int(inputObj.HourData[0].DB / 5.0) * 5.0;
      double num6 = num5 + 5.0;
      int num7 = 1;
      List<HourData>.Enumerator enumerator;
      try
      {
        enumerator = inputObj.HourData.GetEnumerator();
        while (enumerator.MoveNext())
        {
          HourData current = enumerator.Current;
          if (current.DB < num6 & current.DB >= num5 & current.Month == num7)
          {
            double num8 = Psychrometrics.Enthalpy(current.DB, current.HumRatio);
            if (num8 > inputObj.NeededValues.EnthSumI & current.DB > inputObj.InDBSum | num8 < inputObj.NeededValues.EnthWinI & current.DB < inputObj.InDBWin)
            {
              num1 += current.HumRatio;
              num2 += current.DB;
              checked { ++num4; }
            }
          }
          else
          {
            if (num4 > 0)
              binData.Add(new BinData()
              {
                MidPoint = Math.Round((num5 + num6) / 2.0, 2),
                W = num1 / (double) num4,
                DB = num2 / (double) num4,
                Hours = num4,
                Month = num7
              });
            num5 = Conversion.Int(current.DB / 5.0) * 5.0;
            num6 = num5 + 5.0;
            num1 = 0.0;
            num2 = 0.0;
            num4 = 0;
            num7 = current.Month;
            double num8 = Psychrometrics.Enthalpy(current.DB, current.HumRatio);
            if (num8 > inputObj.NeededValues.EnthSumI & current.DB > inputObj.InDBSum | num8 < inputObj.NeededValues.EnthWinI & current.DB < inputObj.InDBWin)
            {
              num1 += current.HumRatio;
              num2 += current.DB;
              checked { ++num4; }
            }
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
      binData.Add(new BinData()
      {
        MidPoint = Math.Round((num5 + num6) / 2.0, 2),
        W = num1 / (double) num4,
        DB = num2 / (double) num4,
        Hours = num4,
        Month = num7
      });
    }

    public void CalculateEnergyBins(Inputs inputObj, ref Outputs outputObj, ref BinEnergyData binData, List<ErrFlags> errsList)
    {
      double[] numArray1 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray2 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray3 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray4 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray5 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray6 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray7 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray8 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray9 = new double[checked (inputObj.NumRows + 1)];
      double[] numArray10 = new double[checked (inputObj.NumRows + 1)];
      Psychrometrics.SetAirProperties(inputObj.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double airDensity = Psychrometrics.AirDensity;
      double RAW1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
      double RAW2 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
      double freshScfm = inputObj.FreshSCFM;
      double exhaustScfm = inputObj.ExhaustSCFM;
      double num1 = inputObj.OutdoorFlow * (airDensity / 0.075);
      int num2 = 0;
      int num3 = checked (inputObj.NumRows - 1);
      int index1 = num2;
      while (index1 <= num3)
      {
        if (inputObj.BinData[index1].Hours != 0)
        {
          double db = inputObj.BinData[index1].DB;
          numArray1[index1] = inputObj.BinData[index1].W;
          double sensibleEffectiveness = inputObj.EffValues.SupSensibleEffectiveness;
          double latentEffectiveness = inputObj.EffValues.SupLatentEffectiveness;
          numArray2[index1] = Psychrometrics.Enthalpy(db, numArray1[index1]);
          numArray3[index1] = numArray3[index1] + numArray2[index1] * (double) inputObj.BinData[index1].Hours;
          numArray4[index1] = numArray4[index1] + Conversions.EnthalpyToEnthalpyMetricOffset(numArray2[index1], numArray1[index1], inputObj.Metric) * (double) inputObj.BinData[index1].Hours;
          binData.AnnualHours[index1] = binData.AnnualHours[index1] + (double) inputObj.BinData[index1].Hours;
          numArray5[index1] = numArray5[index1] + Psychrometrics.WetBulbTemp(db, numArray2[index1], db, airPressure) * (double) inputObj.BinData[index1].Hours;
          double num4;
          double H;
          if (numArray2[index1] > inputObj.NeededValues.EnthSumI & db > inputObj.InDBSum)
          {
            if (inputObj.Sensible)
              new SensibleFuncs().GetSensibleWheelEFF(db, numArray1[index1], inputObj.InDBSum, RAW1, inputObj.InWBSum, ref freshScfm, ref exhaustScfm, inputObj.Elevation, inputObj.OptFrost, inputObj.ControlTemp, inputObj.Capacity, ref sensibleEffectiveness, ref latentEffectiveness);
            num4 = db - sensibleEffectiveness * (db - inputObj.InDBSum);
            double W = numArray1[index1] - latentEffectiveness * (numArray1[index1] - RAW1);
            H = Psychrometrics.Enthalpy(num4, W);
            numArray7[index1] = numArray7[index1] + numArray2[index1] * (double) inputObj.BinData[index1].Hours;
            numArray8[index1] = numArray8[index1] + H * (double) inputObj.BinData[index1].Hours;
            numArray6[index1] = numArray6[index1] + (double) inputObj.BinData[index1].Hours;
          }
          else if (numArray2[index1] < inputObj.NeededValues.EnthWinI & db < inputObj.InDBWin)
          {
            if (inputObj.Sensible)
              new SensibleFuncs().GetSensibleWheelEFF(db, numArray1[index1], inputObj.InDBWin, RAW2, inputObj.InWBWin, ref freshScfm, ref exhaustScfm, inputObj.Elevation, inputObj.OptFrost, inputObj.ControlTemp, inputObj.Capacity, ref sensibleEffectiveness, ref latentEffectiveness);
            if (inputObj.Temp[index1] < inputObj.ControlTemp & inputObj.OptFrost == 1)
            {
              double num5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(inputObj.ControlTemp - inputObj.Temp[index1] > inputObj.Capacity, (object) inputObj.Capacity, (object) (inputObj.ControlTemp - inputObj.Temp[index1])));
              double num6 = db + num5;
              num4 = num6 + sensibleEffectiveness * (inputObj.InDBWin - num6);
              double W = numArray1[index1] + latentEffectiveness * (RAW2 - numArray1[index1]);
              H = Psychrometrics.Enthalpy(num4, W);
              numArray8[index1] = numArray8[index1] + H * inputObj.BinData[index1].DB;
              double num7 = 0.24 * num5;
              binData.BinPreheat[index1] = binData.BinPreheat[index1] + num7 * (double) inputObj.BinData[index1].Hours;
            }
            else
            {
              num4 = db - sensibleEffectiveness * (db - inputObj.InDBWin);
              double W = numArray1[index1] + latentEffectiveness * (RAW2 - numArray1[index1]);
              H = Psychrometrics.Enthalpy(num4, W);
              numArray8[index1] = numArray8[index1] + H * (double) inputObj.BinData[index1].Hours;
            }
            numArray7[index1] = numArray7[index1] + numArray2[index1] * (double) inputObj.BinData[index1].Hours;
            numArray6[index1] = numArray6[index1] + (double) inputObj.BinData[index1].Hours;
          }
          outputObj.TwbEsts = inputObj.OutWBSum - sensibleEffectiveness * (inputObj.OutWBSum - inputObj.InWBSum);
          if (Psychrometrics.WetBulbTemp(num4, H, outputObj.TwbEsts, airPressure) > num4)
          {
            ErrFlags errFlags = new ErrFlags()
            {
              ErrType = 6
            };
            errFlags.ErrText = errFlags.rhIssueText;
            errsList.Add(errFlags);
            return;
          }
        }
        checked { ++index1; }
      }
      binData.TotalCoolingHours = 0.0;
      binData.TotalVentingCoolingHours = 0.0;
      binData.TotalCoolingRecovered = 0.0;
      binData.TotalNetCoolingLoad = 0.0;
      binData.TotalHeatingHours = 0.0;
      binData.TotalVentingHeatingHours = 0.0;
      binData.TotalHeatingRecovered = 0.0;
      binData.TotalNetHeatingLoad = 0.0;
      binData.TotalPreheat = 0.0;
      int num8 = 0;
      int num9 = checked (inputObj.NumRows - 1);
      int index2 = num8;
      while (index2 <= num9)
      {
        if (binData.AnnualHours[index2] != 0.0)
        {
          binData.MCWB[index2] = numArray5[index2] / binData.AnnualHours[index2];
          binData.BinEnthalpy[index2] = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(inputObj.Metric, (object) numArray4[index2], (object) numArray3[index2])) / binData.AnnualHours[index2];
          if (numArray6[index2] != 0.0)
          {
            numArray10[index2] = numArray7[index2] / numArray6[index2];
            if (inputObj.Temp[index2] > inputObj.InDBSum)
            {
              numArray9[index2] = numArray8[index2] / numArray6[index2];
              binData.BinRecLoad[index2] = 4.5 * freshScfm * (numArray10[index2] - numArray9[index2]) * numArray6[index2];
              binData.BinVentLoad[index2] = 4.5 * freshScfm * (numArray10[index2] - inputObj.NeededValues.EnthSumI) * numArray6[index2];
              binData.BinNetLoad[index2] = binData.BinVentLoad[index2] - binData.BinRecLoad[index2];
            }
            else if (inputObj.Temp[index2] < inputObj.InDBWin)
            {
              numArray9[index2] = numArray8[index2] / numArray6[index2];
              binData.BinRecLoad[index2] = 4.5 * freshScfm * (numArray10[index2] - numArray9[index2]) * numArray6[index2];
              binData.BinVentLoad[index2] = 4.5 * freshScfm * (numArray10[index2] - inputObj.NeededValues.EnthWinI) * numArray6[index2];
              binData.BinNetLoad[index2] = binData.BinVentLoad[index2] - binData.BinRecLoad[index2];
              binData.TotPreEnergy[index2] = 0.0;
              if (inputObj.Temp[index2] < inputObj.ControlTemp & inputObj.OptFrost == 1)
              {
                binData.TotPreEnergy[index2] = 4.5 * num1 * binData.BinPreheat[index2];
                binData.BinRecLoad[index2] = binData.BinRecLoad[index2] + binData.TotPreEnergy[index2];
              }
            }
            else
            {
              binData.BinRecLoad[index2] = 0.0;
              binData.BinVentLoad[index2] = 0.0;
              binData.BinNetLoad[index2] = 0.0;
            }
            if (inputObj.Temp[index2] > inputObj.InDBSum)
            {
              binData.TotalCoolingHours += numArray6[index2];
              binData.TotalVentingCoolingHours += binData.BinVentLoad[index2];
              binData.TotalCoolingRecovered += binData.BinRecLoad[index2];
              binData.TotalNetCoolingLoad += binData.BinNetLoad[index2];
            }
            else if (inputObj.Temp[index2] < inputObj.InDBWin)
            {
              binData.TotalHeatingHours += numArray6[index2];
              binData.TotalVentingHeatingHours += binData.BinVentLoad[index2];
              binData.TotalHeatingRecovered += binData.BinRecLoad[index2];
              binData.TotalNetHeatingLoad += binData.BinNetLoad[index2];
              binData.TotalPreheat += binData.TotPreEnergy[index2];
            }
          }
        }
        checked { ++index2; }
      }
    }

    public void AllEnergyBinByMonth(Inputs inputObj, ref Outputs outputobj, ref BinEnergyData binData, ref List<ErrFlags> errsList)
    {
      GlobalFunctions globalFunctions = new GlobalFunctions();
      double[] numArray1 = new double[31];
      double[] numArray2 = new double[31];
      double[] numArray3 = new double[31];
      double[] numArray4 = new double[31];
      double[] numArray5 = new double[31];
      double[] numArray6 = new double[31];
      double[] numArray7 = new double[31];
      double[] numArray8 = new double[13];
      double[] numArray9 = new double[13];
      double[] numArray10 = new double[31];
      double[] numArray11 = new double[31];
      double[] numArray12 = new double[31];
      double[] numArray13 = new double[31];
      double[] numArray14 = new double[31];
      Psychrometrics.SetAirProperties(inputObj.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double airDensity = Psychrometrics.AirDensity;
      double RAW1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
      double RAW2 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
      binData.Factor = 1.0;
      double num1 = 0.0;
      double num2 = 999.0;
      List<BinData>.Enumerator enumerator;
      try
      {
        enumerator = inputObj.BinData.GetEnumerator();
        while (enumerator.MoveNext())
        {
          BinData current = enumerator.Current;
          if (current.DB > num1)
            num1 = current.DB;
          if (current.DB < num2)
            num2 = current.DB;
        }
      }
      finally
      {
        enumerator.Dispose();
      }
      double num3 = Conversion.Int(num1 / 5.0) * 5.0 + 5.0;
      double num4 = Conversion.Int(num2 / 5.0) * 5.0 + 5.0;
      int num5 = checked ((int) Math.Round(unchecked (Conversion.Int(num1 - num2) / 5.0 + 1.0)));
      double[] numArray15 = new double[checked (num5 + 1 + 1)];
      double[] numArray16 = new double[checked (num5 + 1 + 1)];
      double[] numArray17 = new double[checked (num5 + 1)];
      int index1 = 0;
      double num6 = num3 - 2.5;
      double num7 = num4 - 2.5;
      double num8 = num6;
      while (num8 >= num7)
      {
        numArray17[index1] = num8;
        checked { ++index1; }
        num8 += -5.0;
      }
      double num9 = 0.0;
      double num10 = 0.0;
      double num11 = 0.0;
      double freshScfm = inputObj.FreshSCFM;
      double exhaustScfm = inputObj.ExhaustSCFM;
      double num12 = inputObj.OutdoorFlow * (airDensity / 0.075);
      double[] numArray18 = new double[checked (num5 + 1)];
      double[] numArray19 = new double[checked (num5 + 1)];
      double[] numArray20 = new double[checked (num5 + 1)];
      double[] numArray21 = new double[checked (num5 + 1)];
      double[] numArray22 = new double[checked (num5 + 1)];
      numArray3 = new double[checked (num5 + 1)];
      binData.AnnualHours = new double[checked (num5 + 1)];
      double[] numArray23 = new double[checked (num5 + 1)];
      binData.MCWB = new double[checked (num5 + 1)];
      binData.DryBulb = new double[checked (num5 + 1)];
      double[] numArray24 = new double[checked (num5 + 1)];
      binData.BinVentLoad = new double[checked (num5 + 1)];
      binData.BinRecLoad = new double[checked (num5 + 1)];
      binData.BinNetLoad = new double[checked (num5 + 1)];
      binData.binAverageTemps = new double[checked (num5 + 1)];
      double[] numArray25 = new double[checked (num5 + 1)];
      double[] numArray26 = new double[checked (num5 + 1)];
      int num13 = 0;
      int num14 = num5;
      int index2 = num13;
      while (index2 <= num14)
      {
        numArray18[index2] = 0.0;
        numArray19[index2] = 0.0;
        numArray20[index2] = 0.0;
        numArray21[index2] = 0.0;
        numArray22[index2] = 0.0;
        binData.AnnualHours[index2] = 0.0;
        numArray23[index2] = 0.0;
        binData.MCWB[index2] = 0.0;
        numArray24[index2] = 0.0;
        binData.BinVentLoad[index2] = 0.0;
        binData.BinRecLoad[index2] = 0.0;
        binData.BinNetLoad[index2] = 0.0;
        binData.BinPreheat[index2] = 0.0;
        binData.DryBulb[index2] = numArray17[index2];
        checked { ++index2; }
      }
      int num15 = 0;
      int[] numArray27 = new int[13];
      int index3 = 0;
      do
      {
        numArray27[index3] = inputObj.MonthlyHours[index3];
        checked { ++index3; }
      }
      while (index3 <= 11);
      int index4 = 1;
      int num16 = 0;
      int num17 = checked (inputObj.BinData.Count - 1);
      int index5 = num16;
      while (index5 <= num17)
      {
        int[] numArray28 = numArray27;
        int[] numArray29 = numArray28;
        int index6 = checked (inputObj.BinData[index5].Month - 1);
        int index7 = index6;
        int num18 = checked (numArray28[index6] - inputObj.BinData[index5].Hours);
        numArray29[index7] = num18;
        int index8;
        double num19;
        double num20;
        double num21;
        double num22;
        if (inputObj.BinData[index5].Month != num15)
        {
          num15 = inputObj.BinData[index5].Month;
          index8 = 0;
          index4 = num15;
          if (checked (index4 + 1) < 5 | checked (index4 + 1) > 10)
          {
            if (inputObj.HeatingIndex == 0)
            {
              num19 = inputObj.HeatingEfficiency / 100.0;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.FuelCost / 1000000.0;
              num22 = inputObj.WinterElecCost;
            }
            else if (inputObj.HeatingIndex == 1)
            {
              num19 = 1000.0 * inputObj.HeatingEER;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.WinterElecCost;
              num22 = inputObj.WinterElecCost;
            }
            else if (inputObj.HeatingIndex == 2)
            {
              num19 = 3413.0;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.WinterElecCost;
              num22 = inputObj.WinterElecCost;
            }
          }
          else
          {
            numArray8[index4] = 0.0;
            numArray9[index4] = 0.0;
            if (inputObj.HeatingIndex == 0)
            {
              num19 = inputObj.HeatingEfficiency / 100.0;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.FuelCost / 1000000.0;
              num22 = inputObj.SummerElecCost;
            }
            else if (inputObj.HeatingIndex == 1)
            {
              num19 = 1000.0 * inputObj.HeatingEER;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.SummerElecCost;
              num22 = inputObj.SummerElecCost;
            }
            else if (inputObj.HeatingIndex == 2)
            {
              num19 = 3413.0;
              num20 = 1000.0 * inputObj.CoolingEER;
              num21 = inputObj.SummerElecCost;
              num22 = inputObj.SummerElecCost;
            }
          }
        }
        int num23 = 0;
        int num24 = checked (num5 - 1);
        int index9 = num23;
        while (index9 <= num24 && inputObj.BinData[index5].MidPoint != numArray17[index9])
          checked { ++index9; }
        double db = inputObj.BinData[index5].DB;
        numArray25[index8] = inputObj.BinData[index5].W;
        double sensibleEffectiveness = inputObj.EffValues.SupSensibleEffectiveness;
        double latentEffectiveness = inputObj.EffValues.SupLatentEffectiveness;
        numArray26[index8] = Psychrometrics.Enthalpy(db, numArray25[index8]);
        numArray24[index9] = numArray24[index9] + numArray26[index8] * (double) inputObj.BinData[index5].Hours;
        numArray12[index9] = numArray12[index9] + Conversions.EnthalpyToEnthalpyMetricOffset(numArray26[index8], numArray25[index8], inputObj.Metric) * (double) inputObj.BinData[index5].Hours;
        binData.AnnualHours[index9] = binData.AnnualHours[index9] + (double) inputObj.BinData[index5].Hours;
        numArray13[index9] = numArray13[index9] + Psychrometrics.WetBulbTemp(db, numArray26[index8], db, airPressure) * (double) inputObj.BinData[index5].Hours;
        num11 += num22 * (double) inputObj.BinData[index5].Hours;
        numArray9[index4] = 1.0;
        if (numArray26[index8] > inputObj.NeededValues.EnthSumI & db > inputObj.InDBSum)
        {
          double[] numArray30 = numArray16;
          double[] numArray31 = numArray30;
          int index10 = index9;
          int index11 = index10;
          double num25 = numArray30[index10] + db * (double) inputObj.BinData[index5].Hours;
          numArray31[index11] = num25;
          double[] numArray32 = numArray15;
          double[] numArray33 = numArray32;
          int index12 = index9;
          int index13 = index12;
          double num26 = numArray32[index12] + (double) inputObj.BinData[index5].Hours;
          numArray33[index13] = num26;
          if (num20 == 0.0)
          {
            ErrFlags errFlags = new ErrFlags()
            {
              ErrType = 8
            };
            errFlags.ErrText = errFlags.BadDataText;
            errsList.Add(errFlags);
            return;
          }
          if (inputObj.Sensible)
            new SensibleFuncs().GetSensibleWheelEFF(db, numArray25[index8], inputObj.InDBSum, RAW1, inputObj.InWBSum, ref freshScfm, ref exhaustScfm, inputObj.Elevation, inputObj.OptFrost, inputObj.ControlTemp, inputObj.Capacity, ref sensibleEffectiveness, ref latentEffectiveness);
          double num27 = Psychrometrics.Enthalpy(db - sensibleEffectiveness * (db - inputObj.InDBSum), numArray25[index8] - latentEffectiveness * (numArray25[index8] - RAW1));
          numArray18[index9] = numArray18[index9] + num27 * (double) inputObj.BinData[index5].Hours;
          num9 += num22 / num20 * (numArray26[index8] - num27) * (double) inputObj.BinData[index5].Hours;
          double num28 = (numArray26[index8] - num27) / num20;
          if (numArray8[index4] < num28)
            numArray8[index4] = num28;
          numArray23[index9] = numArray23[index9] + (double) inputObj.BinData[index5].Hours;
          numArray22[index9] = numArray22[index9] + numArray26[index8] * (double) inputObj.BinData[index5].Hours;
        }
        else if (numArray26[index8] < inputObj.NeededValues.EnthWinI & db < inputObj.InDBWin)
        {
          double[] numArray30 = numArray16;
          double[] numArray31 = numArray30;
          int index10 = index9;
          int index11 = index10;
          double num25 = numArray30[index10] + db * (double) inputObj.BinData[index5].Hours;
          numArray31[index11] = num25;
          double[] numArray32 = numArray15;
          double[] numArray33 = numArray32;
          int index12 = index9;
          int index13 = index12;
          double num26 = numArray32[index12] + (double) inputObj.BinData[index5].Hours;
          numArray33[index13] = num26;
          if (num19 == 0.0)
          {
            ErrFlags errFlags = new ErrFlags()
            {
              ErrType = 8
            };
            errFlags.ErrText = errFlags.BadDataText;
            errsList.Add(errFlags);
            return;
          }
          if (inputObj.Sensible)
            new SensibleFuncs().GetSensibleWheelEFF(db, numArray25[index8], inputObj.InDBWin, RAW2, inputObj.InWBWin, ref freshScfm, ref exhaustScfm, inputObj.Elevation, inputObj.OptFrost, inputObj.ControlTemp, inputObj.Capacity, ref sensibleEffectiveness, ref latentEffectiveness);
          double num27;
          double H;
          double num28;
          if (numArray17[index9] < inputObj.ControlTemp & inputObj.OptFrost == 1)
          {
            double num29 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(inputObj.ControlTemp - numArray17[index9] > inputObj.Capacity, (object) inputObj.Capacity, (object) (inputObj.ControlTemp - numArray17[index9])));
            double num30 = db + num29;
            num27 = num30 + sensibleEffectiveness * (inputObj.InDBWin - num30);
            double W = numArray25[index9] + latentEffectiveness * (RAW2 - numArray25[index8]);
            H = Psychrometrics.Enthalpy(num27, W);
            numArray18[index9] = numArray18[index9] + H * (double) inputObj.BinData[index5].Hours;
            num28 = 0.24 * num29;
            double num31;
            num10 -= num21 / num19 * (num31 - H) * (double) inputObj.BinData[index5].Hours;
            numArray14[index9] = numArray14[index9] + num28 * (double) inputObj.BinData[index5].Hours;
          }
          else
          {
            num27 = db - sensibleEffectiveness * (db - inputObj.InDBWin);
            double W = numArray25[index8] + latentEffectiveness * (RAW2 - numArray25[index8]);
            H = Psychrometrics.Enthalpy(num27, W);
            numArray18[index9] = numArray18[index9] + H * (double) inputObj.BinData[index5].Hours;
            num10 -= num21 / num19 * (numArray26[index8] - H) * (double) inputObj.BinData[index5].Hours;
          }
          outputobj.TwbEsts = inputObj.OutWBSum - sensibleEffectiveness * (inputObj.OutWBSum - inputObj.InWBSum);
          if (Psychrometrics.WetBulbTemp(num27, H, outputobj.TwbEsts, airPressure) > num27)
          {
            ErrFlags errFlags = new ErrFlags()
            {
              ErrType = 6
            };
            errFlags.ErrText = errFlags.rhIssueText;
            errsList.Add(errFlags);
            return;
          }
          numArray23[index9] = numArray23[index9] + (double) inputObj.BinData[index5].Hours;
          binData.BinPreheat[index9] = binData.BinPreheat[index9] + num28 * (double) inputObj.BinData[index5].Hours;
          numArray22[index9] = numArray22[index9] + numArray26[index8] * (double) inputObj.BinData[index5].Hours;
        }
        checked { ++index8; }
        checked { ++index5; }
      }
      int index14 = 0;
      do
      {
        if (index14 < 5 | index14 > 10)
          num11 += inputObj.WinterElecCost * (double) numArray27[index14];
        else
          num11 += inputObj.SummerElecCost * (double) numArray27[index14];
        checked { ++index14; }
      }
      while (index14 <= 11);
      binData.TotalCoolingHours = 0.0;
      binData.TotalVentingCoolingHours = 0.0;
      binData.TotalCoolingRecovered = 0.0;
      binData.TotalNetCoolingLoad = 0.0;
      binData.TotalHeatingHours = 0.0;
      binData.TotalVentingHeatingHours = 0.0;
      binData.TotalHeatingRecovered = 0.0;
      binData.TotalNetHeatingLoad = 0.0;
      binData.TotalPreheat = 0.0;
      binData.TotalCoolingLoad = 0.0;
      binData.TotalHeatingLoad = 0.0;
      binData.CoolingDollarsSaved = 0.0;
      binData.HeatingDollarsSaved = 0.0;
      binData.TotalFanKWH = 0.0;
      binData.RecCostC = 0.0;
      binData.RecCostH = 0.0;
      binData.FanDollarsSpent = 0.0;
      binData.TotalCoolingHours = 0.0;
      binData.TotalVentingCoolingHours = 0.0;
      binData.TotalCoolingRecovered = 0.0;
      binData.TotalNetCoolingLoad = 0.0;
      binData.TotalHeatingHours = 0.0;
      binData.TotalVentingHeatingHours = 0.0;
      binData.TotalHeatingRecovered = 0.0;
      binData.TotalNetHeatingLoad = 0.0;
      binData.TotalPreheat = 0.0;
      double num32 = 0.0;
      double num33 = 0.0;
      int index15 = 4;
      do
      {
        num32 += numArray8[index15];
        num33 += numArray9[index15];
        checked { ++index15; }
      }
      while (index15 <= 9);
      double num34 = inputObj.SummerDemandCost * 4.5 * freshScfm * num32;
      binData.CoolingDollarsSaved = 4.5 * freshScfm * binData.Factor * num9 + num34;
      binData.HeatingDollarsSaved = 4.5 * freshScfm * binData.Factor * num10;
      binData.FanDollarsSpent = inputObj.FanPower * (binData.Factor * num11 + num33 * inputObj.SummerDemandCost);
      binData.NetAnnualSavings = binData.CoolingDollarsSaved + binData.HeatingDollarsSaved - binData.FanDollarsSpent;
      binData.TotalFanKWH = inputObj.FanPower * (double) inputObj.TotalHours;
      int num35 = 0;
      int num36 = num5;
      int index16 = num35;
      while (index16 <= num36)
      {
        if (binData.AnnualHours[index16] != 0.0)
        {
          binData.MCWB[index16] = numArray13[index16] / binData.AnnualHours[index16];
          binData.BinEnthalpy[index16] = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(inputObj.Metric, (object) numArray12[index16], (object) numArray24[index16])) / binData.AnnualHours[index16];
          binData.binAverageTemps[index16] = numArray16[index16] / numArray15[index16];
          if (numArray23[index16] != 0.0)
          {
            numArray11[index16] = numArray22[index16] / numArray23[index16];
            if (binData.binAverageTemps[index16] > inputObj.InDBSum)
            {
              numArray10[index16] = numArray18[index16] / numArray23[index16];
              binData.BinRecLoad[index16] = 4.5 * freshScfm * binData.Factor * (numArray11[index16] - numArray10[index16]) * numArray23[index16];
              binData.BinVentLoad[index16] = 4.5 * freshScfm * binData.Factor * (numArray11[index16] - inputObj.NeededValues.EnthSumI) * numArray23[index16];
              binData.BinNetLoad[index16] = binData.BinVentLoad[index16] - binData.BinRecLoad[index16];
            }
            else if (binData.binAverageTemps[index16] < inputObj.InDBWin)
            {
              numArray10[index16] = numArray18[index16] / numArray23[index16];
              binData.BinRecLoad[index16] = 4.5 * freshScfm * binData.Factor * (numArray11[index16] - numArray10[index16]) * numArray23[index16];
              binData.BinVentLoad[index16] = 4.5 * freshScfm * binData.Factor * (numArray11[index16] - inputObj.NeededValues.EnthWinI) * numArray23[index16];
              binData.BinNetLoad[index16] = binData.BinVentLoad[index16] - binData.BinRecLoad[index16];
              binData.TotPreEnergy[index16] = 0.0;
              if (binData.binAverageTemps[index16] < inputObj.ControlTemp & inputObj.OptFrost == 1)
              {
                binData.TotPreEnergy[index16] = 4.5 * num12 * binData.Factor * binData.BinPreheat[index16];
                binData.BinRecLoad[index16] = binData.BinRecLoad[index16] + binData.TotPreEnergy[index16];
              }
            }
            else
            {
              binData.BinRecLoad[index16] = 0.0;
              binData.BinVentLoad[index16] = 0.0;
              binData.BinNetLoad[index16] = 0.0;
              binData.TotPreEnergy[index16] = 0.0;
            }
          }
          if (binData.binAverageTemps[index16] > inputObj.InDBSum)
          {
            binData.TotalCoolingHours += binData.Factor * numArray23[index16];
            binData.TotalVentingCoolingHours += binData.BinVentLoad[index16];
            binData.TotalCoolingLoad += binData.BinVentLoad[index16];
            binData.TotalCoolingRecovered += binData.BinRecLoad[index16];
            binData.TotalNetCoolingLoad += binData.BinNetLoad[index16];
          }
          else if (binData.binAverageTemps[index16] < inputObj.InDBWin)
          {
            binData.TotalHeatingHours += binData.Factor * numArray23[index16];
            binData.TotalVentingHeatingHours += binData.BinVentLoad[index16];
            binData.TotalHeatingLoad += binData.BinVentLoad[index16];
            binData.TotalHeatingRecovered += binData.BinRecLoad[index16];
            binData.TotalNetHeatingLoad += binData.BinNetLoad[index16];
            binData.TotalPreheat += binData.TotPreEnergy[index16];
          }
        }
        if (binData.binAverageTemps[index16] > inputObj.InDBSum)
          binData.RecCostC += binData.BinRecLoad[index16];
        else if (binData.binAverageTemps[index16] < inputObj.InDBWin)
          binData.RecCostH -= binData.BinRecLoad[index16];
        checked { ++index16; }
      }
    }
  }
}
