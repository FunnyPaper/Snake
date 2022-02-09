using FakeUnity.Component.Collider.Collision;
using SnakeObjs.GameHooks;
using SnakeObjs.Scenes;

namespace SnakeObjs.Scripts
{
    internal class PlayerScript : FakeUnity.Component.CustomScript
    {
        public override void Awake()
        {
            SnakeGameScene.segment = GameObject.Children[0];
        }

        public override void Start()
        {
            GameObject.Material = FakeUnity.GameObject.Material.Green;
            GameObject.Name = $"Player-object{ID}";
            GameObject.Tag = "Snake";
        }

        public override void Update()
        {
            GameObject.Tag = "Snake";
            System.Console.WriteLine($"SnakePosition: x={Transform.Position.X}, y={Transform.Position.Y}");
            Move();
        }

        private void Move()
        {
            // przestaw wszystkie segmenty w odniesieniu do segmentu poprzedniego
            for(int i = GameObject.Children.Count - 1; i > 0; i--)
            {
                GameObject.Children[i].Transform.Position = GameObject.Children[i-1].Transform.Position;
                SnakeGameScene.UpdatePositionOnBoard(
                    GameObject.Children[i], 
                    (int)GameObject.Children[i].Transform.Position.X,
                    (int)GameObject.Children[i].Transform.Position.Y);
            }

            // pozycja pierwszego dziecka ma być równa pozycji głowy
            if(GameObject.Children.Count > 0)
            {
                GameObject.Children[0].Transform.Position = Transform.Position;
                SnakeGameScene.UpdatePositionOnBoard(
                    GameObject.Children[0],
                    (int)GameObject.Children[0].Transform.Position.X,
                    (int)GameObject.Children[0].Transform.Position.Y);
            }

            // zmień pozycję głowy o wektor przesunięcia
            Transform.Translate(FakeUnity.Core.Input.Movement);
            
            // sprawdź czy wąż nie wyjdzie poza krawędź mapy
            if (Settings.CurrentState.BoardCollision &&
                (Transform.Position.X < 0 || Transform.Position.X >= Settings.CurrentState.Columns ||
                Transform.Position.Y < 0 || Transform.Position.Y >= Settings.CurrentState.Rows))
            {
                GameOver();
            }
            else
            {
                float x, y;

                if (Transform.Position.X < 0)
                    x = Settings.CurrentState.Columns - 1;
                else if (Transform.Position.X >= Settings.CurrentState.Columns)
                    x = 0;
                else x = Transform.Position.X;

                if (Transform.Position.Y < 0)
                    y = Settings.CurrentState.Rows - 1;
                else if (Transform.Position.Y >= Settings.CurrentState.Rows)
                    y = 0;
                else y = Transform.Position.Y;

                Transform.Position = new FakeUnity.NativeTypes.Vector2(x, y);
            }
            
        }

        void GameOver()
        {
            // maybe dodać gameover event do unloadingu sceny
            FakeUnity.Core.GameLoop.UnloadScene();
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            // jeśli uderzono w głowę to gg
            if (collision.GameObject.Tag == "SnakeSegment")
            {
                Statistics.Current.SegmentsOnDeath += GameObject.Children.Count + 1;
                GameOver();
            }

            // jeśli dodam ściany to też gg
            else if (collision.GameObject.Tag == "Wall")
                GameOver();
        }
    }
}
