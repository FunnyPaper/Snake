using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.Entities.Components;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps.Snake
{
    public class TimedLenghten : TimedPowerUp<ISnake>
    {
        private int Amount;

        public TimedLenghten(Point position, int amount, int seconds)
            : base(position, Color.DarkOrange, 2, seconds, nameof(TimedLenghten), $"Add {amount} snake segments for {seconds} seconds")
        {
            Amount = amount;
            this.Collider.CollisionEnter += Apply;
            this.Timer.Tick += CountSeconds;
        }

        protected override void Apply(object sender, GameEventArgs e)
        {
            base.Apply(sender, e);

            if (-Amount >= e.Snake.SegmentsAmount)
            {
                Amount = 1 - e.Snake.SegmentsAmount;
            }

            Target = e.Snake;
            e.Snake.SegmentsAmount += Amount;
            Statistics.Score += PointBase * Mechanics.PointMultiplier;
        }

        protected override void Remove()
        {
            if (Amount >= Target.SegmentsAmount)
            {
                Target.SegmentsAmount = 1;
            }
            else Target.SegmentsAmount -= Amount;
        }
    }
}
