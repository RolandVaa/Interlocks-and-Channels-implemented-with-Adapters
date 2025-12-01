/*
 * Created by nxtSTUDIO.
 * User: valvya
 * Date: 8/12/2014
 * Time: 8:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.HCylinderLS
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FB1 = new HMI.Main.Symbols.HCylinderSA.HMI();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 14, 9);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "FB1";
			this.FB1.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.FB1});
			this.SymbolSize = new System.Drawing.Size(276, 212);
		}
		private HMI.Main.Symbols.HCylinderSA.HMI FB1;
		#endregion
	}
}
