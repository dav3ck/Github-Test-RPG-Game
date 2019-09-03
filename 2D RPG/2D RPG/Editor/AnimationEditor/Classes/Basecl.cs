using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.Editor.AnimationEditor
{
    static class Basecl
    {
        public static List<Class_Instance> all_classes = new List<Class_Instance>();
        public static List<string> all_classes_name = new List<string>();

        static Basecl()
        {
            Initialize_Classes.Load_Classes();

            foreach(var x in all_classes)
            {
                all_classes_name.Add(x.Name);
            }
        }
    }
}
