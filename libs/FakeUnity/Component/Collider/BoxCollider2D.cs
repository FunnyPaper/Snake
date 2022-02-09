namespace FakeUnity.Component.Collider
{
    /// <summary>
    /// Klasa dla koliderów o kształcie prostokąta
    /// </summary>
    public sealed class BoxCollider2D : Collider2D
    {
        /// <summary>
        /// Wymiary kolidera
        /// </summary>
        public NativeTypes.Vector2 Size => BoundingArea.Size;

        public override NativeTypes.Vector2 ClosestPoint(NativeTypes.Vector2 position)
        {
            // uwzględnić pozycję w przestrzeni
            NativeTypes.Bounds me = this.BoundingArea;
            me.Center += Transform.Position;

            return me.ClosestPoint(position);
        }

        public override bool IsTouching(Collider2D collider)
        {
            // uwzględnić pozycję w przestrzeni 
            NativeTypes.Bounds me = this.BoundingArea;
            NativeTypes.Bounds other = collider.BoundingArea;

            //me.Center += Transform.Position;
            me.SetCenterExtents(
                Transform.Position + me.Center,
                NativeTypes.Vector2.Scale(me.Extents, Transform.Scale)
                );

            //other.Center += collider.Transform.Position;
            other.SetCenterExtents(
                collider.Transform.Position + other.Center,
                NativeTypes.Vector2.Scale(other.Extents, collider.Transform.Scale)
                );

            return me.Intersects(other);
        }

        public override void OnCollisionEnter(Collision.Collision2D collision)
        {
            System.Console.WriteLine($"Collision occured between {this}-{this.ID} and {collision.Collider}-{collision.Collider.ID}");
        }
    }
}
