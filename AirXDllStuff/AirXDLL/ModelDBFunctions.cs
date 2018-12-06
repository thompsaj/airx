// Decompiled with JetBrains decompiler
// Type: AirXDLL.ModelDBFunctions
// Assembly: AirXDLL, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 456CD5EF-5BE8-42F2-823E-85FD53B8A4B8
// Assembly location: C:\AirXDLL_Distribution_112917\AirXDLL_Distribution_112917\AirXDLL_Test\AirXDLL_Test\bin\Debug\AirXDLL.dll

using Microsoft.VisualBasic;
using System.Diagnostics;

namespace AirXDLL
{
  public class ModelDBFunctions
  {
    [DebuggerNonUserCode]
    public ModelDBFunctions()
    {
    }

    public int GetModelID(string configFile, string model, ref ErrFlags errs)
    {
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      Model model1 = new Model();
      ModelsCollection models = utilityFunctions.GetModels(configFile);
      if (!Information.IsNothing((object) models))
        return models.get_ModelID(model);
      errs = new ErrFlags();
      errs.ErrType = 8;
      errs.ErrText = errs.BadDataText;
      return -1;
    }

    public Model GetModel(string configFile, string model, ref ErrFlags errs)
    {
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      Model model1 = new Model();
      ModelsCollection models = utilityFunctions.GetModels(configFile);
      if (!Information.IsNothing((object) models))
        return models.get_Model(model);
      errs = new ErrFlags();
      errs.ErrType = 8;
      errs.ErrText = errs.BadDataText;
      return model1;
    }

    public ModelData GetModelData(string configFile, int modelID, ref ErrFlags errs)
    {
      UtilityFunctions utilityFunctions = new UtilityFunctions();
      ModelData modelData = new ModelData();
      ModelsCollection models = utilityFunctions.GetModels(configFile);
      if (!Information.IsNothing((object) models))
        return models.get_Model(modelID).ModelData;
      errs = new ErrFlags();
      errs.ErrType = 8;
      errs.ErrText = errs.BadDataText;
      return modelData;
    }
  }
}
