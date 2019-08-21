using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.Button
{
    public class btInstance : UI_Box
    {
        public delegate void Action();
        private Action action;

        public btInstance(Point location, int width, int height, string text, Action x)
        {
            this.Location = location;
            this.Width = width;
            this.Height = height;
            this.Text = text;
            Hitbox = new Rectangle(Location, new Point(Width, Height));

            action = x;
        }

        public override void Open()
        {
            action();
        }
    }
}
