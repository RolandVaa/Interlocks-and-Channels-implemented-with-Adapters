/*
 * Created by nxtSTUDIO.
 * User: vvya002
 * Date: 7/20/2013
 * Time: 6:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.BUTTONAdp
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
			this.FB1 = new HMI.Main.Symbols.BUTTON.HMI();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 24D, 8D);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "Main";
			this.FB1.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.FB1});
			this.SymbolSize = new System.Drawing.Size(95, 56);
		}
		private HMI.Main.Symbols.BUTTON.HMI FB1;
		#endregion
	}
}
