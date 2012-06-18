namespace Squarification
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabcontrol = new System.Windows.Forms.TabControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainpage = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.compplayerstextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.playerstextbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.customgroup = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gamecombo = new System.Windows.Forms.ComboBox();
			this.customradio = new System.Windows.Forms.RadioButton();
			this.standardradio = new System.Windows.Forms.RadioButton();
			this.standardgroup = new System.Windows.Forms.GroupBox();
			this.standardremovesquares = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.standardheighttext = new System.Windows.Forms.TextBox();
			this.standardwidthtext = new System.Windows.Forms.TextBox();
			this.gamestartbutton = new System.Windows.Forms.Button();
			this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.tabcontrol.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.mainpage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.customgroup.SuspendLayout();
			this.standardgroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Silver;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rulesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(791, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// tabcontrol
			// 
			this.tabcontrol.ContextMenuStrip = this.contextMenuStrip1;
			this.tabcontrol.Controls.Add(this.mainpage);
			this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabcontrol.Location = new System.Drawing.Point(0, 24);
			this.tabcontrol.Name = "tabcontrol";
			this.tabcontrol.SelectedIndex = 0;
			this.tabcontrol.Size = new System.Drawing.Size(791, 521);
			this.tabcontrol.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// mainpage
			// 
			this.mainpage.Controls.Add(this.groupBox2);
			this.mainpage.Controls.Add(this.groupBox1);
			this.mainpage.Controls.Add(this.gamestartbutton);
			this.mainpage.Location = new System.Drawing.Point(4, 22);
			this.mainpage.Name = "mainpage";
			this.mainpage.Padding = new System.Windows.Forms.Padding(3);
			this.mainpage.Size = new System.Drawing.Size(783, 495);
			this.mainpage.TabIndex = 0;
			this.mainpage.Text = "Main";
			this.mainpage.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.compplayerstextbox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.playerstextbox);
			this.groupBox2.Location = new System.Drawing.Point(8, 218);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(446, 114);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(112, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Computer Players:";
			// 
			// compplayerstextbox
			// 
			this.compplayerstextbox.Location = new System.Drawing.Point(112, 35);
			this.compplayerstextbox.Name = "compplayerstextbox";
			this.compplayerstextbox.Size = new System.Drawing.Size(100, 20);
			this.compplayerstextbox.TabIndex = 5;
			this.compplayerstextbox.Text = "1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Human Players:";
			// 
			// playerstextbox
			// 
			this.playerstextbox.Location = new System.Drawing.Point(6, 35);
			this.playerstextbox.Name = "playerstextbox";
			this.playerstextbox.Size = new System.Drawing.Size(100, 20);
			this.playerstextbox.TabIndex = 3;
			this.playerstextbox.Text = "1";
			this.playerstextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerstextbox_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.customgroup);
			this.groupBox1.Controls.Add(this.customradio);
			this.groupBox1.Controls.Add(this.standardradio);
			this.groupBox1.Controls.Add(this.standardgroup);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(446, 206);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game Board";
			// 
			// customgroup
			// 
			this.customgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.customgroup.Controls.Add(this.label3);
			this.customgroup.Controls.Add(this.gamecombo);
			this.customgroup.Location = new System.Drawing.Point(26, 95);
			this.customgroup.Name = "customgroup";
			this.customgroup.Size = new System.Drawing.Size(414, 100);
			this.customgroup.TabIndex = 4;
			this.customgroup.TabStop = false;
			this.customgroup.Text = "Custom Game";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "File:";
			// 
			// gamecombo
			// 
			this.gamecombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gamecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gamecombo.FormattingEnabled = true;
			this.gamecombo.Location = new System.Drawing.Point(9, 32);
			this.gamecombo.Name = "gamecombo";
			this.gamecombo.Size = new System.Drawing.Size(399, 21);
			this.gamecombo.TabIndex = 2;
			// 
			// customradio
			// 
			this.customradio.AutoSize = true;
			this.customradio.Location = new System.Drawing.Point(6, 135);
			this.customradio.Name = "customradio";
			this.customradio.Size = new System.Drawing.Size(14, 13);
			this.customradio.TabIndex = 2;
			this.customradio.UseVisualStyleBackColor = true;
			this.customradio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// standardradio
			// 
			this.standardradio.AutoSize = true;
			this.standardradio.Checked = true;
			this.standardradio.Location = new System.Drawing.Point(6, 54);
			this.standardradio.Name = "standardradio";
			this.standardradio.Size = new System.Drawing.Size(14, 13);
			this.standardradio.TabIndex = 1;
			this.standardradio.TabStop = true;
			this.standardradio.UseVisualStyleBackColor = true;
			this.standardradio.CheckedChanged += new System.EventHandler(this.standardradio_CheckedChanged);
			// 
			// standardgroup
			// 
			this.standardgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.standardgroup.Controls.Add(this.standardremovesquares);
			this.standardgroup.Controls.Add(this.label2);
			this.standardgroup.Controls.Add(this.label1);
			this.standardgroup.Controls.Add(this.standardheighttext);
			this.standardgroup.Controls.Add(this.standardwidthtext);
			this.standardgroup.Location = new System.Drawing.Point(26, 19);
			this.standardgroup.Name = "standardgroup";
			this.standardgroup.Size = new System.Drawing.Size(414, 65);
			this.standardgroup.TabIndex = 0;
			this.standardgroup.TabStop = false;
			this.standardgroup.Text = "Standard Game";
			// 
			// standardremovesquares
			// 
			this.standardremovesquares.AutoSize = true;
			this.standardremovesquares.Location = new System.Drawing.Point(218, 37);
			this.standardremovesquares.Name = "standardremovesquares";
			this.standardremovesquares.Size = new System.Drawing.Size(172, 17);
			this.standardremovesquares.TabIndex = 4;
			this.standardremovesquares.Text = "Remove some random squares";
			this.standardremovesquares.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Height:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Width:";
			// 
			// standardheighttext
			// 
			this.standardheighttext.Location = new System.Drawing.Point(112, 35);
			this.standardheighttext.Name = "standardheighttext";
			this.standardheighttext.Size = new System.Drawing.Size(100, 20);
			this.standardheighttext.TabIndex = 1;
			this.standardheighttext.Text = "5";
			this.standardheighttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.standardheighttext_KeyPress);
			// 
			// standardwidthtext
			// 
			this.standardwidthtext.Location = new System.Drawing.Point(6, 35);
			this.standardwidthtext.Name = "standardwidthtext";
			this.standardwidthtext.Size = new System.Drawing.Size(100, 20);
			this.standardwidthtext.TabIndex = 0;
			this.standardwidthtext.Text = "5";
			this.standardwidthtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.standardwidthtext_KeyPress);
			// 
			// gamestartbutton
			// 
			this.gamestartbutton.Location = new System.Drawing.Point(8, 338);
			this.gamestartbutton.Name = "gamestartbutton";
			this.gamestartbutton.Size = new System.Drawing.Size(446, 23);
			this.gamestartbutton.TabIndex = 0;
			this.gamestartbutton.Text = "Start Game";
			this.gamestartbutton.UseVisualStyleBackColor = true;
			this.gamestartbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// rulesToolStripMenuItem
			// 
			this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
			this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.rulesToolStripMenuItem.Text = "Rules";
			this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 545);
			this.Controls.Add(this.tabcontrol);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabcontrol.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.mainpage.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.customgroup.ResumeLayout(false);
			this.customgroup.PerformLayout();
			this.standardgroup.ResumeLayout(false);
			this.standardgroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.TabControl tabcontrol;
		private System.Windows.Forms.TabPage mainpage;
		private System.Windows.Forms.Button gamestartbutton;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ComboBox gamecombo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox customgroup;
		private System.Windows.Forms.RadioButton customradio;
		private System.Windows.Forms.RadioButton standardradio;
		private System.Windows.Forms.GroupBox standardgroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox standardheighttext;
		private System.Windows.Forms.TextBox standardwidthtext;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox playerstextbox;
		private System.Windows.Forms.CheckBox standardremovesquares;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox compplayerstextbox;
		private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;


	}
}

