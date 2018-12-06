// Decompiled with JetBrains decompiler
// Type: AirXDLL.AirXDLLDataService.HelloWorldCompletedEventArgs
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AirXDLL.AirXDLLDataService
{
  /// <remarks />
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  public class HelloWorldCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal HelloWorldCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
    {
      this.results = results;
    }

    /// <remarks />
    public string Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return Microsoft.VisualBasic.CompilerServices.Conversions.ToString(this.results[0]);
      }
    }
  }
}
