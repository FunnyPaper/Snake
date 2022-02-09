using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Collectibles.Fruits
{
    /// <summary>
    /// Interfejs sluzacy do tworzenia owocow
    /// </summary>
    public interface IFruit : ICollectible
    {
        /// <summary>
        /// Multiplikator punktow dla danej znajdzki
        /// </summary>
        int PointMultiplier { get; }
    }
}
