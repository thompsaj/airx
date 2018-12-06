// Decompiled with JetBrains decompiler
// Type: AirXDLL.CalcEER
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Collections.Generic;
using System.Diagnostics;

namespace AirXDLL
{
  public class CalcEER
  {
    [DebuggerNonUserCode]
    public CalcEER()
    {
    }

    public void CalculateEERs(Inputs inputObj, ref Outputs outputObj, ref List<ErrFlags> errsList)
    {
      double num1 = Psychrometrics.WetBulbHR(inputObj.InDBSum, inputObj.InWBSum, inputObj.Elevation);
      double num2 = Psychrometrics.WetBulbHR(inputObj.OutDBSum, inputObj.OutWBSum, inputObj.Elevation);
      double T = inputObj.OutDBSum - (inputObj.OutDBSum - inputObj.InDBSum) * inputObj.EffValues.SupSensibleEffectiveness;
      double W = num2 - (num2 - num1) * inputObj.EffValues.SupLatentEffectiveness;
      outputObj.OARecoveredSum = 4.5 * inputObj.FreshSCFM * (inputObj.NeededValues.EnthSumO - Psychrometrics.Enthalpy(T, W));
      if (inputObj.FanPower != 0.0)
        outputObj.ErvEER = outputObj.OARecoveredSum / (1000.0 * inputObj.FanPower + 100.0 * inputObj.Wheels);
      outputObj.PercentOALoad = 100.0 * outputObj.OARecoveredSum / (outputObj.OARecoveredSum + inputObj.RTUcapacity);
      outputObj.CombinedEER = (outputObj.OARecoveredSum + inputObj.RTUcapacity) / (1000.0 * inputObj.FanPower + 100.0 * inputObj.Wheels + inputObj.RTUcapacity / inputObj.RTUeer);
    }
  }
}
