using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2D_RPG.Graphics
{
    public class Graphic_Item
    {
        protected Point location_on_screen{get; private set;}
        protected Texture2D Image {get; private set; }

        public void SetScreenLocation(Point Location)
        {
            //Set a new location for a graphic Item

            location_on_screen = Location;
        }

        public static Point GetScreenLocation(Graphic_Item graphic_item)
        {
            //Get a new location for a graphic Item

            return graphic_item.location_on_screen;
        }

        public void SetImage(Texture2D image)
        {
            Image = image;
        }
    }
}
