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
using System.Runtime.InteropServices;

namespace VBEBlock
{

	public partial class Form1
	{
		//Used to detected if any of the messages are any of these constants values.
		private const int WM_DEVICECHANGE = 0x219;
		private const int DBT_DEVICEARRIVAL = 0x8000;
		private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
			//
		private const int DBT_DEVTYP_VOLUME = 0x2;
		//
		//Get the information about the detected volume.
		private struct DEV_BROADCAST_VOLUME
		{
			public int Dbcv_Size;
			public int Dbcv_Devicetype;
			public int Dbcv_Reserved;
			public int Dbcv_Unitmask;
			public short Dbcv_Flags;
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="M"></param>
		protected override void WndProc(ref Message M)
		{
			//
			//These are the required subclassing codes for detecting device based removal and arrival.
			//
			if (M.Msg == WM_DEVICECHANGE) {
                //Check if a device was added.
                if ((int)M.WParam == DBT_DEVICEARRIVAL)
                {
                    int DevType = Marshal.ReadInt32(M.LParam, 4);
                    //Check if a device is a volume.
                    if (DevType == DBT_DEVTYP_VOLUME)
                    {
                        var Vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(M.LParam, typeof(DEV_BROADCAST_VOLUME));
                        if (Vol.Dbcv_Flags == 0)
                        {
                            for (int i = 0; i <= 20; i++)
                            {
                                if (Math.Pow(2, i) == Vol.Dbcv_Unitmask)
                                {
                                    string Usb = Strings.Chr(65 + i) + ":\\";
                                    F_DevAdd.StartScan(new string(Strings.Chr(65 + i), 1));
                                    F_DevAdd.Visible = true;
                                    F_Thread.Visible = false;
                                    Location = new Point(SystemInformation.WorkingArea.Width - Width, SystemInformation.WorkingArea.Height - Height);
                                    Show();
                                    //       MsgBox("Looks like a USB device was plugged in!" & vbNewLine & vbNewLine & "The drive letter is: " & Usb.ToString)
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }
                        }
                    }
                }
                //
                //
                //Check if the message was for the removal of a device.
                //Case DBT_DEVICEREMOVECOMPLETE
                //    Dim DevType As Integer = Runtime.InteropServices.Marshal.ReadInt32(M.LParam, 4)
                //    if DevType = DBT_DEVTYP_VOLUME 
                //        Dim Vol As New DEV_BROADCAST_VOLUME
                //        Vol = Runtime.InteropServices.Marshal.PtrToStructure(M.LParam, GetType(DEV_BROADCAST_VOLUME))
                //        if Vol.Dbcv_Flags = 0 
                //            For i As Integer = 0 To 20
                //                if Math.Pow(2, i) = Vol.Dbcv_Unitmask 
                //                    Dim Usb As String = Chr(65 + i) + ":\"
                //                    MsgBox("Looks like a volume device was removed!" & vbNewLine & vbNewLine & "The drive letter is: " & Usb.ToString)
                //                    Exit For
                //                End if
                //            Next
                //        End if
                //    End if
            
			}
			base.WndProc(ref M);
		}


/*
		public static object WmiGetValue(string WMINamespace, string WMIClass, string Member, int Index = -1, string AddQuery = "")
		{
			try {
				ManagementObjectSearcher searcher = new ManagementObjectSearcher(WMINamespace, "SELECT " + Member + " FROM " + WMIClass + " " + AddQuery);
				var x = 0;
				//: searcher.Options.ReturnImmediately = True : searcher.Options.DirectRead = True
				if (Index != -1) {
					foreach (ManagementObject queryObj in searcher.Get()) {
						if (x == Index)
							return queryObj[Member];
						x += 1;
					}
				} else {
					return searcher.Get().OfType<;
				}
			} catch {
			}
			return null;
		}*/

		private void Form1_Load(object sender, EventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			Hide();
			VBEBlock.My.MyProject.Application.DoEvents();
			F_Thread.Check();
			if (F_Thread.F_Scrip.Count != 0 | F_Thread.F_Suspi.Count != 0) {
				F_DevAdd.Visible = false;
				F_Thread.Visible = true;
				Show();
			}
			Notif.ShowBalloonTip(10, "ARVANS sudah aktif", "Kami akan memantau terus Flashdisk yang terkontaminasi dan aplikasi yang mencurigakan", ToolTipIcon.Info);
		}

		private void Acc_Click(object sender, EventArgs e)
		{
			TimHide.Start();
		}

		private void TimHide_Tick(object sender, EventArgs e)
		{
            Opacity -= 0.05;
            if (Opacity <= 0) {
                Hide();
                Opacity = 1;
                TimHide.Stop();
            }
        }

        private void CountHide_Tick(object sender, EventArgs e)
		{
            if (F_DevAdd.Visible)
            {
                int outp;
                if (int.TryParse(Acc.Text, out outp))
                {
                    Acc.Text = (outp - 1).ToString();
                    if (outp == 1)
                    {
                        Acc.Text = "X";
                        TimHide.Start();
                    }
                }

            }
            else if (Visible)
                F_Thread.Check();
        }

        private void ShowMaliciousProgramsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			F_DevAdd.Visible = false;
			F_Thread.Visible = true;
			Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Label2_MouseDown(object sender, MouseEventArgs e)
		{
			Label2.Tag = new Point(e.X, e.Y);
		}

		private void Label2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) {
                var p = (Point)Label2.Tag;
				Left = Left + (e.X - p.X);
				Top = Top + (e.Y - p.Y);
			}
		}

        private void F_Thread_Load(object sender, EventArgs e)
        {

        }

    }
}
