// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXDLLDataService.AIRXDataService
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using AirXDLL.My;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;

namespace AirXDLL.AirXDLLDataService
{
  /// <remarks />
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "AIRXDataServiceSoap", Namespace = "http://207.150.200.237/AIRXDataService")]
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [DesignerCategory("code")]
  public class AIRXDataService : SoapHttpClientProtocol
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private SendOrPostCallback HelloWorldOperationCompleted;
    private SendOrPostCallback GetModelsOperationCompleted;
    private SendOrPostCallback GetOEMModelsOperationCompleted;
    private SendOrPostCallback GetCustomerOperationCompleted;
    private SendOrPostCallback GetCitiesOperationCompleted;
    private SendOrPostCallback GetVersionOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    [DebuggerNonUserCode]
    static AIRXDataService()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (AIRXDataService.__ENCList)
      {
        if (AIRXDataService.__ENCList.Count == AIRXDataService.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (AIRXDataService.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (AIRXDataService.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                AIRXDataService.__ENCList[index1] = AIRXDataService.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          AIRXDataService.__ENCList.RemoveRange(index1, checked (AIRXDataService.__ENCList.Count - index1));
          AIRXDataService.__ENCList.Capacity = AIRXDataService.__ENCList.Count;
        }
        AIRXDataService.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    /// <remarks />
    public AIRXDataService()
    {
      AIRXDataService.__ENCAddToList((object) this);
      this.Url = MySettings.Default.AirXDLL_AirXDLLDataService_AIRXDataService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    /// <remarks />
    public event HelloWorldCompletedEventHandler HelloWorldCompleted;

    /// <remarks />
    public event GetModelsCompletedEventHandler GetModelsCompleted;

    /// <remarks />
    public event GetOEMModelsCompletedEventHandler GetOEMModelsCompleted;

    /// <remarks />
    public event GetCustomerCompletedEventHandler GetCustomerCompleted;

    /// <remarks />
    public event GetCitiesCompletedEventHandler GetCitiesCompleted;

    /// <remarks />
    public event GetVersionCompletedEventHandler GetVersionCompleted;

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/HelloWorld", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public string HelloWorld()
    {
      return Microsoft.VisualBasic.CompilerServices.Conversions.ToString(this.Invoke(nameof (HelloWorld), new object[0])[0]);
    }

    /// <remarks />
    public void HelloWorldAsync()
    {
      this.HelloWorldAsync((object) null);
    }

    /// <remarks />
    public void HelloWorldAsync(object userState)
    {
      if (this.HelloWorldOperationCompleted == null)
        this.HelloWorldOperationCompleted = new SendOrPostCallback(this.OnHelloWorldOperationCompleted);
      this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnHelloWorldOperationCompleted(object arg)
    {
      if (this.HelloWorldCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      HelloWorldCompletedEventHandler worldCompletedEvent = this.HelloWorldCompletedEvent;
      if (worldCompletedEvent == null)
        return;
      worldCompletedEvent((object) this, new HelloWorldCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/GetModels", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public XmlNode GetModels()
    {
      return (XmlNode) this.Invoke(nameof (GetModels), new object[0])[0];
    }

    /// <remarks />
    public void GetModelsAsync()
    {
      this.GetModelsAsync((object) null);
    }

    /// <remarks />
    public void GetModelsAsync(object userState)
    {
      if (this.GetModelsOperationCompleted == null)
        this.GetModelsOperationCompleted = new SendOrPostCallback(this.OnGetModelsOperationCompleted);
      this.InvokeAsync("GetModels", new object[0], this.GetModelsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetModelsOperationCompleted(object arg)
    {
      if (this.GetModelsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetModelsCompletedEventHandler modelsCompletedEvent = this.GetModelsCompletedEvent;
      if (modelsCompletedEvent == null)
        return;
      modelsCompletedEvent((object) this, new GetModelsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/GetOEMModels", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public XmlNode GetOEMModels(string CompanyRegCode)
    {
      return (XmlNode) this.Invoke(nameof (GetOEMModels), new object[1]
      {
        (object) CompanyRegCode
      })[0];
    }

    /// <remarks />
    public void GetOEMModelsAsync(string CompanyRegCode)
    {
      this.GetOEMModelsAsync(CompanyRegCode, (object) null);
    }

    /// <remarks />
    public void GetOEMModelsAsync(string CompanyRegCode, object userState)
    {
      if (this.GetOEMModelsOperationCompleted == null)
        this.GetOEMModelsOperationCompleted = new SendOrPostCallback(this.OnGetOEMModelsOperationCompleted);
      this.InvokeAsync("GetOEMModels", new object[1]
      {
        (object) CompanyRegCode
      }, this.GetOEMModelsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetOEMModelsOperationCompleted(object arg)
    {
      if (this.GetOEMModelsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetOEMModelsCompletedEventHandler modelsCompletedEvent = this.GetOEMModelsCompletedEvent;
      if (modelsCompletedEvent == null)
        return;
      modelsCompletedEvent((object) this, new GetOEMModelsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/GetCustomer", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public XmlNode GetCustomer(string CompanyRegCode)
    {
      return (XmlNode) this.Invoke(nameof (GetCustomer), new object[1]
      {
        (object) CompanyRegCode
      })[0];
    }

    /// <remarks />
    public void GetCustomerAsync(string CompanyRegCode)
    {
      this.GetCustomerAsync(CompanyRegCode, (object) null);
    }

    /// <remarks />
    public void GetCustomerAsync(string CompanyRegCode, object userState)
    {
      if (this.GetCustomerOperationCompleted == null)
        this.GetCustomerOperationCompleted = new SendOrPostCallback(this.OnGetCustomerOperationCompleted);
      this.InvokeAsync("GetCustomer", new object[1]
      {
        (object) CompanyRegCode
      }, this.GetCustomerOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCustomerOperationCompleted(object arg)
    {
      if (this.GetCustomerCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCustomerCompletedEventHandler customerCompletedEvent = this.GetCustomerCompletedEvent;
      if (customerCompletedEvent == null)
        return;
      customerCompletedEvent((object) this, new GetCustomerCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/GetCities", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public XmlNode GetCities()
    {
      return (XmlNode) this.Invoke(nameof (GetCities), new object[0])[0];
    }

    /// <remarks />
    public void GetCitiesAsync()
    {
      this.GetCitiesAsync((object) null);
    }

    /// <remarks />
    public void GetCitiesAsync(object userState)
    {
      if (this.GetCitiesOperationCompleted == null)
        this.GetCitiesOperationCompleted = new SendOrPostCallback(this.OnGetCitiesOperationCompleted);
      this.InvokeAsync("GetCities", new object[0], this.GetCitiesOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCitiesOperationCompleted(object arg)
    {
      if (this.GetCitiesCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCitiesCompletedEventHandler citiesCompletedEvent = this.GetCitiesCompletedEvent;
      if (citiesCompletedEvent == null)
        return;
      citiesCompletedEvent((object) this, new GetCitiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    [SoapDocumentMethod("http://207.150.200.237/AIRXDataService/GetVersion", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://207.150.200.237/AIRXDataService", ResponseNamespace = "http://207.150.200.237/AIRXDataService", Use = SoapBindingUse.Literal)]
    public XmlNode GetVersion(int ClientVersion)
    {
      return (XmlNode) this.Invoke(nameof (GetVersion), new object[1]
      {
        (object) ClientVersion
      })[0];
    }

    /// <remarks />
    public void GetVersionAsync(int ClientVersion)
    {
      this.GetVersionAsync(ClientVersion, (object) null);
    }

    /// <remarks />
    public void GetVersionAsync(int ClientVersion, object userState)
    {
      if (this.GetVersionOperationCompleted == null)
        this.GetVersionOperationCompleted = new SendOrPostCallback(this.OnGetVersionOperationCompleted);
      this.InvokeAsync("GetVersion", new object[1]
      {
        (object) ClientVersion
      }, this.GetVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetVersionOperationCompleted(object arg)
    {
      if (this.GetVersionCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetVersionCompletedEventHandler versionCompletedEvent = this.GetVersionCompletedEvent;
      if (versionCompletedEvent == null)
        return;
      versionCompletedEvent((object) this, new GetVersionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    /// <remarks />
    public new void CancelAsync(object userState)
    {
      base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || (object) url == (object) string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
