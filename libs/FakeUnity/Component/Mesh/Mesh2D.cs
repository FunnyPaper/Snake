using System.Linq;

namespace FakeUnity.Component.Mesh
{
    /// <summary>
    /// Klasa przechowująca informację o meshach 2D
    /// </summary>
    public sealed class Mesh2D : Component
    {
        public static Mesh2D Quad { get; }

        /// <summary>
        /// Tablica punktów definiująca fragment mesha
        /// </summary>
        public NativeTypes.Vector2[] Vertices
        {
            get => _vertices;
            set
            {
                _vertices = value;
                NativeTypes.Vector2 min = new NativeTypes.Vector2();
                NativeTypes.Vector2 max = new NativeTypes.Vector2();
                foreach(var ver in _vertices)
                {
                    if (ver.X < min.X)
                        min.X = ver.X;
                    else max.X = ver.X;

                    if (ver.Y < min.Y)
                        min.Y = ver.Y;
                    else max.Y = ver.Y;
                }
                Bounds.SetMinMax(min, max);
            }
        }
        private NativeTypes.Vector2[] _vertices;

        /// <summary>
        /// Tablica indeksów definiująca fragment mesha (w połączeniu z Vertices powstają trójkąty)
        /// </summary>
        public int[] Triangles { get; set; }

        /// <summary>
        /// Prostokąt okalający fragment mesha
        /// </summary>
        public NativeTypes.Bounds Bounds { get; }

        public Mesh2D(NativeTypes.Vector2[] vertices)
        {
            Vertices = vertices;

            // policzyć bounds
            Bounds = new NativeTypes.Bounds(vertices);
        }

        static Mesh2D()
        {
            Quad = new Mesh2D(new NativeTypes.Vector2[]
            {
                new NativeTypes.Vector2(-0.5f, -0.5f),
                new NativeTypes.Vector2(-0.5f, 0.5f),
                new NativeTypes.Vector2(0.5f, 0.5f),
                new NativeTypes.Vector2(0.5f, -0.5f)
            });
        }
    }
}
