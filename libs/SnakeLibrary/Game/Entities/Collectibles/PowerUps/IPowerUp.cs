using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps
{
    /// <summary>
    /// Interfejs sluzacy do tworzenia wzmocnien
    /// </summary>
    public interface IPowerUp<T> : ICollectible
    {
        /// <summary>
        /// Opis wzmocnienia
        /// </summary>
        string Description { get; }
    }
}
