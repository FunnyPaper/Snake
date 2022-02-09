using FakeUnity.GameObject;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal class Lenghten : PowerUpScript
    {
        public int Amount { get; private set; }

        public Lenghten(int amount)
        {
            Amount = amount;
        }

        protected override void Apply(GameObject gameObject)
        {

            Statistics.Current.Score += Amount * Points;
            for (int _ = 0; _ < Amount; _++)
            {
                GameObject go = GameObject.Instantiate(Scenes.SnakeGameScene.segment);
                go.Transform.Position = gameObject.Transform.Position;

                gameObject.Children.Add(go);
                FakeUnity.Core.GameLoop.AddToActiveScene(go);
            }

            base.Apply(gameObject);
        }
    }
}
