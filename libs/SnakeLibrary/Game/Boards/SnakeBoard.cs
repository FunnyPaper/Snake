using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.Entities;
using SnakeLibrary.Game.Entities.Collectibles;
using SnakeLibrary.Game.Entities.Collectibles.Fruits;
using SnakeLibrary.Game.Entities.Collectibles.PowerUps.Snake;
using SnakeLibrary.Helper;
using System.Drawing;
using SnakeLibrary.Game.EventHandlers;
using SnakeLibrary.Game.Entities.Components;

namespace SnakeLibrary.Game.Boards
{
    public sealed class SnakeBoard : IBoard
    {
        public int Rows { get; set; }
        public int Cols { get; set; }

        private event Action _gameOver;
        public event Action GameOver
        {
            add
            {
                Snake.SelfCollision += value;
                _gameOver += value;
            }
            remove
            {
                Snake.SelfCollision -= value;
                _gameOver -= value;
            }
        }

        internal ISnake Snake;
        internal IFruit Fruit;
        internal List<ICollectible> Collectibles;

        public SnakeBoard(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;

            CreateSnake();
            CreateFruit(null, null);
            //Collectibles = Enumerable.Empty<ICollectible>();
            Collectibles = new List<ICollectible>();
        }

        private void CreateFruit(object sender, GameEventArgs args)
        {
            Fruit = new Apple(new Point(
                    SingleRandom.Access.Next(Cols),
                    SingleRandom.Access.Next(Rows)));

            Fruit.Collider.CollisionEnter += CreateFruit;
            Fruit.Collider.CollisionEnter += CreatePowerUps;
            Fruit.Collider.CollisionEnter += Snake.AddSegment;
        }

        private void CreateSnake()
        {
            Snake = new BasicSnake(5, new Point(Cols / 2, Rows / 2));
        }

        private void CreatePowerUps(object sender, GameEventArgs args)
        {
            int chance = SingleRandom.Access.Next(3);

            switch(chance)
            {
                case 0:
                case 1: return;
                case 2: GenerateCollectibles();
                    break;
            }
        }

        private void GenerateCollectibles()
        {
            int num = SingleRandom.Access.Next(4);

            Point position = new Point(SingleRandom.Access.Next(Cols), SingleRandom.Access.Next(Rows));
            Console.WriteLine($"Num: {num}");

            switch (num)
            {
                case 0: Collectibles.Add(new Lenghten(position, SingleRandom.Access.Next(3, 11)));
                    break;
                case 1: Collectibles.Add(new Shorten(position, SingleRandom.Access.Next(3, 11)));
                    break;
                case 2: Collectibles.Add(new TimedLenghten(position, SingleRandom.Access.Next(3, 11), SingleRandom.Access.Next(5, 15)));
                    break;
                case 3: Collectibles.Add(new TimedShorten(position, SingleRandom.Access.Next(3, 11), SingleRandom.Access.Next(5, 15)));
                    break;
            }
        }

        private void CheckBorders(IEntity snake)
        {
            int xRed = snake.Position.X;
            int yRed = snake.Position.Y;

            if (xRed >= Cols)
                xRed = 0;
            else if (xRed < 0)
                xRed = Cols - 1;

            if (yRed >= Rows)
                yRed = 0;
            else if (yRed < 0)
                yRed = Rows - 1;

            snake.Position = new Point(xRed, yRed);
        }

        public void UpdateState(object sender, EventArgs e)
        {
            GameEventArgs args = new GameEventArgs(this, Snake);

            (int x, int y) = Input.GetMovement();
            Snake.Move(x, y * -1);
            CheckBorders(Snake);

            //Snake.Collider.OnCollision(Snake.Collider, args);
            Snake.SnakeCollision(args);

            Collectibles = Collectibles.Where(element => element.Collider.OnCollision(Snake.Collider, args) == false).ToList();

            Fruit.Collider.OnCollision(Snake.Collider, args);
        }
    }
}
