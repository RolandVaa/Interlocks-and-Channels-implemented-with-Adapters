using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region #VCylinder_HMI;

namespace HMI.Main.Symbols.VCylinder
{

  public class INDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_pos(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? pos
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_Label(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String Label
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

}

namespace HMI.Main.Symbols.VCylinder
{
  partial class HMI
  {

    private event EventHandler<Symbols.VCylinder.INDEventArgs> IND_Fired;

    protected override void OnEndInit()
    {
      if (IND_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (IND_Fired != null)
            IND_Fired(this, new Symbols.VCylinder.INDEventArgs(channelId, cookie, eventIndex));
        break; 

      }
    }

  }
}

namespace HMI.Main.Controllers.VCylinder
{
  partial class FacePlate01
  {

    private event EventHandler<HMI.Main.Symbols.VCylinder.INDEventArgs> IND_Fired;

    protected override void OnEndInit()
    {
      if (IND_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (IND_Fired != null)
            IND_Fired(this, new HMI.Main.Symbols.VCylinder.INDEventArgs(channelId, cookie, eventIndex));
        break; 

      }
    }

  }
}
#endregion #VCylinder_HMI;

#endregion Definitions;

