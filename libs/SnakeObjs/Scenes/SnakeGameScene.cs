using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FakeUnity.Core;
using FakeUnity.GameObject;
using FakeUnity.NativeTypes;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scenes
{
    public class SnakeGameScene : FakeUnity.Scene.Scene
    {
        internal static GameObject segment; 

        public SnakeGameScene()
        {
            Reload();
            //Resize(Renderer.Canvas, EventArgs.Empty);
        }

        public override void Reload()
        {
            //Resize(Renderer.Canvas, EventArgs.Empty);

            _gameObjects.Clear();
            ClearAndCreateBoard();

            // dodaj metodę umożliwiającą skalowanie grafiki
            Renderer.Canvas.SizeChanged += Resize;

            // tworzenie węża
            {
                //GameObject snake = new Objects.Snake();
                GameObject snake = new GameObject();
                snake.CustomScripts.Add(new Scripts.PlayerScript() { GameObject = snake });
                UpdatePositionOnBoard(snake, Settings.CurrentState.Columns / 2, Settings.CurrentState.Rows / 2);
                _gameObjects.Add(snake);

                for (int i = 0; i < Settings.CurrentState.StartingSnakeSegments; i++)
                {
                    //snake.Children.Add(new Objects.SnakeSegment(snake.Transform.Position) { Parent = snake });
                    GameObject segment = new GameObject(snake);
                    segment.Transform.Position = snake.Transform.Position;
                    segment.CustomScripts.Add(new Scripts.SnakeSegmentScript() { GameObject = segment });
                    snake.Children.Add(segment);
                }

                // dodaj segment na aktywną scenę
                _gameObjects.AddRange(snake.Children);
            }

            //tworzenie generatorów
            if (Settings.CurrentState.GeneratePowerUps)
            {
                // Liczba generatorów
                GameObject[] generators = new GameObject[Settings.CurrentState.GeneratorsCount];
                for (int i = 0; i < generators.Length; i++)
                {
                    //generators[i] = new Objects.PowerUpGenerator();
                    generators[i] = new GameObject();
                    generators[i].CustomScripts.Add(new Scripts.PowerUpGeneratorScript() { GameObject = generators[i] });
                }
                _gameObjects.AddRange(generators);
            }

            // tworzenie owoca
            {
                //GameObject fruit = new Objects.Fruit();
                GameObject fruit = new GameObject();
                fruit.CustomScripts.Add(new Scripts.Collectibles.FruitScript(10) { GameObject = fruit });
                RandomizePositionOnBoard(fruit);
                _gameObjects.Add(fruit);
            }
        }

        public override void Unload()
        {
            Renderer.Canvas.SizeChanged -= Resize;
        }

        // sekcja statyczna

        internal static GameObject[,] Board;
        internal readonly static Random Random = new Random();

        static SnakeGameScene()
        {
            ClearAndCreateBoard();
        }

        internal static void ClearAndCreateBoard()
        {
            Board = new GameObject[Settings.CurrentState.Rows, Settings.CurrentState.Columns];
        }

        internal static void RandomizePositionOnBoard(GameObject gameObject)
        {
            Board[(int)gameObject.Transform.Position.Y, (int)gameObject.Transform.Position.X] = null;
            Vector2 newVec = new Vector2(Random.Next(Board.GetLength(1)), Random.Next(Board.GetLength(0)));
            gameObject.Transform.Position = newVec;
            Board[(int)newVec.Y, (int)newVec.X] = gameObject;
        }

        internal static void UpdatePositionOnBoard(GameObject gameObject, int newX, int newY)
        {
            Board[(int)gameObject.Transform.Position.Y, (int)gameObject.Transform.Position.X] = null;
            gameObject.Transform.Position = new Vector2(newX, newY);
            Board[newY, newX] = gameObject;
        }

        internal static void RemoveFromBoard(GameObject gameObject)
        {
            Board[(int)gameObject.Transform.Position.Y, (int)gameObject.Transform.Position.X] = null;
        }

        // przenieść w osobne miejsce
        public static void Resize(object sender, EventArgs e)
        {
            PictureBox rec = (sender as PictureBox);

            int Width = rec.Width;
            int Height = rec.Height;

            int firstProposedResult = Height / Settings.CurrentState.Rows;
            int secondProposedResult = Width / Settings.CurrentState.Columns;

            Renderer.RenderingScale = firstProposedResult < secondProposedResult ? firstProposedResult : secondProposedResult;

            rec.Size = new System.Drawing.Size(
                (int)(Renderer.RenderingScale * Settings.CurrentState.Columns),
                (int)(Renderer.RenderingScale * Settings.CurrentState.Rows)
                );

            rec.Location = new System.Drawing.Point(
                (int)((rec.Parent.Width - rec.Width) / Renderer.RenderingScale), 
                (rec.Parent.Height - rec.Height) / 2
                );
        }
    }
}
