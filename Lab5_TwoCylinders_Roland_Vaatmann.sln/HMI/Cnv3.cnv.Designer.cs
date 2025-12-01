/*
 * Created by EcoStruxure Automation Expert.
 * User: valeriy
 * Date: 8/2/2023
 * Time: 9:54 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Channel.
	/// </summary>
	partial class Cnv3
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HCyl3 = new HMI.Main.Symbols.HCylAdpOL.sDefault();
			this.VCyl3 = new HMI.Main.Symbols.VCylAdpOL.sDefault();
			this.WP6 = new HMI.Main.Symbols.BUTTONAdp.sDefault();
			// 
			// HCyl3
			// 
			this.HCyl3.BeginInit();
			this.HCyl3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 264D);
			this.HCyl3.Name = "HCyl3";
			this.HCyl3.SecurityToken = ((uint)(4294967295u));
			this.HCyl3.TagName = "E096A192671D79E9";
			this.HCyl3.EndInit();
			// 
			// VCyl3
			// 
			this.VCyl3.BeginInit();
			this.VCyl3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 352D, 32D);
			this.VCyl3.Name = "VCyl3";
			this.VCyl3.SecurityToken = ((uint)(4294967295u));
			this.VCyl3.TagName = "A42B032A2EB4C57F";
			this.VCyl3.EndInit();
			// 
			// WP6
			// 
			this.WP6.BeginInit();
			this.WP6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 136D);
			this.WP6.Name = "WP6";
			this.WP6.SecurityToken = ((uint)(4294967295u));
			this.WP6.TagName = "1BA591F7D0836B60";
			this.WP6.EndInit();
			// 
			// Cnv3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Cnv3";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HCyl3,
			this.VCyl3,
			this.WP6});
			this.Size = new System.Drawing.Size(600, 520);

		}
		private HMI.Main.Symbols.HCylAdpOL.sDefault HCyl3;
		private HMI.Main.Symbols.VCylAdpOL.sDefault VCyl3;
		private HMI.Main.Symbols.BUTTONAdp.sDefault WP6;
		#endregion
	}
}
