/*
 * Created by nxtSTUDIO.
 * User: vvya002
 * Date: 19/11/2012
 * Time: 3:47 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using NxtStudio.Symbols;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.BUTTON
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
		
		void LABELValueChanged(object sender, ValueChangedEventArgs e)
		{
		  drawnButton1.Text=(string)LABEL.Value;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		  this.FireEvent_CNF();
		}
		
		void ENABLEValueChanged(object sender, ValueChangedEventArgs e)
		{
			drawnButton1.Enabled=(bool)ENABLE.Value;
		}

		void DrawnButton1Click(object sender, EventArgs e)
		{
			this.FireEvent_CNF();
			// TODO: Implement DrawnButton1Click
		}
	}
}
