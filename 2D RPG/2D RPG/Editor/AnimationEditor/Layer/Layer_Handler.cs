using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2D_RPG.Editor.AnimationEditor.Classes;
using Microsoft.Xna.Framework;

namespace _2D_RPG.Editor.AnimationEditor.Layer
{
    static class Layer_Handler
    {
        public static List<Layer_Instance>ActiveLayers = new List<Layer_Instance>();
        public static Layer_Instance SelectedLayer;

        public static Layer_Hitbox lrHitbox;

        public static void InitializeLayers(List<Class_Item> clItems)
        {
            ActiveLayers = new List<Layer_Instance>();

            foreach(Class_Item clItem in clItems)
            {
                Layer_Instance x = new Layer_Instance(clItem,  new Point(0, 0), new Vector2(300, 100));
                ActiveLayers.Add(x);
            }

            SelectedLayer = ActiveLayers.First();

            lrHitbox = new Layer_Hitbox();
        }

        public static void draw()
        {
            foreach(var x in ActiveLayers)
            {
                Game1.spriteBatch.Draw(Game1.texture.SpriteSheet_Test, new Rectangle(x.Location.ToPoint(), new Point(40,40)), Color.White);
            }
        }

        public static void SwitchLayer()
        {
            SelectedLayer = ActiveLayers.Find(x => x.clItem.Name == Class_Handler.ClassItemcb.Selected.Text);

            lrHitbox = new Layer_Hitbox();
        }
    }
}
