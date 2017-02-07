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
using System.Management;
using System.IO;
using System.Threading;

namespace VBEBlock
{
	public partial class F_Thread
	{
        public List<string> F_Scrip = new List<string>();
        public List<uint> F_Scrip_ = new List<uint>();
        public List<string> F_Suspi = new List<string>();
        public List<uint> F_Suspi_ = new List<uint>();
        public List<string> F_Weird = new List<string>();
        public List<uint> F_Weird_ = new List<uint>();
        int F_SusOri = 0;
		bool _done = true;

        static readonly string _apos = new string(Strings.Chr(0x22), 1);
        private void _check()
		{
			_done = false;
			bool isChange = false;
			//Check Running Wscript
			var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Process WHERE Name = 'wscript.exe'");
			var zz = searcher.Get().Count;
			if (F_Scrip.Count != zz) {
                F_Scrip.Clear();
                F_Scrip_.Clear();
				isChange = true;
				foreach (ManagementObject queryObj in searcher.Get()) {
                    var exec = Strings.Replace((string)queryObj["ExecutablePath"], "'", _apos);
                    var cmd = Strings.Replace((string)queryObj["CommandLine"], exec, "");
                    var final = Strings.Replace(cmd, _apos, "");
                    F_Scrip.Add(Strings.Trim(final));
                    F_Scrip_.Add((uint)queryObj["ProcessId"]);
				}
			}
			//Check Suspicius Softwares
			searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Process");
			if (F_SusOri != searcher.Get().Count) {
                F_Suspi.Clear();
                F_Suspi_.Clear();
				isChange = true;
				F_SusOri = searcher.Get().Count;
				foreach (ManagementObject queryObj in searcher.Get()) {
					var y = Strings.Replace((string)queryObj["CommandLine"], "'", "");
                    var exec = Strings.Replace((string)queryObj["ExecutablePath"], "'", _apos);
                    if (!File.Exists(exec))
                        continue;
                    var file = new FileInfo(exec);
                    if ((file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) {
                        F_Suspi.Add(y);
                        F_Suspi_.Add((uint)queryObj["ProcessId"]);
       			}
       /*             if (file.DirectoryName == Path.GetTempPath())
                    {
                        F_Suspi.Add(y);
                        F_Suspi_.Add((uint)queryObj["ProcessId"]);
                    }*/

                    if (file.Extension.ToLower() != ".exe")
                    {
                        F_Weird.Add(y);
                        F_Weird_.Add((uint)queryObj["ProcessId"]);
                    }
                }
			}
			//Submit Summary
			if (isChange) {
				R.BeginUpdate();
				R.Items.Clear();
				var x = 0;
				foreach (string I in F_Scrip) {
                    var i = R.Items.Add(F_Scrip_[x].ToString());
                    i.SubItems.Add(I);
                    i.Group = R.Groups[0];
					i.Checked = true;
                    
					x += 1;
				}
				x = 0;
				foreach (string I in F_Suspi) {
                    var i = R.Items.Add(F_Suspi_[x].ToString());
                    i.SubItems.Add(I);
					i.Group = R.Groups[1];
					x += 1;
				}
                x = 0;
                foreach (string I in F_Weird)
                {
                    var i = R.Items.Add(F_Weird_[x].ToString());
                    i.SubItems.Add(I);
                    i.Group = R.Groups[1];
                    x += 1;
                }
                R.EndUpdate();
			}
			_done = true;
		}

		public void Check()
		{
			if (_done) {
				Thread th = new  Thread(new ThreadStart(_check));
				th.IsBackground = true;
				th.Start();
			}
		}

		private void B_Kill_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem I in R.CheckedItems) {
				Process.GetProcessById(int.Parse(I.Text)).Kill();
			}
		}
		public F_Thread()
		{
			InitializeComponent();
		}
	}
}
