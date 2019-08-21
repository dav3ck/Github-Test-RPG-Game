using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.UItools.ComboBox
{
    public static class ComboBox
    {
        public static List<cbInstance> cbList = new List<cbInstance>();
        public static int cbMaxSize = 4;

        public static void ClearAll()
        {
            cbList = new List<cbInstance>();
        }

        public static string GetValue(int ID)
        {
            cbInstance combobox = cbList.Find(x => x.ID == ID);

            if(combobox == null)
            {
                return "";
            }

            return combobox.Text;
        }

    }
}
