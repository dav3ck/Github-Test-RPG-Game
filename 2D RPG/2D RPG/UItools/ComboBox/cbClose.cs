using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.UItools.ComboBox
{
    public static class cbClose
    {
        public static void Close(cbInstance combobox, cbElement selected = null)
        {
            if (selected != null)
            {
                combobox.Selected = selected;
            }

            combobox.Text = combobox.Selected.Text;
            combobox.Active = false;
            combobox.Number = 0;
            Clear_cbElements(combobox);
        }

        private static void Clear_cbElements(cbInstance combobox)
        {
            UI_Box.UIboxList.RemoveAll(x => combobox.Loaded_cbElements.Contains(x));
            combobox.Loaded_cbElements.Clear(); 
        }
    }
}
