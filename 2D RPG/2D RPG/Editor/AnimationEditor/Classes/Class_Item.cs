using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.Editor.AnimationEditor
{
    public class Class_Item
    {
        public string Name;
        public string Discription;
        public int ID;
        public Spritesheet_Instance Spritesheet;

        public Class_Item(string Name, string Discription, int ID, string Spritesheet)
        {
            this.Name = Name;
            this.Discription = Discription;
            this.ID = ID;
            this.Spritesheet = Initialize_Spritesheet.AssignSpritesheet(Spritesheet);
            //this.Spritesheet = Spritesheet;
            
        }
    }
}
