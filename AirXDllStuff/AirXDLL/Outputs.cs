// Decompiled with JetBrains decompiler
// Type: AirXDLL.Outputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

namespace AirXDLL
{
  public class Outputs
  {
    private double _eatr;
    private double _oacf;
    private double _latenteff;
    private double _senseff;
    private double _winterlatenteff;
    private double _wintersenseff;
    private double _supdbsum;
    private double _supwbsum;
    private double _suphrsum;
    private double _supenthsum;
    private double _supdbwin;
    private double _supwbwin;
    private double _suphrwin;
    private double _supenthwin;
    private double _supplyflow;
    private double _returnflow;
    private double _outdoorflow;
    private double _exhaustflow;
    private double _suppressdrop;
    private double _exhpressdrop;
    private double _fanpower;
    private double _measeffsummer;
    private double _neteffsummer;
    private double _measeffwin;
    private double _neteffwinter;
    private double _outdoorpressure;
    private double _supplypressure;
    private double _exhaustpressure;
    private double _returnpressure;
    private bool _condEvap;
    private bool _condensation;
    private double _erveer;
    private double _PercentOALoad;
    private double _CombinedEER;
    private double _oasensiblesum;
    private double _oalatentsum;
    private double _oatotalsum;
    private double _oarecoveredsum;
    private double _oarecoveredsensiblesum;
    private double _oarecoveredlatentsum;
    private double _oanetsum;
    private double _oasensiblewin;
    private double _oalatentwin;
    private double _oatotalwin;
    private double _oarecoveredwin;
    private double _oarecoveredsensiblewin;
    private double _oarecoveredlatentwin;
    private double _oanetwin;
    private double _preheattemp;
    private double _preheatcapacity;
    private double _preheater;
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
    private double _DbexhsNet;
    private double _HrexhsNet;
    private double _EnthexhsNet;
    private double _WbexhsNet;
    private double _RhexhsNet;
    private double _DbexhwNet;
    private double _HrexhwNet;
    private double _EnthexhwNet;
    private double _WbexhwNet;
    private double _RhexhwNet;
    private double _AverageSupplyFlow;
    private double _AverageExhaustFlow;
    private bool _mfRHError;
    private Values _neededValues;
    private EffectivenessValues _effValues;
    private double _purgeAngle;
    private double _freshSCFM;
    private double _exhaustSCFM;

    public Outputs()
    {
      this._neededValues = new Values();
      this._effValues = new EffectivenessValues();
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

    /// <summary>
    /// the total fan power attributed to the flows and the wheel static pressure drops, kW
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FanPower
    {
      get
      {
        return this._fanpower;
      }
      set
      {
        this._fanpower = value;
      }
    }

    /// <summary>total measured effectiveness, summer</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double MeasEffSummer
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

    /// <summary>total net effectiveness, summer</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
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
    public double MeasEffWinter
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

    public bool CondEvap
    {
      get
      {
        return this._condEvap;
      }
      set
      {
        this._condEvap = value;
      }
    }

    public bool Condensation
    {
      get
      {
        return this._condensation;
      }
      set
      {
        this._condensation = value;
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

    /// <summary>the recovered sensible load, Btu/hr, in summer</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RecSensSum
    {
      get
      {
        return this._recsenssum;
      }
      set
      {
        this._recsenssum = value;
      }
    }

    /// <summary>the recovered latent load, Btu/hr, in summer</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RecLatSum
    {
      get
      {
        return this._reclatsum;
      }
      set
      {
        this._reclatsum = value;
      }
    }

    /// <summary>the recovered sensible load, Btu/hr, in winter</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RecSensWin
    {
      get
      {
        return this._recsenswin;
      }
      set
      {
        this._recsenswin = value;
      }
    }

    /// <summary>the recovered latent load, Btu/hr, in winter</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double RecLatWin
    {
      get
      {
        return this._reclatwin;
      }
      set
      {
        this._reclatwin = value;
      }
    }

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

    public double Capacity
    {
      get
      {
        return this._capacity;
      }
      set
      {
        this._capacity = value;
      }
    }

    public double DBSupSNet
    {
      get
      {
        return this._dbsupSnet;
      }
      set
      {
        this._dbsupSnet = value;
      }
    }

    public double EnthSupSNet
    {
      get
      {
        return this._enthsupSnet;
      }
      set
      {
        this._enthsupSnet = value;
      }
    }

    public double HRSupSNet
    {
      get
      {
        return this._hrsupSnet;
      }
      set
      {
        this._hrsupSnet = value;
      }
    }

    public double RHSupSNet
    {
      get
      {
        return this._rhsupSnet;
      }
      set
      {
        this._rhsupSnet = value;
      }
    }

    public double WBSupSNet
    {
      get
      {
        return this._wbsupSnet;
      }
      set
      {
        this._wbsupSnet = value;
      }
    }

    public double DbsupwNet
    {
      get
      {
        return this._DbsupwNet;
      }
      set
      {
        this._DbsupwNet = value;
      }
    }

    public double HRsupwNet
    {
      get
      {
        return this._HrsupwNet;
      }
      set
      {
        this._HrsupwNet = value;
      }
    }

    public double EnthsupwNet
    {
      get
      {
        return this._EnthsupwNet;
      }
      set
      {
        this._EnthsupwNet = value;
      }
    }

    public double WBsupwNet
    {
      get
      {
        return this._WBsupwNet;
      }
      set
      {
        this._WBsupwNet = value;
      }
    }

    public double RHsupwNet
    {
      get
      {
        return this._RHsupwNet;
      }
      set
      {
        this._RHsupwNet = value;
      }
    }

    public double TwbEstw
    {
      get
      {
        return this._TwbEstw;
      }
      set
      {
        this._TwbEstw = value;
      }
    }

    public double TwbEsts
    {
      get
      {
        return this._TwbEsts;
      }
      set
      {
        this._TwbEsts = value;
      }
    }

    public double TempWIn
    {
      get
      {
        return this._TempWIn;
      }
      set
      {
        this._TempWIn = value;
      }
    }

    public double EnthWIn
    {
      get
      {
        return this._EnthWIn;
      }
      set
      {
        this._EnthWIn = value;
      }
    }

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

    public double ESSM
    {
      get
      {
        return this._ESSM;
      }
      set
      {
        this._ESSM = value;
      }
    }

    public double ELSM
    {
      get
      {
        return this._ELSM;
      }
      set
      {
        this._ELSM = value;
      }
    }

    public double ESSN
    {
      get
      {
        return this._ESSN;
      }
      set
      {
        this._ESSN = value;
      }
    }

    public double ELSN
    {
      get
      {
        return this._ELSN;
      }
      set
      {
        this._ELSN = value;
      }
    }

    public double ETSN
    {
      get
      {
        return this._ETSN;
      }
      set
      {
        this._ETSN = value;
      }
    }

    public double ETSM
    {
      get
      {
        return this._ETSM;
      }
      set
      {
        this._ETSM = value;
      }
    }

    public double ESWM
    {
      get
      {
        return this._ESWM;
      }
      set
      {
        this._ESWM = value;
      }
    }

    public double ELWM
    {
      get
      {
        return this._ELWM;
      }
      set
      {
        this._ELWM = value;
      }
    }

    public double ETWM
    {
      get
      {
        return this._ETWM;
      }
      set
      {
        this._ETWM = value;
      }
    }

    public double ESWN
    {
      get
      {
        return this._ESWN;
      }
      set
      {
        this._ESWN = value;
      }
    }

    public double ELWN
    {
      get
      {
        return this._ELWN;
      }
      set
      {
        this._ELWN = value;
      }
    }

    public double ETwN
    {
      get
      {
        return this._ETWN;
      }
      set
      {
        this._ETWN = value;
      }
    }

    public double DbexhsNet
    {
      get
      {
        return this._DbexhsNet;
      }
      set
      {
        this._DbexhsNet = value;
      }
    }

    public double HrexhsNet
    {
      get
      {
        return this._HrexhsNet;
      }
      set
      {
        this._HrexhsNet = value;
      }
    }

    public double EnthexhsNet
    {
      get
      {
        return this._EnthexhsNet;
      }
      set
      {
        this._EnthexhsNet = value;
      }
    }

    public double WbexhsNet
    {
      get
      {
        return this._WbexhsNet;
      }
      set
      {
        this._WbexhsNet = value;
      }
    }

    public double RhexhsNet
    {
      get
      {
        return this._RhexhsNet;
      }
      set
      {
        this._RhexhsNet = value;
      }
    }

    public double DbexhwNet
    {
      get
      {
        return this._DbexhwNet;
      }
      set
      {
        this._DbexhwNet = value;
      }
    }

    public double HrexhwNet
    {
      get
      {
        return this._HrexhwNet;
      }
      set
      {
        this._HrexhwNet = value;
      }
    }

    public double EnthexhwNet
    {
      get
      {
        return this._EnthexhwNet;
      }
      set
      {
        this._EnthexhwNet = value;
      }
    }

    public double WbexhwNet
    {
      get
      {
        return this._WbexhwNet;
      }
      set
      {
        this._WbexhwNet = value;
      }
    }

    public double RhexhwNet
    {
      get
      {
        return this._RhexhwNet;
      }
      set
      {
        this._RhexhwNet = value;
      }
    }

    public double AverageSupplyFlow
    {
      get
      {
        return this._AverageSupplyFlow;
      }
      set
      {
        this._AverageSupplyFlow = value;
      }
    }

    public double AverageExhaustFlow
    {
      get
      {
        return this._AverageExhaustFlow;
      }
      set
      {
        this._AverageExhaustFlow = value;
      }
    }

    public bool mfRHError
    {
      get
      {
        return this._mfRHError;
      }
      set
      {
        this._mfRHError = value;
      }
    }

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
  }
}
