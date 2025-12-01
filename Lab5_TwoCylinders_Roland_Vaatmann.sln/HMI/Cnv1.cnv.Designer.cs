/*
 * Created by EcoStruxure Automation Expert.
 * User: valeriy
 * Date: 8/2/2023
 * Time: 9:53 PM
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
	/// Summary description for Simple.
	/// </summary>
	partial class Cnv1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HCyl1 = new HMI.Main.Symbols.HCylAdpOL.sDefault();
			this.VCyl1 = new HMI.Main.Symbols.VCylAdpOL.sDefault();
			this.WP1 = new HMI.Main.Symbols.BUTTONAdp.sDefault();
			// 
			// HCyl1
			// 
			this.HCyl1.BeginInit();
			this.HCyl1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 76D, 297D);
			this.HCyl1.Name = "HCyl1";
			this.HCyl1.SecurityToken = ((uint)(4294967295u));
			this.HCyl1.TagName = "86A66C45689B494F";
			this.HCyl1.EndInit();
			// 
			// VCyl1
			// 
			this.VCyl1.BeginInit();
			this.VCyl1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 352D, 40D);
			this.VCyl1.Name = "VCyl1";
			this.VCyl1.SecurityToken = ((uint)(4294967295u));
			this.VCyl1.TagName = "6A8181B126980E0D";
			this.VCyl1.EndInit();
			// 
			// WP1
			// 
			this.WP1.BeginInit();
			this.WP1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 104D, 104D);
			this.WP1.Name = "WP1";
			this.WP1.SecurityToken = ((uint)(4294967295u));
			this.WP1.TagName = "27E6468E9DE95342";
			this.WP1.EndInit();
			// 
			// Cnv1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Cnv1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HCyl1,
			this.VCyl1,
			this.WP1});
			this.Size = new System.Drawing.Size(600, 520);

		}
		private HMI.Main.Symbols.HCylAdpOL.sDefault HCyl1;
		private HMI.Main.Symbols.VCylAdpOL.sDefault VCyl1;
		private HMI.Main.Symbols.BUTTONAdp.sDefault WP1;
		#endregion
	}
}
