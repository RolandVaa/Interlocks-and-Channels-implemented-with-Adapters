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

namespace HMI.Main.Symbols.HCylinder
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
			this.Label = new System.HMI.Symbols.Execute<string>();
			// 
			// poschanged
			// 
			this.poschanged.BeginInit();
			this.poschanged.AngleIgnore = false;
			this.poschanged.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 11, 151);
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
			this.labelName.Bounds = new NxtControl.Drawing.RectF(((float)(61)), ((float)(131)), ((float)(60)), ((float)(20)));
			this.labelName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.labelName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.labelName.Name = "labelName";
			this.labelName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.labelName.Text = "Name";
			this.labelName.TextColor = new NxtControl.Drawing.Color("Black");
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(163)), ((float)(79)), ((float)(15)), ((float)(29)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(28)), ((float)(85)), ((float)(136)), ((float)(16)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(15)), ((float)(60)), ((float)(13)), ((float)(65)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(166)), ((float)(75)), ((float)(9)), ((float)(42)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
									new NxtControl.Drawing.PointF(166, 110.53846153846155),
									new NxtControl.Drawing.PointF(166, 75),
									new NxtControl.Drawing.PointF(175, 75),
									new NxtControl.Drawing.PointF(175, 110.53846153846155),
									new NxtControl.Drawing.PointF(170.52662721893495, 117),
									new NxtControl.Drawing.PointF(166, 110.53846153846155),
									new NxtControl.Drawing.PointF(166, 110.53846153846155),
									new NxtControl.Drawing.PointF(166, 110.53846153846155),
									new NxtControl.Drawing.PointF(166, 110.53846153846155),
									new NxtControl.Drawing.PointF(166, 110.53846153846155)});
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(-2)), ((float)(53)), ((float)(158)), ((float)(76)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Radius = 10;
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(6)), ((float)(58.49395751953125)), ((float)(150)), ((float)(65.9277114868164)));
			this.roundedRectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.isMin.Bounds = new NxtControl.Drawing.RectF(((float)(4)), ((float)(58)), ((float)(9)), ((float)(65.9277114868164)));
			this.isMin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.isMax.Bounds = new NxtControl.Drawing.RectF(((float)(144)), ((float)(58)), ((float)(9)), ((float)(65.9277114868164)));
			this.isMax.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalBottom, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
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
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(8)), ((float)(3)), ((float)(0)), ((float)(51)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(82)), ((byte)(122)), ((byte)(174)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(8, 3),
									new NxtControl.Drawing.PointF(8, 54)});
			this.pipe1.Width = 8;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(151)), ((float)(3)), ((float)(0)), ((float)(51)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(82)), ((byte)(122)), ((byte)(174)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(151, 3),
									new NxtControl.Drawing.PointF(151, 54)});
			this.pipe2.Width = 8;
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 67, 165);
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
									this.Label});
			this.SymbolSize = new System.Drawing.Size(194, 152);
		}
		private System.HMI.Symbols.Execute<string> Label;
		
		private NxtStudio.Symbols.Execute<float> poschanged;
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

		#endregion
	}
}
