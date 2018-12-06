// Decompiled with JetBrains decompiler
// Type: AirXDLL.OEMModelsCollection
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using System.Collections.Generic;
using System.Xml.Serialization;

namespace AirXDLL
{
  /// <summary>A Collection of AIRX Models</summary>
  /// <remarks></remarks>
  [XmlRoot("OEMModelCollection")]
  public class OEMModelsCollection
  {
    private List<AirXDLL.OEMModel> pOEMModelList;

    public OEMModelsCollection()
    {
      this.pOEMModelList = new List<AirXDLL.OEMModel>();
    }

    /// <summary>The XML Array for all Models</summary>
    /// <value>An Array of AIRXModels</value>
    /// <returns>An Array of AIRXModels</returns>
    /// <remarks></remarks>
    public AirXDLL.OEMModel[] OEMModel
    {
      get
      {
        AirXDLL.OEMModel[] array = new AirXDLL.OEMModel[checked (this.pOEMModelList.Count - 1 + 1)];
        this.pOEMModelList.CopyTo(array);
        return array;
      }
    }

    [XmlArrayItem("AIRXModel", typeof (AirXDLL.OEMModel))]
    [XmlArray("AIRXModels")]
    public List<AirXDLL.OEMModel> OEMModelArrayList
    {
      get
      {
        return this.pOEMModelList;
      }
      set
      {
        this.pOEMModelList = value;
      }
    }

    public AirXDLL.OEMModel get_OEMModel(int ID, bool isID)
    {
      int num1 = 0;
      int num2 = checked (this.pOEMModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (ID == this.pOEMModelList[index].ID)
          return this.pOEMModelList[index];
        checked { ++index; }
      }
      return (AirXDLL.OEMModel) null;
    }

    public void set_OEMModel(int ID, bool isID, AirXDLL.OEMModel value)
    {
      int num1 = 0;
      int num2 = checked (this.pOEMModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (ID == this.pOEMModelList[index].ID)
          this.pOEMModelList[index] = value;
        checked { ++index; }
      }
    }

    public AirXDLL.OEMModel get_OEMModel(int index)
    {
      return this.pOEMModelList[index];
    }

    public void set_OEMModel(int index, AirXDLL.OEMModel value)
    {
      this.pOEMModelList[index] = value;
    }

    /// <summary>Adds a new Model to the collection</summary>
    /// <param name="iModel">An AIRXModel</param>
    /// <remarks></remarks>
    public void AddModel(AirXDLL.OEMModel iModel)
    {
      this.pOEMModelList.Add(iModel);
    }

    public void ClearModels()
    {
      this.pOEMModelList.Clear();
    }
  }
}
