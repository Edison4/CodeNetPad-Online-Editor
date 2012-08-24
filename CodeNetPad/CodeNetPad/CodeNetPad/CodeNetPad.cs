using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using CodeNetPad.GUI;
using CodeNetPad.Drawing;

namespace CodeNetPad
{
    /// <summary>
    /// CodeNetPad begins here
    /// </summary>
    public class CodeNetPad : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Editor editor;

        public CodeNetPad()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Initialization
        /// </summary>
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 950;
            graphics.PreferredBackBufferHeight = 650;
            graphics.ApplyChanges();

            this.IsMouseVisible = true;
            this.Window.Title = "CodeNetPad - Open Source Online Editor 2012";
            this.Window.AllowUserResizing = true;
            this.Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);

            base.Initialize();
        }

        void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            // Make changes to handle the new window size.
        }

        /// <summary>
        /// Loading Content
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Graph.Init(GraphicsDevice);

            // Create Editor Element
            editor = new Editor();
            editor.X = 5;
            editor.Y = 5;
            editor.Width = 50;
            editor.Height = 50;
        }

        /// <summary>
        /// Unload Content
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Update CodeNetPad
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Exit when pressing key Escape
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // Update Editor
            editor.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// Drawing Interface
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(185, 185, 185));

            spriteBatch.Begin();

            // Drawing Editor
            editor.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
