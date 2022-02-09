namespace FakeUnity.Component.Collider
{
    /// <summary>
    /// Generyczna klasa do koliderów 2D
    /// </summary>
    public abstract class Collider2D : Script, Messages.ICollider2DMessages
    {
        /// <summary>
        /// Wektor określający przesunięcie kolidera względem centrum obiektu
        /// </summary>
        public NativeTypes.Vector2 Offset { get; set; }

        /// <summary>
        /// Prostokąt okalający kolider
        /// </summary>
        public NativeTypes.Bounds BoundingArea => GameObject.Mesh.Bounds;

        /// <summary>
        /// Metoda zwacająca punkt kolidera który znajduje się najbliżej podanej pozycji
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public abstract NativeTypes.Vector2 ClosestPoint(NativeTypes.Vector2 position);

        /// <summary>
        /// Metoda sprawdzająca czy doszło do kolizji pomiędzy koliderami
        /// </summary>
        /// <param name="collider"></param>
        /// <returns></returns>
        public abstract bool IsTouching(Collider2D collider);

        public abstract void OnCollisionEnter(Collision.Collision2D collision);

        /// <summary>
        /// Metoda statyczna do sprawdzania kolizji (alternatywa dla IsTouching)
        /// </summary>
        /// <param name="first">Pierwszy kolider</param>
        /// <param name="second">Drugi kolider</param>
        /// <returns>Czy pierwszy kolider zderzył się z drugim</returns>
        internal static bool CheckCollisions(Collider2D first, Collider2D second)
        {
            return first.IsTouching(second);
        }
    }
}
