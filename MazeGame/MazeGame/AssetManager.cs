using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace MazeGame
{
    public static class AssetManager
    {
        /*SpriteFonts*/

        /*Texture2Ds*/
        public static Texture2D Player;

        /*Sounds*/

        internal static void LoadAssets()
        {
            LoadSpriteFonts();
            LoadTexture2Ds();
            LoadSounds();
        }

        #region Quick-call methods

        /// <summary>
        /// Loads a <see cref="SpriteFont"/> from the <c>Content</c> folder.
        /// </summary>
        public static SpriteFont LoadSpriteFont(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<SpriteFont>(assetPath);
        }

        /// <summary>
        /// Loads a <see cref="Texture2D"/> from the <c>Content</c> folder.
        /// </summary>
        public static Texture2D LoadTexture2D(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<Texture2D>(assetPath);
        }

        /// <summary>
        /// Loads a <see cref="SoundEffect"/> from the <c>Content</c> folder.
        /// </summary>

        public static SoundEffect LoadSounds(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<SoundEffect>(assetPath);
        }

        /// <summary>
        /// Shorthand for <see cref="Microsoft.Xna.Framework.Content.ContentManager.Load{T}(string)"/>.
        /// </summary>
        public static T Load<T>(string assetPath) => Game1.Instance.Content.Load<T>(assetPath);

        #endregion Quick-call methods

        #region Texture initialization methods

        private static void LoadSpriteFonts()
        {
        }

        private static void LoadTexture2Ds()
        {
            Player = LoadTexture2D("Skrunkly");
        }

        private static void LoadSounds()
        {
        }

        #endregion Texture initialization methods
    }
}
