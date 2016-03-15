using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassReplacements;

namespace Squarification
{
	internal class gamecontroller
	{
		public static Form1 baseform;
		private const int horizw = 50;
		private const int horizh = 10;
		private const char sep = ':';
		public static Color defaultcolourline = Color.Blue;
		public static Color defaultcolourbox = Color.White;
		public static Color defaultcolorlinedisabled = Color.Gainsboro;
		public static Color defaultcolorboxdisabled = Color.Gainsboro;
		public static Color inbetweensquare = Color.Black;
		public static char fileboardboxblank = 'X';

		public static void createNewGame(int playersH,int playersAI, string gamepath)
		{
			var FS = new FileStream(gamepath, FileMode.Open);
			var SR = new StreamReader(FS);

			String file = SR.ReadToEnd();
			var sep = new char[] { ' ', '\n', '\r' };

			String[] filesplit = file.Split(sep);
			int width = int.Parse(filesplit[0]);
			int height = int.Parse(filesplit[1]);

			String board = "";
			for (int a = 2; a < filesplit.Count(); a++)
			{
				if (filesplit[a].Length == 0)
					continue;
				board += filesplit[a];
			}
			SR.Close();
			FS.Close();

			var array = new bool[height][];
			int count = 0;
			for (int a = 0; a < height; a++)
			{
				array[a] = new bool[width];
				for (int b = 0; b < width; b++)
				{
					if (board[count].Equals(fileboardboxblank))
						array[a][b] = false;
					else
					{
						array[a][b] = true;
					}
					count++;
				}
			}
			var g = new game(playersH,playersAI, width, height, array);
			initNewGame(g);
		}

		public static void createNewGame(int width, int height, int playersH,int playersAI, bool removesquares)
		{
			game g;
			if (removesquares)
			{
				//25% to remove a square in the grid
				const int randomremove = 25;
				var array = new bool[height][];
				var ran = new Random();
				for (int a = 0; a < height; a++)
				{
					array[a] = new bool[width];
					for (int b = 0; b < width; b++)
					{
						array[a][b] = true;
						int i = ran.Next() % 100;
						if (i <= randomremove)
							array[a][b] = false;
					}
				}
				g = new game(playersH,playersAI, width, height, array);
			}
			else
			{
				//create game
				g = new game(playersH,playersAI, width, height);
			}
			initNewGame(g);
		}

		public static void initNewGame(game g)
		{
			//create interface page
			var TP = new TabPage();
			var gp = new gamepanel();
			TP.Tag = g;
			gp.Dock = DockStyle.Fill;
			gp.Name = game.games.Count.ToString();
			createGamePanel(gp);
			TP.Controls.Add(gp);
			TP.Text = "Game";

			baseform.tabcontrol.Controls.Add(TP);
			baseform.tabcontrol.SelectedIndex = baseform.tabcontrol.TabPages.Count - 1;
			gp.currentplayercolour.BackColor = g.players[0].colour;
			updateScoreTable(g,gp);
			if (g.players[0].isAI)
				ai.performTurn(g,gp);
		}
		//creating individual game controls

		static void P_MouseClick(object sender, MouseEventArgs e)
		{
			var p = sender as PanelReplacement;
			if (p == null || p.Tag == null)
				return;

			var a = p.Tag as area;
			if (a == null)
				return;

			game g = a.parents[0].parent;
			if (g == null)// || p.Parent == null || p.Parent.Parent == null || p.Parent.Parent.Parent == null)
				return;

			var P = getGamePanel(a);// p.Parent.Parent.Parent as gamepanel;
			if (P == null)
				return;

			ai.clickOnArea(a, g, P);
		}

		public static gamepanel getGamePanel(area a)
		{
			return a.refpanel.Parent.Parent.Parent as gamepanel;
		}

		private static void addSquareArea(area a, PanelReplacement p)
		{
			var P = new PanelReplacement();
			P.Tag = a;
			if (a.isAreaUsedInGame)
			{
				P.BorderWidth = 1;
				P.BorderColour = defaultcolourbox;
				P.BackColor = Color.White;
			}
			else
				P.BackColor = defaultcolorboxdisabled;

			P.MouseClick += P_MouseClick;

			P.Width = horizw;
			P.Height = horizw;
			a.refpanel = P;

			p.AddControl(P, true);
		}

		private static void addLine(area a, PanelReplacement p, int count, bool horiz, bool last)
		{
			var P = new PanelReplacement();
			P.Tag = a;

			if (a.isAreaUsedInGame)
			{
				P.BorderWidth = 1;
				P.BorderColour = defaultcolourline;
				P.BackColor = Color.White;
			}
			else
				P.BackColor = defaultcolorlinedisabled;

			P.MouseClick += P_MouseClick;

			if (horiz)
			{
				P.Width = horizw;
				P.Height = horizh;

				a.refpanel = P;
				p.AddControl(P, !last);
			}
			else
			{
				P.Width = horizh;
				P.Height = horizw;
				a.refpanel = P;
				p.AddControl(P, !last);
			}
			if (a.isAreaUsedInGame)
			a.parents[0].parent.lines.Add(a);
		}

		private static PanelReplacement addSquare(PanelReplacement p, bool last)
		{
			var P = new PanelReplacement();
			P.Width = horizh;
			P.Height = horizh;
			P.BackColor = inbetweensquare;
			p.AddControl(P, !last);
			return P;
		}

		public static void createGamePanel(gamepanel gp)
		{
			PanelReplacement p = gp.gamep;
			game g = game.games[game.games.Count - 1];
			gp.Name = game.games.Count.ToString();

			//store these so we can hide solo squares surrounded by hidden areas
			var blacksquares = new List<PanelReplacement>();
			p.Controls.Clear();
			int width = g.width;
			int height = g.height;
			int count = 0;

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					//black square
					blacksquares.Add(addSquare(p, false));
					addLine(g.boxes[y][x].lineup, p, count++, true, false);

					if (x == (width - 1))
						blacksquares.Add(addSquare(p, true));
				}

				for (int x = 0; x < width; x++)
				{
					addLine(g.boxes[y][x].lineleft, p, count++, false, false);
					addSquareArea(g.boxes[y][x].thisBox, p);

					if (x == (width - 1))
					{
						addLine(g.boxes[y][x].lineright, p, count++, false, true);
					}
				}

				if (y == (height - 1))
				{
					for (int x = 0; x < width; x++)
					{
						//black square
						blacksquares.Add(addSquare(p, false));
						addLine(g.boxes[y][x].linedown, p, count++, true, false);

						if (x == (width - 1))
							blacksquares.Add(addSquare(p, true));
					}
				}
			}

			PanelReplacement.FitPanel(p, p,40,0);
			gp.panel1.Location=new Point(0,gp.gamep.Location.Y + gp.gamep.Height + 5);
			PanelReplacement.FitPanel(gp.gameboardresize, gp.gameboardresize);
		}

		public static void endGame(game g,gamepanel gp)
		{
			g.completeGame = true;
			MessageBox.Show("Game Over!");
		}

		public static void updateScoreTable(game g,gamepanel gp)
		{
			var LV = gp.playerscoretable;
			LV.Items.Clear();
			foreach (player p in g.players)
			{
				ListViewItem LVI = new ListViewItem(p.score.ToString());
				if (p.isAI)
					LVI.SubItems.Add("AI");
				else
					LVI.SubItems.Add("Player");

				LVI.BackColor = p.colour;
				LV.Items.Add(LVI);
			}

		}
	}
}

