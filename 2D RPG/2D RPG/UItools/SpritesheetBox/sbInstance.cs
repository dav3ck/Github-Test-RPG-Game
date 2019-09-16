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

        //private List<sbElement> sbElements = new List<sbElement>();
        private static int numRows = 3;
        private int DemSize;

        public Point Selected;

        //private List<sbDisElement> sbActivElem = new List<sbDisElement>();

        public sbInstance(Point location, Spritesheet_Instance sh, string id, Point Size, Point shcords = new Point(), Action x = null)
        {
            AlwaysActiveUIBoxes.Add(this);

            this.Location = location;
            this.Width = Size.X;
            this.Height = Size.Y;

            this.shInstance = sh; 
            this.shCords = shcords;
            this.Size = Size;

            this.imgSize = new Point(Size.X, shInstance.dimensions.Item2 * (Size.X / shInstance.dimensions.Item1));

            /*for(int y = 1; y <= shInstance.dimensions.Item2; y++)
            {
                for (int a = 1; a <= shInstance.dimensions.Item1; a++)
                {
                    sbElements.Add(new sbElement(a, y, shInstance));
                }
            } */

            DemSize = Size.X / shInstance.dimensions.Item1;

            Hitbox = new Rectangle(Location, new Point(Width, Height));
            UIboxList.Add(this);
        }


        public override void Open()
        {
            MouseState currentMouseState = Mouse.GetState();

            Point location = new Point(currentMouseState.X - Location.X, currentMouseState.Y - Location.Y);

            location.Y += offset;

            Selected = new Point(location.X / DemSize, location.Y / DemSize);

            Console.WriteLine("Dimensions of Selected X: {0} - Y: {1}", Selected.X, Selected.Y);
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

            if (offset + Size.Y >= imgSize.Y)
            {
                offset = imgSize.Y - Size.Y;
            }

            if (offset < 0)
            {
                offset = 0;
            }
        }

        public override void Draw()
        {
            Rectangle Source = new Rectangle(offset, 0, Size.X, Size.Y);
            Game1.spriteBatch.Draw(Game1.texture.TestTile1, new Rectangle(Location.X, Location.Y, Width, Height), Source, Color.White);
        }
    }
}
