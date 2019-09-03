using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.Editor.AnimationEditor
{
    public abstract class Field
    {
        protected Point Location;
        protected Point Size;
        protected int Zoom;
        protected string Name;
        protected bool booldraw;

        public Rectangle Hitbox;

        public void Draw()
        {
            if (!booldraw) { return; }

            Game1.backSpriteBatch.Draw(Game1.texture.TestTile1, new Rectangle(Location, Size), Color.Green);
        }
    }
}
