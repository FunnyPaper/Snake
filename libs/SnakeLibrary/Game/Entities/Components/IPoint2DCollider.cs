using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Components
{
    /// <summary>
    /// Komponent umozliwiajacy 
    /// </summary>
    [Obsolete("Pierwotna wersja tworzenia klas do kolizji punktowych")]
    public interface IPoint2DCollider : IComponent
    {
        /// <summary>
        /// Zdarzenie/-a wywolujace sie pod wplywem kolizji
        /// </summary>
        event Action<ICollider, GameEventArgs> CollisionEnter;

        /// <summary>
        /// Metoda sprawdzajaca czy z danym bytem nastapila kolizja
        /// </summary>
        /// <param name="element">Byt do sprawdzenia</param>
        /// <returns>Czy doszlo do kolizji</returns>
        bool OnCollision(ICollider collider, GameEventArgs e);

        /// <summary>
        /// Pozycja jaka zajmuje w przestrzeni kolidator
        /// </summary>
        Point Location { get; set; }
    }
}
