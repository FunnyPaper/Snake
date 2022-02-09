using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.EventArgs
{
    public class SceneEventArgs : System.EventArgs
    {
        public Scene.Scene Scene { get; }
        public SceneEventArgs(Scene.Scene scene)
        {
            Scene = scene;
        }
    }
}
