using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using FakeUnity.NativeTypes;

namespace FakeUnity.Core
{
    public static class Renderer
    {
        public static PictureBox Canvas { get; private set; }
        public static Rectangle CanvaSize => Canvas.DisplayRectangle;

        public static bool DrawOutlines { get; set; }
        public static Color OutlineColor { get; set; }

        public static float RenderingScale { get; set; } = 1;

        public static event EventHandler<EventArgs.GameObjectEventArgs> ObjectDrawed;
        public static event EventHandler<EventArgs.GameObjectSequenceEventArgs> ObjectSequenceDrawed;
        public static event EventHandler<EventArgs.SkyboxEventArgs> SkyboxDrawed;
        public static event EventHandler<EventArgs.SceneEventArgs> SceneDrawed;

        public static void SetCanvas(PictureBox canvas)
        {
            if (Canvas == canvas)
                return;

            Canvas = canvas;
        }

        public static Bitmap MakeScreenshot()
        {
            if (Canvas == null)
                return null;

            Bitmap bitmap = new Bitmap(Canvas.ClientRectangle.Width, Canvas.ClientRectangle.Height);
            Canvas.DrawToBitmap(bitmap, Canvas.ClientRectangle);

            return bitmap;
        }

        public static void DrawObject(GameObject.GameObject gameObject, Graphics graphics)
        {
            if (!gameObject.IsVisible)
                return;

            PointF[] mesh = gameObject.Mesh.Vertices
                .Select(v => (PointF)(Vector2.Scale(v, gameObject.Transform.Scale) * 
                RenderingScale + gameObject.Transform.Position * 
                RenderingScale + new Vector2(RenderingScale/2, RenderingScale/2)))
                .ToArray();

            using (SolidBrush brush = new SolidBrush(gameObject.Material.Color))
            {
                graphics.FillPolygon(brush, mesh);
            }

            //using (Pen brush = new Pen(Color.Black))
            //{
            //    graphics.DrawPolygon(brush, mesh);
            //}

            ObjectDrawed?.Invoke(null, new EventArgs.GameObjectEventArgs(gameObject));
        }

        public static void DrawSkybox(Skybox.Skybox skybox, Graphics graphics)
        {
            graphics.Clear(Color.White);
            // coś tu będzie
            SkyboxDrawed?.Invoke(null, new EventArgs.SkyboxEventArgs(skybox));
        }

        public static void DrawObjects(GameObject.GameObject[] gameObjects, Graphics graphics)
        {
            foreach(GameObject.GameObject gameObject in gameObjects)
            {
                DrawObject(gameObject, graphics);
            }

            ObjectSequenceDrawed?.Invoke(null, new EventArgs.GameObjectSequenceEventArgs(gameObjects));
        }

        public static void DrawObjects(IEnumerable<GameObject.GameObject> gameObjects, Graphics graphics)
            => DrawObjects(gameObjects.ToArray(), graphics);

        public static void DrawScene(Scene.Scene scene)
        {
            Graphics graphics = Canvas.CreateGraphics();
            graphics.Clear(Color.White);

            DrawSkybox(scene.Skybox, graphics);
            DrawObjects(scene.GameObjects, graphics);

            SceneDrawed?.Invoke(null, new EventArgs.SceneEventArgs(scene));
        }
    }
}
