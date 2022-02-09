using SnakeLibrary.Game.Entities.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.EventHandlers;

namespace SnakeLibrary.Game.Entities
{
    public class BasicSnake : ISnake
    {
        public event Action SelfCollision;

        private int _segmentsAmount;
        public int SegmentsAmount
        {
            get => _segmentsAmount;
            set
            {
                //if (value < 0)
                //{
                //    _segmentsAmount = 1;
                //    TruncateBody();
                //}
                //else
                //{
                    AddSegments(value - _segmentsAmount);
                    _segmentsAmount = value;
                //}
            }
        }

        public List<ISnakeSegment> Body { get; private set; }

        public virtual Color Color { get; private set; }

        private Point _position;
        public virtual Point Position 
        {
            get => Body[0].Position; 
            set
            {
                Collider.Location = value;
                Body[0].Position = value;
            }
        }

        public virtual ICollider Collider { get; private set; }

        public void AddSegment(object sender, GameEventArgs e)
        {
            //AddSegments();
            SegmentsAmount++;
        }

        public void AddSegments(int amount = 1)
        {
            if(amount > 0)
            {
                for(int i = 0; i < amount; i++)
                {
                    Body?.Add(new BasicSnakeSegment(Body[Body.Count - 1]));
                }
            }
            else
            {
                Body = Body.Take(Body.Count + amount).ToList();
            }
        }

        private void TruncateBody()
        {
            Body = new List<ISnakeSegment>() { Body.First() };
        }

        public void Move(int x, int y)
        {
            if (x == 0 && y == 0)
                return;

            for (int i = Body.Count - 1; i > 0; i--)
                (Body[i] as BasicSnakeSegment).Position = Body[i - 1].Position;

            int xRed = Body[0].Position.X + x;
            int yRed = Body[0].Position.Y + y;

            (Body[0] as BasicSnakeSegment).Position = new Point(xRed, yRed);
            Position = new Point(xRed, yRed);
        }

        public BasicSnake(int segments, Point position)
        {
            Collider = new Point2DCollider();

            _segmentsAmount = segments;
            CreateBody(position);

            _position = position;
        }

        protected void CreateBody(Point position)
        {
            Body = new List<ISnakeSegment>();
            for (int i = 0; i < SegmentsAmount; i++)
                Body.Add(new BasicSnakeSegment(position));

            //Body[0].Collider.CollisionEnter += SelfCollision;
        }

        [Obsolete("SnakeCollision", true)]
        protected void CheckForSelfCollision(ICollider collider, GameEventArgs e)
        {
            for(int i = 0; i < Body.Count; i++)
            {
                if (Body[0] == e.Snake.Body[i])
                    continue;

                if (Body[0].Position == e.Snake.Body[i].Position)
                {
                    //SelfCollision?.Invoke(collider, e);
                    return;
                }
            }
        }

        public void SnakeCollision(GameEventArgs e)
        {
            for (int i = 1; i < Body.Count; i++)
            {
                //if (Body[0].Collider.OnCollision(Body[i].Collider, e))
                //    return;
                if(Body[0].Position == Body[i].Position)
                {
                    SelfCollision?.Invoke();
                }
            }
        }
    }
}
