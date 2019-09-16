using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace _2D_RPG
{
    public class Spritesheet_Instance
    {

        //Every currently loaded spritesheet has an Instance like this were
        //all its general information can be found.

        public string name { get; set; }
        public string discription { get; set; }

        public Texture2D image { get; set; }
        public Tuple<int, int> dimensions { get; set; }

        public string[,,] imageInformation { get; set; }

        public Spritesheet_Instance(string name, string discription, string image, Tuple<int,int> dimensions, string[,,] imageInformation)
        {
            this.name = name;
            this.discription = discription;
            this.image = (Texture2D)Game1.texture.GetType().GetProperty(image).GetValue(Game1.texture);
            this.dimensions = dimensions;
            this.imageInformation = imageInformation;

            Initialize_Spritesheet.loaded_Spritesheets.Add(this);
        } 

    }
}
