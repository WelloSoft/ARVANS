using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace VBEBlock
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class F_DevAdd : System.Windows.Forms.UserControl
	{

		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.Acc = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Label2 = new System.Windows.Forms.Label();
			this.I_Hide = new System.Windows.Forms.CheckBox();
			this.I_Short = new System.Windows.Forms.CheckBox();
			this.I_Scrip = new System.Windows.Forms.CheckBox();
			this.I_Auto = new System.Windows.Forms.CheckBox();
			this.I_Stat = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Acc
			//
			this.TableLayoutPanel1.SetColumnSpan(this.Acc, 2);
			this.Acc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Acc.Font = new System.Drawing.Font("Segoe UI", 12f);
			this.Acc.ForeColor = System.Drawing.Color.White;
			this.Acc.Location = new System.Drawing.Point(3, 236);
			this.Acc.Name = "Acc";
			this.Acc.Size = new System.Drawing.Size(322, 41);
			this.Acc.TabIndex = 0;
			this.Acc.Text = "Hapus & Perbaiki";
			this.Acc.UseMnemonic = false;
			this.Acc.UseVisualStyleBackColor = true;
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Acc, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.I_Hide, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.I_Short, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.I_Scrip, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.I_Auto, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.I_Stat, 0, 3);
			this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(328, 280);
			this.TableLayoutPanel1.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.Label2, 2);
			this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label2.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(3, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(322, 38);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Scan Selesai, kami menemukan :";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//I_Hide
			//
			this.I_Hide.AutoSize = true;
			this.I_Hide.Checked = true;
			this.I_Hide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.I_Hide.Dock = System.Windows.Forms.DockStyle.Fill;
			this.I_Hide.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.I_Hide.ForeColor = System.Drawing.Color.White;
			this.I_Hide.Location = new System.Drawing.Point(3, 41);
			this.I_Hide.Name = "I_Hide";
			this.I_Hide.Size = new System.Drawing.Size(158, 72);
			this.I_Hide.TabIndex = 3;
			this.I_Hide.Text = "0 Folder Tersembunyi";
			//
			//I_Short
			//
			this.I_Short.AutoSize = true;
			this.I_Short.Checked = true;
			this.I_Short.CheckState = System.Windows.Forms.CheckState.Checked;
			this.I_Short.Dock = System.Windows.Forms.DockStyle.Fill;
			this.I_Short.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.I_Short.ForeColor = System.Drawing.Color.White;
			this.I_Short.Location = new System.Drawing.Point(167, 41);
			this.I_Short.Name = "I_Short";
			this.I_Short.Size = new System.Drawing.Size(158, 72);
			this.I_Short.TabIndex = 4;
			this.I_Short.Text = "0 Shortcuts";
			//
			//I_Scrip
			//
			this.I_Scrip.AutoSize = true;
			this.I_Scrip.Checked = true;
			this.I_Scrip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.I_Scrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.I_Scrip.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.I_Scrip.ForeColor = System.Drawing.Color.White;
			this.I_Scrip.Location = new System.Drawing.Point(3, 119);
			this.I_Scrip.Name = "I_Scrip";
			this.I_Scrip.Size = new System.Drawing.Size(158, 72);
			this.I_Scrip.TabIndex = 5;
			this.I_Scrip.Text = "0 Scripts";
			//
			//I_Auto
			//
			this.I_Auto.AutoSize = true;
			this.I_Auto.Checked = true;
			this.I_Auto.CheckState = System.Windows.Forms.CheckState.Checked;
			this.I_Auto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.I_Auto.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.I_Auto.ForeColor = System.Drawing.Color.White;
			this.I_Auto.Location = new System.Drawing.Point(167, 119);
			this.I_Auto.Name = "I_Auto";
			this.I_Auto.Size = new System.Drawing.Size(158, 72);
			this.I_Auto.TabIndex = 6;
			this.I_Auto.Text = "0 Autorun";
			//
			//I_Stat
			//
			this.I_Stat.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.I_Stat, 2);
			this.I_Stat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.I_Stat.Font = new System.Drawing.Font("Segoe UI", 10f);
			this.I_Stat.ForeColor = System.Drawing.Color.White;
			this.I_Stat.Location = new System.Drawing.Point(3, 194);
			this.I_Stat.Name = "I_Stat";
			this.I_Stat.Size = new System.Drawing.Size(322, 39);
			this.I_Stat.TabIndex = 7;
			this.I_Stat.Text = "Status";
			this.I_Stat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//F_DevAdd
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(40)), Convert.ToInt32(Convert.ToByte(40)), Convert.ToInt32(Convert.ToByte(40)));
			this.Controls.Add(this.TableLayoutPanel1);
			this.Name = "F_DevAdd";
			this.Size = new System.Drawing.Size(328, 280);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button withEventsField_Acc;
		internal System.Windows.Forms.Button Acc {
			get { return withEventsField_Acc; }
			set {
				if (withEventsField_Acc != null) {
					withEventsField_Acc.Click -= Acc_Click;
				}
				withEventsField_Acc = value;
				if (withEventsField_Acc != null) {
					withEventsField_Acc.Click += Acc_Click;
				}
			}
		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.CheckBox I_Hide;
		internal System.Windows.Forms.CheckBox I_Short;
		internal System.Windows.Forms.CheckBox I_Scrip;
		internal System.Windows.Forms.CheckBox I_Auto;

		internal System.Windows.Forms.Label I_Stat;
		public F_DevAdd()
		{
			InitializeComponent();
		}
	}
}
