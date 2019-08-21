using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _2D_RPG.Editor.AnimationEditor
{
    static class Initialize_Classes
    {
        public static void Load_Classes()
        {
            string Path = "D:/Game/2D RPG/2D RPG/Editor/AnimationEditor/Saved_Classes.json";

            using (StreamReader r = new StreamReader(Path))
            {
                string Json = r.ReadToEnd();
                Classes.all_classes = JsonConvert.DeserializeObject<List<Class_Instance>>(Json);
            }
        }
    }
}
