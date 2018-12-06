// Decompiled with JetBrains decompiler
// Type: AirXDLL.EATROACF
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
  public class EATROACF
  {
    [DebuggerNonUserCode]
    public EATROACF()
    {
    }

    public static void Leakages(int mode, Inputs inputobj, ref Outputs outObj, ref List<ErrFlags> errsLIst)
    {
      ModelData modelData1 = new ModelData();
      ModelData modelData2 = new ModelData();
      ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
      ErrFlags errs = new ErrFlags();
      errs.ErrText = "";
      ModelData modelData3 = modelDbFunctions.GetModelData(inputobj.ConfigFileLocation, inputobj.ModelID, ref errs);
      if (Operators.CompareString(errs.ErrText, "", false) != 0)
      {
        errsLIst.Add(errs);
      }
      else
      {
        double sealdim1 = modelData3.SEALDIM;
        double wheelod1 = modelData3.WHEELOD;
        double wheelid = modelData3.WHEELID;
        double wheeldepth = modelData3.WHEELDEPTH;
        double Void = 100.0 * modelData3.VOIDFRACTION;
        double wheelrpm = modelData3.WHEELRPM;
        double numspokes = (double) modelData3.NUMSPOKES;
        double b1 = modelData3.B1;
        double wheelod2 = modelData3.WHEELOD;
        double sealdim2 = modelData3.SEALDIM;
        double ssPress = inputobj.SSPress;
        double esPress = inputobj.ESPress;
        double OuterSealLeakage = 0.0;
        double InnerSealLeakage = 0.0;
        double SAFlowIn = inputobj.FreshFlow / inputobj.Wheels;
        double num1 = inputobj.OutFlow / inputobj.Wheels;
        double SAFlow = SAFlowIn;
        double RAFlow = num1;
        Psychrometrics.SetAirProperties(inputobj.Elevation);
        double airDensity = Psychrometrics.AirDensity;
        int num2 = 1;
        double AvgExhFlow;
        double AvgSupplyFlow;
        double DeltaPReturn;
        double DeltaPSupply;
        double EATR;
        double OACF;
        double SAPressure;
        double RAPressure;
        double EAPressure;
        double OAPressure;
        do
        {
          int num3 = 1;
          double EATTotal;
          do
          {
            EATROACF.Iteration(ref AvgExhFlow, ref AvgSupplyFlow, mode, inputobj.SSPress, inputobj.ESPress, wheeldepth, b1, wheelod1, wheelid, SAFlow, RAFlow, sealdim2, sealdim1, wheelrpm, wheelod2, Void, numspokes, airDensity, ref DeltaPReturn, ref DeltaPSupply, ref EATTotal, ref EATR, ref OACF, ref SAFlowIn, ref InnerSealLeakage, ref OuterSealLeakage, ref SAPressure, ref RAPressure, ref EAPressure, ref OAPressure);
            double num4 = OACF * SAFlowIn;
            double num5 = num1 + (num4 - SAFlowIn);
            SAFlow = (num4 + SAFlowIn) / 2.0;
            RAFlow = (num5 + num1) / 2.0;
            checked { ++num3; }
          }
          while (num3 <= 5);
          if (num2 != 5)
          {
            double num4 = SAFlowIn - EATTotal;
            double num5 = num1 - EATTotal;
            SAFlowIn = SAFlowIn + inputobj.FreshFlow / inputobj.Wheels - num4;
            num1 = num1 + inputobj.OutFlow / inputobj.Wheels - num5;
            checked { ++num2; }
          }
          else
            break;
        }
        while (num2 <= 5);
        Outputs outputs = outObj;
        outputs.EATR = EATR;
        outputs.OACF = OACF;
        outputs.SupplyFlow = inputobj.FreshFlow / (1.0 - outputs.EATR / 100.0);
        outputs.ReturnFlow = inputobj.OutFlow + outObj.EATR * outputs.SupplyFlow / 100.0;
        outputs.OutdoorFlow = outputs.OACF * outputs.SupplyFlow;
        outputs.ExhaustFlow = inputobj.OutFlow + outputs.OutdoorFlow - inputobj.FreshFlow;
        outputs.OutdoorPressure = OAPressure;
        outputs.SupplyPressure = SAPressure;
        outputs.ExhaustPressure = EAPressure;
        outputs.ReturnPressure = RAPressure;
        outputs.SupPressDrop = DeltaPSupply;
        outputs.ExhPressDrop = DeltaPReturn;
        outputs.AllowedDP = modelData3.MAXDELTA;
        outputs.FanPower = 0.0001176104 * inputobj.Wheels * (AvgExhFlow * outputs.ExhPressDrop + AvgSupplyFlow * outputs.SupPressDrop) / (inputobj.FanEff / 100.0);
        if (outObj.SupPressDrop > outObj.AllowedDP)
        {
          ErrFlags errFlags = new ErrFlags()
          {
            ErrType = 2
          };
          errFlags.ErrText = errFlags.SSDPText;
          errsLIst.Add(errFlags);
        }
        if (outObj.ExhPressDrop > outObj.AllowedDP)
        {
          ErrFlags errFlags = new ErrFlags()
          {
            ErrType = 1
          };
          errFlags.ErrText = errFlags.ESDPText;
          errsLIst.Add(errFlags);
        }
      }
    }

    public static void CalculateNodeI(int I, int J, ref double OAT, ref double EAT, double EAPressure, double OAPressure, double Hub, double Rim, double Seal, double Core, double RPM, double Void, int NA, int NR, double Bmod, double innerMatrixFactor, double outerMatrixFactor, double NodeFlowArea, ref double NSpokes, ref double TotalCarryOver, ref double TotalFriction, double WheelFlowArea, double DeltaPReturn, double DeltaPSupply, ref double OAfTot, ref double SAfTot, ref double OArTot, ref double SArTot)
    {
      double num1;
      try
      {
        num1 = Hub / 2.0 + ((double) J - 0.5) / (double) NR * (Rim - Hub) / 2.0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = 6.28318 * num1;
      double num3 = EAPressure + ((double) I - 0.5) / (double) NA * DeltaPReturn;
      double num4 = OAPressure - ((double) I - 0.5) / (double) NA * DeltaPSupply;
      double num5 = num3 <= num4 ? outerMatrixFactor * Seal : innerMatrixFactor * Seal;
      double num6;
      try
      {
        num6 = NodeFlowArea / WheelFlowArea * (Core / num5) * Bmod;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num7 = num6 * (num4 - num3);
      double num8 = num2 * RPM * NodeFlowArea * Void / 100.0 / 1728.0;
      double num9;
      try
      {
        num9 = (num2 - Seal * NSpokes) / num2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (num9 < 0.0)
        num9 = 0.0;
      double num10 = num7 * num9;
      TotalFriction += num10;
      TotalCarryOver += num8;
      OAT = num10 + num8;
      EAT = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(OAT < 0.0, (object) -OAT, (object) 0));
      double num11 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(num10 > 0.0, (object) num10, (object) 0));
      double num12 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(num10 > 0.0, (object) 0, (object) -num10));
      double num13 = num8;
      double num14 = 0.0;
      OAfTot += num11;
      SAfTot += num12;
      OArTot += num13;
      SArTot += num14;
    }

    public static void CalculateNodeO(int I, int J, ref double OAT, ref double EAT, double EAPressure, double OAPressure, double Hub, double Rim, double Seal, double Core, double RPM, double Void, int NA, int NR, double Bmod, double innerMatrixFactor, double outerMatrixFactor, double NodeFlowArea, ref double NSpokes, double WheelFlowArea, double DeltaPReturn, double DeltaPSupply, ref double OAfTot, ref double SAfTot, ref double OArTot, ref double SArTot)
    {
      double num1 = 6.28318 * (Hub / 2.0 + ((double) J - 0.5) / (double) NR * (Rim - Hub) / 2.0);
      double num2 = EAPressure + ((double) I - 0.5) / (double) NA * DeltaPReturn;
      double num3 = OAPressure - ((double) I - 0.5) / (double) NA * DeltaPSupply;
      double num4 = num2 <= num3 ? outerMatrixFactor * Seal : innerMatrixFactor * Seal;
      double num5;
      try
      {
        num5 = NodeFlowArea / WheelFlowArea * (Core / num4) * Bmod;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num6 = num5 * (num3 - num2);
      double num7 = num1 * RPM * NodeFlowArea * Void / 100.0 / 1728.0;
      double num8 = (num1 - Seal * NSpokes) / num1;
      if (num8 < 0.0)
        num8 = 0.0;
      double num9 = num6 * num8;
      OAT = num9 - num7;
      EAT = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(OAT < 0.0, (object) -OAT, (object) 0));
    }

    public static void Iteration(ref double AvgExhFlow, ref double AvgSupplyFlow, int mode, double PSup, double PExh, double Core, double B, double Rim, double Hub, double SAFlow, double RAFlow, double L, double Seal, double RPM, double OD, double Void, double NSpokes, double airDensity, ref double DeltaPReturn, ref double DeltaPSupply, ref double EATTotal, ref double EATR, ref double OACF, ref double SAFlowIn, ref double InnerSealLeakage, ref double OuterSealLeakage, ref double SAPressure, ref double RAPressure, ref double EAPressure, ref double OAPressure)
    {
      double[,] numArray1 = new double[2, 2];
      double[,] numArray2 = new double[2, 2];
      double[,] numArray3 = new double[2, 2];
      double[,] numArray4 = new double[2, 2];
      double[,] numArray5 = new double[2, 2];
      double[,] numArray6 = new double[2, 2];
      double OAfTot = 0.0;
      double SAfTot = 0.0;
      double OArTot = 0.0;
      double SArTot = 0.0;
      int matrixFactor = 2;
      int NR = 50;
      int NA = 50;
      double num1;
      try
      {
        num1 = (Rim - Hub) / (double) NR / 2.0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = Core / (double) NA;
      numArray3 = new double[checked (NA + 1), checked (NR + 1)];
      numArray4 = new double[checked (NA + 1), checked (NR + 1)];
      numArray1 = new double[checked (NA + 1), checked (NR + 1)];
      numArray2 = new double[checked (NA + 1), checked (NR + 1)];
      numArray6 = new double[checked (NA + 1), checked (NR + 1)];
      numArray5 = new double[checked (NA + 1), checked (NR + 1)];
      double Bmod;
      try
      {
        Bmod = 1.0 / B;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double WheelFlowArea = 0.7853975 * (Math.Pow(Rim, 2.0) - Math.Pow(Hub, 2.0)) / 2.0;
      double NodeFlowArea = num1 * num2;
      DeltaPSupply = B * (SAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0);
      DeltaPReturn = B * (RAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0);
      AvgSupplyFlow = SAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0;
      AvgExhFlow = RAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0;
      switch (mode)
      {
        case 1:
          OAPressure = PSup;
          RAPressure = PExh;
          SAPressure = OAPressure - DeltaPSupply;
          EAPressure = RAPressure - DeltaPReturn;
          break;
        case 2:
          OAPressure = PSup;
          EAPressure = PExh;
          SAPressure = OAPressure - DeltaPSupply;
          RAPressure = EAPressure + DeltaPReturn;
          break;
        case 3:
          SAPressure = PSup;
          RAPressure = PExh;
          OAPressure = SAPressure + DeltaPSupply;
          EAPressure = RAPressure - DeltaPReturn;
          break;
        case 4:
          SAPressure = PSup;
          EAPressure = PExh;
          OAPressure = SAPressure + DeltaPSupply;
          RAPressure = EAPressure + DeltaPReturn;
          break;
      }
      double innerMatrixFactor;
      double outerMatrixFactor;
      EATROACF.NeutralPlane(OAPressure, EAPressure, SAPressure, RAPressure, Core, matrixFactor, ref innerMatrixFactor, ref outerMatrixFactor);
      double num3 = 0.0;
      EATTotal = 0.0;
      double TotalCarryOver = 0.0;
      double TotalFriction = 0.0;
      int num4 = 1;
      int num5 = NA;
      int I = num4;
      while (I <= num5)
      {
        int num6 = 1;
        int num7 = NR;
        int J = num6;
        while (J <= num7)
        {
          double OAT;
          double EAT;
          EATROACF.CalculateNodeI(I, J, ref OAT, ref EAT, EAPressure, OAPressure, Hub, Rim, Seal, Core, RPM, Void, NA, NR, Bmod, innerMatrixFactor, outerMatrixFactor, NodeFlowArea, ref NSpokes, ref TotalCarryOver, ref TotalFriction, WheelFlowArea, DeltaPReturn, DeltaPSupply, ref OAfTot, ref SAfTot, ref OArTot, ref SArTot);
          double num8 = num3 + OAT;
          EATTotal += EAT;
          EATROACF.CalculateNodeO(I, J, ref OAT, ref EAT, EAPressure, OAPressure, Hub, Rim, Seal, Core, RPM, Void, NA, NR, Bmod, innerMatrixFactor, outerMatrixFactor, NodeFlowArea, ref NSpokes, WheelFlowArea, DeltaPReturn, DeltaPSupply, ref OAfTot, ref SAfTot, ref OArTot, ref SArTot);
          num3 = num8 + OAT;
          EATTotal += EAT;
          checked { ++J; }
        }
        checked { ++I; }
      }
      double DeltaP1 = OAPressure - EAPressure;
      double DeltaP2 = SAPressure - RAPressure;
      if (DeltaP1 != 0.0)
        EATROACF.SealLeakage(ref OuterSealLeakage, DeltaP1, L, OD, airDensity);
      else
        OuterSealLeakage = 0.0;
      if (DeltaP2 != 0.0)
        EATROACF.SealLeakage(ref InnerSealLeakage, DeltaP2, L, OD, airDensity);
      else
        InnerSealLeakage = 0.0;
      double num9 = num3 + OuterSealLeakage + InnerSealLeakage;
      EATTotal += Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(OuterSealLeakage < 0.0, (object) Math.Abs(OuterSealLeakage), (object) 0));
      EATTotal += Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(InnerSealLeakage < 0.0, (object) Math.Abs(InnerSealLeakage), (object) 0));
      OACF = (SAFlowIn + num9) / SAFlowIn;
      EATR = 100.0 * EATTotal / SAFlowIn;
    }

    public static void SealLeakage(ref double Leakage, double DeltaP, double L, double OD, double airDensity)
    {
      double num1 = 1.5;
      double num2 = 0.03;
      double num3;
      if (DeltaP != 0.0)
        num3 = DeltaP / Math.Abs(DeltaP) * (0.39 * OD * Math.Pow(Math.Abs(DeltaP), 0.68));
      double num4 = 1.0;
      double num5 = 0.5;
      double num6 = num2;
      double num7 = 2.0 * num6;
      double num8 = 100.0;
      int num9 = 1;
      double num10;
      do
      {
        try
        {
          double num11 = 24.0 / num8;
          double num12 = num4 + 4.0 * num11 * (L / num7) + num5;
          double num13 = airDensity;
          if (DeltaP != 0.0)
            num10 = DeltaP / Math.Abs(DeltaP) * (OD * num6 * (5.0 / 12.0) * Math.Sqrt(64.4 * (144.0 * Math.Abs(DeltaP) / 27.2) / (num13 * num12)));
          double num14 = Math.Abs(num10) / (OD * num6 / 144.0);
          double num15 = 1.241E-05;
          num8 = num13 * (num14 / 60.0) * (num7 / 12.0) / num15;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++num9; }
      }
      while (num9 <= 10);
      Leakage = num3 + num10;
      Leakage *= num1;
    }

    public static void NeutralPlane(double OAPressure, double EAPressure, double SAPressure, double RAPressure, double Core, int matrixFactor, ref double innerMatrixFactor, ref double outerMatrixFactor)
    {
      double num1;
      try
      {
        num1 = (OAPressure - EAPressure) * Core / (OAPressure - SAPressure + RAPressure - EAPressure);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = Core - num1;
      if (num1 < 0.0)
        num1 = 0.0;
      if (num2 < 0.0)
        num2 = 0.0;
      innerMatrixFactor = 1.0 + (double) checked (matrixFactor - 1) * (num2 / 3.0);
      outerMatrixFactor = 1.0 + (double) checked (matrixFactor - 1) * (num1 / 3.0);
    }
  }
}
