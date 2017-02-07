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
using System.IO;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace VBEBlock
{
	public partial class F_DevAdd
	{
        public List<string> F_Hide = new List<string>();
        public List<string> F_Short = new List<string>();
        public List<string> F_Scrip = new List<string>();
        public List<string> F_Auto = new List<string>();

        const FileAttributes HiddenAndSystem = FileAttributes.Hidden & FileAttributes.System;

		public void StartScan(string dev)
		{
            F_Auto.Clear();
            F_Hide.Clear();
            F_Scrip.Clear();
            F_Short.Clear();
			var x = new DriveInfo(dev);
			//Search Hiding Folders
			foreach (DirectoryInfo i in x.RootDirectory.GetDirectories()) {
                var attrib = i.Attributes;
				if ((attrib & HiddenAndSystem) == HiddenAndSystem) {
					if (i.Name != "System Volume Information" & i.Name != "$RECYCLE.BIN") 
                        F_Hide.Add(i.FullName);
				}
			}
			foreach (FileInfo i in x.RootDirectory.GetFiles()) {
                var attrib = i.Attributes;
                if ((attrib & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    F_Hide.Add(i.FullName);
				}
			}
			//Search Shortcuts
			foreach (FileInfo i in x.RootDirectory.GetFiles("*.lnk")) {
                F_Short.Add(i.FullName);
			}
			//Search Scripts
			foreach (FileInfo i in x.RootDirectory.GetFiles("*.vbe")) {
                F_Scrip.Add(i.FullName);
            }
            foreach (FileInfo i in x.RootDirectory.GetFiles("*.vbs")) {
                F_Scrip.Add(i.FullName);
            }
            //Search Autorun
            foreach (FileInfo i in x.RootDirectory.GetFiles("autorun.inf")) {
                F_Auto.Add(i.FullName);
			}

			//Report Summary
			I_Auto.Text = string.Format("{0} Autorun",  F_Auto.Count);
			I_Scrip.Text = string.Format("{0} Script", F_Scrip.Count);
			I_Short.Text = string.Format("{0} Shortcuts", F_Short.Count);
            I_Hide.Text = string.Format("{0} Folder Tersembunyi", F_Hide.Count);
			if (F_Hide.Count == 0 && F_Short.Count == 0 && F_Scrip.Count == 0 && F_Auto.Count == 0) {
				I_Stat.Text = "Flashdisk sudah bersih.";
				Acc.Enabled = false;
				((Form1)ParentForm).Acc.Text = "5";

			} else {
				I_Stat.Text = "Beberapa data Flashdisk terdeteksi mencurigakan. Bersihkan sekarang?";
				Acc.Enabled = true;
			}
		}

		private void Acc_Click(object sender, EventArgs e)
		{
			//Fixing
			I_Stat.Text = "Membersihkan...";
			Acc.Enabled = false;
			VBEBlock.My.MyProject.Application.DoEvents();
			var x = 0;
			foreach (string i_loopVariable in F_Hide) {
                try {
					File.SetAttributes(i_loopVariable, FileAttributes.Normal);
					x += 1;
					I_Hide.Text = F_Hide.Count - x + " Folder Tersembunyi";
					My.MyProject.Application.DoEvents();
				} catch {
				}
			}
			x = 0;
			foreach (string i_loopVariable in F_Short) {
              try {
					File.Delete(i_loopVariable);
					x += 1;
					I_Short.Text = F_Short.Count - x + " Shortcuts";
					VBEBlock.My.MyProject.Application.DoEvents();
				} catch {
				}
			}
			x = 0;
			foreach (string i_loopVariable in F_Scrip) {
				try {
					File.Delete(i_loopVariable);
					x += 1;
					I_Scrip.Text = F_Scrip.Count - x + " Scripts";
					VBEBlock.My.MyProject.Application.DoEvents();
				} catch {
				}
			}
			x = 0;
			foreach (string i_loopVariable in F_Auto) {
				try {
					File.Delete(i_loopVariable);
					x += 1;
					I_Auto.Text = F_Auto.Count - x + " Autoruns";
					VBEBlock.My.MyProject.Application.DoEvents();
				} catch {
				}
			}
			I_Stat.Text = "Selesai...";
			((Form1)ParentForm).Acc.Text = "5";
		}
	}
}
