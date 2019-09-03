using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using _2D_RPG.UItools.ComboBox;

namespace _2D_RPG.UItools
{

    abstract public class UI_Box
    {
        public static List<UI_Box> UIboxList = new List<UI_Box>();

        public bool Activable;
        public bool Active;
        public Point Location;
        public int Width;
        public int Height;
        public string Text;
        public Rectangle Hitbox;

        public delegate void Action();
        public Action action;

        public string ID;

        public abstract void Open();

        public static MouseState oldstate;

        public UI_Box()
        {
            UIboxList.Add(this);
        }

        public void draw()
        {
            Game1.spriteBatch.Draw(Game1.texture.TestTile1, new Rectangle(Location.X, Location.Y, Width, Height), Color.White);
            Game1.spriteBatch.DrawString(Game1.texture.Arial20, Text, new Vector2(Location.X, Location.Y), Color.White);
        }

        public static void Update()
        {
            foreach (var x in UI_ActiveBox.ActiveUIBoxes)
            {
                x.update();
            }

            MouseState state = Mouse.GetState();

            if (state.LeftButton == ButtonState.Pressed && oldstate.LeftButton != ButtonState.Pressed)
            {

                Rectangle MouseLocation = new Rectangle(state.Position, new Point(1, 1));
                var UI = UIboxList.Find(x => x.Hitbox.Intersects(MouseLocation));

                if (UI == null)
                {
                    UI_ActiveBox.CloseActive();
                    return;
                }

                UI_ActiveBox.CloseActive();

                UI.Open();
            }

            oldstate = state;
        }

    }
}
