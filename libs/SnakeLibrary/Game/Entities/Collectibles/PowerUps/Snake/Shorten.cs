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
    public class Shorten : PowerUp<ISnake>
    {
        private int Amount;

        public Shorten(Point position, int amount)
            : base(position, Color.LightBlue, 2, nameof(Shorten), $"Eliminate {amount} snake segments")
        {
            Amount = amount;
            this.Collider.CollisionEnter += Apply;
        }

        protected override void Apply(object sender, GameEventArgs e)
        {
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Segments: {e.Snake.SegmentsAmount}");
            if (Amount >= e.Snake.SegmentsAmount)
            {
                Amount = e.Snake.SegmentsAmount - 1;
            }

            e.Snake.SegmentsAmount -= Amount;
            Statistics.Score += PointBase * Mechanics.PointMultiplier;

            Console.WriteLine($"Amount: {Amount}");
        }
    }
}
