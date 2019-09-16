using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2D_RPG.UItools.SpritesheetBox
{
    struct sbElement
    {
        public int Row;
        public int RowValue;

        public Spritesheet_Instance shInstance;

        public sbElement(int _rowValue, int _row, Spritesheet_Instance _shInstance)
        {
            this.Row = _row;
            this.RowValue = _rowValue;
            this.shInstance = _shInstance;
        }
    }
}
