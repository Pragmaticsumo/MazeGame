using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MazeGame;
using MazeGame.Entities;
using System.IO;

namespace MazeGame
{
    public static class Main
    {
        /*GameStuff*/
        public static readonly Version GameVersion = new Version(0, 0, 1);
        public static readonly string VersionText = $"MazeGame v{GameVersion}";
        public static Cursor Cursor = new Cursor();
        public static Player Player = new Player();
        public static Level Level = new Level();
        public static Vector2 WindowMeasurements = Vector2.Zero;
        public static string LevelPath = "Levels/testLevel.json";

        /*States*/
        public static MouseState MazeMouse = Mouse.GetState();
        public static MouseState PrevMazeMouse = MazeMouse;
        public static KeyboardState MazeKeyboard = Keyboard.GetState();
        public static KeyboardState PrevMazeKeyboard = MazeKeyboard;

        /*Sounds*/

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            GraphicsDeviceManager graphicsDeviceManager = Game1.Instance.MazeGraphicsDeviceManager;
            GraphicsDevice graphicsDevice = graphicsDeviceManager.GraphicsDevice;

            graphicsDevice.Clear(Color.CornflowerBlue);

            // Draw anything else
            Level.Draw(gameTime, spriteBatch);

            // Get window measurements
            WindowMeasurements = graphicsDeviceManager.IsFullScreen ? new Vector2(graphicsDevice.DisplayMode.Width, graphicsDevice.DisplayMode.Height) : new Vector2(graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);

            // Draw any text that needs to be drawn
            DrawText(spriteBatch, graphicsDeviceManager, graphicsDevice);
        }

        public static void Update(GameTime gameTime)
        {
            PrevMazeMouse = MazeMouse;
            MazeMouse = Mouse.GetState();

            PrevMazeKeyboard = MazeKeyboard;
            MazeKeyboard = Keyboard.GetState();

            Level.Update(gameTime);

            if (MazeKeyboard.IsKeyDown(Keys.P) && PrevMazeKeyboard.IsKeyUp(Keys.P))
            {
                LevelPath = "Levels/testLevel02";
            }
            else if (MazeKeyboard.IsKeyDown(Keys.L) && PrevMazeKeyboard.IsKeyUp(Keys.L))
            {
                LevelPath = "Levels/testLevel";
            }
        }

        public static void DrawText(SpriteBatch spriteBatch, GraphicsDeviceManager graphicsDeviceManager, GraphicsDevice graphicsDevice)
        {
            Vector2 levelName = AssetManager.TheFont.MeasureString(Level.m.LevelName);
            spriteBatch.DrawString(AssetManager.TheFont, Level.m.LevelName, new Vector2(0, 25 - levelName.Y), Color.Black);
    }
    }
}
