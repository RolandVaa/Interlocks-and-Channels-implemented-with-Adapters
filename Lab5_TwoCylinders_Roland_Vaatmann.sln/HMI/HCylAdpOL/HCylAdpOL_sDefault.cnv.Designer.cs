/*
 * Created by nxtSTUDIO.
 * User: Atmojo
 * Date: 06/10/2018
 * Time: 09:25
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.HCylAdpOL
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
			this.FB1 = new HMI.Main.Symbols.HCylinderLS.sDefault();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 34D, 24D);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "MainH";
			this.FB1.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.FB1});
			this.SymbolSize = new System.Drawing.Size(311, 239);
		}
		private HMI.Main.Symbols.HCylinderLS.sDefault FB1;
		#endregion
	}
}
