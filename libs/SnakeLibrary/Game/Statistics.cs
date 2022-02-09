using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game
{
    internal static class Statistics
    {
        public static int Score { get; set; }
        public static int HighScore { get; private set; }
        public static int CollectiblesAte { get; set; }
        public static int SessionTime { get; set; }

        public static void ResetSession(bool completeReset = false)
        {
            Score = 0;
            CollectiblesAte = 0;
            SessionTime = 0;

            if (completeReset)
                HighScore = 0;
        }
    }
}
