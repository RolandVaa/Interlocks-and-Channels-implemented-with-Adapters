/*
 * Created by nxtStudio.
 * User: Horst Mayer
 * Date: 9/14/2008
 * Time: 12:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtStudio.Symbols;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Valve
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
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.label_11 = new NxtStudio.Symbols.Label<float>();
			this.slider_11 = new NxtStudio.Symbols.Slider<float>();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(15)), ((float)(15)), ((float)(20)), ((float)(30)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("White"), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Grey50"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(35, 15),
									new NxtControl.Drawing.PointF(25, 30),
									new NxtControl.Drawing.PointF(35, 45),
									new NxtControl.Drawing.PointF(15, 45),
									new NxtControl.Drawing.PointF(25, 30),
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(15, 15),
									new NxtControl.Drawing.PointF(15, 15)});
			this.polygon2.TextColor = new NxtControl.Drawing.Color("Black");
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(50, 30);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(25, 30);
			// 
			// label_11
			// 
			this.label_11.BeginInit();
			this.label_11.AngleIgnore = false;
			this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(194)), ((byte)(206)), ((byte)(218)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalLeftTop));
			this.label_11.DecimalPlacesCount = ((uint)(2u));
			this.label_11.FieldValue = "0.0";
			this.label_11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
			this.label_11.Name = "label_11";
			this.label_11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label_11.PrefixTag = null;
			this.label_11.Suffix = "%";
			this.label_11.SuffixTag = null;
			this.label_11.TagName = "value";
			this.label_11.TextColor = new NxtControl.Drawing.Color("Black");
			this.label_11.Transformation = new NxtControl.Drawing.Matrix(0.55, 0, 0, 1.25, 50, 19.999999999999996);
			this.label_11.EndInit();
			// 
			// slider_11
			// 
			this.slider_11.BeginInit();
			this.slider_11.AngleIgnore = false;
			this.slider_11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30)), ((byte)(255))));
			this.slider_11.Maximum = 100F;
			this.slider_11.Minimum = 0F;
			this.slider_11.Name = "slider_11";
			this.slider_11.TagName = "value";
			this.slider_11.Transformation = new NxtControl.Drawing.Matrix(0.16, 0, 0, 0.11153846153846155, 5, 16);
			this.slider_11.Value = 0F;
			this.slider_11.EndInit();
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.line1,
									this.polygon2,
									this.label_11,
									this.slider_11});
		}
		private NxtStudio.Symbols.Slider<float> slider_11;
		private NxtStudio.Symbols.Label<float> label_11;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line1;
		#endregion
	}
}
