using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using _2D_RPG;

namespace _2D_RPG.Editor.AnimationEditor
{
    public class Class_Instance
    {

        public List<Class_Item> class_items = new List<Class_Item>();
        public List<string> class_item_name = new List<string>();
        public string Name;
        public string Discription;

        public Class_Instance(string name, string discription, List<Class_Item> class_items)
        {
            this.Name = name;
            this.Discription = discription;
            this.class_items = class_items;

            foreach (var x in this.class_items)
            {
                class_item_name.Add(x.Name);
            }
        } 



    }
}
