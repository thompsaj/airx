// Decompiled with JetBrains decompiler
// Type: AirXDLL.FunctionDLLInputs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Collections.Generic;
using System.Diagnostics;

namespace AirXDLL
{
  public class FunctionDLLInputs
  {
    private string _configFileLocation;
    private string _dbLocation;
    private double _fanEff;
    private int _daysIndex;
    private List<AirXDLL.BinData> _binData;
    private List<AirXDLL.HourData> _hourData;
    private int _totalHours;
    private UnitPressures _unitPressures;
    private AirFlows _airFlowas;
    private Location _location;
    private ModelParams _modelParams;
    private AirInlets _airInlets;
    private OperationMonth _opMonth;
    private OperationPeriod _opPeriod;
    private TimeOfDayPrice _todPrice;
    private EnergyCosts _energyCosts;
    private CalculatedOutputs _calcOutputs;
    private CalculatedEnergy _calcEnergy;
    private RTU _rtu;

    [DebuggerNonUserCode]
    public FunctionDLLInputs()
    {
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

    public string DBFileLocation
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

    /// <summary>the fan total efficiency including motor efficiency, in percent</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double FanEff
    {
      get
      {
        return this._fanEff;
      }
      set
      {
        this._fanEff = value;
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
        return this._daysIndex;
      }
      set
      {
        this._daysIndex = value;
      }
    }

    public UnitPressures UnitPressures
    {
      get
      {
        return this._unitPressures;
      }
      set
      {
        this._unitPressures = value;
      }
    }

    public AirFlows AirFlows
    {
      get
      {
        return this._airFlowas;
      }
      set
      {
        this._airFlowas = value;
      }
    }

    public Location Location
    {
      get
      {
        return this._location;
      }
      set
      {
        this._location = value;
      }
    }

    public ModelParams ModelParam
    {
      get
      {
        return this._modelParams;
      }
      set
      {
        this._modelParams = value;
      }
    }

    public AirInlets AirInlet
    {
      get
      {
        return this._airInlets;
      }
      set
      {
        this._airInlets = value;
      }
    }

    public OperationMonth OpMonth
    {
      get
      {
        return this._opMonth;
      }
      set
      {
        this._opMonth = value;
      }
    }

    public OperationPeriod OpPeriod
    {
      get
      {
        return this._opPeriod;
      }
      set
      {
        this._opPeriod = value;
      }
    }

    public TimeOfDayPrice TODPrice
    {
      get
      {
        return this._todPrice;
      }
      set
      {
        this._todPrice = value;
      }
    }

    public EnergyCosts EnergyCost
    {
      get
      {
        return this._energyCosts;
      }
      set
      {
        this._energyCosts = value;
      }
    }

    public RTU RTU
    {
      get
      {
        return this._rtu;
      }
      set
      {
        this._rtu = value;
      }
    }

    public CalculatedOutputs CalcOutputs
    {
      get
      {
        return this._calcOutputs;
      }
      set
      {
        this._calcOutputs = value;
      }
    }

    public CalculatedEnergy CalcEnergy
    {
      get
      {
        return this._calcEnergy;
      }
      set
      {
        this._calcEnergy = value;
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
        return this._totalHours;
      }
      set
      {
        this._totalHours = value;
      }
    }
  }
}
