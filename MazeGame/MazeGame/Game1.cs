using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MazeGame;
using MazeGame.Entities;

namespace MazeGame
{
    public class Game1 : Game
    {
        public static Game1 Instance { get; private set; }
        public GraphicsDeviceManager MazeGraphicsDeviceManager { get; }
        public SpriteBatch MazeSpriteBatch { get; private set; }

        public Game1()
        {
            Instance = this;
            MazeGraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "MazeGame";

            base.OnActivated(sender, args);
        }

        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowAltF4 = true;
        }

        protected override void LoadContent()
        {
            MazeSpriteBatch = new SpriteBatch(GraphicsDevice);
            AssetManager.LoadAssets();
        }

        protected override void Update(GameTime gameTime)
        {
            Main.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            MazeSpriteBatch.Begin();
            Main.Draw(gameTime, MazeSpriteBatch);
            MazeSpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
