using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.IO;
using MazeGame;
using MazeGame.Entities;
using Newtonsoft.Json;

namespace MazeGame
{
    public class Level
    {
        public static StreamReader r = new StreamReader(Main.LevelPath);
        static string jsonString = r.ReadToEnd();
        public LevelParams m = JsonConvert.DeserializeObject<LevelParams>(jsonString);

        public class LevelParams
        {
            public string LevelName { get; set; }
            public Vector2 PlayerSpawn { get; set; }
            public string MapPath { get; set; }
        }

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