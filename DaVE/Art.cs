using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class Art
    {
        public static Texture2D BackgroundLevel1 { get; private set; }
        public static SpriteFont Font { get; private set; }
        public static void Load(ContentManager content)
        {
            BackgroundLevel1 = content.Load<Texture2D>("backgrounds/backgroundLevel1");
            Font = content.Load<SpriteFont>("fonts/default");
        }

        public static void Unload(ContentManager content)
        {

        }
    }
}
