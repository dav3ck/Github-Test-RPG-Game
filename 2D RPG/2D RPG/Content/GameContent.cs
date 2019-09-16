using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace _2D_RPG
{
    public class GameContent
    {
        public Texture2D SpriteSheet_Test { get; set; }
        public Texture2D TestTile1 { get; set; }
        public Texture2D TestTile2 { get; set; }
        public Texture2D TestSpriteSheet{ get; set; }
        public SpriteFont Arial20 { get; set; }

        public GameContent(ContentManager content)
        {
            SpriteSheet_Test = content.Load<Texture2D>("Test_Spritesheet_1");
            TestTile1 = content.Load<Texture2D>("Tile1");
            TestTile2 = content.Load<Texture2D>("Tile2");
            Arial20 = content.Load<SpriteFont>("Arial20");
            TestSpriteSheet = content.Load<Texture2D>("Bad_Player_Walk");
        }
    }
}
