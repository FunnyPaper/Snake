using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Entities.Components
{
    public class Point2DColliderList : IColliderList<ICollider>
    {
        public List<ICollider> Elements { get; }

        public List<bool> CheckCollisions(IColliderList<ICollider> colliders)
        {
            throw new NotImplementedException();
        }

        public bool CheckCollisions(ICollider collider)
        {
            throw new NotImplementedException();
        }

        public Point2DColliderList()
        {

        }
    }
}
