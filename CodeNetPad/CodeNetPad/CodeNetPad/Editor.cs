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

namespace CodeNetPad
{
    /// <summary>
    /// CodeNetPad begins here
    /// </summary>
    public class Editor : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Editor()
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
            this.Window.Title = "CodeNetPad - Open Source Online Editor - 2012";
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

            

            base.Update(gameTime);
        }

        /// <summary>
        /// Drawing Interface
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            Texture2D tex = new Texture2D(GraphicsDevice, 1, 1, true, SurfaceFormat.Color);
            tex.SetData(new[] { Color.White });

            spriteBatch.Begin();

            spriteBatch.Draw(tex, new Rectangle(0, 0, 5, 5), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
