/*
 * Created by nxtStudio.
 * User: Horst Mayer
 * Date: 9/14/2008
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Controllers.VCylinderSA
{
	/// <summary>
	/// Summary description for FacePlate01.
	/// </summary>
	partial class FacePlate01
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelName = new NxtControl.GuiFramework.Label();
			this.labelPv = new NxtStudio.Symbols.Label<float>();
			this.trend1 = new NxtControl.GuiFramework.Trend();
			((System.ComponentModel.ISupportInitialize)(this.trend1)).BeginInit();
			// 
			// labelName
			// 
			this.labelName.AngleIgnore = true;
			this.labelName.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(415)), ((float)(20)));
			this.labelName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(212)), ((byte)(208)), ((byte)(200)), ((byte)(255))));
			this.labelName.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.labelName.Name = "labelName";
			this.labelName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.labelName.Text = "        Loop Name";
			this.labelName.TextColor = new NxtControl.Drawing.Color("Black");
			// 
			// labelPv
			// 
			this.labelPv.BeginInit();
			this.labelPv.AngleIgnore = false;
			this.labelPv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelPv.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.labelPv.DecimalPlacesCount = ((uint)(2u));
			this.labelPv.FieldValue = "999.9";
			this.labelPv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.labelPv.Name = "labelPv";
			this.labelPv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.labelPv.PrefixTag = null;
			this.labelPv.Suffix = "°C";
			this.labelPv.SuffixTag = null;
			this.labelPv.TagName = "pv";
			this.labelPv.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(255)));
			this.labelPv.Transformation = new NxtControl.Drawing.Matrix(0.59090909090909094, 0, 0, 1, 135, 20);
			this.labelPv.EndInit();
			// 
			// trend1
			// 
			this.trend1.Location = new System.Drawing.Point(0, 20);
			this.trend1.Name = "trend1";
			this.trend1.ParentSymbol = this;
			this.trend1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("pos", new NxtControl.Drawing.Color(((byte)(202)), ((byte)(114)), ((byte)(110)), ((byte)(255))), false, 0, 100, "Left"));
			this.trend1.Size = new System.Drawing.Size(415, 205);
			this.trend1.TabIndex = 0;
			this.trend1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm:ss", false, true);
			this.trend1.TimeSpan = System.TimeSpan.Parse("00:05:00");
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0, 1784.814587498696, true, "", 0, 100));
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0, 0, false, "", 0, 100));
			this.trend1.ZoomPercentX = 10;
			this.trend1.ZoomPercentY = 10;
			// 
			// FacePlate01
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(415)), ((float)(225)));
			this.Name = "FacePlate01";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.labelName,
									this.trend1,
									this.labelPv});
			this.Size = new System.Drawing.Size(415, 225);
			((System.ComponentModel.ISupportInitialize)(this.trend1)).EndInit();
		}
		private NxtControl.GuiFramework.Trend trend1;
		private NxtStudio.Symbols.Label<float> labelPv;
		private NxtControl.GuiFramework.Label labelName;
		#endregion
	}
}
