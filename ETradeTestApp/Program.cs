using System;
using System.Windows.Forms;

namespace ETradeTestApp {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FormSampleETradeApp());
			Application.Run(new FormAmeriTrade());
		}
	}
}
