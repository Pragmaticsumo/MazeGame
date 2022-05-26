using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.IO;
using MazeGame;
using MazeGame.Entities;

namespace MazeGame
{
    public class Level
    {
        public static Player Player = new Player();

        public void Update(GameTime gameTime)
        {
            Player.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Player.Draw(gameTime, spriteBatch);
        }
    }
}