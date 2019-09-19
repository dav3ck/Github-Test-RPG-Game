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
        public static int cbMaxSize = 5;

        public static void ClearAll()
        {
            cbList = new List<cbInstance>();
        }

        public static string GetValue(string id = "", cbInstance cb = null)
        {
            if (id != "")
            {
                cb = cbList.Find(x => x.ID == id);

                if (cb == null)
                {
                    return "";
                }
            }

            try
            {
                return cb.Text;
            }
            catch (Exception)
            {
                return "";
            }
        }

    }
}
