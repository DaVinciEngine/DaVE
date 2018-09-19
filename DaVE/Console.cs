using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class Console
    {
        List<System.String> messages;
        SpriteFont spriteFont;
        int fontSize = 12;
        int fontPadding = 2;
        Color fontColor = Color.Black;

        public Console (List<System.String> messages, SpriteFont spriteFont)
        {
            this.messages = messages;
            this.spriteFont = spriteFont;
        }

        public void Initialize()
        {

        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int i = 0; i < messages.Count; i++)
            {
                spriteBatch.DrawString(spriteFont, messages[i],
                    new Vector2( 0, (fontSize + fontPadding) * i),
                    fontColor);

            }
        }

    }
}
