// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXFileCheck
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using AirXDLL.AirXDLLDataService;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class AirXFileCheck
  {
    [DebuggerNonUserCode]
    public AirXFileCheck()
    {
    }

    public static Versions GetServerVersion(int ClientVersion)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(new object());
      using (AIRXDataService airxDataService = new AIRXDataService())
      {
        try
        {
          XmlNode version = airxDataService.GetVersion(ClientVersion);
          XmlDocument xd = new XmlDocument();
          xd.LoadXml(version.OuterXml);
          if (version != null)
            AirXFileCheck.GetConfigDataFromDocument(ref objectValue, ref xd, typeof (Versions));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      return (Versions) objectValue;
    }

    public static void GetConfigDataFromDocument(ref object config, ref XmlDocument xd, Type type)
    {
      try
      {
        using (MemoryStream memoryStream = new MemoryStream())
        {
          xd.Save((Stream) memoryStream);
          XmlSerializer xmlSerializer = new XmlSerializer(type);
          memoryStream.Seek(0L, SeekOrigin.Begin);
          config = RuntimeHelpers.GetObjectValue(xmlSerializer.Deserialize((Stream) memoryStream));
          memoryStream.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        StreamWriter streamWriter = File.AppendText("C:\\GetConfigData.log");
        streamWriter.WriteLine("Exception message: GetConfigDataFromDocument() -> " + exception.Message);
        streamWriter.WriteLine("");
        streamWriter.Close();
        ProjectData.ClearProjectError();
      }
    }
  }
}
