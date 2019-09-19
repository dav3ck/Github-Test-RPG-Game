using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2D_RPG.UItools.SpritesheetBox
{
    public class sbInstance : UI_AlwaysActiveBox
    {

        public Point shCords;
        public Spritesheet_Instance shInstance;

        private Point Size;
        private Point imgSize;
        private MouseState oldMouseState;

        private int offset;
        private Texture2D img;

        private int DemSize;

        public Point Selected;

        public sbInstance(Point location, Spritesheet_Instance sh, string id, Point Size, Point shcords = new Point(), Action x = null)
        {
            AlwaysActiveUIBoxes.Add(this);

            this.Location = location;
            this.Width = Size.X;
            this.Height = Size.Y;

            this.shInstance = sh; 
            this.shCords = shcords;
            this.Size = Size;

            this.img = sh.image;
            this.imgSize = new Point(Size.X, (Size.X / sh.dimensions.Item1) * sh.dimensions.Item2);

            Console.WriteLine("Spritesheet Name: {0}", sh.name);

            DemSize = Size.X / shInstance.dimensions.Item1;

            Hitbox = new Rectangle(Location, new Point(Width, Height));
            UIboxList.Add(this);
            this.action = x;
        }

        public override void Open()
        {
            MouseState currentMouseState = Mouse.GetState();

            Point location = new Point(currentMouseState.X - Location.X, currentMouseState.Y - Location.Y);

            location.Y += offset;

            Selected = new Point(location.X / DemSize, location.Y / DemSize);

            Console.WriteLine("Dimensions of Selected X: {0} - Y: {1}", Selected.X, Selected.Y);
            action();
        }

        public override void update()
        {
            MouseState currentMouseState = Mouse.GetState();

            if (currentMouseState == oldMouseState)
            {
                return;
            }

            if (currentMouseState.ScrollWheelValue > oldMouseState.ScrollWheelValue)
            {
                scroll(false);
            }
            else if (currentMouseState.ScrollWheelValue < oldMouseState.ScrollWheelValue)
            {
                scroll(true);
            }

            oldMouseState = currentMouseState;
        }

        private void scroll(bool direction)
        {
            if (direction == true)
            {
                offset += 5;
            }
            else
            {
                offset -= 5;
            }

            if (offset + Size.Y > imgSize.Y)
            {
                offset = imgSize.Y - Size.Y;
            }

            if (offset < 0)
            {
                offset = 0;
            }
        }

        public override void draw()
        {
            //Console.WriteLine("Img Width: {0} -- imgHeight: {1}", imgSize.X, (imgSize.X * Height) / Width);

            Rectangle Source = new Rectangle(0, (img.Width * offset) / Width, img.Width, (img.Width * Height) / Width);
            Game1.spriteBatch.Draw(Game1.texture.TestTile1, new Rectangle(Location.X, Location.Y, Width, Height), Color.White);
            Game1.spriteBatch.Draw(img, new Rectangle(Location.X, Location.Y, Width, Height), Source, Color.White);
        }

        public void SwitchSpriteSheet(Spritesheet_Instance sh, Point Select = new Point())
        {
            this.shInstance = sh;
            this.img = sh.image;
            this.imgSize = new Point(Size.X, (Size.X / sh.dimensions.Item1) * sh.dimensions.Item2);
            offset = 0;
            this.DemSize = Size.X / shInstance.dimensions.Item1;
        }
    }
}
