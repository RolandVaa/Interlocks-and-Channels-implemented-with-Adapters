/*
 * Created by nxtSTUDIO.
 * User: vvya002
 * Date: 19/11/2012
 * Time: 3:47 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtStudio.Symbols;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.BUTTON
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
			this.LABEL = new NxtStudio.Symbols.Execute<string>();
			this.ENABLE = new NxtStudio.Symbols.Execute<bool>();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// LABEL
			// 
			this.LABEL.BeginInit();
			this.LABEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LABEL.IsOnlyInput = true;
			this.LABEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LABEL.Name = "LABEL";
			this.LABEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LABEL.TagName = "LABEL";
			this.LABEL.Value = null;
			this.LABEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LABELValueChanged);
			this.LABEL.EndInit();
			// 
			// ENABLE
			// 
			this.ENABLE.BeginInit();
			this.ENABLE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ENABLE.IsOnlyInput = true;
			this.ENABLE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ENABLE.Name = "ENABLE";
			this.ENABLE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ENABLE.TagName = "ENABLE";
			this.ENABLE.Value = false;
			this.ENABLE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ENABLEValueChanged);
			this.ENABLE.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(57D)), ((float)(100D)), ((float)(33D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("White");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.LABEL,
			this.ENABLE,
			this.drawnButton1});
			this.SymbolSize = new System.Drawing.Size(236, 141);

		}
		private NxtStudio.Symbols.Execute<bool> ENABLE;
		private NxtStudio.Symbols.Execute<string> LABEL;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		#endregion
	}
}
