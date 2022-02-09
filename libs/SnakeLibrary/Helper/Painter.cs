using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Game.Entities;
using System.Drawing;
using SnakeLibrary.Settings;

namespace SnakeLibrary.Helper
{
    public static class Painter
    {
        public static void DrawGrid(Graphics graphics, int tileSize)
        {
            RectangleF Board = graphics.VisibleClipBounds;
            using (Pen brush = new Pen(Color.White))
            {
                for (int i = 1; i < SettingsManager.CurrentState.BoardCols; i++)
                {
                    graphics.DrawLine(brush, new PointF(i * tileSize, 0), new PointF(i * tileSize, Board.Height));
                }

                for (int i = 1; i < SettingsManager.CurrentState.BoardRows; i++)
                {
                    graphics.DrawLine(brush, new PointF(0, i * tileSize), new PointF(Board.Width, i * tileSize));
                }
            }
        }

        public static void DrawEntity(Graphics graphics, IEntity entity, int tileSize)
        {
            using (SolidBrush brush = new SolidBrush(entity.Color))
            {
                graphics.FillRectangle(
                    brush,
                    new RectangleF(
                        new PointF(
                            entity.Position.X * tileSize,
                            entity.Position.Y * tileSize),
                        new SizeF(
                            tileSize,
                            tileSize)));
            }

            using (Pen brush = new Pen(Color.Black))
            {
                graphics.DrawRectangles(
                    brush,
                    new RectangleF[] {
                        new RectangleF(
                            new PointF(
                                entity.Position.X * tileSize,
                                entity.Position.Y * tileSize),
                            new SizeF(
                                tileSize,
                                tileSize)
                            )});
            }
        }

        public static void DrawEntity(Graphics graphics, IEnumerable<IEntity> entities, int tileSize)
        {
            foreach(IEntity entity in entities)           
                DrawEntity(graphics, entity, tileSize);          
        }

        public static void DrawSnake(Graphics graphics, ISnake snake, int tileSize)
        {
            foreach (IEntity entity in snake.Body)
                DrawEntity(graphics, entity, tileSize);
        }
    }
}
