using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Components
{
    /// <summary>
    /// Interfejs umozliwiajcy tworzenie komponentow
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Okresla czy komponent jest aktywny
        /// </summary>
        bool IsActive { get; }
    }
}
