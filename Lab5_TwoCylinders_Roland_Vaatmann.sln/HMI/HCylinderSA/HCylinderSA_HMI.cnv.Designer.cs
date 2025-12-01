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

namespace HMI.Main.Symbols.HCylinderSA
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
			this.LeftSns = new Symbols.Sensor.HMI();
			this.RightSns = new Symbols.Sensor.HMI();
			this.Cylinder = new Symbols.HCylinder.HMI();
			this.ValvePop = new Symbols.Valve.HMI();
			this.ValvePush = new Symbols.Valve.HMI();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// LeftSns
			// 
			this.LeftSns.BeginInit();
			this.LeftSns.AngleIgnore = false;
			this.LeftSns.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 32, 172);
			this.LeftSns.Name = "LeftSns";
			this.LeftSns.SecurityToken = ((uint)(4294967295u));
			this.LeftSns.TagName = "LeftSns";
			this.LeftSns.EndInit();
			// 
			// RightSns
			// 
			this.RightSns.BeginInit();
			this.RightSns.AngleIgnore = false;
			this.RightSns.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 154, 172);
			this.RightSns.Name = "RightSns";
			this.RightSns.SecurityToken = ((uint)(4294967295u));
			this.RightSns.TagName = "RightSns";
			this.RightSns.EndInit();
			// 
			// Cylinder
			// 
			this.Cylinder.BeginInit();
			this.Cylinder.AngleIgnore = false;
			this.Cylinder.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 18, 40);
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
			this.ValvePop.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 153, 12);
			this.ValvePop.Name = "ValvePop";
			this.ValvePop.SecurityToken = ((uint)(4294967295u));
			this.ValvePop.TagName = "ValvePop";
			this.ValvePop.EndInit();
			// 
			// ValvePush
			// 
			this.ValvePush.BeginInit();
			this.ValvePush.AngleIgnore = false;
			this.ValvePush.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 7, 11);
			this.ValvePush.Name = "ValvePush";
			this.ValvePush.SecurityToken = ((uint)(4294967295u));
			this.ValvePush.TagName = "ValvePush";
			this.ValvePush.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(3)), ((float)(3)), ((float)(257)), ((float)(199)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush();
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Dash);
			// 
			// HMI
			// 
			this.Name = "HMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.LeftSns,
									this.RightSns,
									this.Cylinder,
									this.ValvePop,
									this.ValvePush,
									this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(266, 214);
			}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private Symbols.Valve.HMI ValvePush;
		private Symbols.Valve.HMI ValvePop;
		private Symbols.HCylinder.HMI Cylinder;
		private Symbols.Sensor.HMI RightSns;
		private Symbols.Sensor.HMI LeftSns;
		#endregion
	}
}
