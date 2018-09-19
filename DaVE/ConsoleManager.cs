using System.Collections.Generic;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class ConsoleManager : DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        Console console;

        List<System.String> messages = new List<System.String>();

        public ConsoleManager(Game game)
            : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            messages.Add("Test Message 1");
            messages.Add("Test Message 2");
            messages.Add("Test Message 3");
            messages.Add("Test Message 4");
            messages.Add("Test Message 5");
            messages.Add("Test Message 6");
            messages.Add("Test Message 7");
            messages.Add("Test Message 8");
            messages.Add("Test Message 9");
            messages.Add("Test Message 10");
            messages.Add("Test Message 11");



            console = new Console(messages, Game.Content.Load<SpriteFont>("fonts/default"));

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            console.Draw(gameTime, spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
