using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Components
{
    public interface ICollider : IComponent
    {
        /// <summary>
        /// Zdarzenie/-a wywolujace sie pod wplywem kolizji
        /// </summary>
        event EventHandler<GameEventArgs> CollisionEnter;

        /// <summary>
        /// Metoda sprawdzajaca czy z danym bytem nastapila kolizja
        /// </summary>
        /// <param name="sender">Byt do sprawdzenia</param>
        /// <returns>Czy doszlo do kolizji</returns>
        bool OnCollision(object sender, GameEventArgs e);

        /// <summary>
        /// Pozycja jaka zajmuje w przestrzeni kolidator
        /// </summary>
        Point Location { get; set; }
    }
}
