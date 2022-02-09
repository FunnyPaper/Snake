using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps
{
    public interface ITimed<T>
    {
        /// <summary>
        /// Jak dlugo bedzie jeszcze dzialac
        /// </summary>
        int SecondsLeft { get; }

        /// <summary>
        /// Czy czas minal
        /// </summary>
        bool Expired { get; }

        /// <summary>
        /// Zegar odmierzajacy czas
        /// </summary>
        Timer Timer { get; }

        /// <summary>
        /// Odniesienie do obiektu
        /// </summary>
        T Target { get; }
    }
}
