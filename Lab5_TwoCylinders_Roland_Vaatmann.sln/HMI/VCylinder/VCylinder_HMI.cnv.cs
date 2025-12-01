/*
 * Created by nxtStudio.
 * User: Horst Mayer
 * Date: 9/14/2008
 * Time: 10:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using NxtStudio.Symbols;
using NxtControl.GuiFramework;

#if !WindowsCE
using System.ComponentModel;
#endif

namespace HMI.Main.Symbols.VCylinder
{
	/// <summary>
	/// Description of HMI.
	/// </summary>
	public partial class HMI : NxtControl.GuiFramework.HMISymbol
	{
		public HMI()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void PoschangeValueChanged(object sender, ValueChangedEventArgs e)
		{
			
		  NxtControl.Drawing.PointF newPos = grpInnerPart.Location;
		  float position = (float)e.Value;
			double relpos = 115.0d/100.0d * position + 115.0d;
			if (relpos > 220.0d) {
				isMax.Visible = true;
				isMin.Visible = false;
			} else if (relpos < 125.0d) {
				isMax.Visible = false;
				isMin.Visible = true;
			} else {
				isMax.Visible = false;
				isMin.Visible = false;
			}
			newPos.Y = relpos;
			grpInnerPart.Location = newPos;
		}
		
		void LabelValueChanged(object sender, ValueChangedEventArgs e)
		{
		  labelName.Text=(string)Label.Value;
		}		
#region FACEPLATE		
		private Controllers.VCylinder.FacePlate01 controller = null;
		
		void cmdOpenFaceplate(object sender, EventArgs e)
		{
		  if (controller != null)
		  {
		    controller.Activate();
		  }
		  else
		  {
		    controller = FacePlate01;
		    controller.Disposed += OnControllerDisposed;
		    controller.LabelName = this.LabelName;
		    controller.Show(this);
		  }			
		}

		private void OnControllerDisposed(object sender, System.EventArgs args)
		{
		  controller.Disposed -= OnControllerDisposed;
		  controller = null;
		}		
		
        
		#if !WindowsCE
        [DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Behavior")]
		#endif
        public string LabelName 
        { 
        	get { return labelName.Text; }
        	set 
        	{ 
        		labelName.Text = value;
        	}
        } 
        
       	
#endregion FACEPLATE		
		
	}
}
