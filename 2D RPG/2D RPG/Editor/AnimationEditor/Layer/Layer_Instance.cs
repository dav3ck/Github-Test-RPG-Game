using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using _2D_RPG.Editor.AnimationEditor.Classes;

namespace _2D_RPG.Editor.AnimationEditor.Layer
{
    public class Layer_Instance
    {
        public Point Spritecords;
        public Vector2 Location;
        public Field animField;
        public Class_Item clItem;

        public Layer_Instance(Class_Item clitem, Point spritecords, Vector2 location, Field animfield = null)
        {
            this.clItem = clitem;
            this.animField = animfield;
            this.Spritecords = spritecords;
            this.Location = location;
        }
    }
}
