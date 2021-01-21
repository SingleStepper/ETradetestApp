
namespace ETradeTestApp {
	partial class FormSampleETradeApp {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.buttonRequestToken = new System.Windows.Forms.Button();
			this.textBoxResponse = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxTarget = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSandboxKey = new System.Windows.Forms.TextBox();
			this.textBoxSandBoxSecret = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxConsumerSecret = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxConsumerKey = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonRequestToken
			// 
			this.buttonRequestToken.Location = new System.Drawing.Point(256, 29);
			this.buttonRequestToken.Name = "buttonRequestToken";
			this.buttonRequestToken.Size = new System.Drawing.Size(91, 26);
			this.buttonRequestToken.TabIndex = 0;
			this.buttonRequestToken.Text = "Request Token";
			this.buttonRequestToken.UseVisualStyleBackColor = true;
			this.buttonRequestToken.Click += new System.EventHandler(this.buttonRequestTokenAndPin_Click);
			// 
			// textBoxResponse
			// 
			this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResponse.Location = new System.Drawing.Point(15, 189);
			this.textBoxResponse.Multiline = true;
			this.textBoxResponse.Name = "textBoxResponse";
			this.textBoxResponse.Size = new System.Drawing.Size(526, 234);
			this.textBoxResponse.TabIndex = 9;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(553, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As...";
			// 
			// comboBoxTarget
			// 
			this.comboBoxTarget.FormattingEnabled = true;
			this.comboBoxTarget.Items.AddRange(new object[] {
            "Sandbox",
            "Live"});
			this.comboBoxTarget.Location = new System.Drawing.Point(105, 29);
			this.comboBoxTarget.Name = "comboBoxTarget";
			this.comboBoxTarget.Size = new System.Drawing.Size(124, 21);
			this.comboBoxTarget.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Target:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Sandbox Key:";
			// 
			// textBoxSandboxKey
			// 
			this.textBoxSandboxKey.Location = new System.Drawing.Point(105, 69);
			this.textBoxSandboxKey.Name = "textBoxSandboxKey";
			this.textBoxSandboxKey.Size = new System.Drawing.Size(436, 20);
			this.textBoxSandboxKey.TabIndex = 16;
			// 
			// textBoxSandBoxSecret
			// 
			this.textBoxSandBoxSecret.Location = new System.Drawing.Point(105, 95);
			this.textBoxSandBoxSecret.Name = "textBoxSandBoxSecret";
			this.textBoxSandBoxSecret.Size = new System.Drawing.Size(436, 20);
			this.textBoxSandBoxSecret.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Sandbox Secret:";
			// 
			// textBoxConsumerSecret
			// 
			this.textBoxConsumerSecret.Location = new System.Drawing.Point(105, 152);
			this.textBoxConsumerSecret.Name = "textBoxConsumerSecret";
			this.textBoxConsumerSecret.Size = new System.Drawing.Size(436, 20);
			this.textBoxConsumerSecret.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Consumer Secret:";
			// 
			// textBoxConsumerKey
			// 
			this.textBoxConsumerKey.Location = new System.Drawing.Point(105, 126);
			this.textBoxConsumerKey.Name = "textBoxConsumerKey";
			this.textBoxConsumerKey.Size = new System.Drawing.Size(436, 20);
			this.textBoxConsumerKey.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Consumer Key:";
			// 
			// FormSampleETradeApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 435);
			this.Controls.Add(this.textBoxConsumerSecret);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxConsumerKey);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSandBoxSecret);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxSandboxKey);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxTarget);
			this.Controls.Add(this.textBoxResponse);
			this.Controls.Add(this.buttonRequestToken);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormSampleETradeApp";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRequestToken;
		private System.Windows.Forms.TextBox textBoxResponse;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBoxTarget;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSandboxKey;
		private System.Windows.Forms.TextBox textBoxSandBoxSecret;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxConsumerSecret;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxConsumerKey;
		private System.Windows.Forms.Label label5;
	}
}

