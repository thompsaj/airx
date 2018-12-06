// Decompiled with JetBrains decompiler
// Type: AirXDLL.AIRXCustomers.AIRXCustomer
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System;
using System.Xml.Serialization;

namespace AirXDLL.AIRXCustomers
{
  /// <summary>An AIRX Project base type</summary>
  /// <remarks></remarks>
  [XmlRoot("AIRXCustomer")]
  public class AIRXCustomer
  {
    private string pAIRXCustomerName;
    private int pAIRXCustomerID;
    private Guid pAIRXCompanyRegCode;
    private string pAddress;
    private string pAddress2;
    private string pCity;
    private string pState;
    private string pZip;
    private string pPhone;
    private string pFax;
    private string pEmail;
    private string pWebsite;
    private string pNotes;
    private string pTagline;
    private DateTime pDateCreated;
    private string pCreatedBy;
    private string pStatus;
    private DateTime pDateModified;
    private string pModifiedBy;
    private bool pUseOEMModels;
    private bool pUsePressuresInput;
    private bool pUsePressureDrop;
    private bool pUseMatrixSelection;
    private bool pUseDataOverride;
    private bool pUseAdvanceDataOverride;
    private bool pUseExpandedVersion;
    private byte[] pLogo;

    public AIRXCustomer()
    {
      this.pAIRXCustomerID = -1;
    }

    [XmlElement("AIRXCustomerName")]
    public string AIRXCustomerName
    {
      get
      {
        return this.pAIRXCustomerName;
      }
      set
      {
        this.pAIRXCustomerName = value;
      }
    }

    [XmlElement("AIRXCustomerID")]
    public int AIRXCustomerID
    {
      get
      {
        return this.pAIRXCustomerID;
      }
      set
      {
        this.pAIRXCustomerID = value;
      }
    }

    [XmlElement("AIRXCompanyRegCode")]
    public Guid AIRXCompanyRegCode
    {
      get
      {
        return this.pAIRXCompanyRegCode;
      }
      set
      {
        this.pAIRXCompanyRegCode = value;
      }
    }

    [XmlElement("Address")]
    public string Address
    {
      get
      {
        return this.pAddress;
      }
      set
      {
        this.pAddress = value;
      }
    }

    [XmlElement("Address2")]
    public string Address2
    {
      get
      {
        return this.pAddress2;
      }
      set
      {
        this.pAddress2 = value;
      }
    }

    [XmlElement("City")]
    public string City
    {
      get
      {
        return this.pCity;
      }
      set
      {
        this.pCity = value;
      }
    }

    [XmlElement("State")]
    public string State
    {
      get
      {
        return this.pState;
      }
      set
      {
        this.pState = value;
      }
    }

    [XmlElement("Zip")]
    public string Zip
    {
      get
      {
        return this.pZip;
      }
      set
      {
        this.pZip = value;
      }
    }

    [XmlElement("Phone")]
    public string Phone
    {
      get
      {
        return this.pPhone;
      }
      set
      {
        this.pPhone = value;
      }
    }

    [XmlElement("Fax")]
    public string Fax
    {
      get
      {
        return this.pFax;
      }
      set
      {
        this.pFax = value;
      }
    }

    [XmlElement("Email")]
    public string Email
    {
      get
      {
        return this.pEmail;
      }
      set
      {
        this.pEmail = value;
      }
    }

    [XmlElement("Website")]
    public string Website
    {
      get
      {
        return this.pWebsite;
      }
      set
      {
        this.pWebsite = value;
      }
    }

    [XmlElement("Notes")]
    public string Notes
    {
      get
      {
        return this.pNotes;
      }
      set
      {
        this.pNotes = value;
      }
    }

    [XmlElement("Tagline")]
    public string Tagline
    {
      get
      {
        return this.pTagline;
      }
      set
      {
        this.pTagline = value;
      }
    }

    [XmlElement("DateCreated")]
    public DateTime DateCreated
    {
      get
      {
        return this.pDateCreated;
      }
      set
      {
        this.pDateCreated = value;
      }
    }

    [XmlElement("CreatedBy")]
    public string CreatedBy
    {
      get
      {
        return this.pCreatedBy;
      }
      set
      {
        this.pCreatedBy = value;
      }
    }

    [XmlElement("Status")]
    public string Status
    {
      get
      {
        return this.pStatus;
      }
      set
      {
        this.pStatus = value;
      }
    }

    [XmlElement("DateModified")]
    public DateTime DateModified
    {
      get
      {
        return this.pDateModified;
      }
      set
      {
        this.pDateModified = value;
      }
    }

    [XmlElement("ModifiedBy")]
    public string ModifiedBy
    {
      get
      {
        return this.pModifiedBy;
      }
      set
      {
        this.pModifiedBy = value;
      }
    }

    [XmlElement("UseOEMModels")]
    public bool UseOEMModels
    {
      get
      {
        return this.pUseOEMModels;
      }
      set
      {
        this.pUseOEMModels = value;
      }
    }

    [XmlElement("UsePressuresInput")]
    public bool UsePressuresInput
    {
      get
      {
        return this.pUsePressuresInput;
      }
      set
      {
        this.pUsePressuresInput = value;
      }
    }

    [XmlElement("UsePressureDrop")]
    public bool UsePressureDrop
    {
      get
      {
        return this.pUsePressureDrop;
      }
      set
      {
        this.pUsePressureDrop = value;
      }
    }

    [XmlElement("UseMatrixSelection")]
    public bool UseMatrixSelection
    {
      get
      {
        return this.pUseMatrixSelection;
      }
      set
      {
        this.pUseMatrixSelection = value;
      }
    }

    [XmlElement("UseDataOverride")]
    public bool UseDataOverride
    {
      get
      {
        return this.pUseDataOverride;
      }
      set
      {
        this.pUseDataOverride = value;
      }
    }

    [XmlElement("UseAdvanceDataOverride")]
    public bool UseAdvanceDataOverride
    {
      get
      {
        return this.pUseAdvanceDataOverride;
      }
      set
      {
        this.pUseAdvanceDataOverride = value;
      }
    }

    [XmlElement("UseExpandedVersion")]
    public bool UseExpandedVersion
    {
      get
      {
        return this.pUseExpandedVersion;
      }
      set
      {
        this.pUseExpandedVersion = value;
      }
    }

    [XmlElement("Logo")]
    public byte[] Logo
    {
      get
      {
        return this.pLogo;
      }
      set
      {
        this.pLogo = value;
      }
    }
  }
}
