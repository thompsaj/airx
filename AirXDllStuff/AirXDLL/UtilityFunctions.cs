// Decompiled with JetBrains decompiler
// Type: AirXDLL.UtilityFunctions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class UtilityFunctions
  {
    [DebuggerNonUserCode]
    public UtilityFunctions()
    {
    }

    public ModelsCollection GetModels(string fileLocation)
    {
      string path = fileLocation + "Models.xml";
      if (!File.Exists(path))
        return (ModelsCollection) null;
      object objectValue;
      using (FileStream fileStream = new FileStream(Path.GetFullPath(path), FileMode.Open, FileAccess.Read))
        objectValue = RuntimeHelpers.GetObjectValue(new XmlSerializer(typeof (ModelsCollection)).Deserialize((Stream) fileStream));
      return (ModelsCollection) objectValue;
    }

    public ArrayList GetModelsList(string fileLocation)
    {
      ModelsCollection models = this.GetModels(fileLocation);
      ArrayList arrayList = new ArrayList();
      List<Model>.Enumerator enumerator;
      try
      {
        enumerator = models.ModelArrayList.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Model current = enumerator.Current;
          if (!current.ModelName.StartsWith("*"))
            arrayList.Add((object) current.ModelName);
        }
      }
      finally
      {
        enumerator.Dispose();
      }
      return arrayList;
    }

    public OEMModelsCollection GetOEMModels(string fileLocation)
    {
      if (!File.Exists(fileLocation))
        return (OEMModelsCollection) null;
      object objectValue;
      using (FileStream fileStream = new FileStream(Path.GetFullPath(fileLocation), FileMode.Open, FileAccess.Read))
        objectValue = RuntimeHelpers.GetObjectValue(new XmlSerializer(typeof (OEMModelsCollection)).Deserialize((Stream) fileStream));
      return (OEMModelsCollection) objectValue;
    }

    public AIRXAppConfig GetAppVersion(string filelocation)
    {
      string path = filelocation + "AIRXAppConfig.xml";
      if (!File.Exists(path))
        return (AIRXAppConfig) null;
      object objectValue;
      using (FileStream fileStream = new FileStream(Path.GetFullPath(path), FileMode.Open, FileAccess.Read))
        objectValue = RuntimeHelpers.GetObjectValue(new XmlSerializer(typeof (AIRXAppConfig)).Deserialize((Stream) fileStream));
      return (AIRXAppConfig) objectValue;
    }

    public static bool SaveConfigData(string CONFIG_FNAME, object config, Type type)
    {
      bool flag;
      try
      {
        using (FileStream fileStream = new FileStream(Path.GetFullPath(CONFIG_FNAME), FileMode.Create))
          new XmlSerializer(type).Serialize((Stream) fileStream, RuntimeHelpers.GetObjectValue(config));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_8;
      }
      flag = true;
label_8:
      return flag;
    }
  }
}
