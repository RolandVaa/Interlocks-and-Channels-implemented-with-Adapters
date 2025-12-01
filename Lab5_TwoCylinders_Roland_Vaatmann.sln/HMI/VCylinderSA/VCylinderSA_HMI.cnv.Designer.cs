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

namespace HMI.Main.Symbols.VCylinderSA
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
			this.TopS = new Symbols.Sensor.HMI();
			this.BottomS = new Symbols.Sensor.HMI();
			this.Cylinder = new Symbols.VCylinder.HMI();
			this.ValvePop = new Symbols.Valve.HMI();
			this.ValvePush = new Symbols.Valve.HMI();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// TopS
			// 
			this.TopS.BeginInit();
			this.TopS.AngleIgnore = false;
			this.TopS.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 80, 114);
			this.TopS.Name = "TopS";
			this.TopS.SecurityToken = ((uint)(4294967295u));
			this.TopS.TagName = "TopS";
			this.TopS.EndInit();
			// 
			// BottomS
			// 
			this.BottomS.BeginInit();
			this.BottomS.AngleIgnore = false;
			this.BottomS.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 80, 227);
			this.BottomS.Name = "BottomS";
			this.BottomS.SecurityToken = ((uint)(4294967295u));
			this.BottomS.TagName = "BottomS";
			this.BottomS.EndInit();
			// 
			// Cylinder
			// 
			this.Cylinder.BeginInit();
			this.Cylinder.AngleIgnore = false;
			this.Cylinder.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 0, 39);
			this.Cylinder.LabelName = "Name";
			this.Cylinder.Name = "Cylinder";
			this.Cylinder.SecurityToken = ((uint)(4294967295u));
			this.Cylinder.TagName = "Cylinder";
			this.Cylinder.EndInit();
			// 
			// ValvePop
			// 
			this.ValvePop.BeginInit();
			this.ValvePop.AngleIgnore = false;
			this.ValvePop.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 118, 10);
			this.ValvePop.Name = "ValvePop";
			this.ValvePop.SecurityToken = ((uint)(4294967295u));
			this.ValvePop.TagName = "ValvePop";
			this.ValvePop.EndInit();
			// 
			// ValvePush
			// 
			this.ValvePush.BeginInit();
			this.ValvePush.AngleIgnore = false;
			this.ValvePush.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 5, 10);
			this.ValvePush.Name = "ValvePush";
			this.ValvePush.SecurityToken = ((uint)(4294967295u));
			this.ValvePush.TagName = "ValvePush";
			this.ValvePush.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(1)), ((float)(5)), ((float)(223)), ((float)(283)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush();
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Dash);
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.TopS,
									this.BottomS,
									this.Cylinder,
									this.ValvePop,
									this.ValvePush,
									this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(228, 441);
			}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private Symbols.Valve.HMI ValvePush;
		private Symbols.Valve.HMI ValvePop;
		private Symbols.VCylinder.HMI Cylinder;
		private Symbols.Sensor.HMI BottomS;
		private Symbols.Sensor.HMI TopS;
		#endregion
	}
}
