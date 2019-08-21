using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.UItools
{
    public abstract class UI_ActiveBox : UI_Box
    {
        public abstract void Close();
        public abstract void update();

        public static List<UI_ActiveBox> ActiveUIBoxes = new List<UI_ActiveBox>();

        public static void CloseActive()
        {
            foreach (var x in ActiveUIBoxes)
            {
                x.Active = false;
                x.Close();
            }

            ActiveUIBoxes.Clear();
        }

    }
}
