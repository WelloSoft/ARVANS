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
	partial class Form1 : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
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
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		internal void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Acc = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TimHide = new System.Windows.Forms.Timer(this.components);
            this.CountHide = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMaliciousProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TentangVBEBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notif = new System.Windows.Forms.NotifyIcon(this.components);
            this.F_Thread = new VBEBlock.F_Thread();
            this.F_DevAdd = new VBEBlock.F_DevAdd();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Acc
            // 
            this.Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Acc.Location = new System.Drawing.Point(346, 3);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(51, 41);
            this.Acc.TabIndex = 1;
            this.Acc.Text = "X";
            this.Acc.UseMnemonic = false;
            this.Acc.UseVisualStyleBackColor = false;
            this.Acc.Click += new System.EventHandler(this.Acc_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(3, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(394, 44);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Device Added";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseDown);
            this.Label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            // 
            // TimHide
            // 
            this.TimHide.Interval = 20;
            this.TimHide.Tick += new System.EventHandler(this.TimHide_Tick);
            // 
            // CountHide
            // 
            this.CountHide.Enabled = true;
            this.CountHide.Interval = 1000;
            this.CountHide.Tick += new System.EventHandler(this.CountHide_Tick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMaliciousProgramsToolStripMenuItem,
            this.TentangVBEBlockToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(218, 70);
            // 
            // ShowMaliciousProgramsToolStripMenuItem
            // 
            this.ShowMaliciousProgramsToolStripMenuItem.Name = "ShowMaliciousProgramsToolStripMenuItem";
            this.ShowMaliciousProgramsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ShowMaliciousProgramsToolStripMenuItem.Text = "Cek Aplikasi Mencurigakan";
            this.ShowMaliciousProgramsToolStripMenuItem.Click += new System.EventHandler(this.ShowMaliciousProgramsToolStripMenuItem_Click);
            // 
            // TentangVBEBlockToolStripMenuItem
            // 
            this.TentangVBEBlockToolStripMenuItem.Name = "TentangVBEBlockToolStripMenuItem";
            this.TentangVBEBlockToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.TentangVBEBlockToolStripMenuItem.Text = "Tentang VBEBlock...";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ExitToolStripMenuItem.Text = "Keluar";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Notif
            // 
            this.Notif.ContextMenuStrip = this.ContextMenuStrip1;
            this.Notif.Icon = ((System.Drawing.Icon)(resources.GetObject("Notif.Icon")));
            this.Notif.Text = "Script Blocker";
            this.Notif.Visible = true;
            // 
            // F_Thread
            // 
            this.F_Thread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.F_Thread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F_Thread.Location = new System.Drawing.Point(3, 47);
            this.F_Thread.Name = "F_Thread";
            this.F_Thread.Size = new System.Drawing.Size(394, 250);
            this.F_Thread.TabIndex = 4;
            this.F_Thread.Visible = false;
            this.F_Thread.Load += new System.EventHandler(this.F_Thread_Load);
            // 
            // F_DevAdd
            // 
            this.F_DevAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.F_DevAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F_DevAdd.Location = new System.Drawing.Point(3, 47);
            this.F_DevAdd.Name = "F_DevAdd";
            this.F_DevAdd.Padding = new System.Windows.Forms.Padding(3);
            this.F_DevAdd.Size = new System.Drawing.Size(394, 250);
            this.F_DevAdd.TabIndex = 0;
            this.F_DevAdd.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.F_Thread);
            this.Controls.Add(this.F_DevAdd);
            this.Controls.Add(this.Acc);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.TopMost = true;
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal VBEBlock.F_DevAdd F_DevAdd;
		internal System.Windows.Forms.Button Acc;

		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Timer TimHide;
		internal System.Windows.Forms.Timer CountHide;
		internal VBEBlock.F_Thread F_Thread;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem ShowMaliciousProgramsToolStripMenuItem;
		/*internal System.Windows.Forms.ToolStripMenuItem ShowMaliciousProgramsToolStripMenuItem {
			get { return ShowMaliciousProgramsToolStripMenuItem; }
			set {
				if (ShowMaliciousProgramsToolStripMenuItem != null) {
					ShowMaliciousProgramsToolStripMenuItem.Click -= ShowMaliciousProgramsToolStripMenuItem_Click;
				}
				ShowMaliciousProgramsToolStripMenuItem = value;
				if (ShowMaliciousProgramsToolStripMenuItem != null) {
					ShowMaliciousProgramsToolStripMenuItem.Click += ShowMaliciousProgramsToolStripMenuItem_Click;
				}
			}
		}*/
		internal System.Windows.Forms.NotifyIcon Notif;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
	/*	internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem {
			get { return ExitToolStripMenuItem; }
			set {
				if (ExitToolStripMenuItem != null) {
					ExitToolStripMenuItem.Click -= ExitToolStripMenuItem_Click;
				}
				ExitToolStripMenuItem = value;
				if (ExitToolStripMenuItem != null) {
					ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
				}
			}
		}*/
		internal ToolStripMenuItem TentangVBEBlockToolStripMenuItem;
		public Form1()
		{
			Shown += Form1_Shown;
			Load += Form1_Load;
			InitializeComponent();
		}

        private System.ComponentModel.IContainer components;
    }
}
