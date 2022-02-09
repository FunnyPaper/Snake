using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeLibrary.Game.Draw
{
    /// <summary>
    /// Najbardziej podstawowa reprezentacja informacji o swiecie
    /// </summary>
    [Obsolete("Przedawniony sposob reprezentacji swiata", true)]
    public struct Unit
    {
        Color Color { get; set; }
        Point Position { get; set; }

        public Unit(Color color, Point position)
        {
            Color = color;
            Position = position;
        }
    }
}
