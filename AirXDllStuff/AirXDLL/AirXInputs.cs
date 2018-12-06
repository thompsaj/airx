// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXInputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

namespace AirXDLL
{
  public class AirXInputs
  {
    private string _configFileLocation;
    private string _dbLocation;
    private string _model;
    private double _freshflow;
    private double _outflow;
    private double _wheels;
    private double _sspress;
    private double _espress;
    private string _ssprespt;
    private string _esprespt;
    private double _faneff;
    private int _frostControl;
    private double _purgeangle;
    private double _RTUcapacity;
    private double _RTUeer;
    private double _indbsum;
    private double _inwbsum;
    private double _outdbsum;
    private double _outwbsum;
    private double _indbwin;
    private double _inwbwin;
    private double _outdbwin;
    private double _outwbwin;
    private string _region;
    private string _fileName;
    private string _city;
    private string _state;
    private double _elevation;
    private int _heatingindex;
    private double _heatingCOP;
    private double _heatingefficiency;
    private double _coolingEER;
    private double _wintereleccost;
    private double _fuelcost;
    private double _summereleccost;
    private double _summerdemandcost;
    private bool _tod;
    private double _tod0;
    private double _tod1;
    private double _tod2;
    private double _tod3;
    private double _tod4;
    private double _tod5;
    private bool _january;
    private bool _feb;
    private bool _march;
    private bool _apr;
    private bool _may;
    private bool _june;
    private bool _july;
    private bool _aug;
    private bool _sept;
    private bool _oct;
    private bool _nov;
    private bool _dec;
    private string _months;
    private bool _period1;
    private bool _period2;
    private bool _period3;
    private bool _period4;
    private bool _period5;
    private bool _period6;
    private int _daysindex;
    private string _Monday;
    private string _Tues;
    private string _Wed;
    private string _Thurs;
    private string _Fri;
    private string _Sat;
    private string _Sun;
    private double _controltemp;
    private double _PreHeatCap;
    private double _targetEATR;
    private bool _calcPurge;
    private bool _sensible;

    public AirXInputs()
    {
      this._freshflow = double.NaN;
      this._outflow = double.NaN;
      this._wheels = double.NaN;
      this._sspress = double.NaN;
      this._espress = double.NaN;
      this._faneff = double.NaN;
      this._purgeangle = double.NaN;
      this._RTUcapacity = double.NaN;
      this._RTUeer = double.NaN;
      this._indbsum = double.NaN;
      this._inwbsum = double.NaN;
      this._outdbsum = double.NaN;
      this._outwbsum = double.NaN;
      this._indbwin = double.NaN;
      this._inwbwin = double.NaN;
      this._outdbwin = double.NaN;
      this._outwbwin = double.NaN;
      this._elevation = double.NaN;
      this._heatingCOP = double.NaN;
      this._heatingefficiency = double.NaN;
      this._coolingEER = double.NaN;
      this._wintereleccost = double.NaN;
      this._fuelcost = double.NaN;
      this._summereleccost = double.NaN;
      this._summerdemandcost = double.NaN;
      this._tod0 = double.NaN;
      this._tod1 = double.NaN;
      this._tod2 = double.NaN;
      this._tod3 = double.NaN;
      this._tod4 = double.NaN;
      this._tod5 = double.NaN;
      this._controltemp = double.NaN;
      this._PreHeatCap = double.NaN;
      this._targetEATR = double.NaN;
      this._sensible = false;
    }

    public string DBLocation
    {
      get
      {
        return this._dbLocation;
      }
      set
      {
        this._dbLocation = value;
      }
    }

    public string Region
    {
      get
      {
        return this._region;
      }
      set
      {
        this._region = value;
      }
    }

    public string FileName
    {
      get
      {
        return this._fileName;
      }
      set
      {
        this._fileName = value;
      }
    }

    /// <summary>City location who's weather data will be used in the bin energy analysis.</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string City
    {
      get
      {
        return this._city;
      }
      set
      {
        this._city = value;
      }
    }

    /// <summary>State location who's weather data will be used in the bin energy analysis.</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string State
    {
      get
      {
        return this._state;
      }
      set
      {
        this._state = value;
      }
    }

    /// <summary>geographic elevation above sea level, ft.</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double Elevation
    {
      get
      {
        return this._elevation;
      }
      set
      {
        this._elevation = value;
      }
    }

    /// <summary>desired fresh air to be brought into the conditoned space, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FreshFlow
    {
      get
      {
        return this._freshflow;
      }
      set
      {
        this._freshflow = value;
      }
    }

    /// <summary>number of wheels in a unit</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double Wheels
    {
      get
      {
        return this._wheels;
      }
      set
      {
        this._wheels = value;
      }
    }

    /// <summary>desired return air actually removed from the conditioned space, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutFlow
    {
      get
      {
        return this._outflow;
      }
      set
      {
        this._outflow = value;
      }
    }

    /// <summary>the outdoor dry bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutDBSum
    {
      get
      {
        return this._outdbsum;
      }
      set
      {
        this._outdbsum = value;
      }
    }

    /// <summary>the outdoor wet bulb temperature at summer design conditons, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutWBSum
    {
      get
      {
        return this._outwbsum;
      }
      set
      {
        this._outwbsum = value;
      }
    }

    /// <summary>the indoor dry bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InDBSum
    {
      get
      {
        return this._indbsum;
      }
      set
      {
        this._indbsum = value;
      }
    }

    /// <summary>the indoor wet bulb temperature at summer design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InWBSum
    {
      get
      {
        return this._inwbsum;
      }
      set
      {
        this._inwbsum = value;
      }
    }

    /// <summary>the outdoor dry bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutDBWin
    {
      get
      {
        return this._outdbwin;
      }
      set
      {
        this._outdbwin = value;
      }
    }

    /// <summary>the outdoor wet bulb temperature at winter design conditons, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutWBWin
    {
      get
      {
        return this._outwbwin;
      }
      set
      {
        this._outwbwin = value;
      }
    }

    /// <summary>the indoor dry bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InDBWin
    {
      get
      {
        return this._indbwin;
      }
      set
      {
        this._indbwin = value;
      }
    }

    /// <summary>the indoor wet bulb temperature at winter design conditions, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double InWBWin
    {
      get
      {
        return this._inwbwin;
      }
      set
      {
        this._inwbwin = value;
      }
    }

    /// <summary>the supply side plenum pressure, for the plenum specified in "ssprespt"</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SSPress
    {
      get
      {
        return this._sspress;
      }
      set
      {
        this._sspress = value;
      }
    }

    /// <summary>the exhaust side plenum pressure, for the plenum specified in "esprespt"</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ESPress
    {
      get
      {
        return this._espress;
      }
      set
      {
        this._espress = value;
      }
    }

    /// <summary>the fan total efficiency including motor efficiency, in percent</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FanEff
    {
      get
      {
        return this._faneff;
      }
      set
      {
        this._faneff = value;
      }
    }

    /// <summary>the purge angle if channel matrix is used, from 0 to 15 degrees</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PurgeAngle
    {
      get
      {
        return this._purgeangle;
      }
      set
      {
        this._purgeangle = value;
      }
    }

    /// <summary>the model of the cassette as used by Airxchange</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string Model
    {
      get
      {
        return this._model;
      }
      set
      {
        this._model = value;
      }
    }

    /// <summary>
    /// the supply side plenum for which the static pressure is given.  "sa" for the supply plenum.  "oa" for the outdoor plenum
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string SSPresT
    {
      get
      {
        return this._ssprespt;
      }
      set
      {
        this._ssprespt = value;
      }
    }

    /// <summary>
    /// the exhaust side plenum for which the static pressure is given.  "ra" for thereturn plenum.  "ea" for the exhaust plenum
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string ESPresT
    {
      get
      {
        return this._esprespt;
      }
      set
      {
        this._esprespt = value;
      }
    }

    /// <summary>The full path to the folder that contains the AirXDLL configuration files.</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string ConfigFileLocation
    {
      get
      {
        return this._configFileLocation;
      }
      set
      {
        this._configFileLocation = value;
      }
    }

    /// <summary>Exhaust Air Transfer Ratio allowed when AirXDLL calculates the purge angle.</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TargetEATR
    {
      get
      {
        return this._targetEATR;
      }
      set
      {
        this._targetEATR = value;
      }
    }

    /// <summary>Frost control temperature °F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ControlTemp
    {
      get
      {
        return this._controltemp;
      }
      set
      {
        this._controltemp = value;
      }
    }

    /// <summary>Preheater capacity expressed as a temperature rise °F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PreheatCap
    {
      get
      {
        return this._PreHeatCap;
      }
      set
      {
        this._PreHeatCap = value;
      }
    }

    /// <summary>Frost COntrol On/Off  0 = Off, 1 = On</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public int FrostControl
    {
      get
      {
        return this._frostControl;
      }
      set
      {
        this._frostControl = value;
      }
    }

    /// <summary>capacity of associated A/C, Btu/hr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RTUcapacity
    {
      get
      {
        return this._RTUcapacity;
      }
      set
      {
        this._RTUcapacity = value;
      }
    }

    /// <summary>EER of associated A/C, Btu/Wh</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RTUeer
    {
      get
      {
        return this._RTUeer;
      }
      set
      {
        this._RTUeer = value;
      }
    }

    public string Months
    {
      get
      {
        return this._months;
      }
      set
      {
        this._months = value;
      }
    }

    public bool January
    {
      get
      {
        return this._january;
      }
      set
      {
        this._january = value;
      }
    }

    public bool February
    {
      get
      {
        return this._feb;
      }
      set
      {
        this._feb = value;
      }
    }

    public bool March
    {
      get
      {
        return this._march;
      }
      set
      {
        this._march = value;
      }
    }

    public bool April
    {
      get
      {
        return this._apr;
      }
      set
      {
        this._apr = value;
      }
    }

    public bool May
    {
      get
      {
        return this._may;
      }
      set
      {
        this._may = value;
      }
    }

    public bool June
    {
      get
      {
        return this._june;
      }
      set
      {
        this._june = value;
      }
    }

    public bool July
    {
      get
      {
        return this._july;
      }
      set
      {
        this._july = value;
      }
    }

    public bool August
    {
      get
      {
        return this._aug;
      }
      set
      {
        this._aug = value;
      }
    }

    public bool September
    {
      get
      {
        return this._sept;
      }
      set
      {
        this._sept = value;
      }
    }

    public bool October
    {
      get
      {
        return this._oct;
      }
      set
      {
        this._oct = value;
      }
    }

    public bool November
    {
      get
      {
        return this._nov;
      }
      set
      {
        this._nov = value;
      }
    }

    public bool December
    {
      get
      {
        return this._dec;
      }
      set
      {
        this._dec = value;
      }
    }

    public string Sunday
    {
      get
      {
        return this._Sun;
      }
      set
      {
        this._Sun = value;
      }
    }

    public string Monday
    {
      get
      {
        return this._Monday;
      }
      set
      {
        this._Monday = value;
      }
    }

    public string Tuesday
    {
      get
      {
        return this._Tues;
      }
      set
      {
        this._Tues = value;
      }
    }

    public string Wednessday
    {
      get
      {
        return this._Wed;
      }
      set
      {
        this._Wed = value;
      }
    }

    public string Thursday
    {
      get
      {
        return this._Thurs;
      }
      set
      {
        this._Thurs = value;
      }
    }

    public string Friday
    {
      get
      {
        return this._Fri;
      }
      set
      {
        this._Fri = value;
      }
    }

    public string Saturday
    {
      get
      {
        return this._Sat;
      }
      set
      {
        this._Sat = value;
      }
    }

    /// <summary>midnight to 4am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period1
    {
      get
      {
        return this._period1;
      }
      set
      {
        this._period1 = value;
      }
    }

    /// <summary>4am to 8am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period2
    {
      get
      {
        return this._period2;
      }
      set
      {
        this._period2 = value;
      }
    }

    /// <summary>8am to noon</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period3
    {
      get
      {
        return this._period3;
      }
      set
      {
        this._period3 = value;
      }
    }

    /// <summary>noon to 4pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period4
    {
      get
      {
        return this._period4;
      }
      set
      {
        this._period4 = value;
      }
    }

    /// <summary>4pm to 8pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period5
    {
      get
      {
        return this._period5;
      }
      set
      {
        this._period5 = value;
      }
    }

    /// <summary>8pm to midnight</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool Period6
    {
      get
      {
        return this._period6;
      }
      set
      {
        this._period6 = value;
      }
    }

    /// <summary>0 = 5 days, 1 = 6 days, 2 = 7 days</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public int DaysIndex
    {
      get
      {
        return this._daysindex;
      }
      set
      {
        this._daysindex = value;
      }
    }

    /// <summary>Use Time of Day pricing, 0 = No, 1 = Yes</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool TOD
    {
      get
      {
        return this._tod;
      }
      set
      {
        this._tod = value;
      }
    }

    /// <summary>cost of electricity in period 0, m - 4am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD0
    {
      get
      {
        return this._tod0;
      }
      set
      {
        this._tod0 = value;
      }
    }

    /// <summary>cost of electricity in period 1, 4am - 8am</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD1
    {
      get
      {
        return this._tod1;
      }
      set
      {
        this._tod1 = value;
      }
    }

    /// <summary>cost of electricity in period 2, 8am - n</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD2
    {
      get
      {
        return this._tod2;
      }
      set
      {
        this._tod2 = value;
      }
    }

    /// <summary>cost of electricity in period 3, n - 4pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD3
    {
      get
      {
        return this._tod3;
      }
      set
      {
        this._tod3 = value;
      }
    }

    /// <summary>cost of electricity in period 4, 4pm - 8pm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD4
    {
      get
      {
        return this._tod4;
      }
      set
      {
        this._tod4 = value;
      }
    }

    /// <summary>cost of electricity in period 5, 8pm - m</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TOD5
    {
      get
      {
        return this._tod5;
      }
      set
      {
        this._tod5 = value;
      }
    }

    /// <summary>0 = fossil fuel, 1 = heat pump, 2 = resistance</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public int HeatingIndex
    {
      get
      {
        return this._heatingindex;
      }
      set
      {
        this._heatingindex = value;
      }
    }

    /// <summary>COP of heat pump heating, kW-h/kW-e</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double HeatingCOP
    {
      get
      {
        return this._heatingCOP;
      }
      set
      {
        this._heatingCOP = value;
      }
    }

    /// <summary>efficiency of a fuel-based heating system, %</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double HeatingEfficiency
    {
      get
      {
        return this._heatingefficiency;
      }
      set
      {
        this._heatingefficiency = value;
      }
    }

    /// <summary>EER of A/C cooling, Btu/Whr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double CoolingEER
    {
      get
      {
        return this._coolingEER;
      }
      set
      {
        this._coolingEER = value;
      }
    }

    /// <summary>'cost of electricity during winter, $/kWh</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double WinterElecCost
    {
      get
      {
        return this._wintereleccost;
      }
      set
      {
        this._wintereleccost = value;
      }
    }

    /// <summary>cost of fuel, $/mmBtu</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FuelCost
    {
      get
      {
        return this._fuelcost;
      }
      set
      {
        this._fuelcost = value;
      }
    }

    /// <summary>cost of electricity during summer, $/kWhc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SummerElecCost
    {
      get
      {
        return this._summereleccost;
      }
      set
      {
        this._summereleccost = value;
      }
    }

    /// <summary>cost of incrementatl electrical dema</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SummerDemandCost
    {
      get
      {
        return this._summerdemandcost;
      }
      set
      {
        this._summerdemandcost = value;
      }
    }

    /// <summary>
    /// Indicates if AirXDLL should calculate the purge angle using the TargetEATR supplied.
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public bool CalcPurge
    {
      get
      {
        return this._calcPurge;
      }
      set
      {
        this._calcPurge = value;
      }
    }

    public bool Sensible
    {
      get
      {
        return this._sensible;
      }
      set
      {
        this._sensible = value;
      }
    }

    public enum Days
    {
      Days5,
      Days6,
      Days7,
    }

    public enum HeatingIndexValues
    {
      FossilFuel,
      HeatPump,
      Resistance,
    }

    public enum TODPricing
    {
      No,
      Yes,
    }

    public enum FrostControlType
    {
      None,
      PreHeat,
    }
  }
}
