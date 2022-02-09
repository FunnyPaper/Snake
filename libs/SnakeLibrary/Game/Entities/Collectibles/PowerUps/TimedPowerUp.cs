using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.Entities.Components;
using SnakeLibrary.Game.EventHandlers;
using System.Windows.Forms;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps
{
    public abstract class TimedPowerUp<T> : ITimedPowerUp<T>
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

        public int SecondsLeft { get; protected set; }

        public Timer Timer { get; }

        public T Target { get; set; }

        public bool Expired { get; protected set; }

        protected virtual void Apply(object sender, GameEventArgs e)
        {
            Timer.Enabled = true;
        }

        protected abstract void Remove();

        protected virtual void CountSeconds(object o, EventArgs e)
        {
            if (this.SecondsLeft == 0)
            {
                Timer.Enabled = false;
                Expired = true;
                Remove();
            }
            else
            {
                this.SecondsLeft--;
            }
            Console.WriteLine("this!");
        }

        public TimedPowerUp(Point position, Color color, int pointBase = 5, int LastInSeconds = 10, string name = "*GENERIC_POWERUP_NAME*", string description = "*GENERIC_POWERUP_DESCRIPTION*")
        {
            Target = default(T);
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += CountSeconds;
            Collider = new Point2DCollider();

            Description = description;
            PointBase = pointBase;
            Name = name;
            Color = color;
            SecondsLeft = LastInSeconds;
            Expired = false;
            Position = position;
        }
    }
}
