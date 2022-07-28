using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using RZEngine.Core.ContentManagement;
using RZEngine.Core.Debugging;
using RZEngine.Core.Tasking;

namespace RZEngine.Core
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        public static Game Instance;
        public Logger Logger;
        public ContentManager ContentMgr;
        public RZAContentLoader ContentLoader;
        public TaskManager Tasks;

        private GraphicsDeviceManager _gdm;
        private SpriteBatch _sb;

        public Game() : base()
        {
            _gdm = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1280,
                PreferredBackBufferHeight = 720,
                IsFullScreen = false
            };

            ContentMgr = new();
            ContentLoader = new(ContentMgr);
            Logger = new();
            Tasks = new();
            Instance = this;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            ContentLoader.Unpack();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void OnExiting(object sender, EventArgs args)
        {
            base.OnExiting(sender, args);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            _gdm.GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
