// Decompiled with JetBrains decompiler
// Type: AirXDLL.ErrFlags
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

namespace AirXDLL
{
  public class ErrFlags
  {
    public string ESDPText;
    public string SSDPText;
    public string PurgeDPText;
    public string PreHeatText;
    public string ConditionsText;
    public string rhIssueText;
    public string LocationText;
    public string BadDataText;
    public string FlowRangesText;
    public string PlenumSpecText;
    public string PurgeAngleText;
    public string EATRErrorText;
    public string CoolingEERText;
    public string HeatingEffText;
    public string HeatingCOPText;
    public string FanEFFText;
    public string CityStateText;
    public string HourlyDataErrorText;
    public string FrostText;
    private int _errType;
    private string _errText;

    public ErrFlags()
    {
      this.ESDPText = "Exhaust side pressure drop exceeds allowed";
      this.SSDPText = "supply side pressure drop exceeds allowed";
      this.PurgeDPText = "purge pressure drop is in wrong direction";
      this.PreHeatText = "preheat required but not requested";
      this.ConditionsText = "problem with weather conditions";
      this.rhIssueText = "relative humidity calculates out of range";
      this.LocationText = "location is not found in list of cities and states";
      this.BadDataText = "Data Problem";
      this.FlowRangesText = "flow is out of range for the selected cassette";
      this.PlenumSpecText = "error in specifying the plenums or pressures";
      this.PurgeAngleText = "purge angle is out of range of 0 to 15";
      this.EATRErrorText = "EATR out of range of 0.5 to 15";
      this.CoolingEERText = "cooling eer must be between 1 and 20";
      this.HeatingEffText = "heating eff must be between 25 and 100";
      this.HeatingCOPText = "heating COP must be between 0.3 and 7.5";
      this.FanEFFText = "fan eff must be between 20 and 90";
      this.CityStateText = "City and State are required inputs";
      this.HourlyDataErrorText = "Error getting hourly data";
      this.FrostText = "Frost will occur. Preheat required.";
    }

    public int ErrType
    {
      get
      {
        return this._errType;
      }
      set
      {
        this._errType = value;
      }
    }

    public string ErrText
    {
      get
      {
        return this._errText;
      }
      set
      {
        this._errText = value;
      }
    }

    public enum Errs
    {
      ESDP = 1,
      SSDP = 2,
      PurgeDP = 3,
      Preheat = 4,
      Conditions = 5,
      rhissue = 6,
      Location = 7,
      BadData = 8,
      FlowRanges = 9,
      PlenumSpec = 10, // 0x0000000A
      PurgeAngle = 11, // 0x0000000B
      EATRError = 12, // 0x0000000C
      CoolingEER = 13, // 0x0000000D
      HeatingEff = 14, // 0x0000000E
      HeatingCOP = 15, // 0x0000000F
      FanEff = 16, // 0x00000010
      CityState = 17, // 0x00000011
      HourData = 18, // 0x00000012
      Frost = 19, // 0x00000013
    }
  }
}
