using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.UItools
{
    public abstract class UI_AlwaysActiveBox : UI_Box
    {
        public abstract void update();
        //public abstract void Draw();

        public static List<UI_AlwaysActiveBox> AlwaysActiveUIBoxes = new List<UI_AlwaysActiveBox>();
    }
}
