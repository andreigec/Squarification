using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassReplacements;

namespace Squarification
{
	partial class gamepanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gameboardresize = new PanelReplacement();
			this.panel1 = new System.Windows.Forms.Panel();
			this.newplayercolours = new System.Windows.Forms.Button();
			this.playerscoretable = new ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.currentplayercolour = new System.Windows.Forms.Panel();
			this.gamep = new PanelReplacement();
			this.gameboardresize.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gameboardresize
			// 
			this.gameboardresize.AutoSize = true;
			this.gameboardresize.BackColor = System.Drawing.Color.Gainsboro;
			this.gameboardresize.BorderColour = System.Drawing.Color.Black;
			this.gameboardresize.BorderWidth = 0;
			this.gameboardresize.Controls.Add(this.panel1);
			this.gameboardresize.Controls.Add(this.gamep);
			this.gameboardresize.Location = new System.Drawing.Point(3, 3);
			this.gameboardresize.Name = "gameboardresize";
			this.gameboardresize.Size = new System.Drawing.Size(414, 298);
			this.gameboardresize.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.newplayercolours);
			this.panel1.Controls.Add(this.playerscoretable);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.currentplayercolour);
			this.panel1.Location = new System.Drawing.Point(3, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 239);
			this.panel1.TabIndex = 3;
			// 
			// newplayercolours
			// 
			this.newplayercolours.Location = new System.Drawing.Point(251, 22);
			this.newplayercolours.Name = "newplayercolours";
			this.newplayercolours.Size = new System.Drawing.Size(111, 22);
			this.newplayercolours.TabIndex = 4;
			this.newplayercolours.Text = "New Player Colours";
			this.newplayercolours.UseVisualStyleBackColor = true;
			this.newplayercolours.Click += new System.EventHandler(this.newplayercolours_Click);
			// 
			// playerscoretable
			// 
			this.playerscoretable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.playerscoretable.FullRowSelect = true;
			this.playerscoretable.Location = new System.Drawing.Point(6, 50);
			this.playerscoretable.Name = "playerscoretable";
			this.playerscoretable.Size = new System.Drawing.Size(356, 172);
			this.playerscoretable.TabIndex = 3;
			this.playerscoretable.UseCompatibleStateImageBehavior = false;
			this.playerscoretable.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Player Scores";
			this.columnHeader1.Width = 254;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Player Type";
			this.columnHeader2.Width = 70;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Current Players Turn:";
			// 
			// currentplayercolour
			// 
			this.currentplayercolour.Location = new System.Drawing.Point(6, 28);
			this.currentplayercolour.Name = "currentplayercolour";
			this.currentplayercolour.Size = new System.Drawing.Size(103, 16);
			this.currentplayercolour.TabIndex = 2;
			// 
			// gamep
			// 
			this.gamep.BackColor = System.Drawing.Color.Gainsboro;
			this.gamep.BorderColour = System.Drawing.Color.Black;
			this.gamep.BorderWidth = 0;
			this.gamep.Location = new System.Drawing.Point(0, 0);
			this.gamep.Name = "gamep";
			this.gamep.Size = new System.Drawing.Size(368, 50);
			this.gamep.TabIndex = 0;
			// 
			// gamepanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.Controls.Add(this.gameboardresize);
			this.Name = "gamepanel";
			this.Size = new System.Drawing.Size(427, 306);
			this.gameboardresize.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public PanelReplacement gamep;
		public PanelReplacement gameboardresize;
		public ListView  playerscoretable;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Panel currentplayercolour;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button newplayercolours;
		private System.Windows.Forms.ColumnHeader columnHeader2;


	}
}
