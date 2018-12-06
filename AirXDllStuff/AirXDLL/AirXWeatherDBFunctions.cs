// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXWeatherDBFunctions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AirXDLL
{
  public class AirXWeatherDBFunctions
  {
    [DebuggerNonUserCode]
    public AirXWeatherDBFunctions()
    {
    }

    public WeatherDesignData GetWeatherDesignData(string region, string country, string state, string city, string dbLocation)
    {
      string str = "AirXWeatherData-" + region.Replace(" ", "_") + ".mdb";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbLocation + str);
      WeatherDesignData weatherDesignData = new WeatherDesignData();
      try
      {
        connection.Open();
        OleDbDataReader oleDbDataReader = new OleDbCommand("Select Elev, DB04, MCWB04,DB996, MCWB996, Locations.FileName FROM DesignConditions INNER JOIN Locations On DesignConditions.WMO = Locations.DesignWMO " + " WHERE Locations.Country='" + country + "' AND Locations.State = '" + state + "' AND Locations.City = '" + city + "'", connection).ExecuteReader();
        while (oleDbDataReader.Read())
        {
          weatherDesignData.Elev = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(oleDbDataReader["Elev"]);
          weatherDesignData.DB04 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["DB04"]);
          weatherDesignData.MCWB04 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["MCWB04"]);
          weatherDesignData.DB996 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["DB996"]);
          weatherDesignData.MCWB996 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["MCWB996"]);
          weatherDesignData.FileName = oleDbDataReader["FileName"].ToString();
        }
        oleDbDataReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection.State == ConnectionState.Open)
          connection.Close();
      }
      return weatherDesignData;
    }

    public string ValidateBinInputs(string strMonths, string strSunday, string strMonday, string strTuesday, string strWednesday, string strThursday, string strFriday, string strSaturday)
    {
      string str = "";
      if (strMonths.Length != 12)
        str = "Month string must be 12 chars long";
      if (!Regex.IsMatch(strMonths, "^[0-1 ]+$"))
        str += " Month string can only contain 0's or 1's";
      if (strSunday.Length != 24)
        str += " Sunday string must be 24 chars long";
      if (!Regex.IsMatch(strSunday, "^[0-1 ]+$"))
        str += " Sunday string can only contain 0's or 1's";
      if (strMonday.Length != 24)
        str += " Monday string must be 24 chars long";
      if (!Regex.IsMatch(strMonday, "^[0-1 ]+$"))
        str += " Monday string can only contain 0's or 1's";
      if (strTuesday.Length != 24)
        str += " Tuesday string must be 24 chars long";
      if (!Regex.IsMatch(strTuesday, "^[0-1 ]+$"))
        str += " Tuesday string can only contain 0's or 1's";
      if (strWednesday.Length != 24)
        str += " Wednesday string must be 24 chars long";
      if (!Regex.IsMatch(strWednesday, "^[0-1 ]+$"))
        str += " Wednesday string can only contain 0's or 1's";
      if (strThursday.Length != 24)
        str += " Thursday string must be 24 chars long";
      if (!Regex.IsMatch(strThursday, "^[0-1 ]+$"))
        str += " Thursday string can only contain 0's or 1's";
      if (strFriday.Length != 24)
        str += " Friday string must be 24 chars long";
      if (!Regex.IsMatch(strFriday, "^[0-1 ]+$"))
        str += " Friday string can only contain 0's or 1's";
      if (strSaturday.Length != 24)
        str += " Saturday string must be 24 chars long";
      if (!Regex.IsMatch(strSaturday, "^[0-1 ]+$"))
        str += " Saturday string can only contain 0's or 1's";
      return str;
    }

    public List<HourData> GetHourDataByMonth(string region, string city, string strMonths, string strSunday, string strMonday, string strTuesday, string strWednesday, string strThursday, string strFriday, string strSaturday, string dbLocation)
    {
      string str = "AirXWeatherData-" + region.Replace(" ", "_") + ".mdb";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbLocation + str);
      List<HourData> hourDataList = new List<HourData>();
      try
      {
        connection.Open();
        string[] restrictionValues = new string[4]
        {
          null,
          null,
          "HourlyData",
          null
        };
        if (connection.GetSchema("Tables", restrictionValues).Rows.Count == 0)
          return hourDataList;
        connection.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      string sql = "Select Month, Tdb_IP, W_IP FROM HourlyData, Locations" + " WHERE Locations.FileName = HourlyData.FileName AND HourlyData.FileName='" + city + "'";
      this.ParseSelectedTime(ref sql, strMonths, strSunday, strMonday, strTuesday, strWednesday, strThursday, strFriday, strSaturday);
      sql += " ORDER BY Month, Tdb_IP DESC";
      OleDbCommand oleDbCommand = new OleDbCommand(sql, connection);
      try
      {
        connection.Open();
        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
        while (oleDbDataReader.Read())
          hourDataList.Add(new HourData()
          {
            DB = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["Tdb_IP"]),
            HumRatio = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(oleDbDataReader["W_IP"]),
            Month = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(oleDbDataReader["Month"])
          });
        oleDbDataReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection.State == ConnectionState.Open)
          connection.Close();
      }
      return hourDataList;
    }

    private void ParseSelectedTime(ref string sql, string strMonths, string strSunday, string strMonday, string strTuesday, string strWednesday, string strThursday, string strFriday, string strSaturday)
    {
      if (!strMonths.Contains("1"))
        return;
      string Left1 = "";
      int startIndex = 0;
      do
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strMonths.Substring(startIndex, 1), "1", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "", false) != 0)
            Left1 += ",";
          Left1 += checked (startIndex + 1).ToString();
        }
        checked { ++startIndex; }
      }
      while (startIndex <= 11);
      sql = sql + " AND Month IN (" + Left1 + ")";
      string Left2 = "";
      string day1 = this.ParseDay(strSunday, 1);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day1, "", false) != 0)
        Left2 = " AND (" + day1;
      string day2 = this.ParseDay(strMonday, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day2, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day2;
      string day3 = this.ParseDay(strTuesday, 3);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day3, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day3;
      string day4 = this.ParseDay(strWednesday, 4);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day4, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day4;
      string day5 = this.ParseDay(strThursday, 5);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day5, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day5;
      string day6 = this.ParseDay(strFriday, 6);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day6, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day6;
      string day7 = this.ParseDay(strSaturday, 7);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(day7, "", false) != 0)
        Left2 = (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0 ? " AND (" : Left2 + " OR ") + day7;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) != 0)
        Left2 += ")";
      sql += Left2;
    }

    private string ParseDay(string dayString, int day)
    {
      string str1 = "";
      string Left = "";
      if (dayString.Contains("1"))
      {
        string str2 = "(DayOfWeek = " + Microsoft.VisualBasic.CompilerServices.Conversions.ToString(day) + "  and hour in (";
        int startIndex = 0;
        do
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dayString.Substring(startIndex, 1), "1", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
              Left += ",";
            Left += checked (startIndex + 1).ToString();
          }
          checked { ++startIndex; }
        }
        while (startIndex <= 23);
        str1 = str2 + Left + "))";
      }
      return str1;
    }

    public List<string> GetCountries(string region, string dblocation)
    {
      string str = "AirXWeatherData-" + region.Replace(" ", "_") + ".mdb";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dblocation + str);
      string cmdText = "Select Distinct(Country) FROM Locations order by Country ASC";
      List<string> stringList = new List<string>();
      try
      {
        connection.Open();
        OleDbDataReader oleDbDataReader = new OleDbCommand(cmdText, connection).ExecuteReader();
        while (oleDbDataReader.Read())
          stringList.Add(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(oleDbDataReader["Country"]));
        oleDbDataReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection.State == ConnectionState.Open)
          connection.Close();
      }
      return stringList;
    }

    public List<string> GetStates(string region, string country, string dblocation)
    {
      string str = "AirXWeatherData-" + region.Replace(" ", "_") + ".mdb";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dblocation + str);
      string cmdText = "Select Distinct(State) FROM Locations Where Country='" + country + "' order by State ASC";
      List<string> stringList = new List<string>();
      try
      {
        connection.Open();
        OleDbDataReader oleDbDataReader = new OleDbCommand(cmdText, connection).ExecuteReader();
        while (oleDbDataReader.Read())
          stringList.Add(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(oleDbDataReader["State"]));
        oleDbDataReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection.State == ConnectionState.Open)
          connection.Close();
      }
      return stringList;
    }

    public List<string> GetCities(string region, string country, string state, string dblocation)
    {
      string str = "AirXWeatherData-" + region.Replace(" ", "_") + ".mdb";
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dblocation + str);
      string cmdText = "Select Distinct(City) FROM Locations Where Country='" + country + "'" + " AND State='" + state + "' order by City ASC";
      List<string> stringList = new List<string>();
      try
      {
        connection.Open();
        OleDbDataReader oleDbDataReader = new OleDbCommand(cmdText, connection).ExecuteReader();
        while (oleDbDataReader.Read())
          stringList.Add(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(oleDbDataReader["City"]));
        oleDbDataReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection.State == ConnectionState.Open)
          connection.Close();
      }
      return stringList;
    }
  }
}
