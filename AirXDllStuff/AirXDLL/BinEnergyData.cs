// Decompiled with JetBrains decompiler
// Type: AirXDLL.BinEnergyData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

namespace AirXDLL
{
  public class BinEnergyData
  {
    public double[] binAverageTemps;
    public int NB;
    public double[] DryBulb;
    public double[] TotPreEnergy;
    public double[] MCWB;
    public double[] AnnualHours;
    public double[] BinEnthalpy;
    public double[] BinVentLoad;
    public double[] BinRecLoad;
    public double[] BinNetLoad;
    public double[] BinPreheat;
    public double TotalCoolingHours;
    public double TotalHeatingHours;
    public double TotalCoolingLoad;
    public double TotalCoolingRecovered;
    public double TotalVentingCoolingHours;
    public double TotalNetCoolingLoad;
    public double TotalHeatingLoad;
    public double TotalHeatingRecovered;
    public double TotalNetHeatingLoad;
    public double TotalVentingHeatingHours;
    public double TotalPreheat;
    public double TotalFanKWH;
    public double CoolingDollarsSaved;
    public double HeatingDollarsSaved;
    public double FanDollarsSpent;
    public double NetAnnualSavings;
    public double Factor;
    public double RecCostC;
    public double RecCostH;
    public double CoolingTotal;
    public double HeatingTotal;

    public BinEnergyData()
    {
      this.binAverageTemps = new double[31];
      this.DryBulb = new double[31];
      this.TotPreEnergy = new double[31];
      this.MCWB = new double[31];
      this.AnnualHours = new double[31];
      this.BinEnthalpy = new double[31];
      this.BinVentLoad = new double[31];
      this.BinRecLoad = new double[31];
      this.BinNetLoad = new double[31];
      this.BinPreheat = new double[31];
    }

    public enum MonthNames
    {
      Yearly = -1,
      January = 1,
      Febuary = 2,
      March = 3,
      April = 4,
      May = 5,
      June = 6,
      July = 7,
      August = 8,
      September = 9,
      October = 10, // 0x0000000A
      November = 11, // 0x0000000B
      December = 12, // 0x0000000C
    }
  }
}
