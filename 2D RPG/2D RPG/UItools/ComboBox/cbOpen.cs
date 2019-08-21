using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.ComboBox
{
    static class cbOpen
    {
        static public void Open(cbInstance cb)
        {

            if (cb.Active)
            {
                return;
            }

            cb.Active = true;
            cb.canScroll = false;

            Console.WriteLine("Opening ComboBox!");

            if (cb.cbElements.Count() > ComboBox.cbMaxSize)
            {
                cb.canScroll = true;
            }

            for (int x = 0; x < ComboBox.cbMaxSize && x < cb.cbElements.Count(); x++)
            {
                cb.Loaded_cbElements.Add(new cbElement(x, new Point(cb.Location.X, cb.Location.Y + cb.Height * (x + 1)), cb.Width, cb.Height, cb, cb.cbElements[x]));
            }

            cb.Selected = cb.Loaded_cbElements.First();

            UI_ActiveBox.ActiveUIBoxes.Add(cb);
        }
    }
}
