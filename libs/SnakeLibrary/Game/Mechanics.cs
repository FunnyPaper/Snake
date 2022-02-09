using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.Entities.Collectibles.PowerUps.Snake;

namespace SnakeLibrary.Game
{
    internal static class Mechanics
    {
        public static int PointMultiplier { get; set; }
        public static float SpeedMultiplier { get; set; }
        public static int BonusSegments { get; set; }

        static Mechanics()
        {
            PointMultiplier = 1;
            SpeedMultiplier = 1f;
            BonusSegments = 0;
        }
    }
}
