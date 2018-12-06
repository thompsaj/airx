// Decompiled with JetBrains decompiler
// Type: AirXDLL.My.MySettings
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AirXDLL.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }

    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("http://localhost/AIRXServices/AIRXDataService.asmx")]
    [ApplicationScopedSetting]
    public string AirXDLL_AirXDLLDataService_AIRXDataService
    {
      get
      {
        return Microsoft.VisualBasic.CompilerServices.Conversions.ToString(this[nameof (AirXDLL_AirXDLLDataService_AIRXDataService)]);
      }
    }
  }
}
