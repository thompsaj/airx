// Decompiled with JetBrains decompiler
// Type: AirXDLL.Inputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Collections.Generic;

namespace AirXDLL
{
  public class Inputs
  {
    private int _modelID;
    private string _city;
    private string _state;
    private double _elevation;
    private double _freshflow;
    private double _freshsupplyflow;
    private double _exhaustreturnflow;
    private double _fanPower;
    private double _wheels;
    private double _outflow;
    private double _outdbsum;
    private double _outwbsum;
    private double _indbsum;
    private double _inwbsum;
    private double _outdbwin;
    private double _outwbwin;
    private double _indbwin;
    private double _inwbwin;
    private double _sspress;
    private double _espress;
    private double _faneff;
    private double _purgeangle;
    private string _model;
    private string _ssprespt;
    private string _esprespt;
    private string _configFileLocation;
    private bool _sensible;
    private int _perecentRatedRPM;
    private double _controltemp;
    private int _optFrost;
    private bool _BedeSpecial;
    private bool _ExpandedVersion;
    private double _RTUcapacity;
    private double _RTUeer;
    private bool _hasPurge;
    private double _gap;
    private double _sealFactor;
    private double _targetEATR;
    private List<AirXDLL.BinData> _binData;
    private List<AirXDLL.HourData> _hourData;
    private int _TotalHours;
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
    private int[] _monthlyHours;
    private bool _period1;
    private bool _period2;
    private bool _period3;
    private bool _period4;
    private bool _period5;
    private bool _period6;
    private int _daysindex;
    private bool _tod;
    private double _tod0;
    private double _tod1;
    private double _tod2;
    private double _tod3;
    private double _tod4;
    private double _tod5;
    private int _heatingindex;
    private double _heatingCOP;
    private double _heatingefficiency;
    private double _heatingEER;
    private double _coolingEER;
    private double _wintereleccost;
    private double _fuelcost;
    private double _summereleccost;
    private double _summerdemandcost;
    private List<double> _temp;
    private int _numRows;
    private bool _metric;
    private double _OACF;
    private double _EATR;
    private double _Capacity;
    private EffectivenessValues _effValues;
    private Values _neededValues;
    private double _freshSCFM;
    private double _exhaustSCFM;
    private double _outdoorflow;
    private double _newRPM;

    public Inputs()
    {
      this._monthlyHours = new int[12];
    }

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

    public double FreshSupplyFlow
    {
      get
      {
        return this._freshsupplyflow;
      }
      set
      {
        this._freshsupplyflow = value;
      }
    }

    public double ExhaustReturnFlow
    {
      get
      {
        return this._exhaustreturnflow;
      }
      set
      {
        this._exhaustreturnflow = value;
      }
    }

    public double FanPower
    {
      get
      {
        return this._fanPower;
      }
      set
      {
        this._fanPower = value;
      }
    }

    /// <summary>'number of wheels in a unit</summary>
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

    /// <summary>vthe indoor dry bulb temperature at summer design conditions, F</summary>
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
    public int ModelID
    {
      get
      {
        return this._modelID;
      }
      set
      {
        this._modelID = value;
      }
    }

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

    /// <summary>the exhaust air transfer ratio, percent</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double EATR
    {
      get
      {
        return this._EATR;
      }
      set
      {
        this._EATR = value;
      }
    }

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

    /// <summary>the outdoor air correction factor</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OACF
    {
      get
      {
        return this._OACF;
      }
      set
      {
        this._OACF = value;
      }
    }

    public double Capacity
    {
      get
      {
        return this._Capacity;
      }
      set
      {
        this._Capacity = value;
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

    public int OptFrost
    {
      get
      {
        return this._optFrost;
      }
      set
      {
        this._optFrost = value;
      }
    }

    public bool BedeSpecial
    {
      get
      {
        return this._BedeSpecial;
      }
      set
      {
        this._BedeSpecial = value;
      }
    }

    public bool ExpandedVersion
    {
      get
      {
        return this._ExpandedVersion;
      }
      set
      {
        this._ExpandedVersion = value;
      }
    }

    /// <summary>'capacity of associated A/C, Btu/hr</summary>
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

    /// <summary>'EER of associated A/C, Btu/Wh</summary>
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

    public bool HasPurge
    {
      get
      {
        return this._hasPurge;
      }
      set
      {
        this._hasPurge = value;
      }
    }

    public double Gap
    {
      get
      {
        return this._gap;
      }
      set
      {
        this._gap = value;
      }
    }

    public double SealFactor
    {
      get
      {
        return this._sealFactor;
      }
      set
      {
        this._sealFactor = value;
      }
    }

    public int PercentRatedRPM
    {
      get
      {
        return this._perecentRatedRPM;
      }
      set
      {
        this._perecentRatedRPM = value;
      }
    }

    public List<AirXDLL.BinData> BinData
    {
      get
      {
        return this._binData;
      }
      set
      {
        this._binData = value;
      }
    }

    public List<AirXDLL.HourData> HourData
    {
      get
      {
        return this._hourData;
      }
      set
      {
        this._hourData = value;
      }
    }

    public int TotalHours
    {
      get
      {
        return this._TotalHours;
      }
      set
      {
        this._TotalHours = value;
      }
    }

    public int[] MonthlyHours
    {
      get
      {
        return this._monthlyHours;
      }
      set
      {
        this._monthlyHours = value;
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

    /// <summary>'TOD pricing, 0 = No, 1 = Yes</summary>
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

    /// <summary>'0 = fossil fuel, 1 = heat pump, 2 = resistance</summary>
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

    /// <summary>'COP of heat pump heating, kW-h/kW-e</summary>
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

    /// <summary>'efficiency of a fuel-based heating system, %</summary>
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

    public double HeatingEER
    {
      get
      {
        return this._heatingEER;
      }
      set
      {
        this._heatingEER = value;
      }
    }

    /// <summary>'EER of A/C cooling, Btu/Whr</summary>
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

    /// <summary>'cost of fuel, $/mmBtu</summary>
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

    /// <summary>'cost of electricity during summer, $/kWhc</summary>
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

    /// <summary>'cost of incrementatl electrical dema</summary>
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

    public int NumRows
    {
      get
      {
        return this._numRows;
      }
      set
      {
        this._numRows = value;
      }
    }

    public bool Metric
    {
      get
      {
        return this._metric;
      }
      set
      {
        this._metric = value;
      }
    }

    public List<double> Temp
    {
      get
      {
        return this._temp;
      }
      set
      {
        this._temp = value;
      }
    }

    public Values NeededValues
    {
      get
      {
        return this._neededValues;
      }
      set
      {
        this._neededValues = value;
      }
    }

    public EffectivenessValues EffValues
    {
      get
      {
        return this._effValues;
      }
      set
      {
        this._effValues = value;
      }
    }

    public double FreshSCFM
    {
      get
      {
        return this._freshSCFM;
      }
      set
      {
        this._freshSCFM = value;
      }
    }

    public double ExhaustSCFM
    {
      get
      {
        return this._exhaustSCFM;
      }
      set
      {
        this._exhaustSCFM = value;
      }
    }

    public double OutdoorFlow
    {
      get
      {
        return this._outdoorflow;
      }
      set
      {
        this._outdoorflow = value;
      }
    }

    public double NewRPM
    {
      get
      {
        return this._newRPM;
      }
      set
      {
        this._newRPM = value;
      }
    }
  }
}
