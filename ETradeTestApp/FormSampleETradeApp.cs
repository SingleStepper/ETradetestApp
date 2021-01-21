using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using OAuth;

namespace ETradeTestApp {
	/// <summary>
	/// TestApp for ETrade OAuth
	/// Author: Greg Moress
	/// OAuth.cs from Dino Chiesa
	/// 
	/// Designed to be a simple way to explore basic functions
	/// </summary>
	public partial class FormSampleETradeApp:Form {
		public FormSampleETradeApp() {
			InitializeComponent();

			AddtextBox(this.textBoxConsumerKey);
			AddtextBox(this.textBoxConsumerSecret);
			AddtextBox(this.textBoxSandboxKey);
			AddtextBox(this.textBoxSandBoxSecret);
		}

		private void buttonRequestTokenAndPin_Click(object sender, EventArgs e) {
			try {
				string url;
				string key, secret;
				if(this.comboBoxTarget.SelectedIndex==1) {
					key=textBoxConsumerKey.Text;
					secret=textBoxConsumerSecret.Text;
					url="https://api.etrade.com/";
				} else {
					key=textBoxSandboxKey.Text;
					secret=textBoxSandBoxSecret.Text;
					url="https://apisb.etrade.com/";
				}

				Manager manager = new Manager();
				manager["consumer_key"]=key;
				manager["consumer_secret"]=secret;
				OAuthResponse requestToken =
					manager.AcquireRequestToken(url+"oauth/request_token", "POST");


				textBoxResponse.Text="Request Token succeeded"+Environment.NewLine;
				// +requestToken.AllText; // <- shows the response

				string responseToken=requestToken["oauth_token"];
				string responseSecret=requestToken["oauth_token_secret"];

				string authorizeURL = "https://us.etrade.com/e/t/etws/authorize?key="+
					manager["consumer_key"]+"&token="+requestToken["oauth_token"];

				System.Diagnostics.Process.Start(authorizeURL);

				FormGetVerifyKey form = new FormGetVerifyKey();
				if( form.ShowDialog()==DialogResult.OK) {
					string pin = form.Pin;
					manager = new Manager();
					manager["consumer_key"]=key;
					manager["consumer_secret"]=secret;
					manager["token"]=responseToken;
					manager["token_secret"]=responseSecret;

					// Now get access token
					string URL_ACCESS_TOKEN = url+"oauth/access_token";
					string sentHeader="";
					try {
						var responseAuth = manager.AcquireAccessToken(URL_ACCESS_TOKEN,
										 "POST", pin, out sentHeader);

						textBoxResponse.Text=responseAuth.AllText;
					} catch(Exception ex) {
						textBoxResponse.Text+=Environment.NewLine+"Get Access Token Failed";
						textBoxResponse.Text+=Environment.NewLine+"Sent: "+sentHeader+Environment.NewLine;
						textBoxResponse.Text+=Environment.NewLine+"Exception"+Environment.NewLine+ex.Message;
						return;
					}
				}

			} catch(Exception ex) {				
				textBoxResponse.Text="Exception"+Environment.NewLine+ex.Message;
				return;
			}
		}

		#region ______________________ Persistence ___________________________

		Dictionary<string, TextBox> textBoxes = new Dictionary<string, TextBox>();

		void AddtextBox(TextBox textbox) {
			textBoxes.Add(textbox.Name, textbox);
		}
	
		string fileName = "WebChat.txt";

		private void Form1_Load(object sender, EventArgs e) {
			if(File.Exists(fileName)) {
				var lines = File.ReadAllLines(fileName);

				foreach(var line in lines) {
					int eqAt = line.IndexOf('=');
					string name = line.Substring(0, eqAt);
					string val = line.Substring(eqAt+1);

					switch(name) {
						case "TargetIndex":
							comboBoxTarget.SelectedIndex=int.Parse(val);
							break;
						default:
							TextBox tb;
							if( textBoxes.TryGetValue(name, out tb)) {
								tb.Text=val;
							}
							break;
					}

				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			// Save state
			using(var writer = File.CreateText(fileName)) {
				writer.WriteLine("TargetIndex="+comboBoxTarget.SelectedIndex.ToString());
				foreach(var pair in textBoxes) {
					if(pair.Value.Text.Length>0) {
						writer.WriteLine(pair.Key+'='+ pair.Value.Text);
					}
				}
			}
		}

		#endregion ______________________ Persistence ___________________________
	}
}
