using SnakeLibrary.Game.Entities.Components;
using SnakeLibrary.Game.EventHandlers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps
{
    public abstract class PowerUp<T> : IPowerUp<T>
    {
        public string Description { get; }

        public int PointBase { get; }

        public string Name { get; }

        public Color Color { get; }

        private Point _position;
        public Point Position
        {
            get => _position;
            set
            {
                Collider.Location = value;
                _position = value;
            }
        }

        public ICollider Collider { get; }

        protected abstract void Apply(object sender, GameEventArgs e);

        public PowerUp(Point position, Color color, int pointBase = 5, string name = "*GENERIC_POWERUP_NAME*", string description = "*GENERIC_POWERUP_DESCRIPTION*")
        {
            Collider = new Point2DCollider();

            Description = description;
            PointBase = pointBase;
            Name = name;
            Color = color;
            Position = position;
        }
    }
}
