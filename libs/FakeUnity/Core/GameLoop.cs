using System;
using System.Collections.Generic;
using System.Diagnostics;
using FakeUnity.Component;
using FakeUnity.Component.Collider.Collision;
using System.Windows.Forms;

namespace FakeUnity.Core
{
    public static class GameLoop
    {
        public static Scene.Scene ActiveScene => _activeScene;
        private static Scene.Scene _activeScene;

        private static List<GameObject.GameObject> _addingList = new List<GameObject.GameObject>();
        private static List<GameObject.GameObject> _removingList = new List<GameObject.GameObject>();

        private static Stopwatch StopWatch;

        //private static Clock Clock;
        private static Timer Clock;

        public static int Interval
        {
            get => Clock.Interval;
            set => Clock.Interval = value;
        }

        public static bool IsActiveSceneUnloaded => _isUnloaded;
        private static bool _isUnloaded = false;

        public static event EventHandler<EventArgs.SceneEventArgs> FrameStarted;
        public static event EventHandler<EventArgs.SceneEventArgs> StateUpdated;
        public static event EventHandler<EventArgs.SceneEventArgs> SceneStarted;
        public static event EventHandler<EventArgs.SceneEventArgs> ScenePaused;
        public static event EventHandler<EventArgs.SceneEventArgs> SceneUnloaded;

        static GameLoop()
        {
            //Clock = new Clock();
            Clock = new Timer();
            StopWatch = new Stopwatch();
            Interval = 200;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LoadScene(Scene.Scene scene)
        {
            _activeScene = scene;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void UnloadScene()
        {
            Clock.Tick -= NextFrame;
            Clock.Stop();
            _isUnloaded = true;
            //Clock.Disable();
            //_activeScene.Unload();
            SceneUnloaded?.Invoke(null, new EventArgs.SceneEventArgs(_activeScene));
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Start()
        {
            Clock.Tick += NextFrame;
            _isUnloaded = false;
            _activeScene.Reload();
            Input.Reset();
            SceneStarted?.Invoke(null, new EventArgs.SceneEventArgs(ActiveScene));
            FrameStarted?.Invoke(null, new EventArgs.SceneEventArgs(ActiveScene));
            StopWatch.Start();
            
            // wywołanie Awake 
            for (int i = 0; i < _activeScene.GameObjects.Count; i++)
                for (int j = 0; j < _activeScene.GameObjects[i].CustomScripts.Count; j++)
                        _activeScene.GameObjects[i].CustomScripts[j].Awake();

            // wywołanie Start - tylko jeśli skrypt jest włączony
            for (int i = 0; i < _activeScene.GameObjects.Count; i++)
                for (int j = 0; j < _activeScene.GameObjects[i].CustomScripts.Count; j++)
                        if(_activeScene.GameObjects[i].CustomScripts[j].IsActive)
                            _activeScene.GameObjects[i].CustomScripts[j].Start();

            // rysowanie sceny
            Renderer.DrawScene(ActiveScene);

            StopWatch.Stop();
            Time.DeltaTime = StopWatch.Elapsed.TotalSeconds;

            //Clock.Enable();
            Clock.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void NextFrame(object obj, System.EventArgs e)
        {
            FrameStarted?.Invoke(null, new EventArgs.SceneEventArgs(ActiveScene));
            StopWatch.Restart();

            {
                _activeScene.GameObjects.AddRange(_addingList);
                _addingList.Clear();

                foreach(GameObject.GameObject go in _removingList)
                    _activeScene.GameObjects.Remove(go);

                _removingList.Clear();
            }

            // wywołanie GUI
            {
                for (int i = 0; i < _activeScene.GameObjects.Count; i++)
                    for (int j = 0; j < _activeScene.GameObjects[i].CustomScripts.Count; j++)
                        if(_activeScene.GameObjects[i].CustomScripts[j].UseGUILayout &&
                            _activeScene.GameObjects[i].CustomScripts[j].IsActive)
                            _activeScene.GameObjects[i].CustomScripts[j].Update();
            }

            // wywołanie Update
            {
                for (int i = 0; i < _activeScene.GameObjects.Count; i++)
                    for (int j = 0; j < _activeScene.GameObjects[i].CustomScripts.Count; j++)
                        if (_activeScene.GameObjects[i].CustomScripts[j].IsActive)
                            _activeScene.GameObjects[i].CustomScripts[j].Update();

                StateUpdated?.Invoke(null, new EventArgs.SceneEventArgs(ActiveScene));
            }

            // sprawdzenie Kolizji
            for(int i = 0; i < ActiveScene.GameObjects.Count; i++)
            {
                //while (!ActiveScene.GameObjects[i].Collider.IsActive && i < ActiveScene.GameObjects.Count)
                //    i++;

                for(int j = i + 1; j < ActiveScene.GameObjects.Count; j++)
                {
                    //while (!ActiveScene.GameObjects[j].Collider.IsActive && j < ActiveScene.GameObjects.Count)
                    //    j++;

                    if(ActiveScene.GameObjects[i].Collider.IsTouching(ActiveScene.GameObjects[j].Collider))
                    {
                        // Pierwszy kolider
                        Collision2D collision = new Collision2D(ActiveScene.GameObjects[j].Collider);

                        foreach (CustomScript script in ActiveScene.GameObjects[i].CustomScripts)
                            script.OnCollisionEnter(collision);

                        ActiveScene.GameObjects[i].Collider.OnCollisionEnter(collision);

                        // Drugi kolider
                        collision = new Collision2D(ActiveScene.GameObjects[i].Collider);

                        foreach (CustomScript script in ActiveScene.GameObjects[j].CustomScripts)
                            script.OnCollisionEnter(collision);

                        ActiveScene.GameObjects[j].Collider.OnCollisionEnter(collision);
                    }
                }
            }

            // Myszka
            foreach(GameObject.GameObject go in ActiveScene.GameObjects)
            {
                // ???
            }

            // rysowanie sceny
            Renderer.DrawScene(ActiveScene);

            StopWatch.Stop();
            Time.DeltaTime = StopWatch.Elapsed.TotalSeconds;

            Console.WriteLine();
            Console.WriteLine($"GameObjects-{_activeScene.GameObjects.Count}");
            Console.WriteLine($"RenderingScale-{Renderer.RenderingScale}");
            Console.WriteLine($"InputMovement-{Input.Movement.X}, {Input.Movement.Y}");
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Pause()
        {
            //Clock.Disable();
            Clock.Stop();
            ScenePaused?.Invoke(null, new EventArgs.SceneEventArgs(_activeScene));
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Resume()
        {
            Clock.Start();
            //Clock.Enable();
        }

        public static void AddToActiveScene(GameObject.GameObject gameObject)
        {
            _addingList.Add(gameObject);
        }

        public static void RemoveFromActiveScene(GameObject.GameObject gameObject)
        {
            _removingList.Add(gameObject);
        }

    }
}
