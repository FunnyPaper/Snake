using System;
using System.Collections.Generic;
using System.Linq;
using FakeUnity.GameObject;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal class Shorten : PowerUpScript
    {
        public int Amount { get; private set; }

        public Shorten(int amount)
        {
            Amount = amount;
        }

        protected override void Apply(GameObject gameObject)
        {
            Statistics.Current.Score -= Amount * Points;
            
            if (gameObject.Children.Count < Amount)
                Amount = gameObject.Children.Count;

            // usuń obiekty ze sceny
            var del = gameObject.Children.GetRange(gameObject.Children.Count - Amount, Amount);
            foreach(GameObject obj in del)
            {
                FakeUnity.Core.GameLoop.RemoveFromActiveScene(obj);
            }
            gameObject.Children.RemoveRange(gameObject.Children.Count - Amount, Amount);

            base.Apply(gameObject);
        }
    }
}
