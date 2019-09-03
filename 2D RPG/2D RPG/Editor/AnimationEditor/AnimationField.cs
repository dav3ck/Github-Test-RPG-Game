using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.Editor.AnimationEditor
{
    public class AnimationField : Field
    {
        public AnimationField(string name, Point size = new Point(), Point location = new Point(), int zoom = 0)
        {
            this.Name = name;
            this.Zoom = zoom;
            this.Size = size;
            this.Location = location;
            this.booldraw = true;

            this.Hitbox = new Rectangle(Location, Size);

        }
    }
}
