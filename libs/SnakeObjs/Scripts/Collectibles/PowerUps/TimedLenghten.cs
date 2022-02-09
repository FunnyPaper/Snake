using FakeUnity.GameObject;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal class TimedLenghten : TimedPowerUpScript
    {
        public int Amount { get; private set; }
        private GameObject _target;

        public TimedLenghten(int amount, int interval = 1000)
            : base(interval)
        {
            Amount = amount;
        }

        protected override void Apply(GameObject gameObject)
        {
            _target = gameObject;

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

        protected override void Remove()
        {
            //_target.RemoveSegments(Amount);   
            if (_target.Children.Count < Amount)
                Amount = _target.Children.Count; // lub _target.Childen.Clear()

            // usuń obiekty ze sceny
            var del = _target.Children.GetRange(_target.Children.Count - Amount, Amount);
            foreach (GameObject ob in del)
            {
                FakeUnity.Core.GameLoop.RemoveFromActiveScene(ob);
            }
            _target.Children.RemoveRange(_target.Children.Count - Amount, Amount);
        }
    }
}
