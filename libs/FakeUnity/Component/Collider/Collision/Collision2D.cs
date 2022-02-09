namespace FakeUnity.Component.Collider.Collision
{
    /// <summary>
    /// Klasa magazynująca informację o kolizji 2D
    /// </summary>
    public sealed class Collision2D : Core.FakeUnityObject
    {
        /// <summary>
        /// Uderzony kolider
        /// </summary>
        public Collider2D Collider { get; }

        /// <summary>
        /// Obiekt do którego należy uderzony kolider
        /// </summary>
        public GameObject.GameObject GameObject => Collider?.GameObject;

        /// <summary>
        /// Transformacja obiektu do którego należy uderzony kolider
        /// </summary>
        public Transform Transform => Collider?.GameObject?.Transform;

        /// <summary>
        /// Konstruktor kolizji 2D
        /// </summary>
        /// <param name="collider">Uderzony kolider</param>
        internal Collision2D(Collider2D collider)
        {
            Collider = collider;
        }
    }
}