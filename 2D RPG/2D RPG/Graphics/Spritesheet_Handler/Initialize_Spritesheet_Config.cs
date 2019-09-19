using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _2D_RPG
{
    public static class Initialize_Spritesheet_Config
    {
        public static List<SpritesheetFiles> Spritesheet_Data_File;

        static Initialize_Spritesheet_Config()
        {
            //Whenever the program runs anything SpriteSheet related. It will first look in the SpriteSheet_Config.json file
            //and will create a list with all the possible spritesheets and their location

            LoadJson();
        }

        private static void LoadJson()
        {
            using (StreamReader r = new StreamReader("D:/Game/Github-Test-RPG-Game/2D RPG/2D RPG/Graphics/Spritesheet_Handler/Spritesheet_Config.json"))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
                Spritesheet_Data_File = JsonConvert.DeserializeObject<List<SpritesheetFiles>>(json);
            }
        }

        public class SpritesheetFiles
        {
            public string name;
            public string path;
        }
    }


}
