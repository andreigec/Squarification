using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ANDREICSLIB;

namespace Squarification
{
	public class player
	{
		public bool isAI = false;
		public Color colour;
		public int score;
	}

	public class area
	{
		//public Color c;
		//public string ident;
		public PanelReplacement refpanel;
		public List<box> parents = new List<box>();
		public bool isSet;
		public bool isAreaUsedInGame;

		public area(box parentIN)
		{
			parents.Add(parentIN);
			isSet = false;
			isAreaUsedInGame = false;
		}
	}

	public class box
	{
		public int x, y;
		public area lineup, linedown, lineleft, lineright;
		public area thisBox;
		public game parent;
	}

	public class game
	{
		//can link to this from the tabpage.tag
		public int width;
		public int height;
        public List<player> players = new List<player>();
		public box[][] boxes;
		public bool completeGame = false;
		//list of all lines for ai later
		public List<area> lines = new List<area>();

		//game states
		public void requeuePlayers()
		{
			var c = players[0];
			players.RemoveAt(0);
			players.Add(c);
		}

		//static
		public static List<game> games = new List<game>();

		public void initAreas(box bx, bool isUsed)
		{
			bx.thisBox = new area(bx) { isAreaUsedInGame = isUsed };

			if ((bx.x - 1) >= 0)
			{
				bx.lineleft = boxes[bx.y][bx.x - 1].lineright;
				bx.lineleft.parents.Add(bx);
			}
			else
				bx.lineleft = new area(bx);


			bx.lineright = new area(bx);

			if ((bx.y - 1) >= 0)
			{
				bx.lineup = boxes[bx.y - 1][bx.x].linedown;
				bx.lineup.parents.Add(bx);
			}
			else
				bx.lineup = new area(bx);

			bx.linedown = new area(bx);

			if (bx.lineleft.isAreaUsedInGame == false)
				bx.lineleft.isAreaUsedInGame = isUsed;
			if (bx.lineright.isAreaUsedInGame == false)
				bx.lineright.isAreaUsedInGame = isUsed;
			if (bx.lineup.isAreaUsedInGame == false)
				bx.lineup.isAreaUsedInGame = isUsed;
			if (bx.linedown.isAreaUsedInGame == false)
				bx.linedown.isAreaUsedInGame = isUsed;
		}

		public game(int playersH, int playersAI, int widthIN, int heightIN, bool[][] customGrid = null)
		{
			bool isCustom = customGrid != null;

			width = widthIN;
			height = heightIN;

			boxes = ANDREICSLIB.MatrixOps.CreateMatrix<box>(width, height);
			for (int a = 0; a < height; a++)
			{
				for (int b = 0; b < width; b++)
				{
					box bx = boxes[a][b];
					bx.x = b;
					bx.y = a;
					bx.parent = this;

					if (isCustom == false)
						initAreas(bx, true);
					else
						initAreas(bx, customGrid[a][b]);
				}
			}

			addPlayer(playersH, false);
			addPlayer(playersAI, true);
			games.Add(this);
		}

		public void resetPlayerColours()
		{
			foreach (player p in players)
			{
				Color rand = getRandomColour();
				//change existing colours on the board
				foreach (area a in lines)
				{
					if (a.refpanel.BackColor == p.colour)
						a.refpanel.BackColor = rand;

					foreach (box b in a.parents)
					{
						if (b.thisBox.refpanel.BackColor == p.colour)
							b.thisBox.refpanel.BackColor = rand;
					}
					gamepanel gp = gamecontroller.getGamePanel(a);

					if (gp.currentplayercolour.BackColor == p.colour)
						gp.currentplayercolour.BackColor = rand;
				}
				p.colour = rand;
			}
		}

		private Color getRandomColour()
		{
		retry:
			var r = new Random();
			var names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
			KnownColor randomColorName = names[r.Next(names.Length)];
			Color ran = Color.FromKnownColor(randomColorName);
			if (containsLoop(ran, players)
				|| ran == Color.Black || ran == Color.White
				|| ran == gamecontroller.defaultcolorlinedisabled || ran == gamecontroller.defaultcolorboxdisabled
				|| ran == gamecontroller.defaultcolourline || ran == gamecontroller.defaultcolourbox ||
				(ran.R < 60 && ran.G < 60 && ran.B < 60) ||
				(ran.R > 220 && ran.G > 220 && ran.B > 220))
				goto retry;

			bool near = players.Any(c => isNear(c.colour, ran));
			if (near)
				goto retry;

			return ran;
		}

		private void addPlayer(int count, bool ai)
		{
			int createdPlayers = 0;
			while (createdPlayers < count)
			{
				Color ran = getRandomColour();
				player p = new player() { colour = ran, isAI = ai };
				players.Add(p);
				createdPlayers++;
			}
		}

        private bool containsLoop(Color c, List<player> pl)
		{
			foreach (var v in pl)
			{
				if (v.colour == c)
					return true;
			}
			return false;
		}

		private bool isNear(Color one, Color two)
		{
			int distance = 20;
			return ((two.R > (one.R - distance) && two.R < (one.R + distance)) &&
					(two.G > (one.G - distance) && two.G < (one.G + distance)) &&
					(two.B > (one.B - distance) && two.B < (one.B + distance)));
		}

	}

}