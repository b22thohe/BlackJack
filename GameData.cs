using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    /// <summary>
    /// Class stores values for all the statistics
    /// </summary>
    public static class GameData
    {
        // Player 1 stats
        public static int p1GamesPlayed {  get; set; }
        public static int p1Wins {  get; set; }
        public static int p1Draws { get; set; }
        public static int p1Losses { get; set; }
        public static int p1BlackJacks {  get; set; }

        // Player 2 stats
        public static int p2GamesPlayed { get; set; }
        public static int p2Wins { get; set; }
        public static int p2Draws { get; set; }
        public static int p2Losses { get; set; }
        public static int p2BlackJacks { get; set; }
    }
}
