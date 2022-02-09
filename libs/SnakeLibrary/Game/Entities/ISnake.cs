using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.EventHandlers;
using SnakeLibrary.Game.Entities.Components;

namespace SnakeLibrary.Game.Entities
{
    public interface ISnake : IEntity
    {
        int SegmentsAmount { get; set; }
        List<ISnakeSegment> Body { get; }
        event Action SelfCollision;

        void Move(int x, int y);
        void AddSegments(int amount = 1);
        void AddSegment(object sender, GameEventArgs e);
        void SnakeCollision(GameEventArgs e);
    }
}
