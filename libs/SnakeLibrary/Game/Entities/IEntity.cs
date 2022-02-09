using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SnakeLibrary.Game.Draw;
using SnakeLibrary.Game.Entities.Components;

namespace SnakeLibrary.Game.Entities
{
    public interface IEntity
    {
        Color Color { get; }
        Point Position { get; set; }
        ICollider Collider { get; }
    }
}
