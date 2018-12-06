// Decompiled with JetBrains decompiler
// Type: AirXDLL.Calculate
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AirXDLL
{
  public class Calculate
  {
    [DebuggerNonUserCode]
    public Calculate()
    {
    }

    public bool MainCalc(AirXInputs inputObj, ref AirXOutputs outputObj, ref BinEnergyData bindata, ref List<ErrFlags> errsList)
    {
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      Inputs inputs1 = new Inputs();
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errFlags1 = new ErrFlags();
      Inputs inputs2 = inputs1;
      inputs2.ConfigFileLocation = inputObj.ConfigFileLocation;
      inputs2.Gap = 0.03;
      inputs2.SealFactor = 1.5;
      inputs2.ExpandedVersion = false;
      inputs2.BedeSpecial = false;
      inputs2.Sensible = inputObj.Sensible;
      inputs2.Metric = false;
      inputs2.Elevation = inputObj.Elevation;
      inputs2.FreshFlow = inputObj.FreshFlow;
      inputs2.FreshSupplyFlow = inputObj.FreshFlow;
      inputs2.OutFlow = inputObj.OutFlow;
      inputs2.ExhaustReturnFlow = inputs2.OutFlow;
      inputs2.OutDBSum = inputObj.OutDBSum;
      inputs2.OutWBSum = inputObj.OutWBSum;
      inputs2.InDBSum = inputObj.InDBSum;
      inputs2.InWBSum = inputObj.InWBSum;
      inputs2.OutDBWin = inputObj.OutDBWin;
      inputs2.OutWBWin = inputObj.OutWBWin;
      inputs2.InDBWin = inputObj.InDBWin;
      inputs2.InWBWin = inputObj.InWBWin;
      inputs2.SSPress = inputObj.SSPress;
      inputs2.ESPress = inputObj.ESPress;
      inputs2.FanEff = inputObj.FanEff;
      inputs2.PurgeAngle = inputObj.PurgeAngle;
      inputs2.HasPurge = !inputObj.CalcPurge;
      inputs2.Model = inputObj.Model;
      inputs2.SSPresT = inputObj.SSPresT;
      inputs2.ESPresT = inputObj.ESPresT;
      inputs2.Wheels = inputObj.Wheels;
      inputs2.TargetEATR = inputObj.TargetEATR;
      ErrFlags errs1 = new ErrFlags();
      errs1.ErrText = "";
      inputs2.ModelID = modelDbFunctions.GetModelID(inputObj.ConfigFileLocation, inputs2.Model, ref errs1);
      if (Operators.CompareString(errs1.ErrText, "", false) != 0)
      {
        errsList.Add(errs1);
        return false;
      }
      inputs2.PercentRatedRPM = 100;
      double num1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
      double num2 = Psychrometrics.WetBulbHR(inputObj.OutDBSum, inputObj.OutWBSum, inputObj.Elevation);
      double num3 = Psychrometrics.WetBulbHR(inputObj.InDBWin, inputObj.InWBWin, inputObj.Elevation);
      double num4 = Psychrometrics.WetBulbHR(inputObj.OutDBWin, inputObj.OutWBWin, inputObj.Elevation);
      if (inputObj.OutDBSum < inputObj.InDBSum)
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 5
        };
        errFlags2.ErrText = errFlags2.ConditionsText;
        errsList.Add(errFlags2);
      }
      if (num2 < num1)
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 5
        };
        errFlags2.ErrText = errFlags2.ConditionsText;
        errsList.Add(errFlags2);
      }
      if (inputObj.OutDBWin > inputObj.InDBWin)
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 5
        };
        errFlags2.ErrText = errFlags2.ConditionsText;
        errsList.Add(errFlags2);
      }
      if (num4 > num3)
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 5
        };
        errFlags2.ErrText = errFlags2.ConditionsText;
        errsList.Add(errFlags2);
      }
      if ((inputObj.PurgeAngle < 0.0 | inputObj.PurgeAngle > 15.0) & !inputObj.CalcPurge)
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 11
        };
        errFlags2.ErrText = errFlags2.PurgeAngleText;
        errsList.Add(errFlags2);
        return false;
      }
      if (inputObj.CalcPurge & (inputObj.TargetEATR < 0.5 | inputObj.TargetEATR > 15.0))
      {
        ErrFlags errFlags2 = new ErrFlags()
        {
          ErrType = 12
        };
        errFlags2.ErrText = errFlags2.EATRErrorText;
        errsList.Add(errFlags2);
        return false;
      }
      ModelData modelData1 = new ModelData();
      ErrFlags errs2 = new ErrFlags();
      ModelData modelData2 = modelDbFunctions.GetModelData(inputs1.ConfigFileLocation, inputs1.ModelID, ref errs2);
      double num5;
      double num6;
      if (inputObj.Model.Contains("2W"))
      {
        num5 = 2.0 * modelData2.MINFLOW;
        num6 = 2.0 * modelData2.MAXFLOW;
      }
      else
      {
        num5 = modelData2.MINFLOW;
        num6 = modelData2.MAXFLOW;
      }
      if (inputObj.FreshFlow < num5 | inputObj.FreshFlow > num6)
      {
        errs2 = new ErrFlags() { ErrType = 9 };
        errs2.ErrText = errs2.FlowRangesText;
        errsList.Add(errs2);
        return false;
      }
      if (inputObj.OutFlow < num5 | inputObj.OutFlow > num6)
      {
        errs2 = new ErrFlags() { ErrType = 9 };
        errs2.ErrText = errs2.FlowRangesText;
        errsList.Add(errs2);
        return false;
      }
      if (inputObj.CoolingEER > 20.0 | inputObj.CoolingEER < 1.0)
      {
        errs2 = new ErrFlags() { ErrType = 13 };
        errs2.ErrText = errs2.CoolingEERText;
        errsList.Add(errs2);
        return false;
      }
      if (inputObj.HeatingIndex != 1 & (inputObj.HeatingEfficiency > 100.0 | inputObj.HeatingEfficiency < 25.0))
      {
        errs2 = new ErrFlags() { ErrType = 14 };
        errs2.ErrText = errs2.HeatingEffText;
        errsList.Add(errs2);
        return false;
      }
      if (inputObj.HeatingIndex == 1 & (inputObj.HeatingCOP > 7.5 | inputObj.HeatingCOP < 0.3))
      {
        errs2 = new ErrFlags() { ErrType = 15 };
        errs2.ErrText = errs2.HeatingCOPText;
        errsList.Add(errs2);
        return false;
      }
      if (inputObj.FanEff < 20.0 | inputObj.FanEff > 90.0)
      {
        errs2 = new ErrFlags() { ErrType = 16 };
        errs2.ErrText = errs2.FanEFFText;
        errsList.Add(errs2);
        return false;
      }
      if (Operators.CompareString(inputObj.City, "", false) == 0 | Operators.CompareString(inputObj.State, "", false) == 0)
      {
        errs2 = new ErrFlags() { ErrType = 17 };
        errs2.ErrText = errs2.CityStateText;
        errsList.Add(errs2);
        return false;
      }
      Outputs outputs = new Outputs();
      if (modelData2.Purge)
      {
        if (!inputObj.CalcPurge)
          ++inputs1.PurgeAngle;
        this.CalculateLeakageP(inputs1, ref outputs, ref errsList);
        if (inputObj.CalcPurge)
        {
          double num7 = 57.2958279087978 * ((outputs.PurgeAngle - 1.0) * 0.0174532777777778);
          outputs.PurgeAngle = num7;
        }
        else if (inputObj.PurgeAngle > 0.0)
          --outputs.PurgeAngle;
      }
      else
        this.CalculateLeakage(inputs1, ref outputs, ref errsList);
      inputs1.EATR = outputs.EATR;
      inputs1.OACF = outputs.OACF;
      if (inputObj.PurgeAngle > 0.0 && outputs.OutdoorPressure - outputs.ReturnPressure < 0.0)
      {
        errs2 = new ErrFlags() { ErrType = 3 };
        errs2.ErrText = errs2.PurgeDPText;
        errsList.Add(errs2);
        return false;
      }
      if (outputs.SupPressDrop > outputs.AllowedDP | outputs.ExhPressDrop > outputs.AllowedDP)
      {
        errs2 = new ErrFlags() { ErrType = 10 };
        errs2.ErrText = errs2.PlenumSpecText;
        errsList.Add(errs2);
        return false;
      }
      Psychrometrics.SetAirProperties(inputs1.Elevation);
      double airPressure = Psychrometrics.AirPressure;
      double airDensity = Psychrometrics.AirDensity;
      inputs1.FreshSCFM = airDensity / 0.075 * inputObj.FreshFlow;
      inputs1.ExhaustSCFM = airDensity / 0.075 * inputObj.OutFlow;
      inputs1.OutdoorFlow = outputs.OutdoorFlow;
      inputs1.FanPower = outputs.FanPower;
      this.CalculatePreHeat2(inputs1, ref outputs, ref errsList);
      inputs1.ControlTemp = outputs.TFrost;
      if (outputs.Capacity > 0.0)
      {
        outputs.PreHeatTemp = outputs.TFrost;
        inputs1.OptFrost = 1;
      }
      else
      {
        outputs.PreHeatTemp = 0.0;
        inputs1.OptFrost = 0;
      }
      inputs1.Capacity = outputs.Capacity;
      inputs1.ExhaustReturnFlow = 210.0;
      this.CalculateOutputs(inputs1, ref outputs, ref errsList, true);
      inputs1.EffValues = new EffectivenessValues();
      inputs1.EffValues.LatentEffectiveness = outputs.EffValues.LatentEffectiveness;
      inputs1.EffValues.SensibleEffectiveness = outputs.EffValues.SensibleEffectiveness;
      inputs1.EffValues.SupLatentEffectiveness = outputs.EffValues.SupLatentEffectiveness;
      inputs1.EffValues.WinterLatentEffectiveness = outputs.EffValues.WinterLatentEffectiveness;
      inputs1.EffValues.WinterSensibleEffectiveness = outputs.EffValues.WinterSensibleEffectiveness;
      inputs1.EffValues.WinterSupLatentEffectiveness = outputs.EffValues.WinterSupLatentEffectiveness;
      inputs1.EffValues.WinterSupSensibleEffectiveness = outputs.EffValues.WinterSupSensibleEffectiveness;
      inputs1.EffValues.SupSensibleEffectiveness = outputs.EffValues.SupSensibleEffectiveness;
      inputs1.NeededValues = new Values();
      inputs1.NeededValues.EnthSumI = outputs.NeededValues.EnthSumI;
      inputs1.NeededValues.EnthSumO = outputs.NeededValues.EnthSumO;
      inputs1.NeededValues.EnthWinI = outputs.NeededValues.EnthWinI;
      inputs1.NeededValues.EnthWinO = outputs.NeededValues.EnthWinO;
      inputs1.Capacity = outputs.Capacity;
      inputs1.ControlTemp = outputs.TFrost;
      inputs1.City = inputObj.City;
      inputs1.State = inputObj.State;
      inputs1.DaysIndex = inputObj.DaysIndex;
      inputs1.January = inputObj.January;
      inputs1.February = inputObj.February;
      inputs1.March = inputObj.March;
      inputs1.April = inputObj.April;
      inputs1.May = inputObj.May;
      inputs1.June = inputObj.June;
      inputs1.July = inputObj.July;
      inputs1.August = inputObj.August;
      inputs1.September = inputObj.September;
      inputs1.October = inputObj.October;
      inputs1.November = inputObj.November;
      inputs1.December = inputObj.December;
      inputs1.Metric = false;
      inputs1.HeatingIndex = inputObj.HeatingIndex;
      inputs1.HeatingEfficiency = inputObj.HeatingEfficiency;
      inputs1.HeatingEER = inputObj.HeatingCOP * 3.413;
      inputs1.CoolingEER = inputObj.CoolingEER;
      inputs1.FuelCost = inputObj.FuelCost;
      inputs1.WinterElecCost = inputObj.WinterElecCost;
      inputs1.SummerElecCost = inputObj.SummerElecCost;
      inputs1.SummerDemandCost = inputObj.SummerDemandCost;
      AirXWeatherDBFunctions xweatherDbFunctions = new AirXWeatherDBFunctions();
      List<HourData> hourDataList = new List<HourData>();
      List<BinData> binData = new List<BinData>();
      List<HourData> hourDataByMonth = xweatherDbFunctions.GetHourDataByMonth(inputObj.Region, inputObj.FileName, inputObj.Months, inputObj.Sunday, inputObj.Monday, inputObj.Tuesday, inputObj.Wednessday, inputObj.Thursday, inputObj.Friday, inputObj.Saturday, inputObj.DBLocation);
      if (hourDataByMonth.Count == 0)
      {
        errs2 = new ErrFlags() { ErrType = 18 };
        errs2.ErrText = errs2.HourlyDataErrorText;
        errsList.Add(errs2);
        return false;
      }
      inputs1.HourData = new List<HourData>();
      List<HourData>.Enumerator enumerator1;
      try
      {
        enumerator1 = hourDataByMonth.GetEnumerator();
        while (enumerator1.MoveNext())
        {
          HourData current = enumerator1.Current;
          inputs1.HourData.Add(new HourData()
          {
            DB = current.DB,
            HumRatio = current.HumRatio,
            Month = current.Month
          });
        }
      }
      finally
      {
        enumerator1.Dispose();
      }
      inputs1.TotalHours = hourDataByMonth.Count;
      this.CalculateBinDataByMonth(inputs1, ref outputs, ref binData);
      List<BinData> binDataList = new List<BinData>();
      List<BinData>.Enumerator enumerator2;
      try
      {
        enumerator2 = binData.GetEnumerator();
        while (enumerator2.MoveNext())
        {
          BinData current = enumerator2.Current;
          binDataList.Add(new BinData()
          {
            DB = current.DB,
            W = current.W,
            Hours = current.Hours,
            MidPoint = current.MidPoint,
            Month = current.Month
          });
        }
      }
      finally
      {
        enumerator2.Dispose();
      }
      inputs1.BinData = binDataList;
      this.CalculateAllEnergyBinsByMonth(inputs1, ref outputs, ref bindata, ref errsList);
      inputs1.RTUcapacity = inputObj.RTUcapacity;
      inputs1.RTUeer = inputObj.RTUeer;
      this.CalculateEER(inputs1, ref outputs, ref errsList);
      AirXOutputs airXoutputs = outputObj;
      airXoutputs.SupplyFlow = outputs.SupplyFlow;
      airXoutputs.ReturnFlow = outputs.ReturnFlow;
      airXoutputs.ExhaustFlow = outputs.ExhaustFlow;
      airXoutputs.OutdoorFlow = outputs.OutdoorFlow;
      airXoutputs.EATR = outputs.EATR;
      airXoutputs.OACF = outputs.OACF;
      airXoutputs.ExhPressDrop = outputs.ExhPressDrop;
      airXoutputs.SupPressDrop = outputs.SupPressDrop;
      airXoutputs.FanPower = (object) outputs.FanPower;
      airXoutputs.SupDBSum = outputs.DBSupSNet;
      airXoutputs.SupWBSum = outputs.WBSupSNet;
      airXoutputs.SupRHSum = outputs.RHSupSNet;
      airXoutputs.SupDBWin = outputs.DbsupwNet;
      airXoutputs.SupWBWin = outputs.WBsupwNet;
      airXoutputs.SupRHWin = outputs.RHsupwNet;
      airXoutputs.OASensSum = outputs.OASensSum;
      airXoutputs.OALatentSum = outputs.OALatentSum;
      airXoutputs.OATotalSum = outputs.OATotalSum;
      airXoutputs.OARecoveredSum = outputs.OARecoveredSum;
      airXoutputs.OANetSum = outputs.OANetSum;
      airXoutputs.OASensibleWin = -1.0 * outputs.OASensibleWin;
      airXoutputs.OALatentWin = -1.0 * outputs.OALatentWin;
      airXoutputs.OATotalWin = -1.0 * outputs.OATotalWin;
      airXoutputs.OARecoveredWin = -1.0 * outputs.OARecoveredWin;
      airXoutputs.OANetWin = -1.0 * outputs.OANetWin;
      airXoutputs.PreHeatTemp = outputs.PreHeatTemp;
      airXoutputs.PreHeatCapacity = outputs.Capacity;
      airXoutputs.PreHeater = outputs.PreHeater;
      airXoutputs.NetEffSummer = outputs.ETSN;
      airXoutputs.NetEffWinter = outputs.ETwN;
      airXoutputs.ErvEER = outputs.ErvEER;
      airXoutputs.PercentOALoad = outputs.PercentOALoad;
      airXoutputs.CombinedEER = outputs.CombinedEER;
      airXoutputs.LatentEff = outputs.EffValues.LatentEffectiveness;
      airXoutputs.SensEff = outputs.EffValues.SensibleEffectiveness;
      airXoutputs.WinterLatentEff = outputs.EffValues.WinterLatentEffectiveness;
      airXoutputs.WinterSensEff = outputs.EffValues.WinterSensibleEffectiveness;
      airXoutputs.SupHRSum = outputs.HRSupSNet;
      airXoutputs.SupEnthSum = outputs.EnthSupSNet;
      airXoutputs.SupHRWin = outputs.HRsupwNet;
      airXoutputs.SupEnthWin = outputs.EnthsupwNet;
      airXoutputs.OutdoorPressure = outputs.OutdoorPressure;
      airXoutputs.SupplyPressure = outputs.SupplyPressure;
      airXoutputs.ReturnPressure = outputs.ReturnPressure;
      airXoutputs.ExhaustPressure = outputs.ExhaustPressure;
      airXoutputs.OARecoveredSensibleSum = Math.Abs(outputs.OARecoveredSensibleSum);
      airXoutputs.OARecoveredLatentSum = Math.Abs(outputs.OARecoveredLatentSum);
      airXoutputs.OARecoveredSensibleWin = Math.Abs(outputs.OARecoveredSensibleWin);
      airXoutputs.OARecoveredLatentWin = Math.Abs(outputs.OARecoveredLatentWin);
      airXoutputs.AllowedDP = outputs.AllowedDP;
      airXoutputs.TFrost = outputs.TFrost;
      airXoutputs.CLGSav = outputs.CLGSav;
      airXoutputs.HTGSav = outputs.HTGSav;
      airXoutputs.ExhDBSum = outputs.DbexhsNet;
      airXoutputs.ExhWBSum = outputs.WbexhsNet;
      airXoutputs.ExhDBWin = outputs.DbexhwNet;
      airXoutputs.ExhWBWin = outputs.WbexhwNet;
      airXoutputs.PurgeAngle = outputs.PurgeAngle;
      bindata.TotalHeatingLoad = -1.0 * bindata.TotalHeatingLoad;
      bindata.TotalHeatingRecovered = -1.0 * bindata.TotalHeatingRecovered;
      bindata.TotalNetHeatingLoad = -1.0 * bindata.TotalNetHeatingLoad;
      bindata.TotalPreheat = -1.0 * bindata.TotalPreheat;
      return true;
    }

    public void CalculateOutputs(FunctionDLLInputs funcDLLInputs, ref CalculatedOutputs calcOutputs, ref List<ErrFlags> errsList)
    {
      Inputs inputObj = new Inputs();
      Outputs outputs = new Outputs();
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      inputObj.ConfigFileLocation = funcDLLInputs.ConfigFileLocation;
      inputObj.FanEff = funcDLLInputs.FanEff;
      inputObj.Metric = false;
      inputObj.PercentRatedRPM = 100;
      inputObj.SSPress = funcDLLInputs.UnitPressures.SSPress;
      inputObj.ESPress = funcDLLInputs.UnitPressures.ESPress;
      inputObj.SSPresT = funcDLLInputs.UnitPressures.SSPresT;
      inputObj.ESPresT = funcDLLInputs.UnitPressures.ESPresT;
      inputObj.Elevation = funcDLLInputs.Location.Elevation;
      inputObj.Model = funcDLLInputs.ModelParam.Model;
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      Model model = modelDbFunctions.GetModel(funcDLLInputs.ConfigFileLocation, funcDLLInputs.ModelParam.Model, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsList.Add(errs);
      }
      else
      {
        inputObj.ModelID = modelDbFunctions.GetModelID(funcDLLInputs.ConfigFileLocation, funcDLLInputs.ModelParam.Model, ref errs);
        inputObj.Wheels = funcDLLInputs.ModelParam.Wheels;
        inputObj.EATR = funcDLLInputs.ModelParam.EATR;
        inputObj.OACF = funcDLLInputs.ModelParam.OACF;
        inputObj.Sensible = funcDLLInputs.ModelParam.Sensible;
        if (inputObj.Sensible)
          inputObj.BedeSpecial = true;
        if (model.ModelData.Purge)
        {
          inputObj.HasPurge = funcDLLInputs.ModelParam.HasPurge;
          if (inputObj.HasPurge)
            ++funcDLLInputs.ModelParam.PurgeAngle;
          inputObj.PurgeAngle = funcDLLInputs.ModelParam.PurgeAngle;
          inputObj.TargetEATR = funcDLLInputs.ModelParam.TargetEATR;
          inputObj.ExhaustReturnFlow = funcDLLInputs.AirFlows.OutFlow;
          inputObj.FreshSupplyFlow = funcDLLInputs.AirFlows.FreshFlow;
          inputObj.Gap = 0.03;
          inputObj.SealFactor = 1.5;
          inputObj.ExpandedVersion = false;
          inputObj.BedeSpecial = false;
          inputObj.Metric = false;
          this.CalculateLeakageP(inputObj, ref outputs, ref errsList);
        }
        else
        {
          inputObj.FreshFlow = funcDLLInputs.AirFlows.FreshFlow;
          inputObj.OutFlow = funcDLLInputs.AirFlows.OutFlow;
          this.CalculateLeakage(inputObj, ref outputs, ref errsList);
        }
        inputObj.FreshFlow = funcDLLInputs.AirFlows.FreshFlow;
        inputObj.OutFlow = funcDLLInputs.AirFlows.OutFlow;
        inputObj.EATR = outputs.EATR;
        inputObj.OACF = outputs.OACF;
        Psychrometrics.SetAirProperties(inputObj.Elevation);
        double airPressure = Psychrometrics.AirPressure;
        double airDensity = Psychrometrics.AirDensity;
        inputObj.OutdoorFlow = outputs.OutdoorFlow;
        inputObj.FanPower = outputs.FanPower;
        inputObj.FreshSCFM = airDensity / 0.075 * inputObj.FreshFlow;
        inputObj.ExhaustSCFM = airDensity / 0.075 * inputObj.OutFlow;
        inputObj.OutDBSum = funcDLLInputs.AirInlet.OutDBSum;
        inputObj.InDBSum = funcDLLInputs.AirInlet.InDBSum;
        inputObj.OutWBSum = funcDLLInputs.AirInlet.OutWBSum;
        inputObj.InWBSum = funcDLLInputs.AirInlet.InWBSum;
        inputObj.OutDBWin = funcDLLInputs.AirInlet.OutDBWin;
        inputObj.InDBWin = funcDLLInputs.AirInlet.InDBWin;
        inputObj.OutWBWin = funcDLLInputs.AirInlet.OutWBWin;
        inputObj.InWBWin = funcDLLInputs.AirInlet.InWBWin;
        this.CalculatePreHeat2(inputObj, ref outputs, ref errsList);
        inputObj.ControlTemp = outputs.TFrost;
        if (outputs.Capacity > 0.0)
        {
          outputs.PreHeatTemp = outputs.TFrost;
          inputObj.OptFrost = 1;
        }
        else
        {
          outputs.PreHeatTemp = 0.0;
          inputObj.OptFrost = 0;
        }
        inputObj.Capacity = outputs.Capacity;
        inputObj.ExhaustReturnFlow = 210.0;
        this.CalculateOutputs(inputObj, ref outputs, ref errsList, true);
        calcOutputs.EATR = outputs.EATR;
        calcOutputs.OACF = outputs.OACF;
        calcOutputs.OutdoorFlow = outputs.OutdoorFlow;
        calcOutputs.SupplyFlow = outputs.SupplyFlow;
        calcOutputs.ReturnFlow = outputs.ReturnFlow;
        calcOutputs.ExhaustFlow = outputs.ExhaustFlow;
        calcOutputs.FanPower = outputs.FanPower;
        calcOutputs.AllowedDP = outputs.AllowedDP;
        calcOutputs.SupPressDrop = outputs.SupPressDrop;
        calcOutputs.ExhPressDrop = outputs.ExhPressDrop;
        calcOutputs.OutdoorPressure = outputs.OutdoorPressure;
        calcOutputs.SupplyPressure = outputs.SupplyPressure;
        calcOutputs.ExhaustPressure = outputs.ExhaustPressure;
        calcOutputs.ReturnPressure = outputs.ReturnPressure;
        calcOutputs.PurgeAngle = outputs.PurgeAngle <= 0.0 ? outputs.PurgeAngle : outputs.PurgeAngle - 1.0;
        calcOutputs.PreHeatTemp = outputs.PreHeatTemp;
        calcOutputs.Capacity = outputs.Capacity;
        calcOutputs.PreHeater = outputs.PreHeater;
        calcOutputs.EnthSumO = outputs.NeededValues.EnthSumO;
        calcOutputs.EnthSumI = outputs.NeededValues.EnthSumI;
        calcOutputs.EnthWinI = outputs.NeededValues.EnthWinI;
        calcOutputs.EnthWinO = outputs.NeededValues.EnthWinO;
        calcOutputs.LatentEffectiveness = outputs.EffValues.LatentEffectiveness;
        calcOutputs.SensibleEffectiveness = outputs.EffValues.SensibleEffectiveness;
        calcOutputs.SupLatentEffectiveness = outputs.EffValues.SupLatentEffectiveness;
        calcOutputs.SupSensibleEffectiveness = outputs.EffValues.SupSensibleEffectiveness;
        calcOutputs.WinterLatentEffectiveness = outputs.EffValues.WinterLatentEffectiveness;
        calcOutputs.WinterSensibleEffectiveness = outputs.EffValues.WinterSensibleEffectiveness;
        calcOutputs.WinterSupLatentEffectiveness = outputs.EffValues.WinterSupLatentEffectiveness;
        calcOutputs.WinterSupSensibleEffectiveness = outputs.EffValues.WinterSupSensibleEffectiveness;
        calcOutputs.FreshSCFM = outputs.FreshSCFM;
        calcOutputs.ExhaustSCFM = outputs.ExhaustSCFM;
        calcOutputs.DBSupSNet = outputs.DBSupSNet;
        calcOutputs.WBSupSNet = outputs.WBSupSNet;
        calcOutputs.RHSupSNet = outputs.RHSupSNet;
        calcOutputs.HRSupSNet = outputs.HRSupSNet;
        calcOutputs.EnthSupSNet = outputs.EnthSupSNet;
        calcOutputs.DbsupwNet = outputs.DbsupwNet;
        calcOutputs.WBsupwNet = outputs.WBsupwNet;
        calcOutputs.RHsupwNet = outputs.RHsupwNet;
        calcOutputs.HRsupwNet = outputs.HRsupwNet;
        calcOutputs.EnthsupwNet = outputs.EnthsupwNet;
        calcOutputs.OARecoveredSensibleSum = Math.Abs(outputs.OARecoveredSensibleSum);
        calcOutputs.OARecoveredLatentSum = Math.Abs(outputs.OARecoveredLatentSum);
        calcOutputs.OASensSum = outputs.OASensSum;
        calcOutputs.OATotalSum = outputs.OATotalSum;
        calcOutputs.OALatentSum = outputs.OALatentSum;
        calcOutputs.OARecoveredSum = outputs.OARecoveredSum;
        calcOutputs.OANetSum = outputs.OANetSum;
        calcOutputs.OARecoveredSensibleWin = Math.Abs(outputs.OARecoveredSensibleWin);
        calcOutputs.OARecoveredLatentWin = Math.Abs(outputs.OARecoveredLatentWin);
        calcOutputs.OASensibleWin = -1.0 * outputs.OASensibleWin;
        calcOutputs.OATotalWin = -1.0 * outputs.OATotalWin;
        calcOutputs.OALatentWin = -1.0 * outputs.OALatentWin;
        calcOutputs.OARecoveredWin = -1.0 * outputs.OARecoveredWin;
        calcOutputs.OANetWin = -1.0 * outputs.OANetWin;
        calcOutputs.TotalEffSummer = outputs.ETSN;
        calcOutputs.TotalEffWinter = outputs.ETwN;
        calcOutputs.CLGSav = outputs.CLGSav;
        calcOutputs.HTGSav = outputs.HTGSav;
        calcOutputs.DbexhsNet = outputs.DbexhsNet;
        calcOutputs.WbexhsNet = outputs.WbexhsNet;
        calcOutputs.DbexhwNet = outputs.DbexhwNet;
        calcOutputs.WbexhwNet = outputs.WbexhwNet;
        calcOutputs.HrexhsNet = outputs.HrexhsNet;
        calcOutputs.EnthexhsNet = outputs.EnthexhsNet;
        calcOutputs.RhexhsNet = outputs.RhexhsNet;
        calcOutputs.HrexhwNet = outputs.HrexhwNet;
        calcOutputs.EnthexhwNet = outputs.EnthexhwNet;
        calcOutputs.RhexhwNet = outputs.RhexhwNet;
      }
    }

    public void CalculateEnergyNewBins(FunctionDLLInputs funcDLLInputs, ref BinEnergyData bindata, ref List<ErrFlags> errsList)
    {
      Inputs inputobj = new Inputs();
      Outputs outputObj = new Outputs();
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      ModelsCollection modelsCollection = new ModelsCollection();
      inputobj.ConfigFileLocation = funcDLLInputs.ConfigFileLocation;
      inputobj.DaysIndex = funcDLLInputs.DaysIndex;
      inputobj.OutdoorFlow = funcDLLInputs.CalcOutputs.OutdoorFlow;
      inputobj.City = funcDLLInputs.Location.City;
      inputobj.State = funcDLLInputs.Location.State;
      inputobj.Elevation = funcDLLInputs.Location.Elevation;
      inputobj.Metric = false;
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      inputobj.ModelID = modelDbFunctions.GetModelID(funcDLLInputs.ConfigFileLocation, funcDLLInputs.ModelParam.Model, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsList.Add(errs);
      }
      else
      {
        inputobj.InDBSum = funcDLLInputs.AirInlet.InDBSum;
        inputobj.OutWBSum = funcDLLInputs.AirInlet.OutWBSum;
        inputobj.InWBSum = funcDLLInputs.AirInlet.InWBSum;
        inputobj.InDBWin = funcDLLInputs.AirInlet.InDBWin;
        inputobj.InWBWin = funcDLLInputs.AirInlet.InWBWin;
        inputobj.EffValues = new EffectivenessValues();
        inputobj.NeededValues = new Values();
        Inputs inputs = inputobj;
        inputs.EffValues.SupSensibleEffectiveness = funcDLLInputs.CalcOutputs.SupSensibleEffectiveness;
        inputs.EffValues.SupLatentEffectiveness = funcDLLInputs.CalcOutputs.SupLatentEffectiveness;
        inputs.NeededValues.EnthSumI = funcDLLInputs.CalcOutputs.EnthSumI;
        inputs.NeededValues.EnthSumO = funcDLLInputs.CalcOutputs.EnthSumO;
        inputs.NeededValues.EnthWinI = funcDLLInputs.CalcOutputs.EnthWinI;
        inputs.NeededValues.EnthWinO = funcDLLInputs.CalcOutputs.EnthWinO;
        inputs.Capacity = funcDLLInputs.CalcOutputs.Capacity;
        inputs.OptFrost = inputs.Capacity <= 0.0 ? 0 : 1;
        inputs.ControlTemp = funcDLLInputs.CalcOutputs.PreHeatTemp;
        inputs.FreshSCFM = funcDLLInputs.CalcOutputs.FreshSCFM;
        inputs.ExhaustSCFM = funcDLLInputs.CalcOutputs.ExhaustSCFM;
        inputs.FanPower = funcDLLInputs.CalcOutputs.FanPower;
        inputs.HeatingIndex = funcDLLInputs.EnergyCost.HeatingIndex;
        inputs.HeatingEfficiency = funcDLLInputs.EnergyCost.HeatingEfficiency;
        inputs.HeatingEER = funcDLLInputs.EnergyCost.HeatingEER;
        inputs.CoolingEER = funcDLLInputs.EnergyCost.CoolingEER;
        inputs.FuelCost = funcDLLInputs.EnergyCost.FuelCost;
        inputs.WinterElecCost = funcDLLInputs.EnergyCost.WinterElecCost;
        inputs.SummerDemandCost = funcDLLInputs.EnergyCost.SummerDemandCost;
        inputs.SummerElecCost = funcDLLInputs.EnergyCost.SummerElecCost;
        inputs.BinData = funcDLLInputs.BinData;
        inputs.TotalHours = funcDLLInputs.TotalHours;
        this.CalculateAllEnergyBinsByMonth(inputobj, ref outputObj, ref bindata, ref errsList);
      }
    }

    public void CalculateEconomicsNewBins(FunctionDLLInputs funcDLLInputs, ref BinEnergyData bindata, ref List<ErrFlags> errsList)
    {
      Inputs inputobj = new Inputs();
      Outputs outputObj = new Outputs();
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      ModelsCollection modelsCollection = new ModelsCollection();
      inputobj.ConfigFileLocation = funcDLLInputs.ConfigFileLocation;
      inputobj.DaysIndex = funcDLLInputs.DaysIndex;
      inputobj.OutdoorFlow = funcDLLInputs.CalcOutputs.OutdoorFlow;
      inputobj.City = funcDLLInputs.Location.City;
      inputobj.State = funcDLLInputs.Location.State;
      inputobj.Elevation = funcDLLInputs.Location.Elevation;
      inputobj.Metric = false;
      inputobj.InDBSum = funcDLLInputs.AirInlet.InDBSum;
      inputobj.OutWBSum = funcDLLInputs.AirInlet.OutWBSum;
      inputobj.InWBSum = funcDLLInputs.AirInlet.InWBSum;
      inputobj.InDBWin = funcDLLInputs.AirInlet.InDBWin;
      inputobj.InWBWin = funcDLLInputs.AirInlet.InWBWin;
      inputobj.EffValues = new EffectivenessValues();
      inputobj.NeededValues = new Values();
      Inputs inputs = inputobj;
      inputs.EffValues.SupSensibleEffectiveness = funcDLLInputs.CalcOutputs.SupSensibleEffectiveness;
      inputs.EffValues.SupLatentEffectiveness = funcDLLInputs.CalcOutputs.SupLatentEffectiveness;
      inputs.NeededValues.EnthSumI = funcDLLInputs.CalcOutputs.EnthSumI;
      inputs.NeededValues.EnthSumO = funcDLLInputs.CalcOutputs.EnthSumO;
      inputs.NeededValues.EnthWinI = funcDLLInputs.CalcOutputs.EnthWinI;
      inputs.NeededValues.EnthWinO = funcDLLInputs.CalcOutputs.EnthWinO;
      inputs.Capacity = funcDLLInputs.CalcOutputs.Capacity;
      inputs.FreshSCFM = funcDLLInputs.CalcOutputs.FreshSCFM;
      inputs.ExhaustSCFM = funcDLLInputs.CalcOutputs.ExhaustSCFM;
      inputs.OptFrost = inputs.Capacity <= 0.0 ? 0 : 1;
      inputs.ControlTemp = funcDLLInputs.CalcOutputs.PreHeatTemp;
      inputs.FanPower = funcDLLInputs.CalcOutputs.FanPower;
      inputs.HeatingIndex = funcDLLInputs.EnergyCost.HeatingIndex;
      inputs.HeatingEfficiency = funcDLLInputs.EnergyCost.HeatingEfficiency;
      inputs.HeatingEER = funcDLLInputs.EnergyCost.HeatingEER;
      inputs.CoolingEER = funcDLLInputs.EnergyCost.CoolingEER;
      inputs.FuelCost = funcDLLInputs.EnergyCost.FuelCost;
      inputs.WinterElecCost = funcDLLInputs.EnergyCost.WinterElecCost;
      inputs.SummerDemandCost = funcDLLInputs.EnergyCost.SummerDemandCost;
      inputs.SummerElecCost = funcDLLInputs.EnergyCost.SummerElecCost;
      inputs.BinData = funcDLLInputs.BinData;
      inputs.TotalHours = funcDLLInputs.TotalHours;
      bindata.BinPreheat = funcDLLInputs.CalcEnergy.BinPreHeat;
      this.CalculateAllEnergyBinsByMonth(inputobj, ref outputObj, ref bindata, ref errsList);
    }

    public void CalculateEER(FunctionDLLInputs funcDLLInputs, ref CalculatedEER calcEER, ref List<ErrFlags> errsList)
    {
      Inputs inputobj = new Inputs();
      Outputs outputObj = new Outputs();
      inputobj.EffValues = new EffectivenessValues();
      inputobj.NeededValues = new Values();
      Inputs inputs = inputobj;
      inputs.Elevation = funcDLLInputs.Location.Elevation;
      inputs.Wheels = funcDLLInputs.ModelParam.Wheels;
      inputs.OutDBSum = funcDLLInputs.AirInlet.OutDBSum;
      inputs.OutWBSum = funcDLLInputs.AirInlet.OutWBSum;
      inputs.InDBSum = funcDLLInputs.AirInlet.InDBSum;
      inputs.InWBSum = funcDLLInputs.AirInlet.InWBSum;
      inputs.FreshSCFM = funcDLLInputs.CalcOutputs.FreshSCFM;
      inputs.EffValues.SupSensibleEffectiveness = funcDLLInputs.CalcOutputs.SupSensibleEffectiveness;
      inputs.EffValues.SupLatentEffectiveness = funcDLLInputs.CalcOutputs.SupLatentEffectiveness;
      inputs.NeededValues.EnthSumO = funcDLLInputs.CalcOutputs.EnthSumO;
      inputs.FanPower = funcDLLInputs.CalcOutputs.FanPower;
      inputs.RTUcapacity = funcDLLInputs.RTU.RTUcapacity;
      inputs.RTUeer = funcDLLInputs.RTU.RTUeer;
      this.CalculateEER(inputobj, ref outputObj, ref errsList);
      calcEER.CombinedEER = outputObj.CombinedEER;
      calcEER.ErvEER = outputObj.ErvEER;
      calcEER.OARecoveredSum = outputObj.OARecoveredSum;
      calcEER.PercentOALoad = outputObj.PercentOALoad;
    }

    public void CalculateLeakage(Inputs inputObj, ref Outputs outObj, ref List<ErrFlags> errsList)
    {
      int mode;
      if (Operators.CompareString(inputObj.SSPresT, "oa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ra", false) == 0)
        mode = 1;
      else if (Operators.CompareString(inputObj.SSPresT, "oa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ea", false) == 0)
        mode = 2;
      else if (Operators.CompareString(inputObj.SSPresT, "sa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ra", false) == 0)
        mode = 3;
      else if (Operators.CompareString(inputObj.SSPresT, "sa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ea", false) == 0)
        mode = 4;
      EATROACF.Leakages(mode, inputObj, ref outObj, ref errsList);
    }

    public void CalculateLeakageP(Inputs inputObj, ref Outputs outObj, ref List<ErrFlags> errsList)
    {
      int mode;
      if (Operators.CompareString(inputObj.SSPresT, "oa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ra", false) == 0)
        mode = 1;
      else if (Operators.CompareString(inputObj.SSPresT, "oa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ea", false) == 0)
        mode = 2;
      else if (Operators.CompareString(inputObj.SSPresT, "sa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ra", false) == 0)
        mode = 3;
      else if (Operators.CompareString(inputObj.SSPresT, "sa", false) == 0 & Operators.CompareString(inputObj.ESPresT, "ea", false) == 0)
        mode = 4;
      PurgeCalculations.CalculateLeakageP(mode, inputObj, ref outObj, ref errsList);
    }

    public void CalculateOutputs(Inputs inputObj, ref Outputs outputObj, ref List<ErrFlags> errsList, bool callSingle = false)
    {
      new GlobalFunctions().RecalculateOutputs(inputObj, ref outputObj, ref errsList, callSingle);
    }

    public void CalculatePreHeat2(Inputs inputObj, ref Outputs outputObj, ref List<ErrFlags> errsList)
    {
      GlobalFunctions.Preheat2(inputObj, ref outputObj, errsList);
    }

    public void CalculatePreheatSensible(Inputs inputObj, ref Outputs outputObj, ref List<ErrFlags> errsList)
    {
      GlobalFunctions.PreheatSensible(inputObj, ref outputObj, errsList);
    }

    public void CalculateEnergyBins(Inputs inputobj, ref Outputs outputObj, ref BinEnergyData bindata, ref List<ErrFlags> errsList)
    {
      new EnergyCalc().CalculateEnergyBins(inputobj, ref outputObj, ref bindata, errsList);
    }

    public void CalculateBinData(Inputs inputObj, ref Outputs outputObj, ref List<BinData> binData)
    {
      new EnergyCalc().CalculateBinData(inputObj, ref outputObj, ref binData);
    }

    public void CalculateBinDataByMonth(Inputs inputObj, ref Outputs outputObj, ref List<BinData> binData)
    {
      new EnergyCalc().CalculateBinDataByMonth(inputObj, ref outputObj, ref binData);
    }

    public void CalculateAllEnergyBinsByMonth(Inputs inputobj, ref Outputs outputObj, ref BinEnergyData bindata, ref List<ErrFlags> errsList)
    {
      new EnergyCalc().AllEnergyBinByMonth(inputobj, ref outputObj, ref bindata, ref errsList);
    }

    public void CalculateEER(Inputs inputobj, ref Outputs outputObj, ref List<ErrFlags> errsList)
    {
      new CalcEER().CalculateEERs(inputobj, ref outputObj, ref errsList);
    }
  }
}
