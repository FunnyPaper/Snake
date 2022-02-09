using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeLibrary.Game.Entities.Collectibles.Fruits
{
    public class Apple : Fruit
    {
        public Apple(Point position)
            : base(position, Color.FromArgb(170, 0, 0)) 
        {
            Name = "Apple";   
        }
    }
}
