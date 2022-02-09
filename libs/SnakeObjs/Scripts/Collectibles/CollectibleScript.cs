using FakeUnity.Component.Collider.Collision;
using FakeUnity.Core;
using SnakeObjs.Scenes;

namespace SnakeObjs.Scripts.Collectibles
{
    internal abstract class CollectibleScript : FakeUnity.Component.CustomScript
    {
        public int Points => _points;
        protected int _points;

        protected virtual void Apply(FakeUnity.GameObject.GameObject gameObject)
        {
            GameHooks.Statistics.Current.Score += Points;

            if (GameLoop.Interval > 100)
                GameLoop.Interval -= 1;
            
            // usuń ten obiekt
            SnakeGameScene.RemoveFromBoard(this.GameObject);
            GameLoop.RemoveFromActiveScene(this.GameObject);
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.GameObject.Tag != "Snake")
                return;

            Apply(collision.GameObject);
        }
    }
}
