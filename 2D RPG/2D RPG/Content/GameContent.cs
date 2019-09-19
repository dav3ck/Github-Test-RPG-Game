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

        public Texture2D BA_Test { get; set; }
        public Texture2D BL_Test { get; set; }
        public Texture2D FL_Test { get; set; }
        public Texture2D H_Test { get; set; }
        public Texture2D B_Test { get; set; }

        public GameContent(ContentManager content)
        {
            SpriteSheet_Test = content.Load<Texture2D>("Test_Spritesheet_1");
            TestTile1 = content.Load<Texture2D>("Tile1");
            TestTile2 = content.Load<Texture2D>("Tile2");
            Arial20 = content.Load<SpriteFont>("Arial20");
            TestSpriteSheet = content.Load<Texture2D>("Bad_Player_Walk");

            BA_Test = content.Load<Texture2D>("BackArm_TestSpritesheet");
            BL_Test = content.Load<Texture2D>("BackLeg_TestSpritesheet");
            FL_Test = content.Load<Texture2D>("FrontLeg_TestSpritesheet");
            H_Test = content.Load<Texture2D>("Head_TestSpritesheet");
            B_Test = content.Load<Texture2D>("Body_TestSpritesheet");
        }
    }
}
