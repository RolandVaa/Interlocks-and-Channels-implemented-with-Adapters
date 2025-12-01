/*
 * Created by nxtStudio.
 * User: Horst Mayer
 * Date: 9/14/2008
 * Time: 10:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtStudio.Symbols;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Sensor
{
	/// <summary>
	/// Summary description for HMI.
	/// </summary>
	partial class HMI
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.swL = new NxtStudio.Symbols.Execute<bool>();
			this.ledSquare_11 = new NxtStudio.Symbols.LedSquare<bool>();
			// 
			// swL
			// 
			this.swL.BeginInit();
			this.swL.AngleIgnore = false;
			this.swL.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 4, 23);
			this.swL.IsOnlyInput = true;
			this.swL.Name = "swL";
			this.swL.TagName = "sensRead";
			this.swL.Value = false;
			this.swL.EndInit();
			// 
			// ledSquare_11
			// 
			this.ledSquare_11.BeginInit();
			this.ledSquare_11.AngleIgnore = false;
			this.ledSquare_11.ColorFrame = new NxtControl.Drawing.Color("Black");
			this.ledSquare_11.ColorOff = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.ledSquare_11.ColorOn = new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30)));
			this.ledSquare_11.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 2, 2, 3);
			this.ledSquare_11.Frame = 2;
			this.ledSquare_11.Name = "ledSquare_11";
			this.ledSquare_11.TagName = "sensRead";
			this.ledSquare_11.EndInit();
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.swL,
									this.ledSquare_11});
			this.SymbolSize = new System.Drawing.Size(115, 56);
		}
		private NxtStudio.Symbols.LedSquare<bool> ledSquare_11;
		private NxtStudio.Symbols.Execute<bool> swL;
		#endregion
	}
}
