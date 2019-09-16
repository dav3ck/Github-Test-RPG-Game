using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.SpritesheetBox
{
    class sbDisElement : UI_Box
    {
        private sbInstance Parent;
        private sbElement Mirror;

        public sbDisElement(Point location, Point size)
        {
            this.Location = location;
            this.Width = size.X;
            this.Height = size.Y;
        }
        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}
