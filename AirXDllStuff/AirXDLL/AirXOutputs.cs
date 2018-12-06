// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXOutputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class AirXOutputs
  {
    private double _supplyflow;
    private double _returnflow;
    private double _outdoorflow;
    private double _exhaustflow;
    private double _eatr;
    private double _oacf;
    private double _suppressdrop;
    private double _exhpressdrop;
    private double _fanPower;
    private double _supdbsum;
    private double _supwbsum;
    private double _supdbwin;
    private double _supwbwin;
    private double _oasensiblesum;
    private double _oalatentsum;
    private double _oatotalsum;
    private double _oarecoveredsum;
    private double _oanetsum;
    private double _oasensiblewin;
    private double _oalatentwin;
    private double _oatotalwin;
    private double _oarecoveredwin;
    private double _oanetwin;
    private double _preheattemp;
    private double _preheatcapacity;
    private double _preheater;
    private double _measeffsummer;
    private double _neteffsummer;
    private double _measeffwin;
    private double _neteffwinter;
    private double _erveer;
    private double _PercentOALoad;
    private double _CombinedEER;
    private double _latenteff;
    private double _senseff;
    private double _winterlatenteff;
    private double _wintersenseff;
    private double _suphrsum;
    private double _supenthsum;
    private double _supRHsum;
    private double _suphrwin;
    private double _supenthwin;
    private double _supRHwin;
    private double _outdoorpressure;
    private double _supplypressure;
    private double _exhaustpressure;
    private double _returnpressure;
    private double _oarecoveredsensiblesum;
    private double _oarecoveredlatentsum;
    private double _oarecoveredsensiblewin;
    private double _oarecoveredlatentwin;
    private double _recsenssum;
    private double _reclatsum;
    private double _recsenswin;
    private double _reclatwin;
    private double _allowedDP;
    private double _tFrost;
    private double _capacity;
    private double _dbsupSnet;
    private double _hrsupSnet;
    private double _enthsupSnet;
    private double _rhsupSnet;
    private double _wbsupSnet;
    private double _DbsupwNet;
    private double _HrsupwNet;
    private double _EnthsupwNet;
    private double _WBsupwNet;
    private double _RHsupwNet;
    private double _TwbEstw;
    private double _TwbEsts;
    private double _TempWIn;
    private double _EnthWIn;
    private double _CLGSav;
    private double _HTGSav;
    private double _ESSM;
    private double _ELSM;
    private double _ETSM;
    private double _ESSN;
    private double _ELSN;
    private double _ETSN;
    private double _ESWM;
    private double _ELWM;
    private double _ETWM;
    private double _ESWN;
    private double _ELWN;
    private double _ETWN;
    private double _ExhDBSum;
    private double _HrexhsNet;
    private double _EnthexhsNet;
    private double _ExhWBSum;
    private double _RhexhsNet;
    private double _ExhDBWin;
    private double _HrexhwNet;
    private double _EnthexhwNet;
    private double _ExhWBWin;
    private double _RhexhwNet;
    private double _AverageSupplyFlow;
    private double _AverageExhaustFlow;
    private double _purgeAngle;

    [DebuggerNonUserCode]
    public AirXOutputs()
    {
    }

    /// <summary>the exhaust air transfer ratio, percent</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double EATR
    {
      get
      {
        return this._eatr;
      }
      set
      {
        this._eatr = value;
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
        return this._oacf;
      }
      set
      {
        this._oacf = value;
      }
    }

    /// <summary>
    /// the latent effectiveness of the wheel at the flows used, which is applied to humidity ratios and mass flows, summer
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double LatentEff
    {
      get
      {
        return this._latenteff;
      }
      set
      {
        this._latenteff = value;
      }
    }

    /// <summary>the sensible effectiveness of the wheel at the flows used, summer</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SensEff
    {
      get
      {
        return this._senseff;
      }
      set
      {
        this._senseff = value;
      }
    }

    /// <summary>
    /// the latent effectiveness of the wheel at the flows used, which is applied to humidity ratios and mass flows, winter
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double WinterLatentEff
    {
      get
      {
        return this._winterlatenteff;
      }
      set
      {
        this._winterlatenteff = value;
      }
    }

    /// <summary>the sensible effectiveness of the wheel at the flows used, winter</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double WinterSensEff
    {
      get
      {
        return this._wintersenseff;
      }
      set
      {
        this._wintersenseff = value;
      }
    }

    /// <summary>
    /// the summer supply air dry bulb temperature, F, including the effect of exhaust air leakage
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupDBSum
    {
      get
      {
        return this._supdbsum;
      }
      set
      {
        this._supdbsum = value;
      }
    }

    /// <summary>
    /// the summer supply air wet bulb temperature, F, including the effect of exhaust air leakage
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupWBSum
    {
      get
      {
        return this._supwbsum;
      }
      set
      {
        this._supwbsum = value;
      }
    }

    /// <summary>the summer supply air humidity ratio gr/lb</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupHRSum
    {
      get
      {
        return this._suphrsum;
      }
      set
      {
        this._suphrsum = value;
      }
    }

    /// <summary>the summer supply air enthalpy Btu/lb</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupEnthSum
    {
      get
      {
        return this._supenthsum;
      }
      set
      {
        this._supenthsum = value;
      }
    }

    /// <summary>the summer supply air relative humidity %</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupRHSum
    {
      get
      {
        return this._supRHsum;
      }
      set
      {
        this._supRHsum = value;
      }
    }

    /// <summary>
    /// the winter supply air dry bulb temperature, F, including the effect of exhaust air leakage
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupDBWin
    {
      get
      {
        return this._supdbwin;
      }
      set
      {
        this._supdbwin = value;
      }
    }

    /// <summary>
    /// the winter supply air wet bulb temperature, F, including the effect of exhaust air leakage
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupWBWin
    {
      get
      {
        return this._supwbwin;
      }
      set
      {
        this._supwbwin = value;
      }
    }

    /// <summary>the winter supply air humidity ratio gr/lb</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupHRWin
    {
      get
      {
        return this._suphrwin;
      }
      set
      {
        this._suphrwin = value;
      }
    }

    /// <summary>the winter supply air enthalpy Btu/lb</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupEnthWin
    {
      get
      {
        return this._supenthwin;
      }
      set
      {
        this._supenthwin = value;
      }
    }

    /// <summary>the winter supply air relative humidity %</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupRHWin
    {
      get
      {
        return this._supRHwin;
      }
      set
      {
        this._supRHwin = value;
      }
    }

    /// <summary>the total flow out of the supply air plenum deliverd to the building, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupplyFlow
    {
      get
      {
        return this._supplyflow;
      }
      set
      {
        this._supplyflow = value;
      }
    }

    /// <summary>the total flow out into the return air plenum taken from the building, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ReturnFlow
    {
      get
      {
        return this._returnflow;
      }
      set
      {
        this._returnflow = value;
      }
    }

    /// <summary>the total flow into the outdoor air plenum, cfm</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
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

    /// <summary>
    /// the total flow out of the exhaust air plenum deliverd to the surroundings, cfm
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ExhaustFlow
    {
      get
      {
        return this._exhaustflow;
      }
      set
      {
        this._exhaustflow = value;
      }
    }

    /// <summary>the total supply side pressure drop, in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupPressDrop
    {
      get
      {
        return this._suppressdrop;
      }
      set
      {
        this._suppressdrop = value;
      }
    }

    /// <summary>the total exhaust side pressure drop, in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ExhPressDrop
    {
      get
      {
        return this._exhpressdrop;
      }
      set
      {
        this._exhpressdrop = value;
      }
    }

    /// <summary>total fan electrical power, kW</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public object FanPower
    {
      get
      {
        return (object) this._fanPower;
      }
      set
      {
        this._fanPower = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(value);
      }
    }

    public double TotalEffSummer
    {
      get
      {
        return this._measeffsummer;
      }
      set
      {
        this._measeffsummer = value;
      }
    }

    public double NetEffSummer
    {
      get
      {
        return this._neteffsummer;
      }
      set
      {
        this._neteffsummer = value;
      }
    }

    /// <summary>total measured effectiveness, winter</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TotalEffWinter
    {
      get
      {
        return this._measeffwin;
      }
      set
      {
        this._measeffwin = value;
      }
    }

    /// <summary>total net effectiveness, winter</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double NetEffWinter
    {
      get
      {
        return this._neteffwinter;
      }
      set
      {
        this._neteffwinter = value;
      }
    }

    /// <summary>static pressure in the outside air plenum in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OutdoorPressure
    {
      get
      {
        return this._outdoorpressure;
      }
      set
      {
        this._outdoorpressure = value;
      }
    }

    /// <summary>static pressure in the supply air plenum in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double SupplyPressure
    {
      get
      {
        return this._supplypressure;
      }
      set
      {
        this._supplypressure = value;
      }
    }

    /// <summary>static pressure in the exhaust air plenum in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ExhaustPressure
    {
      get
      {
        return this._exhaustpressure;
      }
      set
      {
        this._exhaustpressure = value;
      }
    }

    /// <summary>static pressure in the return air plenum in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ReturnPressure
    {
      get
      {
        return this._returnpressure;
      }
      set
      {
        this._returnpressure = value;
      }
    }

    /// <summary>'calculated EER of ERV</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double ErvEER
    {
      get
      {
        return this._erveer;
      }
      set
      {
        this._erveer = value;
      }
    }

    /// <summary>'percent of total load due to OA</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PercentOALoad
    {
      get
      {
        return this._PercentOALoad;
      }
      set
      {
        this._PercentOALoad = value;
      }
    }

    /// <summary>'combined EER of ERV and AC</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double CombinedEER
    {
      get
      {
        return this._CombinedEER;
      }
      set
      {
        this._CombinedEER = value;
      }
    }

    /// <summary>
    /// the sensible load on the conditioned space at summer design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OASensSum
    {
      get
      {
        return this._oasensiblesum;
      }
      set
      {
        this._oasensiblesum = value;
      }
    }

    /// <summary>
    /// the latent load on the conditioned space at summer design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OALatentSum
    {
      get
      {
        return this._oalatentsum;
      }
      set
      {
        this._oalatentsum = value;
      }
    }

    /// <summary>the total load on the conditioned space at summer design conditions, Btu/hr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OATotalSum
    {
      get
      {
        return this._oatotalsum;
      }
      set
      {
        this._oatotalsum = value;
      }
    }

    /// <summary>
    /// the ventilation load which is removed by the wheel at summer design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredSum
    {
      get
      {
        return this._oarecoveredsum;
      }
      set
      {
        this._oarecoveredsum = value;
      }
    }

    /// <summary>
    /// the ventilation sensible load which is removed by the wheel at summer design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredSensibleSum
    {
      get
      {
        return this._oarecoveredsensiblesum;
      }
      set
      {
        this._oarecoveredsensiblesum = value;
      }
    }

    /// <summary>
    /// the ventilation latent load which is removed by the wheel at summer design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredLatentSum
    {
      get
      {
        return this._oarecoveredlatentsum;
      }
      set
      {
        this._oarecoveredlatentsum = value;
      }
    }

    /// <summary>
    /// the residual ventilation load delivered to the conditioned space at summer design conditions, Btu/hrv
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OANetSum
    {
      get
      {
        return this._oanetsum;
      }
      set
      {
        this._oanetsum = value;
      }
    }

    /// <summary>
    /// the sensible load on the conditioned space at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OASensibleWin
    {
      get
      {
        return this._oasensiblewin;
      }
      set
      {
        this._oasensiblewin = value;
      }
    }

    /// <summary>
    /// the latent load on the conditioned space at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OALatentWin
    {
      get
      {
        return this._oalatentwin;
      }
      set
      {
        this._oalatentwin = value;
      }
    }

    /// <summary>the total load on the conditioned space at winter design conditions, Btu/hr</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OATotalWin
    {
      get
      {
        return this._oatotalwin;
      }
      set
      {
        this._oatotalwin = value;
      }
    }

    /// <summary>
    /// the ventilation load which is removed by the wheel at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredWin
    {
      get
      {
        return this._oarecoveredwin;
      }
      set
      {
        this._oarecoveredwin = value;
      }
    }

    /// <summary>
    /// the ventilation sensible load which is removed by the wheel at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredSensibleWin
    {
      get
      {
        return this._oarecoveredsensiblewin;
      }
      set
      {
        this._oarecoveredsensiblewin = value;
      }
    }

    /// <summary>
    /// the ventilation latent load which is removed by the wheel at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OARecoveredLatentWin
    {
      get
      {
        return this._oarecoveredlatentwin;
      }
      set
      {
        this._oarecoveredlatentwin = value;
      }
    }

    /// <summary>
    /// 	the residual ventilation load delivered to the conditioned space at winter design conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double OANetWin
    {
      get
      {
        return this._oanetwin;
      }
      set
      {
        this._oanetwin = value;
      }
    }

    /// <summary>
    /// the control temperature for the preheater, i.e., the maximum inlet temperature, F
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PreHeatTemp
    {
      get
      {
        return this._preheattemp;
      }
      set
      {
        this._preheattemp = value;
      }
    }

    /// <summary>the maximum temperature rise of the preheater, F</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PreHeatCapacity
    {
      get
      {
        return this._preheatcapacity;
      }
      set
      {
        this._preheatcapacity = value;
      }
    }

    /// <summary>
    /// the actual installed capacity of the preheater for the given conditions, Btu/hr
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PreHeater
    {
      get
      {
        return this._preheater;
      }
      set
      {
        this._preheater = value;
      }
    }

    /// <summary>Maximum pressure loss through the wheel in. wc</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double AllowedDP
    {
      get
      {
        return this._allowedDP;
      }
      set
      {
        this._allowedDP = value;
      }
    }

    /// <summary>
    /// Outside air temperature at which frost formation within the wheel is possible °F
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double TFrost
    {
      get
      {
        return this._tFrost;
      }
      set
      {
        this._tFrost = value;
      }
    }

    /// <summary>Cooling energy saved at the summer design condition Tons</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double CLGSav
    {
      get
      {
        return this._CLGSav;
      }
      set
      {
        this._CLGSav = value;
      }
    }

    /// <summary>Heating energy saved at the winter design conditon Btuh</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double HTGSav
    {
      get
      {
        return this._HTGSav;
      }
      set
      {
        this._HTGSav = value;
      }
    }

    public double ExhDBSum
    {
      get
      {
        return this._ExhDBSum;
      }
      set
      {
        this._ExhDBSum = value;
      }
    }

    public double ExhWBSum
    {
      get
      {
        return this._ExhWBSum;
      }
      set
      {
        this._ExhWBSum = value;
      }
    }

    public double ExhDBWin
    {
      get
      {
        return this._ExhDBWin;
      }
      set
      {
        this._ExhDBWin = value;
      }
    }

    public double ExhWBWin
    {
      get
      {
        return this._ExhWBWin;
      }
      set
      {
        this._ExhWBWin = value;
      }
    }

    /// <summary>
    /// Purge angle used in the calculations. Will be a calculated value if AirXDLL was asked to calculate it.
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PurgeAngle
    {
      get
      {
        return this._purgeAngle;
      }
      set
      {
        this._purgeAngle = value;
      }
    }
  }
}
