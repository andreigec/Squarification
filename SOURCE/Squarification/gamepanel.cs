using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;

namespace Squarification
{
	public partial class gamepanel : UserControl
	{
		public gamepanel()
		{
			InitializeComponent();
		}

		private void newplayercolours_Click(object sender, EventArgs e)
		{
			TabPage tp = Parent as TabPage;
			if (tp == null)
				return;
			game g = tp.Tag as game;
			g.resetPlayerColours();

			gamepanel gp = gamecontroller.getGamePanel(g.boxes[0][0].lineleft);
			if (gp == null)
				return;
			gamecontroller.updateScoreTable(g,gp);
		}
	}
}
