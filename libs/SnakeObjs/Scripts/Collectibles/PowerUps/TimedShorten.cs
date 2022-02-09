using FakeUnity.GameObject;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal class TimedShorten : TimedPowerUpScript
    {
        public int Amount { get; private set; }
        private GameObject _target;

        public TimedShorten(int amount, int interval = 1000)
            : base(interval)
        {
            Amount = amount;
        }

        protected override void Apply(GameObject gameObject)
        {
            _target = gameObject;
            Statistics.Current.Score -= Amount * Points;

            if (gameObject.Children.Count < Amount)
                Amount = gameObject.Children.Count;


            // usuń obiekty ze sceny
            var del = gameObject.Children.GetRange(gameObject.Children.Count - Amount, Amount);
            foreach (GameObject obj in del)
            {
                FakeUnity.Core.GameLoop.RemoveFromActiveScene(obj);
            }

            gameObject.Children.RemoveRange(gameObject.Children.Count - Amount, Amount);

            base.Apply(gameObject);
        }

        protected override void Remove()
        {
            //_target.AddSegments(Amount);

            for (int _ = 0; _ < Amount; _++)
            {
                GameObject go = GameObject.Instantiate(Scenes.SnakeGameScene.segment);
                go.Transform.Position = _target.Transform.Position;

                _target.Children.Add(go);
                FakeUnity.Core.GameLoop.AddToActiveScene(go);
            }
        }
    }
}
