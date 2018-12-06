// Decompiled with JetBrains decompiler
// Type: AirXDLL.ModelsCollection
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AirXDLL
{
  /// <summary>A Collection of AIRX Models</summary>
  /// <remarks></remarks>
  [XmlRoot("ModelCollection")]
  public class ModelsCollection
  {
    private List<AirXDLL.Model> pModelList;

    public ModelsCollection()
    {
      this.pModelList = new List<AirXDLL.Model>();
    }

    /// <summary>The XML Array for all Models</summary>
    /// <value>An Array of AIRXModels</value>
    /// <returns>An Array of AIRXModels</returns>
    /// <remarks></remarks>
    public AirXDLL.Model[] Model
    {
      get
      {
        AirXDLL.Model[] array = new AirXDLL.Model[checked (this.pModelList.Count - 1 + 1)];
        this.pModelList.CopyTo(array);
        return array;
      }
    }

    [XmlArrayItem("AIRXModel", typeof (AirXDLL.Model))]
    [XmlArray("AIRXModels")]
    public List<AirXDLL.Model> ModelArrayList
    {
      get
      {
        return this.pModelList;
      }
      set
      {
        this.pModelList = value;
      }
    }

    public int get_ModelID(string modelName)
    {
      int num1 = 0;
      int num2 = checked (this.pModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (Operators.CompareString(modelName, this.pModelList[index].ModelName, false) == 0)
          return this.pModelList[index].ID;
        checked { ++index; }
      }
      return 0;
    }

    public void set_ModelID(string modelName, int value)
    {
    }

    public AirXDLL.Model get_Model(string modelName)
    {
      int num1 = 0;
      int num2 = checked (this.pModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (Operators.CompareString(modelName, this.pModelList[index].ModelName, false) == 0)
          return this.pModelList[index];
        checked { ++index; }
      }
      return (AirXDLL.Model) null;
    }

    public void set_Model(string modelName, AirXDLL.Model value)
    {
    }

    public AirXDLL.Model get_Model(int ID)
    {
      int num1 = 0;
      int num2 = checked (this.pModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (ID == this.pModelList[index].ID)
          return this.pModelList[index];
        checked { ++index; }
      }
      return (AirXDLL.Model) null;
    }

    public void set_Model(int ID, AirXDLL.Model value)
    {
      int num1 = 0;
      int num2 = checked (this.pModelList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (ID == this.pModelList[index].ID)
          this.pModelList[index] = value;
        checked { ++index; }
      }
    }

    /// <summary>Adds a new Model to the collection</summary>
    /// <param name="iModel">An AIRXModel</param>
    /// <remarks></remarks>
    public void AddModel(AirXDLL.Model iModel)
    {
      this.pModelList.Add(iModel);
    }

    public void ClearModels()
    {
      this.pModelList.Clear();
    }
  }
}
