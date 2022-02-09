namespace FakeUnity.EventArgs
{
    public class GameObjectEventArgs : System.EventArgs
    {
        public GameObject.GameObject GameObject { get; }
        public GameObjectEventArgs(GameObject.GameObject gameObject)
        {
            GameObject = gameObject;
        }
    }
}
