namespace FakeUnity.EventArgs
{
    public class CollisionEventArgs : System.EventArgs
    {
        public Component.Collider.Collision.Collision2D Collision { get; }
        public CollisionEventArgs(Component.Collider.Collision.Collision2D collision)
        {
            Collision = collision;
        }
    }
}
