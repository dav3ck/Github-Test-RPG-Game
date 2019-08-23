using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace _2D_RPG.UItools.ComboBox
{
    public class cbElement : UI_Box
    {
        public int Position;
        private cbInstance Parent;

        public cbElement(int Position, Point Location, int Width, int Height, cbInstance Parent, string Text = "null")
        {
            this.Position = Position;
            this.Location = Location;
            this.Width = Width;
            this.Height = Height;
            this.Text = Text;
            this.Parent = Parent;
            this.Activable = false;
            Hitbox = new Rectangle(Location, new Point(Width, Height));

        }

        public override void Open()
        {
            cbClose.Close(Parent, this);
        }
    }
}
