using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.TextInput
{
    public class tibInstance : UI_ActiveBox
    {
        private string Infotext;

        public tibInstance(Point location, int width, int height, string text)
        {
            this.Location = location;
            this.Width = width;
            this.Height = height;

            this.Infotext = text;
            this.Text = Infotext;

            this.Hitbox = new Rectangle(this.Location, new Point(this.Width, this.Height));
        }

        public override void Open()
        {
            if (this.Active)
            {
                return;
            }

            this.Active = true;
            this.Text = "";
            UI_ActiveBox.ActiveUIBoxes.Add(this);
        }

        public override void Close()
        {
            if(this.Text == "")
            {
                this.Text = this.Infotext;
            }
        }

        public override void update()
        {
            //CHECK HERE FOR USER INPUT
            //CURSOR POSITION
            // MAX WORD LIMIT ??
        } 
    }
}
