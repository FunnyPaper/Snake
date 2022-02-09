using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.Entities.Components;
using SnakeLibrary.Game.EventHandlers;
using SnakeLibrary.Game;

namespace SnakeLibrary.Game.Entities.Collectibles.PowerUps.Snake
{
    public class Lenghten : PowerUp<ISnake>
    {
        private int Amount;

        public Lenghten(Point position, int amount)
            : base(position, Color.LightYellow, 2, nameof(Lenghten), $"Add {amount} snake segments")
        {
            Amount = amount;
            this.Collider.CollisionEnter += Apply;
        }

        protected override void Apply(object sender, GameEventArgs e)
        {
            if (-Amount >= e.Snake.SegmentsAmount)
            {
                Amount = 1 - e.Snake.SegmentsAmount;
            }

            e.Snake.SegmentsAmount += Amount;
            Statistics.Score += PointBase * Mechanics.PointMultiplier;
        }
    }
}
