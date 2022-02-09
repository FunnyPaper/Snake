using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.EventArgs
{
    public class GameObjectSequenceEventArgs : System.EventArgs
    {
        public GameObject.GameObject[] GameObjectSequence { get; }
        public GameObjectSequenceEventArgs(GameObject.GameObject[] gameObjectSequence)
        {
            GameObjectSequence = gameObjectSequence;
        }

        public GameObjectSequenceEventArgs(IEnumerable<GameObject.GameObject> gameObjectSequence)
        {
            GameObjectSequence = gameObjectSequence.ToArray();
        }
    }
}
