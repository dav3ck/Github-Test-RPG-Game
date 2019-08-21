using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _2D_RPG
{
    public static class Initialize_Spritesheet
    {
        // This is a list containing all the spriteSheets that are currently loaded.
        public static List<Spritesheet_Instance> loaded_Spritesheets = new List<Spritesheet_Instance>();


        public static void LoadData(string spritesheet_name)
        {
            //This Reads all the Data from the Spritesheet Json file and loads it into an object which corresponds
            //to the loaded spritesheet

            string Path = GetPath(spritesheet_name);

            Console.WriteLine("SpriteSheet Manager: Finding Spritesheet Data at Path {0}", Path);

            using (StreamReader r = new StreamReader(Path))
            {
                string json = r.ReadToEnd();
                Spritesheet_Instance test = JsonConvert.DeserializeObject<Spritesheet_Instance>(json);
            }
        }

        private static string GetPath(string name)
        {
            //Returns the File Path that matches a given Spritesheet name

            return Initialize_Spritesheet_Config.Spritesheet_Data_File.Find(x => x.name == name).path;
        }


        public static Spritesheet_Instance AssignSpritesheet(string name)
        {
            //A Object can ask to be assigned a SpriteSheet, this is done by giving the name of the spritesheet,
            //If the SpriteSheet is already loaded it will return it, If the spritesheet exists but is not yet loaded
            //it will load it and then return it. If the Given name does not correspont to a Spritesheet, it will return
            //the standard Blanc Spritesheet.

            if (loaded_Spritesheets.Any(x => x.name == name))
            {
                Console.WriteLine("SpriteSheet Manager: {0} was already loaded", name);
                return loaded_Spritesheets.Find(x => x.name == name);
            }
            else if (Initialize_Spritesheet_Config.Spritesheet_Data_File.Any(x => x.name == name))
            {
                Console.WriteLine("SpriteSheet Manager: {0} is loading", name);
                LoadData(name);
                return loaded_Spritesheets.Find(x => x.name == name);
            }
            else
            {
                Console.WriteLine("Spritesheet Manager: {0} Does not exist! loading Blanc Spritesheet");
                return loaded_Spritesheets.Find(x => x.name == "Blanc");
            }
        }

        public static void Load(string name)
        {
            //This Function does the same as AssignSpriteSheet only does it not return a Spritesheet, this method can be used for manual loading of spritesheets

            if (loaded_Spritesheets.Any(x => x.name == name))
            {
                Console.WriteLine("SpriteSheet Manager: {0} was already loaded", name);
            }
            else if (Initialize_Spritesheet_Config.Spritesheet_Data_File.Any(x => x.name == name))
            {
                Console.WriteLine("SpriteSheet Manager: {0} is loading", name);
                LoadData(name);
            }
            else
            {
                Console.WriteLine("SpriteSheet Manager: {0} does not exist", name);
            }
        }

    }


}
