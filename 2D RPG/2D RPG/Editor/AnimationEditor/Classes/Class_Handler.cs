using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2D_RPG.UItools.ComboBox;
using _2D_RPG.UItools;
using Microsoft.Xna.Framework;
using _2D_RPG.Editor.AnimationEditor.Layer;


namespace _2D_RPG.Editor.AnimationEditor.Classes
{
    static class Class_Handler
    {
        public static Class_Instance currentcl;
        public static List<Class_Item> currentcli = new List<Class_Item>();

        private static cbInstance Classcb;
        public static cbInstance ClassItemcb;

        public static void Class_Handler_Initialize()
        {
            currentcl = Basecl.all_classes[0];

            Classcb = new cbInstance(new Point(100, 100), Basecl.all_classes_name, "Classcb", 100, 30, new UI_Box.Action(switchclass));
            ClassItemcb = new cbInstance(new Point(100, 250), currentcl.class_item_name, "ClassItemcb", 100, 30, new UI_Box.Action(Layer_Handler.SwitchLayer));

            Layer_Handler.InitializeLayers(Basecl.all_classes.First().class_items);
        }

        public static void switchclass ()
        {
            string cl_name = Classcb.Selected.Text;

            Class_Instance cl = Basecl.all_classes.Find(x => x.Name == cl_name);

            if(cl == null)
            {
                Console.WriteLine("Class Handler: Name could not be found during class switch");
                return;
            }

            ClassItemcb.ChangeOptions(cl.class_item_name);

            currentcl = cl;
            currentcli = cl.class_items;

            Layer_Handler.InitializeLayers(cl.class_items);
        }
    }
}
