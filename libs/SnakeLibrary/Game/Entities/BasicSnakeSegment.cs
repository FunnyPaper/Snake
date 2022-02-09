using SnakeLibrary.Game.Entities.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities
{
    public class BasicSnakeSegment : ISnakeSegment
    {
        public virtual Color Color { get; }

        private Point _position;
        public virtual Point Position 
        {
            get => _position;
            set
            {
                Collider.Location = value;
                _position = value;
            }
        }

        public virtual ICollider Collider { get; }

        public BasicSnakeSegment(Point position, Color color)
        {
            Collider = new Point2DCollider();

            Color = color;
            Position = position;
        }

        public BasicSnakeSegment(ISnakeSegment segment)
            : this(segment.Position, segment.Color)
        {
        }

        public BasicSnakeSegment()
            : this(new Point(), Color.FromArgb(0, 170, 0))
        {
        }

        public BasicSnakeSegment(Point position)
            : this(position, Color.FromArgb(0, 170, 0))
        {
        }
    }
}
