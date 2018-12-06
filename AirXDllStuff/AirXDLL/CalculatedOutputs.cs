// Decompiled with JetBrains decompiler
// Type: AirXDLL.CalculatedOutputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class CalculatedOutputs
  {
    private double _eatr;
    private double _oacf;
    private double _supplyflow;
    private double _returnflow;
    private double _outdoorflow;
    private double _exhaustflow;
    private double _fanpower;
    private double _allowedDP;
    private double _suppressdrop;
    private double _exhpressdrop;
    private double _outdoorpressure;
    private double _supplypressure;
    private double _exhaustpressure;
    private double _returnpressure;
    private double _AverageSupplyFlow;
    private double _AverageExhaustFlow;
    private double _purgeAngle;
    private double _preheattemp;
    private double _tFrost;
    private double _capacity;
    private double _preheater;
    private double _enthsumo;
    private double _enthsumi;
    private double _enthwino;
    private double _enthwini;
    private double _WinterSupSensibleEffectiveness;
    private double _WinterSupLatentEffectiveness;
    private double _WinterSensibleEffectiveness;
    private double _WinterLatentEffectiveness;
    private double _SupSensibleEffectiveness;
    private double _SupLatentEffectiveness;
    private double _SensibleEffectiveness;
    private double _LatentEffectiveness;
    private double _freshSCFM;
    private double _exhaustSCFM;
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
    private double _neteffsummer;
    private double _neteffwinter;
    private double _totaleffsummer;
    private double _totaleffwinter;
    private double _CLGSav;
    private double _HTGSav;
    private double _DbexhsNet;
    private double _WbexhsNet;
    private double _DbexhwNet;
    private double _WbexhwNet;
    private double _HrexhsNet;
    private double _EnthexhsNet;
    private double _RhexhsNet;
    private double _HrexhwNet;
    private double _EnthexhwNet;
    private double _RhexhwNet;

    [DebuggerNonUserCode]
    public CalculatedOutputs()
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

    public double EnthSumI
    {
      get
      {
        return this._enthsumi;
      }
      set
      {
        this._enthsumi = value;
      }
    }

    public double EnthSumO
    {
      get
      {
        return this._enthsumo;
      }
      set
      {
        this._enthsumo = value;
      }
    }

    public double EnthWinI
    {
      get
      {
        return this._enthwini;
      }
      set
      {
        this._enthwini = value;
      }
    }

    public double EnthWinO
    {
      get
      {
        return this._enthwino;
      }
      set
      {
        this._enthwino = value;
      }
    }

    public double WinterSupSensibleEffectiveness
    {
      get
      {
        return this._WinterSupSensibleEffectiveness;
      }
      set
      {
        this._WinterSupSensibleEffectiveness = value;
      }
    }

    public double WinterSupLatentEffectiveness
    {
      get
      {
        return this._WinterSupLatentEffectiveness;
      }
      set
      {
        this._WinterSupLatentEffectiveness = value;
      }
    }

    public double WinterSensibleEffectiveness
    {
      get
      {
        return this._WinterSensibleEffectiveness;
      }
      set
      {
        this._WinterSensibleEffectiveness = value;
      }
    }

    public double WinterLatentEffectiveness
    {
      get
      {
        return this._WinterLatentEffectiveness;
      }
      set
      {
        this._WinterLatentEffectiveness = value;
      }
    }

    public double SupSensibleEffectiveness
    {
      get
      {
        return this._SupSensibleEffectiveness;
      }
      set
      {
        this._SupSensibleEffectiveness = value;
      }
    }

    public double SupLatentEffectiveness
    {
      get
      {
        return this._SupLatentEffectiveness;
      }
      set
      {
        this._SupLatentEffectiveness = value;
      }
    }

    public double SensibleEffectiveness
    {
      get
      {
        return this._SensibleEffectiveness;
      }
      set
      {
        this._SensibleEffectiveness = value;
      }
    }

    public double LatentEffectiveness
    {
      get
      {
        return this._LatentEffectiveness;
      }
      set
      {
        this._LatentEffectiveness = value;
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

    public double TotalEffSummer
    {
      get
      {
        return this._totaleffsummer;
      }
      set
      {
        this._totaleffsummer = value;
      }
    }

    public double TotalEffWinter
    {
      get
      {
        return this._totaleffwinter;
      }
      set
      {
        this._totaleffwinter = value;
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
  }
}
