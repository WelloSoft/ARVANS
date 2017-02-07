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
namespace VBEBlock.My
{

	// The following events are available for MyApplication:
	// 
	// Startup: Raised when the application starts, before the startup form is created.
	// Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	// UnhandledException: Raised if the application encounters an unhandled exception.
	// StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	// NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	internal partial class MyApplication
	{

		private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
		{
			e.ExitApplication = false;
			Interaction.MsgBox(e.Exception, MsgBoxStyle.Exclamation, "VBEBlock Error");
		}
	}


}

