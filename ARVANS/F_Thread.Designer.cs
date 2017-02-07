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
	partial class F_Thread : System.Windows.Forms.UserControl
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
            System.Windows.Forms.ColumnHeader PID;
            System.Windows.Forms.ColumnHeader Path;
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Scripts", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Suspicious Programs", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Weird Extensions", System.Windows.Forms.HorizontalAlignment.Left);
            this.Label2 = new System.Windows.Forms.Label();
            this.B_Del = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.ListView();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B_Kill = new System.Windows.Forms.Button();
            PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PID
            // 
            PID.Text = "PID";
            PID.Width = 65;
            // 
            // Path
            // 
            Path.Text = "Alamat Aplikasi";
            Path.Width = 307;
            // 
            // Label2
            // 
            this.TableLayoutPanel1.SetColumnSpan(this.Label2, 2);
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(377, 43);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Cek Aplikasi mencurigakan yang masih berjalan di PC Anda";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_Del
            // 
            this.B_Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Del.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.B_Del.ForeColor = System.Drawing.Color.White;
            this.B_Del.Location = new System.Drawing.Point(194, 240);
            this.B_Del.Name = "B_Del";
            this.B_Del.Size = new System.Drawing.Size(186, 33);
            this.B_Del.TabIndex = 3;
            this.B_Del.Text = "Lenyapkan dan Hapus";
            this.B_Del.UseMnemonic = false;
            this.B_Del.UseVisualStyleBackColor = true;
            // 
            // R
            // 
            this.R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R.CheckBoxes = true;
            this.R.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            PID,
            Path});
            this.TableLayoutPanel1.SetColumnSpan(this.R, 2);
            this.R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R.FullRowSelect = true;
            this.R.GridLines = true;
            listViewGroup1.Header = "Scripts";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "ListViewGroup1";
            listViewGroup2.Header = "Suspicious Programs";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "ListViewGroup2";
            listViewGroup3.Header = "Weird Extensions";
            listViewGroup3.Name = "listViewGroup1";
            this.R.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.R.HideSelection = false;
            this.R.Location = new System.Drawing.Point(3, 46);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(377, 188);
            this.R.TabIndex = 5;
            this.R.UseCompatibleStateImageBehavior = false;
            this.R.View = System.Windows.Forms.View.Details;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.B_Kill, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.B_Del, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.R, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(383, 276);
            this.TableLayoutPanel1.TabIndex = 6;
            // 
            // B_Kill
            // 
            this.B_Kill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Kill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.B_Kill.ForeColor = System.Drawing.Color.White;
            this.B_Kill.Location = new System.Drawing.Point(3, 240);
            this.B_Kill.Name = "B_Kill";
            this.B_Kill.Size = new System.Drawing.Size(185, 33);
            this.B_Kill.TabIndex = 6;
            this.B_Kill.Text = "Lenyapkan";
            this.B_Kill.UseMnemonic = false;
            this.B_Kill.UseVisualStyleBackColor = true;
            // 
            // F_Thread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "F_Thread";
            this.Size = new System.Drawing.Size(383, 276);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button B_Del;
		internal System.Windows.Forms.ListView R;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		private System.Windows.Forms.Button B_Kill;
		/*internal System.Windows.Forms.Button B_Kill {
			get { return withEventsField_B_Kill; }
			set {
				if (withEventsField_B_Kill != null) {
					withEventsField_B_Kill.Click -= B_Kill_Click;
				}
				withEventsField_B_Kill = value;
				if (withEventsField_B_Kill != null) {
					withEventsField_B_Kill.Click += B_Kill_Click;
				}
			}
		}*/
	}
}
