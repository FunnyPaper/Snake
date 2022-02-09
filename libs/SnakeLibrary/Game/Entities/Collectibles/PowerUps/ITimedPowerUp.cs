using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps
{
    interface ITimedPowerUp<T> : IPowerUp<T>, ITimed<T>
    {
    }
}
