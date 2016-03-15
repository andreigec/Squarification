using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Squarification
{
	public class ai
	{
		public static Form1 baseform;
		#region ai
		public static void performTurn(game g, gamepanel gp)
		{
			if (g.completeGame)
				return;

				Thread.Sleep(100);
				Application.DoEvents();

			//get list of possible moves
			var possible = new List<area>();
			bool sacrifice = false;
			retry:
			foreach (area a in g.lines)
			{
				if (a.isSet)
					continue;

				//push wins to the front and exit
				int setedges = checkFilledBoxBlankEdges(a);

				if (setedges == 4)
				{
					possible.Clear();
					possible.Insert(0, a);
					break;
				}
				//try not to sacrifice this square unless no other option, or no sac = push
				if ((setedges == 3&& sacrifice) || setedges <= 2)
				{
					int n = 0;
					if (possible.Count > 0)
					{
						var R = new Random();
						n = R.Next()%possible.Count;
					}
					possible.Insert(n,a);
				}
			}

			//if there are no possible moves, but we are still here, it means we have to sacrifice
			if (possible.Count == 0)
			{
				//if sac already true, then error
				if (sacrifice)
				{
					MessageBox.Show("Error in ai");
					return;
				}
				sacrifice = true;
				goto retry;
			}

			clickOnArea(possible[0], g, gp);
		}
		#endregion

		#region player
		private static bool checkEndGame(game g)
		{
			for (int y = 0; y < g.height; y++) for (int x = 0; x < g.width; x++)
				{
					area a = g.boxes[y][x].lineup;
					if (a.isAreaUsedInGame && a.isSet == false)
						return false;

					a = g.boxes[y][x].linedown;
					if (a.isAreaUsedInGame && a.isSet == false)
						return false;

					a = g.boxes[y][x].lineleft;
					if (a.isAreaUsedInGame && a.isSet == false)
						return false;

					a = g.boxes[y][x].lineright;
					if (a.isAreaUsedInGame && a.isSet == false)
						return false;
				}
			return true;
		}


		public static void clickOnArea(area a, game g, gamepanel gp)
		{
			if (a.isAreaUsedInGame == false || a.isSet || a.parents[0].thisBox == a)
				return;

			a.isSet = true;
			a.refpanel.BackColor = g.players[0].colour;

			//check boxes
			bool goodmove = false;
			foreach (var v in a.parents)
			{
				if (v.thisBox.isAreaUsedInGame == false || v.thisBox.isSet)
					continue;

				bool val = checkAndSetFilledBox(v, g);
				if (val)
					goodmove = true;
			}
			//if the box gets set, that means it was a filled square- the player gets another turn
			if (goodmove == false)
			{
				g.requeuePlayers();
				gp.currentplayercolour.BackColor = g.players[0].colour;
			}
			else
			{
				gamecontroller.updateScoreTable(g, gp);
			}

			//check end game
			if (checkEndGame(g))
			{
				gamecontroller.endGame(g,gp);
			}

			if (g.players[0].isAI)
			{
				Thread.Sleep(100);
				performTurn(g, gp);
			}
		}

		private static bool checkAndSetFilledBox(box b, game g)
		{
			//dont check is set so we can change later on if required via abilities or whatever
			if (b.thisBox.isAreaUsedInGame == false)
				return false;

			if (b.lineup.isSet && b.lineleft.isSet &&
				b.lineright.isSet && b.linedown.isSet)
			{
				b.thisBox.refpanel.BackColor = g.players[0].colour;
				b.thisBox.isSet = true;
				g.players[0].score++;
				return true;
			}
			return false;
		}

		private static int checkFilledBoxBlankEdges(area proposedLine)
		{
			int setedgemax = 0;
			int setedge = 0;
			foreach (box b in proposedLine.parents)
			{
				if (b.thisBox.isAreaUsedInGame==false)
					continue;
				
				setedge = 0;
				if (b.lineup.isSet || proposedLine == b.lineup)
					setedge++;
				if (b.linedown.isSet || proposedLine == b.linedown)
					setedge++;
				if (b.lineleft.isSet || proposedLine == b.lineleft)
					setedge++;
				if (b.lineright.isSet || proposedLine == b.lineright)
					setedge++;

				if (setedgemax == -1 || setedgemax < setedge)
					setedgemax = setedge;
			}
			return setedgemax;
		}

		#endregion
	}
}
