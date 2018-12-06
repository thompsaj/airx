// Decompiled with JetBrains decompiler
// Type: AirXDLL.Location
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Diagnostics;

namespace AirXDLL
{
  public class Location
  {
    private string _city;
    private string _state;
    private string _elevation;

    [DebuggerNonUserCode]
    public Location()
    {
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
        return Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(this._elevation);
      }
      set
      {
        this._elevation = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value);
      }
    }
  }
}
