using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using _2D_RPG;

namespace _2D_RPG.Editor.AnimationEditor
{
    class Class_Instance
    {

        public List<Class_Item> class_items;
        public string Name;
        public string Discription;

        public Class_Instance()
        {

        } 

        public class Class_Item
        {
            public string Name1;
            public string Discription;
            public int ID;
            public Spritesheet_Instance Spritesheet;

            public Class_Item(string Name, string Discription, int ID, string Spritesheet)
            {
                this.Name1 = Name;
                this.Discription = Discription;
                this.ID = ID;
                this.Spritesheet = Initialize_Spritesheet.AssignSpritesheet(Spritesheet);
                //this.Spritesheet = Spritesheet;
            }
        }
    }
}
