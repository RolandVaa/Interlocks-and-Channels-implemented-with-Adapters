using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region HCylinder_HMI;

namespace HMI.Main.Symbols.HCylinder
{
  partial class HMI
  {

    private Controllers.HCylinder.FacePlate01 FacePlate01
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Controllers.HCylinder.FacePlate01 faceplate = null; 
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Controllers.HCylinder.FacePlate01)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Controllers.HCylinder.FacePlate01));

        if (faceplate == null)
        {
          faceplate = new Controllers.HCylinder.FacePlate01();
          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());
          if (hmiManagementService != null)
            hmiManagementService.RegisterHMISymbolController(faceplate);
        }
        return faceplate;
      }
    }
     
    protected override void DoOpenFaceplate(OpenFaceplate openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

    public override void DoOpenFaceplate(string openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

  }
}
#endregion HCylinder_HMI;

#endregion Definitions;

