using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CodeNetPad.Drawing;

namespace CodeNetPad.GUI
{
    class Editor : Element
    {
        public Editor()
        {

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch sprite)
        {
            Graph.DrawFillRect(sprite, X, Y, Width, Height, Color.White);
        }
    }
}
