using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.Switch
{
    public class sbInstance : UI_Box
    {
        public Tuple<string, string> TextStates;
        public bool State;

        public sbInstance(Point location, int width, int height, Tuple<string,string> textState, string id, bool state = false, Action x = null)
        {
            this.Location = location;
            this.Width = width;
            this.Height = height;
            this.ID = id;
            this.TextStates = textState;
            this.State = state;
            this.Hitbox = new Rectangle(Location, new Point(Width, Height));
            this.action = x;

            this.Text = this.State ? TextStates.Item2 : TextStates.Item1;     
        }

        public override void Open()
        {
            this.State = !this.State;
            this.Text = this.State ? TextStates.Item2 : TextStates.Item1;


            if (action != null) { action(); }
        }
    }
}
