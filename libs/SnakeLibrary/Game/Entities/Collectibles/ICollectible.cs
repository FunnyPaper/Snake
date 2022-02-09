using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Collectibles
{
    /// <summary>
    /// Podstawowy interfejs do tworzenia znajdziek
    /// </summary>
    public interface ICollectible : IEntity
    {
        /// <summary>
        /// Ilosc punktow danej znajdzki
        /// </summary>
        int PointBase { get; }

        /// <summary>
        /// Nazwa znajdzki
        /// </summary>
        string Name { get; }
    }
}
