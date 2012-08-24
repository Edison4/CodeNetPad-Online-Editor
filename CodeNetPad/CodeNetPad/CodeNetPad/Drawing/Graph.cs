using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CodeNetPad.Drawing
{
    static class Graph
    {
        private static GraphicsDevice GraphDevice;
        private static Texture2D tex;

        public static void Init(GraphicsDevice g)
        {
            GraphDevice = g;

            tex = new Texture2D(GraphDevice, 1, 1, true, SurfaceFormat.Color);
            tex.SetData(new[] { Color.White });
        }

        // Drawing Rectangle
        public static void DrawRect(SpriteBatch sprite, Rectangle rect, Color color)
        {
            sprite.Draw(tex, rect, color);
        }
        public static void DrawRect(SpriteBatch sprite, int X, int Y, int W, int H, Color color)
        {
            sprite.Draw(tex, new Rectangle(X, Y, W, H), color);
        }
    }
}
