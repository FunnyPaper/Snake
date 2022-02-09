using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FakeUnity.GameObject
{
    public sealed class Material : Core.FakeUnityObject
    {
        public static Material Red { get; }
        public static Material Green { get; }
        public static Material Blue { get; }
        public static Material LightBlue { get; }
        public static Material Yellow { get; }
        public static Material LightYellow { get; }
        public static Material Pink { get; }
        public static Material Purple { get; }

        // itd
        public static Material Default { get; }

        public static Dictionary<int, Material> SharedMaterial { get; }

        public Color Color { get; set; }
        public Bitmap Bitmap { get; set;}
        public bool HasBitmap => Bitmap != null;

        public Material()
        {
            Color = Color.Black;
            Bitmap = null;
            SharedMaterial[ID] = this;
        }

        public Material(Color color)
        {
            Color = color;
            Bitmap = null;
            SharedMaterial[ID] = this;
        }

        public Material(Color color, Bitmap bitmap)
        {
            Color = color;
            Bitmap = bitmap;
            SharedMaterial[ID] = this;
        }

        static Material()
        {
            SharedMaterial = new Dictionary<int, Material>();
            Red = new Material(Color.Red);
            Green = new Material(Color.Green);
            Blue = new Material(Color.Blue);
            LightBlue = new Material(Color.LightBlue);
            Yellow = new Material(Color.Yellow);
            LightYellow = new Material(Color.LightYellow);
            Pink = new Material(Color.Pink);
            Purple = new Material(Color.Purple);
            Default = new Material(Color.Black);
        }
    }
}
