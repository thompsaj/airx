// Decompiled with JetBrains decompiler
// Type: AirXDLL.ModelParams
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System;
using System.Diagnostics;

namespace AirXDLL
{
  public class ModelParams
  {
    private string _model;
    private int _wheels;
    private bool _hasPurge;
    private int _purgeAngle;
    private double _EATR;
    private double _OACF;
    private double _TargetEATR;
    private bool _sensible;

    [DebuggerNonUserCode]
    public ModelParams()
    {
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

    /// <summary>'number of wheels in a unit</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double Wheels
    {
      get
      {
        return (double) this._wheels;
      }
      set
      {
        this._wheels = checked ((int) Math.Round(value));
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

    /// <summary>the purge angle if channel matrix is used, from 0 to 15 degrees</summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public double PurgeAngle
    {
      get
      {
        return (double) this._purgeAngle;
      }
      set
      {
        this._purgeAngle = checked ((int) Math.Round(value));
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
        return this._TargetEATR;
      }
      set
      {
        this._TargetEATR = value;
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
  }
}
