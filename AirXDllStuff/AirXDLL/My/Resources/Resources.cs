// Decompiled with JetBrains decompiler
// Type: AirXDLL.My.Resources.Resources
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AirXDLL.My.Resources
{
  /// <summary>A strongly-typed resource class, for looking up localized strings, etc.</summary>
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [StandardModule]
  [CompilerGenerated]
  [HideModuleName]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    /// <summary>Returns the cached ResourceManager instance used by this class.</summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) AirXDLL.My.Resources.Resources.resourceMan, (object) null))
          AirXDLL.My.Resources.Resources.resourceMan = new ResourceManager("AirXDLL.Resources", typeof (AirXDLL.My.Resources.Resources).Assembly);
        return AirXDLL.My.Resources.Resources.resourceMan;
      }
    }

    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return AirXDLL.My.Resources.Resources.resourceCulture;
      }
      set
      {
        AirXDLL.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
