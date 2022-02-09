using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Components
{
    public interface IColliderList<T>
        where T: ICollider
    {
        List<T> Elements { get; }

        List<bool> CheckCollisions(IColliderList<T> colliders);

        bool CheckCollisions(T collider);
    }
}
