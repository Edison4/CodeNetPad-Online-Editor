using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CodeNetPad
{
    static class Art
    {
        public static ContentManager content;
        public static Texture2D BUTTON_DEFAULT; 

        public static void Loading(ContentManager c)
        {
            content = c;
            BUTTON_DEFAULT = content.Load<Texture2D>(@"GUI\\button_default");
        }

    }
}
