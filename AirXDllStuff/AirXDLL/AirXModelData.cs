// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXModelData
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace AirXDLL
{
  public class AirXModelData
  {
    [DebuggerNonUserCode]
    public AirXModelData()
    {
    }

    public static int GetModelID(string ModelName)
    {
      if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIRXERC\\ERC"))
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIRXERC\\ERC");
      object obj = (object) null;
      ModelsCollection modelsCollection = new ModelsCollection();
      object objectValue = RuntimeHelpers.GetObjectValue(AirXModelData.GetConfigData("Models.xml", typeof (ModelsCollection), true));
      if (objectValue is ModelsCollection)
        modelsCollection = (ModelsCollection) objectValue;
      obj = (object) null;
      List<Model>.Enumerator enumerator;
      int id;
      try
      {
        enumerator = modelsCollection.ModelArrayList.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Model current = enumerator.Current;
          if (Operators.CompareString(current.ModelName, ModelName, false) == 0)
            id = current.ID;
        }
      }
      finally
      {
        enumerator.Dispose();
      }
      return id;
    }

    public static object GetConfigData(string CONFIG_FNAME, Type type, bool AppData)
    {
      object obj = (object) null;
      using (Mutex mutex = new Mutex(false, "Global\\AIRXXML"))
      {
        mutex.WaitOne(300, false);
        try
        {
          string path = !AppData ? CONFIG_FNAME : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIRXERC\\ERC\\" + CONFIG_FNAME;
          if (File.Exists(Path.GetFullPath(path)))
          {
            using (FileStream fileStream = new FileStream(Path.GetFullPath(path), FileMode.Open))
              obj = RuntimeHelpers.GetObjectValue(new XmlSerializer(type).Deserialize((Stream) fileStream));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        mutex.ReleaseMutex();
      }
      return obj;
    }
  }
}
