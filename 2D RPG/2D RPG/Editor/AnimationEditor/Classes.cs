using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG.Editor.AnimationEditor
{
    static class Classes
    {
        public static List<Class_Instance> all_classes = new List<Class_Instance>();

        static Classes()
        {
            Initialize_Classes.Load_Classes();
            
        }
    }
}
