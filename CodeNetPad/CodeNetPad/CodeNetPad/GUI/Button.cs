using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeNetPad.Drawing;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CodeNetPad.GUI
{
    class Button : Element 
    {
        private Texture2D iconTex;
        public String Text;
        private int state;

        public Button(String Caption)
        {
            Text = Caption;
            state = 0;
            /* 
             * state:
             *  = 0 > Released
             *  = 1 > Hover
             *  = 2 > Pressed
            */
        }
        public void Update()
        {
            MouseState mouseState = Mouse.GetState();

            int mX = mouseState.X;
            int mY = mouseState.Y;

            if (mX > X && mY > Y && mX < X + Width && mY < Y + Height)
            {
                if (mouseState.LeftButton != ButtonState.Pressed)
                {
                    state = 1;
                }
                else
                {
                    state = 2;
                }


            }
            else
            {
                state = 0;
            }
        
        }
        public void Draw(SpriteBatch sprite)
        {
            switch (state)
            {
                case 0:
                    Graph.DrawFillRect(sprite, X, Y, Width, Height, Color.White);
                    break;
                case 1:
                    Graph.DrawFillRect(sprite, X, Y, Width, Height, Color.Gray);
                    break;
                case 2:
                    Graph.DrawFillRect(sprite, X, Y, Width, Height, Color.DarkGray);
                    break;
            }
            
        }
        public void LoadIcon(String iconPath)
        {
            iconTex = Art.content.Load<Texture2D>(iconPath);
        }
    }
}
