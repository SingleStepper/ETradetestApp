using System;
using System.Windows.Forms;

namespace ETradeTestApp {
	public partial class FormGetVerifyKey:Form {
		public FormGetVerifyKey() {
			InitializeComponent();
		}

		public string Pin {
			get {
				return textBoxPin.Text;
			}
		}
	}
}
