using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MazeGame;
using MazeGame.Entities;

namespace MazeGame.Entities
{
    public class Player : Entity
    {
        public float playerScale = .50f;
        public float playerRotation = 0f;
        public SpriteEffects playerEffect = SpriteEffects.None;

        public static Vector2 ScreenMiddle => Main.WindowMeasurements / 2f;

        public override void Update(GameTime gameTime)
        {
            if (Main.MazeKeyboard.IsKeyDown(Keys.A))
            {
                if (playerEffect == SpriteEffects.None)
                {
                    playerEffect = SpriteEffects.FlipHorizontally;
                }
                this.Position.X -= 3;
            }
            else if (Main.MazeKeyboard.IsKeyDown(Keys.D))
            {
                if (playerEffect == SpriteEffects.FlipHorizontally)
                {
                    playerEffect = SpriteEffects.None;
                }
                this.Position.X += 3;
            }
            else if (Main.MazeKeyboard.IsKeyDown(Keys.W))
            {
                this.Position.Y -= 3;
            }
            else if (Main.MazeKeyboard.IsKeyDown(Keys.S))
            {
                this.Position.Y += 3;
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.Player, this.Position, null, Color.White, playerRotation, Vector2.Zero, playerScale, playerEffect, 0f);
        }
    }
}
