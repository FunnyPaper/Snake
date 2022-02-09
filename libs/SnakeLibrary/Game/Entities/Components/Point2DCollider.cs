using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Components
{
    public class Point2DCollider : ICollider
    {
        public bool IsActive { get; set; }
        public Point Location { get; set; }

        public event EventHandler<GameEventArgs> CollisionEnter;

        /// <summary>
        /// Tworzy obiekt punktowego kolidatora w przestrzeni 2D
        /// </summary>
        /// <param name="location">Polozenie kolidatora</param>
        /// <param name="isActive">Czy kolidator jest aktywny</param>
        public Point2DCollider(Point location, bool isActive)
        {
            IsActive = isActive;
            Location = Location;
        }

        /// <summary>
        /// Tworzy obiekt punktowego kolidatora w przestrzeni 2D
        /// </summary>
        /// <param name="location">Polozenie kolidatora</param>
        public Point2DCollider(Point location)
            : this(location, true)
        { 
        }

        /// <summary>
        /// Tworzy obiekt punktowego kolidatora w przestrzeni 2D
        /// </summary>
        public Point2DCollider()
            : this(new Point(), true)
        {
        }

        public virtual bool OnCollision(object sender, GameEventArgs e)
        {
            if (sender is ICollider collider)
            {
                if (!collider.IsActive || !this.IsActive)
                    return false;

                bool res = Point.Equals(this.Location, collider.Location);
                if (res)
                {
                    CollisionEnter?.Invoke(this, e);
                }
                return res;
            }

            throw new ArgumentException("Invalid argument type", nameof(sender));
        }
    }
}
