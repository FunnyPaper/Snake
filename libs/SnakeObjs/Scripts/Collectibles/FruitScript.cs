using FakeUnity.Component.Collider.Collision;
using FakeUnity.Core;
using SnakeObjs.Scenes;
using FakeUnity.GameObject;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles
{
    internal class FruitScript : CollectibleScript
    {
        public FruitScript(int points) => _points = points;

        public override void Start()
        {
            GameObject.Material = FakeUnity.GameObject.Material.Red;
            GameObject.Name = $"Fruit-object{ID}";
            GameObject.Tag = "Fruit";
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.GameObject.Tag != "Snake")
                return;

            {
                GameObject go = GameObject.Instantiate(SnakeGameScene.segment);
                go.Transform.Position = collision.Transform.Position;

                collision.GameObject.Children.Add(go);
                GameLoop.AddToActiveScene(go);
            }

            Statistics.Current.FruitPicked += 1;
            Apply(collision.GameObject);
            CreateNewFruit();
        }

        private void CreateNewFruit()
        {
            // stwórz nowy owoc
            //Objects.Fruit fruit = new Objects.Fruit();
            //foreach (var script in fruit.CustomScripts)
            //    script.Start();

            GameObject fruit = GameObject.Instantiate(this.GameObject);

            SnakeGameScene.RandomizePositionOnBoard(fruit);
            GameLoop.AddToActiveScene(fruit);
        }
    }
}
