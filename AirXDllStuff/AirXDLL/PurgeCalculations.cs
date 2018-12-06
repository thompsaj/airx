// Decompiled with JetBrains decompiler
// Type: AirXDLL.PurgeCalculations
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
  public class PurgeCalculations
  {
    [DebuggerNonUserCode]
    public PurgeCalculations()
    {
    }

    public static void CalculateLeakageP(int mode, Inputs inputobj, ref Outputs outObj, ref List<ErrFlags> errsList)
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        double num4 = 1.0;
label_2:
        num3 = 2;
label_3:
        num3 = 3;
        ErrFlags errs = new ErrFlags();
label_4:
        num3 = 4;
        errs.ErrText = "";
label_5:
        num3 = 5;
        ModelDBFunctions modelDbFunctions = new ModelDBFunctions();
label_6:
        num3 = 6;
        ModelData modelData = new ModelData();
label_7:
        num3 = 7;
        modelData = modelDbFunctions.GetModelData(inputobj.ConfigFileLocation, inputobj.ModelID, ref errs);
label_8:
        num3 = 8;
        if (Operators.CompareString(errs.ErrText, "", false) == 0)
          goto label_10;
label_9:
        num3 = 9;
        errsList.Add(errs);
        goto label_49;
label_10:
label_11:
        num3 = 12;
        double ssPress = inputobj.SSPress;
label_12:
        num3 = 13;
        double esPress = inputobj.ESPress;
label_13:
        num3 = 14;
        if (!inputobj.HasPurge)
          goto label_15;
label_14:
        num3 = 15;
        int Mode1 = mode;
        double PSup1 = ssPress;
        double PExh1 = esPress;
        double elevation1 = inputobj.Elevation;
        double num5;
        ref double local1 = ref num5;
        double num6;
        ref double local2 = ref num6;
        double num7;
        ref double local3 = ref num7;
        double freshSupplyFlow1 = inputobj.FreshSupplyFlow;
        double exhaustReturnFlow1 = inputobj.ExhaustReturnFlow;
        double num8;
        ref double local4 = ref num8;
        int Wheels1 = checked ((int) Math.Round(inputobj.Wheels));
        double num9;
        ref double local5 = ref num9;
        double num10;
        ref double local6 = ref num10;
        Inputs inputs1 = inputobj;
        double purgeAngle1 = inputs1.PurgeAngle;
        ref double local7 = ref purgeAngle1;
        Inputs inputs2 = inputobj;
        double oacf1 = inputs2.OACF;
        ref double local8 = ref oacf1;
        double num11;
        ref double local9 = ref num11;
        Inputs inputs3 = inputobj;
        double eatr1 = inputs3.EATR;
        ref double local10 = ref eatr1;
        double num12;
        ref double local11 = ref num12;
        double num13;
        ref double local12 = ref num13;
        double num14;
        ref double local13 = ref num14;
        double num15;
        ref double local14 = ref num15;
        double num16;
        ref double local15 = ref num16;
        double num17;
        ref double local16 = ref num17;
        double num18;
        ref double local17 = ref num18;
        double num19;
        ref double local18 = ref num19;
        double num20;
        ref double local19 = ref num20;
        Inputs inputs4 = inputobj;
        double fanEff1 = inputs4.FanEff;
        ref double local20 = ref fanEff1;
        ModelData myModel1 = modelData;
        double num21;
        ref double local21 = ref num21;
        double num22;
        ref double local22 = ref num22;
        Inputs inputs5 = inputobj;
        double gap1 = inputs5.Gap;
        ref double local23 = ref gap1;
        Inputs inputs6 = inputobj;
        double sealFactor1 = inputs6.SealFactor;
        ref double local24 = ref sealFactor1;
        ref Outputs local25 = ref outObj;
        ref List<ErrFlags> local26 = ref errsList;
        PurgeCalculations.PurgeLeakage(Mode1, PSup1, PExh1, elevation1, ref local1, ref local2, ref local3, freshSupplyFlow1, exhaustReturnFlow1, ref local4, Wheels1, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16, ref local17, ref local18, ref local19, ref local20, myModel1, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26);
        inputs6.SealFactor = sealFactor1;
        inputs5.Gap = gap1;
        inputs4.FanEff = fanEff1;
        inputs3.EATR = eatr1;
        inputs2.OACF = oacf1;
        inputs1.PurgeAngle = purgeAngle1;
        goto label_41;
label_15:
        num3 = 17;
label_16:
        num3 = 18;
        inputobj.PurgeAngle = 0.0 + num4;
label_17:
        num3 = 19;
        double num23 = 0.0 + num4;
label_18:
        num3 = 20;
        int Mode2 = mode;
        double PSup2 = ssPress;
        double PExh2 = esPress;
        double elevation2 = inputobj.Elevation;
        ref double local27 = ref num5;
        ref double local28 = ref num6;
        ref double local29 = ref num7;
        double freshSupplyFlow2 = inputobj.FreshSupplyFlow;
        double exhaustReturnFlow2 = inputobj.ExhaustReturnFlow;
        ref double local30 = ref num8;
        int Wheels2 = checked ((int) Math.Round(inputobj.Wheels));
        ref double local31 = ref num9;
        ref double local32 = ref num10;
        Inputs inputs7 = inputobj;
        double purgeAngle2 = inputs7.PurgeAngle;
        ref double local33 = ref purgeAngle2;
        Inputs inputs8 = inputobj;
        double oacf2 = inputs8.OACF;
        ref double local34 = ref oacf2;
        ref double local35 = ref num11;
        Inputs inputs9 = inputobj;
        double eatr2 = inputs9.EATR;
        ref double local36 = ref eatr2;
        ref double local37 = ref num12;
        ref double local38 = ref num13;
        ref double local39 = ref num14;
        ref double local40 = ref num15;
        ref double local41 = ref num16;
        ref double local42 = ref num17;
        ref double local43 = ref num18;
        ref double local44 = ref num19;
        ref double local45 = ref num20;
        Inputs inputs10 = inputobj;
        double fanEff2 = inputs10.FanEff;
        ref double local46 = ref fanEff2;
        ModelData myModel2 = modelData;
        ref double local47 = ref num21;
        ref double local48 = ref num22;
        Inputs inputs11 = inputobj;
        double gap2 = inputs11.Gap;
        ref double local49 = ref gap2;
        Inputs inputs12 = inputobj;
        double sealFactor2 = inputs12.SealFactor;
        ref double local50 = ref sealFactor2;
        ref Outputs local51 = ref outObj;
        ref List<ErrFlags> local52 = ref errsList;
        PurgeCalculations.PurgeLeakage(Mode2, PSup2, PExh2, elevation2, ref local27, ref local28, ref local29, freshSupplyFlow2, exhaustReturnFlow2, ref local30, Wheels2, ref local31, ref local32, ref local33, ref local34, ref local35, ref local36, ref local37, ref local38, ref local39, ref local40, ref local41, ref local42, ref local43, ref local44, ref local45, ref local46, myModel2, ref local47, ref local48, ref local49, ref local50, ref local51, ref local52);
        inputs12.SealFactor = sealFactor2;
        inputs11.Gap = gap2;
        inputs10.FanEff = fanEff2;
        inputs9.EATR = eatr2;
        inputs8.OACF = oacf2;
        inputs7.PurgeAngle = purgeAngle2;
label_19:
        num3 = 21;
        if (inputobj.EATR <= inputobj.TargetEATR)
          goto label_40;
label_20:
        num3 = 22;
        double eatr3 = inputobj.EATR;
label_21:
        num3 = 23;
        inputobj.PurgeAngle = 15.0 + num4;
label_22:
        num3 = 24;
        double num24 = 15.0 + num4;
label_23:
        num3 = 25;
        int Mode3 = mode;
        double PSup3 = ssPress;
        double PExh3 = esPress;
        double elevation3 = inputobj.Elevation;
        ref double local53 = ref num5;
        ref double local54 = ref num6;
        ref double local55 = ref num7;
        double freshSupplyFlow3 = inputobj.FreshSupplyFlow;
        double exhaustReturnFlow3 = inputobj.ExhaustReturnFlow;
        ref double local56 = ref num8;
        int Wheels3 = checked ((int) Math.Round(inputobj.Wheels));
        ref double local57 = ref num9;
        ref double local58 = ref num10;
        Inputs inputs13 = inputobj;
        double purgeAngle3 = inputs13.PurgeAngle;
        ref double local59 = ref purgeAngle3;
        Inputs inputs14 = inputobj;
        double oacf3 = inputs14.OACF;
        ref double local60 = ref oacf3;
        ref double local61 = ref num11;
        Inputs inputs15 = inputobj;
        double eatr4 = inputs15.EATR;
        ref double local62 = ref eatr4;
        ref double local63 = ref num12;
        ref double local64 = ref num13;
        ref double local65 = ref num14;
        ref double local66 = ref num15;
        ref double local67 = ref num16;
        ref double local68 = ref num17;
        ref double local69 = ref num18;
        ref double local70 = ref num19;
        ref double local71 = ref num20;
        Inputs inputs16 = inputobj;
        double fanEff3 = inputs16.FanEff;
        ref double local72 = ref fanEff3;
        ModelData myModel3 = modelData;
        ref double local73 = ref num21;
        ref double local74 = ref num22;
        Inputs inputs17 = inputobj;
        double gap3 = inputs17.Gap;
        ref double local75 = ref gap3;
        Inputs inputs18 = inputobj;
        double sealFactor3 = inputs18.SealFactor;
        ref double local76 = ref sealFactor3;
        ref Outputs local77 = ref outObj;
        ref List<ErrFlags> local78 = ref errsList;
        PurgeCalculations.PurgeLeakage(Mode3, PSup3, PExh3, elevation3, ref local53, ref local54, ref local55, freshSupplyFlow3, exhaustReturnFlow3, ref local56, Wheels3, ref local57, ref local58, ref local59, ref local60, ref local61, ref local62, ref local63, ref local64, ref local65, ref local66, ref local67, ref local68, ref local69, ref local70, ref local71, ref local72, myModel3, ref local73, ref local74, ref local75, ref local76, ref local77, ref local78);
        inputs18.SealFactor = sealFactor3;
        inputs17.Gap = gap3;
        inputs16.FanEff = fanEff3;
        inputs15.EATR = eatr4;
        inputs14.OACF = oacf3;
        inputs13.PurgeAngle = purgeAngle3;
label_24:
        num3 = 26;
        double eatr5 = inputobj.EATR;
label_25:
        num3 = 27;
        if (eatr5 >= inputobj.TargetEATR)
          goto label_34;
label_26:
        num3 = 28;
        int num25 = 1;
label_27:
        ProjectData.ClearProjectError();
        num1 = -2;
label_28:
        num3 = 30;
        inputobj.PurgeAngle = num23 + (num24 - num23) * (eatr3 - inputobj.TargetEATR) / (eatr3 - eatr5);
label_29:
        num3 = 31;
        num24 = inputobj.PurgeAngle;
label_30:
        num3 = 32;
        int Mode4 = mode;
        double PSup4 = ssPress;
        double PExh4 = esPress;
        double elevation4 = inputobj.Elevation;
        ref double local79 = ref num5;
        ref double local80 = ref num6;
        ref double local81 = ref num7;
        double freshSupplyFlow4 = inputobj.FreshSupplyFlow;
        double exhaustReturnFlow4 = inputobj.ExhaustReturnFlow;
        ref double local82 = ref num8;
        int Wheels4 = checked ((int) Math.Round(inputobj.Wheels));
        ref double local83 = ref num9;
        ref double local84 = ref num10;
        Inputs inputs19 = inputobj;
        double purgeAngle4 = inputs19.PurgeAngle;
        ref double local85 = ref purgeAngle4;
        Inputs inputs20 = inputobj;
        double oacf4 = inputs20.OACF;
        ref double local86 = ref oacf4;
        ref double local87 = ref num11;
        Inputs inputs21 = inputobj;
        double eatr6 = inputs21.EATR;
        ref double local88 = ref eatr6;
        ref double local89 = ref num12;
        ref double local90 = ref num13;
        ref double local91 = ref num14;
        ref double local92 = ref num15;
        ref double local93 = ref num16;
        ref double local94 = ref num17;
        ref double local95 = ref num18;
        ref double local96 = ref num19;
        ref double local97 = ref num20;
        Inputs inputs22 = inputobj;
        double fanEff4 = inputs22.FanEff;
        ref double local98 = ref fanEff4;
        ModelData myModel4 = modelData;
        ref double local99 = ref num21;
        ref double local100 = ref num22;
        Inputs inputs23 = inputobj;
        double gap4 = inputs23.Gap;
        ref double local101 = ref gap4;
        Inputs inputs24 = inputobj;
        double sealFactor4 = inputs24.SealFactor;
        ref double local102 = ref sealFactor4;
        ref Outputs local103 = ref outObj;
        ref List<ErrFlags> local104 = ref errsList;
        PurgeCalculations.PurgeLeakage(Mode4, PSup4, PExh4, elevation4, ref local79, ref local80, ref local81, freshSupplyFlow4, exhaustReturnFlow4, ref local82, Wheels4, ref local83, ref local84, ref local85, ref local86, ref local87, ref local88, ref local89, ref local90, ref local91, ref local92, ref local93, ref local94, ref local95, ref local96, ref local97, ref local98, myModel4, ref local99, ref local100, ref local101, ref local102, ref local103, ref local104);
        inputs24.SealFactor = sealFactor4;
        inputs23.Gap = gap4;
        inputs22.FanEff = fanEff4;
        inputs21.EATR = eatr6;
        inputs20.OACF = oacf4;
        inputs19.PurgeAngle = purgeAngle4;
label_31:
        num3 = 33;
        eatr5 = inputobj.EATR;
label_32:
        num3 = 34;
        if (Math.Abs(inputobj.TargetEATR - inputobj.EATR) < 0.01)
          goto label_39;
label_33:
        num3 = 37;
        checked { ++num25; }
        if (num25 <= 100)
          goto label_27;
        else
          goto label_39;
label_34:
        num3 = 39;
label_35:
        num3 = 40;
        errs = new ErrFlags();
label_36:
        num3 = 41;
        errs.ErrType = 8;
label_37:
        num3 = 42;
        errs.ErrText = errs.BadDataText;
label_38:
        num3 = 43;
        errsList.Add(errs);
label_39:
label_40:
label_41:
label_42:
        num3 = 47;
        outObj.PurgeAngle = inputobj.PurgeAngle;
        goto label_49;
label_44:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num26 = num2 + 1;
            num2 = 0;
            switch (num26)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
              case 48:
                goto label_49;
              case 11:
                goto label_10;
              case 12:
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
              case 46:
                goto label_41;
              case 17:
                goto label_15;
              case 18:
                goto label_16;
              case 19:
                goto label_17;
              case 20:
                goto label_18;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
                goto label_24;
              case 27:
                goto label_25;
              case 28:
                goto label_26;
              case 29:
                goto label_27;
              case 30:
                goto label_28;
              case 31:
                goto label_29;
              case 32:
                goto label_30;
              case 33:
                goto label_31;
              case 34:
                goto label_32;
              case 35:
              case 38:
              case 44:
                goto label_39;
              case 36:
              case 37:
                goto label_33;
              case 39:
                goto label_34;
              case 40:
                goto label_35;
              case 41:
                goto label_36;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 45:
                goto label_40;
              case 47:
                goto label_42;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_44;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_49:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void PurgeLeakage(int Mode, double PSup, double PExh, double Elevation, ref double SAFlow, ref double RAFlow, ref double RAFlowOut, double FreshSupplyFlow, double ExhaustReturnFlow, ref double PurgeFlow, int Wheels, ref double OuterSealLeakage, ref double InnerSealLeakage, ref double PurgeAngle, ref double OACF, ref double EATTotal, ref double EATR, ref double OAPressure, ref double SAPressure, ref double EAPressure, ref double RAPressure, ref double DeltaPSupply, ref double DeltaPReturn, ref double TotalReturnFlow, ref double TotalSupplyFlow, ref double FanPower, ref double FanEfficiency, ModelData myModel, ref double OATTotal, ref double FreshAirAdded, ref double Gap, ref double SealFactor, ref Outputs outobj, ref List<ErrFlags> errsList)
    {
      double SAFlowIN = FreshSupplyFlow / (double) Wheels;
      RAFlowOut = ExhaustReturnFlow / (double) Wheels;
      SAFlow = SAFlowIN;
      RAFlow = RAFlowOut;
      OuterSealLeakage = 0.0;
      InnerSealLeakage = 0.0;
      PurgeFlow = SAFlowIN * (PurgeAngle / 180.0);
      int num1 = 1;
      do
      {
        int num2 = 1;
        do
        {
          PurgeCalculations.PurgeIteration(myModel, Mode, PSup, PExh, PurgeAngle, ref DeltaPSupply, ref DeltaPReturn, Elevation, ref InnerSealLeakage, ref OuterSealLeakage, SAFlow, RAFlow, SAFlowIN, ref PurgeFlow, ref OAPressure, ref SAPressure, ref EAPressure, ref RAPressure, ref EATTotal, ref OATTotal, ref FreshAirAdded, ref OACF, ref EATR, Gap, SealFactor, ref outobj);
          double num3 = OACF * SAFlowIN;
          double num4 = RAFlowOut + (num3 - SAFlowIN);
          SAFlow = num3 - PurgeFlow;
          RAFlow = num4;
          checked { ++num2; }
        }
        while (num2 <= 5);
        if (num1 != 5)
        {
          double num3 = SAFlowIN - EATTotal;
          double num4 = RAFlowOut - EATTotal;
          SAFlowIN = SAFlowIN + FreshSupplyFlow / (double) Wheels - num3;
          RAFlowOut = RAFlowOut + ExhaustReturnFlow / (double) Wheels - num4;
          checked { ++num1; }
        }
        else
          break;
      }
      while (num1 <= 5);
      TotalSupplyFlow = FreshSupplyFlow / (1.0 - EATR / 100.0);
      outobj.SupplyFlow = FreshSupplyFlow / (1.0 - EATR / 100.0);
      outobj.ReturnFlow = ExhaustReturnFlow + EATR * TotalSupplyFlow / 100.0;
      outobj.FanPower = (double) Wheels * 5.204 * 2.26E-05 * (outobj.AverageExhaustFlow * DeltaPReturn + outobj.AverageSupplyFlow * DeltaPSupply) / (FanEfficiency / 100.0);
      outobj.OutdoorFlow = OACF * TotalSupplyFlow;
      outobj.ExhaustFlow = ExhaustReturnFlow + outobj.OutdoorFlow - FreshSupplyFlow;
      outobj.OutdoorPressure = OAPressure;
      outobj.SupplyPressure = SAPressure;
      outobj.ExhaustPressure = EAPressure;
      outobj.ReturnPressure = RAPressure;
      outobj.SupPressDrop = DeltaPSupply;
      outobj.ExhPressDrop = DeltaPReturn;
      outobj.EATR = EATR;
      outobj.OACF = OACF;
      if (outobj.SupPressDrop > outobj.AllowedDP)
      {
        ErrFlags errFlags = new ErrFlags()
        {
          ErrType = 2
        };
        errFlags.ErrText = errFlags.SSDPText;
        errsList.Add(errFlags);
      }
      if (outobj.ExhPressDrop <= outobj.AllowedDP)
        return;
      ErrFlags errFlags1 = new ErrFlags()
      {
        ErrType = 1
      };
      errFlags1.ErrText = errFlags1.ESDPText;
      errsList.Add(errFlags1);
    }

    public static void PurgeIteration(ModelData myModel, int Mode, double PSup, double PExh, double PurgeAngle, ref double DeltaPSupply, ref double DeltaPReturn, double Elevation, ref double InnerSealLeakage, ref double OuterSealLeakage, double SAFlow, double RAFlow, double SAFlowIN, ref double PurgeFlow, ref double OAPressure, ref double SAPressure, ref double EAPressure, ref double RAPressure, ref double EATTotal, ref double OATTotal, ref double FreshAirAdded, ref double OACF, ref double EATR, double Gap, double SealFactor, ref Outputs outputobj)
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        double sealdim1 = myModel.SEALDIM;
label_2:
        num3 = 2;
        double wheelod1 = myModel.WHEELOD;
label_3:
        num3 = 3;
        double wheelid = myModel.WHEELID;
label_4:
        num3 = 4;
        double wheeldepth = myModel.WHEELDEPTH;
label_5:
        num3 = 5;
        double spacing = myModel.SPACING;
label_6:
        num3 = 6;
        double num4 = 100.0 * myModel.VOIDFRACTION;
label_7:
        num3 = 7;
        double wheelrpm = myModel.WHEELRPM;
label_8:
        num3 = 8;
        double b1 = myModel.B1;
label_9:
        num3 = 9;
        outputobj.AllowedDP = myModel.MAXDELTA;
label_10:
        num3 = 10;
        double wheelod2 = myModel.WHEELOD;
label_11:
        num3 = 11;
        double sealdim2 = myModel.SEALDIM;
label_12:
        ProjectData.ClearProjectError();
        num1 = -2;
label_13:
        num3 = 13;
        double num5 = 1.0 / b1;
label_14:
        num3 = 14;
        double num6 = 0.7853975 * (Math.Pow(wheelod1, 2.0) - Math.Pow(wheelid, 2.0)) / 2.0;
label_15:
        num3 = 15;
        double num7 = num6 * (180.0 - PurgeAngle) / 180.0;
label_16:
        num3 = 16;
        double num8 = num6 * PurgeAngle / 180.0;
label_17:
        ProjectData.ClearProjectError();
        num1 = -3;
label_18:
        num3 = 18;
        double num9 = num5 * num7 / num6;
label_19:
        ProjectData.ClearProjectError();
        num1 = -4;
label_20:
        num3 = 20;
        double num10 = num5 * num8 / num6;
label_21:
        ProjectData.ClearProjectError();
        num1 = -5;
label_22:
        num3 = 22;
        DeltaPSupply = 1.0 / num9 * (SAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0);
label_23:
        num3 = 23;
        DeltaPReturn = b1 * (RAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0);
label_24:
        num3 = 24;
        outputobj.AverageSupplyFlow = SAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0 - PurgeFlow;
label_25:
        num3 = 25;
        outputobj.AverageExhaustFlow = RAFlow - OuterSealLeakage / 2.0 + InnerSealLeakage / 2.0;
label_26:
        num3 = 26;
        switch (Mode)
        {
          case 1:
            break;
          case 2:
            goto label_31;
          case 3:
            goto label_35;
          case 4:
            goto label_39;
          default:
            goto label_43;
        }
label_27:
        num3 = 30;
        OAPressure = PSup;
label_28:
        num3 = 31;
        RAPressure = PExh;
label_29:
        num3 = 32;
        SAPressure = OAPressure - DeltaPSupply;
label_30:
        num3 = 33;
        EAPressure = RAPressure - DeltaPReturn;
        goto label_43;
label_31:
        num3 = 36;
        OAPressure = PSup;
label_32:
        num3 = 37;
        EAPressure = PExh;
label_33:
        num3 = 38;
        SAPressure = OAPressure - DeltaPSupply;
label_34:
        num3 = 39;
        RAPressure = EAPressure + DeltaPReturn;
        goto label_43;
label_35:
        num3 = 42;
        SAPressure = PSup;
label_36:
        num3 = 43;
        RAPressure = PExh;
label_37:
        num3 = 44;
        OAPressure = SAPressure + DeltaPSupply;
label_38:
        num3 = 45;
        EAPressure = RAPressure - DeltaPReturn;
        goto label_43;
label_39:
        num3 = 48;
        SAPressure = PSup;
label_40:
        num3 = 49;
        EAPressure = PExh;
label_41:
        num3 = 50;
        OAPressure = SAPressure + DeltaPSupply;
label_42:
        num3 = 51;
        RAPressure = EAPressure + DeltaPReturn;
label_43:
label_44:
        num3 = 53;
        double num11 = OAPressure - RAPressure;
label_45:
        num3 = 54;
        PurgeFlow = num10 * num11;
label_46:
        num3 = 55;
        double num12 = 3.14159 * wheelrpm * wheeldepth * (num4 / 100.0) * (Math.Pow(wheelod1, 2.0) - Math.Pow(wheelid, 2.0)) / 4.0 / 1728.0;
label_47:
        num3 = 56;
        double num13 = 3.0 * wheelrpm * (wheelod1 - wheelid) * wheeldepth / 1728.0;
label_48:
        num3 = 57;
        if (PurgeAngle == 0.0)
          goto label_52;
label_49:
        num3 = 58;
        PurgeCalculations.Purge(myModel, PurgeAngle, SAFlow, RAFlow, SAFlowIN, PurgeFlow, OAPressure, SAPressure, EAPressure, RAPressure, ref EATTotal, ref OATTotal);
label_50:
        num3 = 59;
        FreshAirAdded = num12 - EATTotal;
label_51:
        num3 = 60;
        OATTotal = PurgeFlow;
        goto label_56;
label_52:
        num3 = 62;
label_53:
        num3 = 63;
        EATTotal = num12;
label_54:
        num3 = 64;
        FreshAirAdded = 0.0;
label_55:
        num3 = 65;
        OATTotal = 0.0;
label_56:
label_57:
        num3 = 67;
        if (num12 == 0.0)
          goto label_59;
label_58:
        num3 = 68;
        EATTotal = EATTotal * (num12 - num13) / num12;
        goto label_61;
label_59:
        num3 = 70;
label_60:
        num3 = 71;
        EATTotal = EATTotal;
label_61:
label_62:
        num3 = 73;
        double DeltaP1 = OAPressure - EAPressure;
label_63:
        num3 = 74;
        double DeltaP2 = SAPressure - RAPressure;
label_64:
        num3 = 75;
        if (DeltaP1 == 0.0)
          goto label_66;
label_65:
        num3 = 76;
        OuterSealLeakage = PurgeCalculations.PurgeSealLeakage(myModel, DeltaP1, Elevation, Gap, SealFactor);
        goto label_68;
label_66:
        num3 = 78;
label_67:
        num3 = 79;
        OuterSealLeakage = 0.0;
label_68:
label_69:
        num3 = 81;
        if (DeltaP2 == 0.0)
          goto label_71;
label_70:
        num3 = 82;
        InnerSealLeakage = PurgeCalculations.PurgeSealLeakage(myModel, DeltaP2, Elevation, Gap, SealFactor);
        goto label_73;
label_71:
        num3 = 84;
label_72:
        num3 = 85;
        InnerSealLeakage = 0.0;
label_73:
label_74:
        num3 = 87;
        OATTotal = OATTotal + OuterSealLeakage + InnerSealLeakage;
label_75:
        num3 = 88;
        EATTotal += Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(OuterSealLeakage < 0.0, (object) Math.Abs(OuterSealLeakage), (object) 0));
label_76:
        num3 = 89;
        EATTotal += Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Interaction.IIf(InnerSealLeakage < 0.0, (object) Math.Abs(InnerSealLeakage), (object) 0));
label_77:
        num3 = 90;
        OACF = (SAFlowIN + OATTotal) / SAFlowIN;
label_78:
        num3 = 91;
        EATR = 100.0 * EATTotal / SAFlowIN;
        goto label_85;
label_80:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num14 = num2 + 1;
            num2 = 0;
            switch (num14)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
                goto label_26;
              case 27:
              case 34:
              case 40:
              case 46:
              case 52:
                goto label_43;
              case 28:
              case 30:
                goto label_27;
              case 31:
                goto label_28;
              case 32:
                goto label_29;
              case 33:
                goto label_30;
              case 35:
              case 36:
                goto label_31;
              case 37:
                goto label_32;
              case 38:
                goto label_33;
              case 39:
                goto label_34;
              case 41:
              case 42:
                goto label_35;
              case 43:
                goto label_36;
              case 44:
                goto label_37;
              case 45:
                goto label_38;
              case 47:
              case 48:
                goto label_39;
              case 49:
                goto label_40;
              case 50:
                goto label_41;
              case 51:
                goto label_42;
              case 53:
                goto label_44;
              case 54:
                goto label_45;
              case 55:
                goto label_46;
              case 56:
                goto label_47;
              case 57:
                goto label_48;
              case 58:
                goto label_49;
              case 59:
                goto label_50;
              case 60:
                goto label_51;
              case 61:
              case 66:
                goto label_56;
              case 62:
                goto label_52;
              case 63:
                goto label_53;
              case 64:
                goto label_54;
              case 65:
                goto label_55;
              case 67:
                goto label_57;
              case 68:
                goto label_58;
              case 69:
              case 72:
                goto label_61;
              case 70:
                goto label_59;
              case 71:
                goto label_60;
              case 73:
                goto label_62;
              case 74:
                goto label_63;
              case 75:
                goto label_64;
              case 76:
                goto label_65;
              case 77:
              case 80:
                goto label_68;
              case 78:
                goto label_66;
              case 79:
                goto label_67;
              case 81:
                goto label_69;
              case 82:
                goto label_70;
              case 83:
              case 86:
                goto label_73;
              case 84:
                goto label_71;
              case 85:
                goto label_72;
              case 87:
                goto label_74;
              case 88:
                goto label_75;
              case 89:
                goto label_76;
              case 90:
                goto label_77;
              case 91:
                goto label_78;
              case 92:
                goto label_85;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_80;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_85:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static double PurgeSealLeakage(ModelData myModel, double DeltaP, double Elevation, double Gap, double SealFactor)
    {
label_1:
      int num1;
      double num2;
      int num3;
      try
      {
        int num4 = 1;
        double wheelod = myModel.WHEELOD;
label_2:
        num4 = 2;
        double sealdim = myModel.SEALDIM;
label_3:
        num4 = 3;
        Psychrometrics.SetAirProperties(Elevation);
label_4:
        num4 = 4;
        double airDensity = Psychrometrics.AirDensity;
label_5:
        num4 = 5;
        if (DeltaP == 0.0)
          goto label_7;
label_6:
        num4 = 6;
        double num5 = DeltaP / Math.Abs(DeltaP) * (0.39 * wheelod * Math.Pow(Math.Abs(DeltaP), 0.68));
label_7:
label_8:
        num4 = 8;
        double num6 = 1.0;
label_9:
        num4 = 9;
        double num7 = 0.5;
label_10:
        num4 = 10;
        double num8 = Gap;
label_11:
        num4 = 11;
        double num9 = 2.0 * num8;
label_12:
        num4 = 12;
        double num10 = 100.0;
label_13:
        num4 = 13;
        short num11 = 1;
label_14:
        ProjectData.ClearProjectError();
        num1 = -2;
label_15:
        num4 = 15;
        double num12 = 24.0 / num10;
label_16:
        num4 = 16;
        double num13 = num6 + 4.0 * num12 * (sealdim / num9) + num7;
label_17:
        num4 = 17;
        double num14 = airDensity;
label_18:
        num4 = 18;
        if (DeltaP == 0.0)
          goto label_20;
label_19:
        num4 = 19;
        double num15 = DeltaP / Math.Abs(DeltaP) * (wheelod * num8 * (5.0 / 12.0) * Math.Sqrt(64.4 * (144.0 * Math.Abs(DeltaP) / 27.2) / (num14 * num13)));
label_20:
        num4 = 21;
        double num16 = Math.Abs(num15) / (wheelod * num8 / 144.0);
label_21:
        num4 = 22;
        double num17 = 1.241E-05;
label_22:
        num4 = 23;
        num10 = num14 * (num16 / 60.0) * (num9 / 12.0) / num17;
label_23:
        num4 = 24;
        checked { ++num11; }
        if (num11 <= (short) 10)
          goto label_14;
label_24:
        num4 = 25;
        num2 = (num5 + num15) * SealFactor;
        goto label_31;
label_26:
        num3 = num4;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num18 = num3 + 1;
            num3 = 0;
            switch (num18)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
              case 21:
                goto label_20;
              case 22:
                goto label_21;
              case 23:
                goto label_22;
              case 24:
                goto label_23;
              case 25:
                goto label_24;
              case 26:
                goto label_31;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_26;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_31:
      double num19 = num2;
      if (num3 == 0)
        return num19;
      ProjectData.ClearProjectError();
      return num19;
    }

    public static void Purge(ModelData myModel, double PurgeAngle, double SAFlow, double RAFlow, double SAFlowIN, double PurgeFlow, double OAPressure, double SAPressure, double EAPressure, double RAPressure, ref double EATTotal, ref double OATTotal)
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        double wheelod1 = myModel.WHEELOD;
label_2:
        num3 = 2;
        double wheelid = myModel.WHEELID;
label_3:
        num3 = 3;
        double wheeldepth = myModel.WHEELDEPTH;
label_4:
        num3 = 4;
        double spacing = myModel.SPACING;
label_5:
        num3 = 5;
        double num4 = 100.0 * myModel.VOIDFRACTION;
label_6:
        num3 = 6;
        double wheelrpm = myModel.WHEELRPM;
label_7:
        num3 = 7;
        double b1 = myModel.B1;
label_8:
        num3 = 8;
        double wheelod2 = myModel.WHEELOD;
label_9:
        num3 = 9;
        double sealdim = myModel.SEALDIM;
label_10:
        num3 = 10;
        double num5 = spacing;
label_11:
        num3 = 11;
        double num6 = 0.7853975 * (Math.Pow(wheelod1, 2.0) - Math.Pow(wheelid, 2.0)) / 2.0;
label_12:
        ProjectData.ClearProjectError();
        num1 = -2;
label_13:
        num3 = 13;
        double num7 = PurgeAngle / 360.0 / wheelrpm;
label_14:
        ProjectData.ClearProjectError();
        num1 = -3;
label_15:
        num3 = 15;
        double num8 = wheeldepth / num7 / 12.0;
label_16:
        ProjectData.ClearProjectError();
        num1 = -4;
label_17:
        num3 = 17;
        double num9 = PurgeFlow / (num4 / 100.0 * (num6 / 144.0) * (PurgeAngle / 180.0));
label_18:
        num3 = 18;
        double num10 = num9 * 2.0 * num5 / 12.0;
label_19:
        ProjectData.ClearProjectError();
        num1 = -5;
label_20:
        num3 = 20;
        double num11 = 0.75 * num10 * (12.0 / num5);
label_21:
        num3 = 21;
        double num12 = num8 - num11;
label_22:
        num3 = 22;
        if (num12 < 0.0)
          goto label_26;
label_23:
        ProjectData.ClearProjectError();
        num1 = -6;
label_24:
        num3 = 24;
        EATTotal = (num8 - num9) * (num6 / 144.0 * PurgeAngle / 180.0) * (num4 / 100.0);
label_25:
        num3 = 25;
        OATTotal = 0.0;
        goto label_37;
label_26:
        num3 = 27;
label_27:
        ProjectData.ClearProjectError();
        num1 = -7;
label_28:
        num3 = 29;
        double num13 = num5 * Math.Sqrt(1.0 - 4.0 / 3.0 * num8 * (num5 / 12.0) / num10);
label_29:
        ProjectData.ClearProjectError();
        num1 = -8;
label_30:
        num3 = 31;
        double num14 = 3.0 * num10 / 4.0 * (2.0 / 3.0 - num13 / num5 + Math.Pow(num13 / num5, 3.0) / 3.0) / ((num5 - num13) / 12.0);
label_31:
        ProjectData.ClearProjectError();
        num1 = -9;
label_32:
        num3 = 33;
        EATTotal = (num8 - num14) * ((num5 - num13) / num5) * (num6 / 144.0 * PurgeAngle / 180.0) * (num4 / 100.0);
label_33:
        ProjectData.ClearProjectError();
        num1 = -10;
label_34:
        num3 = 35;
        double num15 = 3.0 * num10 / 4.0 * (1.0 - Math.Pow(num13 / num5, 2.0) / 3.0) / (num5 / 12.0);
label_35:
        ProjectData.ClearProjectError();
        num1 = -11;
label_36:
        num3 = 37;
        OATTotal = (num15 - num8) * (num13 / num5) * (num6 / 144.0 * PurgeAngle / 180.0) * (num4 / 100.0);
label_37:
        goto label_44;
label_39:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num16 = num2 + 1;
            num2 = 0;
            switch (num16)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
              case 38:
                goto label_37;
              case 27:
                goto label_26;
              case 28:
                goto label_27;
              case 29:
                goto label_28;
              case 30:
                goto label_29;
              case 31:
                goto label_30;
              case 32:
                goto label_31;
              case 33:
                goto label_32;
              case 34:
                goto label_33;
              case 35:
                goto label_34;
              case 36:
                goto label_35;
              case 37:
                goto label_36;
              case 39:
                goto label_44;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_39;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_44:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }
  }
}
