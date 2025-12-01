/*
 * Created by nxtStudio.
 * User: Horst Mayer
 * Date: 9/14/2008
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;

using NxtControl.GuiFramework;

#if !WindowsCE
using System.ComponentModel;
#endif

namespace HMI.Main.Controllers.VCylinder
{
	/// <summary>
	/// Description of FacePlate01.
	/// </summary>
	public partial class FacePlate01 : NxtControl.GuiFramework.HMIFaceplate
	{
		public FacePlate01()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
        
		#if !WindowsCE
        [DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Behavior")]
		#endif
        public string LabelUnit 
        { 
        	get { return labelPv.Suffix; }
        	set 
        	{ 
        		labelPv.Suffix = value;
        	}
        }           
	}
}
