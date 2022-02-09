using SnakeLibrary.Game.Entities.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Collectibles.Fruits
{
    public abstract class Fruit : IFruit
    {
        public int PointMultiplier { get; }

        public int PointBase { get; }

        public string Name { get; set; }

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

        public Fruit(Point position, Color color, int pointMultiplier = 1, int pointBase = 10, string name = "*GENERIC_FRUIT*")
        {
            Collider = new Point2DCollider();
            Collider.CollisionEnter += AddPoints;

            Position = position;
            Color = color;
            PointMultiplier = pointMultiplier;
            PointBase = pointBase;
            Name = name;
        }

        protected virtual void AddPoints(object sender, GameEventArgs e)
        {
            Statistics.Score += PointBase * PointMultiplier * Mechanics.PointMultiplier;
        }
    }
}
