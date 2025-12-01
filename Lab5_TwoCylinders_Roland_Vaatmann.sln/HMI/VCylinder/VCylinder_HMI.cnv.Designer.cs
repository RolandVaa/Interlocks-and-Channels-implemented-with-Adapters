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

namespace HMI.Main.Symbols.VCylinder
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
			this.poschanged = new NxtStudio.Symbols.Execute<float>();
			this.labelName = new NxtControl.GuiFramework.Label();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.isMin = new NxtControl.GuiFramework.RoundedRectangle();
			this.isMax = new NxtControl.GuiFramework.RoundedRectangle();
			this.grpInnerPart = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.Label = new System.HMI.Symbols.Execute<string>();
			// 
			// poschanged
			// 
			this.poschanged.BeginInit();
			this.poschanged.AngleIgnore = false;
			this.poschanged.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 31, 65);
			this.poschanged.IsOnlyInput = true;
			this.poschanged.Name = "poschanged";
			this.poschanged.TagName = "pos";
			this.poschanged.Value = 0F;
			this.poschanged.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PoschangeValueChanged);
			this.poschanged.EndInit();
			// 
			// labelName
			// 
			this.labelName.AngleIgnore = true;
			this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.labelName.Bounds = new NxtControl.Drawing.RectF(((float)(65)), ((float)(260)), ((float)(60)), ((float)(20)));
			this.labelName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.labelName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.labelName.Name = "labelName";
			this.labelName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.labelName.Text = "Name";
			this.labelName.TextColor = new NxtControl.Drawing.Color("Black");
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(24)), ((float)(262)), ((float)(29)), ((float)(15)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(150)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)))}, new float[] {
															0F,
															0.48F,
															1F})));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(31)), ((float)(127)), ((float)(16)), ((float)(136)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(150)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)))}, new float[] {
															0F,
															0.48F,
															1F})));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.rectangle1.ShadowOffSet = 2;
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(7)), ((float)(114)), ((float)(65)), ((float)(13)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(150)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)))}, new float[] {
															0F,
															0.48F,
															1F})));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			this.rectangle7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.rectangle7.ShadowOffSet = 2;
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(15)), ((float)(265)), ((float)(42)), ((float)(9)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))),
															new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))),
															new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))),
															new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))),
															new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)))}, new float[] {
															0F,
															0.25F,
															0.5F,
															0.74F,
															1F})));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(21, 265),
									new NxtControl.Drawing.PointF(57, 265),
									new NxtControl.Drawing.PointF(57, 274),
									new NxtControl.Drawing.PointF(21, 274),
									new NxtControl.Drawing.PointF(15, 270),
									new NxtControl.Drawing.PointF(21, 265),
									new NxtControl.Drawing.PointF(21, 265),
									new NxtControl.Drawing.PointF(21, 265),
									new NxtControl.Drawing.PointF(21, 265),
									new NxtControl.Drawing.PointF(21, 265)});
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(1)), ((float)(99)), ((float)(76)), ((float)(158)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Radius = 10;
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(6)), ((float)(107)), ((float)(65.9277114868164)), ((float)(150)));
			this.roundedRectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))),
															new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))),
															new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))),
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)))}, new float[] {
															0F,
															0.24F,
															0.51F,
															0.76F,
															1F})));
			this.roundedRectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle4.Name = "roundedRectangle4";
			this.roundedRectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.roundedRectangle4.Radius = 7;
			// 
			// isMin
			// 
			this.isMin.Bounds = new NxtControl.Drawing.RectF(((float)(6)), ((float)(105)), ((float)(65.9277114868164)), ((float)(9)));
			this.isMin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))),
															new NxtControl.Drawing.Color(((byte)(178)), ((byte)(14)), ((byte)(18))),
															new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))),
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)))}, new float[] {
															0F,
															0.24F,
															0.51F,
															0.76F,
															1F})));
			this.isMin.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.isMin.Name = "isMin";
			this.isMin.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.isMin.Radius = 7;
			this.isMin.Visible = false;
			// 
			// isMax
			// 
			this.isMax.Bounds = new NxtControl.Drawing.RectF(((float)(6)), ((float)(245)), ((float)(65.9277114868164)), ((float)(9)));
			this.isMax.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalLeft, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))),
															new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))),
															new NxtControl.Drawing.Color(((byte)(178)), ((byte)(14)), ((byte)(18))),
															new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))),
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)))}, new float[] {
															0F,
															0.24F,
															0.51F,
															0.76F,
															1F})));
			this.isMax.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.isMax.Name = "isMax";
			this.isMax.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.isMax.Radius = 7;
			this.isMax.Visible = false;
			// 
			// grpInnerPart
			// 
			this.grpInnerPart.BeginInit();
			this.grpInnerPart.Name = "grpInnerPart";
			this.grpInnerPart.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle7,
									this.rectangle1,
									this.rectangle4,
									this.polygon3});
			this.grpInnerPart.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.roundedRectangle3,
									this.roundedRectangle4,
									this.isMin,
									this.isMax});
			this.group2.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(26)), ((float)(39)), ((float)(0)), ((float)(56)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(82)), ((byte)(122)), ((byte)(174)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(26, 39),
									new NxtControl.Drawing.PointF(26, 95)});
			this.pipe1.Width = 8;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(136)), ((float)(40)), ((float)(0)), ((float)(211)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(82)), ((byte)(122)), ((byte)(174)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(136, 40),
									new NxtControl.Drawing.PointF(136, 251)});
			this.pipe2.Width = 8;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(77)), ((float)(252)), ((float)(60)), ((float)(0)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(82)), ((byte)(122)), ((byte)(174)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(137, 252),
									new NxtControl.Drawing.PointF(77, 252)});
			this.pipe3.Width = 8;
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 20, 283);
			this.Label.IsOnlyInput = true;
			this.Label.Name = "Label";
			this.Label.TagName = "Label";
			this.Label.Value = null;
			this.Label.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LabelValueChanged);
			this.Label.EndInit();
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.pipe1,
									this.pipe2,
									this.poschanged,
									this.labelName,
									this.group2,
									this.grpInnerPart,
									this.pipe3,
									this.Label});
			this.SymbolSize = new System.Drawing.Size(161, 437);
			}
		private System.HMI.Symbols.Execute<string> Label;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Group grpInnerPart;
		private NxtControl.GuiFramework.RoundedRectangle isMax;
		private NxtControl.GuiFramework.RoundedRectangle isMin;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle4;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Label labelName;
		private NxtStudio.Symbols.Execute<float> poschanged;
		#endregion
	}
}
