using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.Scene
{
    public abstract class Scene : Core.FakeUnityObject
    {
        protected List<GameObject.GameObject> _gameObjects => GameObjects;
        internal List<GameObject.GameObject> GameObjects { get; }
        public Skybox.Skybox Skybox { get; }

        public Scene()
        {
            GameObjects = new List<GameObject.GameObject>();
            Skybox = new Skybox.Skybox();
        }

        public abstract void Reload();
        public abstract void Unload();
    }
}
