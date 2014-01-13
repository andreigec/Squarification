using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ANDREICSLIB;
using Squarification.ServiceReference1;

namespace Squarification
{
	public partial class Form1 : Form
	{
		private const string gamepath = "gameBoards";
		public Form1()
		{
			InitializeComponent();
			gamecontroller.baseform = this;
			ai.baseform = this;
		}

		#region licensing

		private const string AppTitle = "Squarification";
		private const double AppVersion = 0.3;
		private const String HelpString = "";

		private readonly String OtherText =
			@"©" + DateTime.Now.Year +
			@" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			int p = int.Parse(playerstextbox.Text);
			int pAI = int.Parse(compplayerstextbox.Text);

			if (p+pAI<1)
			{
				MessageBox.Show("You must have at least 1 player of any kind to start the game");
				return;
			}

			if (p>5||pAI>5)
			{
				DialogResult DR = MessageBox.Show("Warning, there are many players - this could slow down the game. Continue?", "question", MessageBoxButtons.YesNo);
				if (DR != DialogResult.Yes)
					return;
			}

			if (standardradio.Checked)
			{
				int w = int.Parse(standardwidthtext.Text);
				int h = int.Parse(standardheighttext.Text);
				gamecontroller.createNewGame(w, h, p,pAI, standardremovesquares.Checked);
			}
			else if (customradio.Checked)
				gamecontroller.createNewGame(p,pAI, gamecombo.Text);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			initGameCombo();
			updateCheck();
            Licensing.CreateLicense(this, menuStrip1, new Licensing.SolutionDetails(GetDetails, HelpString, AppTitle, AppVersion, OtherText));
		}

        public Licensing.DownloadedSolutionDetails GetDetails()
        {
            try
            {
                var sr = new ServicesClient();
                var ti = sr.GetTitleInfo(AppTitle);
                if (ti == null)
                    return null;
                return ToDownloadedSolutionDetails(ti);

            }
            catch (Exception)
            {
            }
            return null;
        }

        public static Licensing.DownloadedSolutionDetails ToDownloadedSolutionDetails(TitleInfoServiceModel tism)
        {
            return new Licensing.DownloadedSolutionDetails()
            {
                ZipFileLocation = tism.LatestTitleDownloadPath,
                ChangeLog = tism.LatestTitleChangelog,
                Version = tism.LatestTitleVersion
            };
        }


		private void initGameCombo()
		{
			String rel = gamecombo.Text;
			gamecombo.Items.Clear();
			if (Directory.Exists(gamepath) == false)
				Directory.CreateDirectory(gamepath);

			string[] files = Directory.GetFiles(gamepath);
			foreach (var f in files)
			{
				gamecombo.Items.Add(f);
			}

			if (rel.Length > 0)
				gamecombo.Text = rel;
			else if (gamecombo.Items.Count > 0)
				gamecombo.Text = gamecombo.Items[0].ToString();
		}

		private void standardwidthtext_KeyPress(object sender, KeyPressEventArgs e)
		{
		        e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false,true,false,false), e.KeyChar);
		}

	    private void standardheighttext_KeyPress(object sender, KeyPressEventArgs e)
		{
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true, false, false), e.KeyChar);
		}

		private void standardradio_CheckedChanged(object sender, EventArgs e)
		{
			updateCheck();
		}

		private void updateCheck()
		{
			if (standardradio.Checked)
			{
				standardgroup.Enabled = true;
				customgroup.Enabled = false;
			}
			else if (customradio.Checked)
			{
				standardgroup.Enabled = false;
				customgroup.Enabled = true;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			updateCheck();
		}

		private void playerstextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true, false, false), e.KeyChar);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			game g = tabcontrol.SelectedTab.Tag as game;
			game.games.Remove(g);
			tabcontrol.TabPages.Remove(tabcontrol.SelectedTab);
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			if (tabcontrol.SelectedTab.TabIndex == 0)
			e.Cancel = true;
		}

		private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String s =
				@"Starting with an empty grid of dots, players take turns, adding a single horizontal or vertical line between two unjoined adjacent dots. 
A player who completes the fourth side of a 1×1 box earns one point and takes another turn. 
(The points are typically recorded by placing in the box an identifying mark of the player, such as an initial). 
The game ends when no more lines can be placed. The winner of the game is the player with the most points.";
			MessageBox.Show(s);
		}
	}
}
