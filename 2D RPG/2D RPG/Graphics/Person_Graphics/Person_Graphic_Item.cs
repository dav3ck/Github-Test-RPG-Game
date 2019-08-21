using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.Graphics.Person_Graphics
{
    class Person_Graphic_Item : Graphic_Item
    {
        public Person_Graphic_Item(Point Location)
        {
            SetScreenLocation(Location);
        }
    }
}
