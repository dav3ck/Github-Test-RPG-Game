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

            Class_Handler.SpriteSheetBox.SwitchSpriteSheet(SelectedLayer.clItem.Spritesheet);

            lrHitbox = new Layer_Hitbox();
        }

        public static void draw()
        {
            foreach(var x in ActiveLayers)
            {
                int FrameWidth = x.clItem.Spritesheet.image.Width / x.clItem.Spritesheet.dimensions.Item1;
                int FrameHeight = x.clItem.Spritesheet.image.Height / x.clItem.Spritesheet.dimensions.Item2;
                Rectangle Source = new Rectangle(FrameWidth * x.Spritecords.X, FrameHeight * x.Spritecords.Y, FrameWidth, FrameHeight);
                Game1.spriteBatch.Draw(x.clItem.Spritesheet.image, new Rectangle(x.Location.ToPoint(), new Point(40,40)),Source, Color.White);
            }
        }

        public static void SwitchLayer()
        {
            SelectedLayer = ActiveLayers.Find(x => x.clItem.Name == Class_Handler.ClassItemcb.Selected.Text);

            Class_Handler.SpriteSheetBox.SwitchSpriteSheet(SelectedLayer.clItem.Spritesheet);

            lrHitbox = new Layer_Hitbox();
        }

        public static void SwitchLayerImg()
        {
            SelectedLayer.Spritecords = Class_Handler.SpriteSheetBox.Selected;
        }
    }
}
