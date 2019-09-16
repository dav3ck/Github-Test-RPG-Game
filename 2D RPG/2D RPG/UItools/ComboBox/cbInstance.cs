using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2D_RPG.UItools.ComboBox
{
    public class cbInstance : UI_ActiveBox
    {
        public List<string> cbElements;
        public List<cbElement> Loaded_cbElements = new List<cbElement>();
        public bool canScroll;
        public int Number;
        public cbElement Selected;
        private KeyboardState oldKeyboardState;
        private MouseState oldMouseState;

        public cbInstance(Point location, List<string> cbElements, string id, int Width = 100, int Height = 20, Action x = null)
        {

            if (!cbElements.Any())
            {
                Console.WriteLine("Cancel creation of ComboBox Because Element List is Empty");
                return;
            }

            this.Location = location;
            this.cbElements = cbElements;
            this.Width = Width;
            this.Height = Height;
            this.Text = this.cbElements.First();
            this.Activable = true;
            this.ID = id;
            this.action = x;

            Hitbox = new Rectangle(Location, new Point(Width, Height));

            ComboBox.cbList.Add(this);

            Console.WriteLine("Succesfully created ComboBox!");

            UIboxList.Add(this);
        }

        public void ChangeSelection(bool DirectionDown)
        {
            int x;

            if (DirectionDown) { x = 1; }
            else { x = -1; }

            int newPosition = Number + x;

            if (newPosition < 0 || newPosition >= Loaded_cbElements.Count())
            {
                return;
            }

            if (canScroll)
            {
                if (newPosition - x == (int)(ComboBox.cbMaxSize / 2) && (Loaded_cbElements.First().Position + x >= 0 && Loaded_cbElements.Last().Position <= cbElements.Count() - 1 - x))
                {
                    Scroll(x);
                }
                else
                {
                    Number += x;
                }
            }
            Selected = Loaded_cbElements[Number];
            this.Text = Selected.Text;


            foreach (var y in Loaded_cbElements)
            {
                if (y == Selected)
                {
                    Console.WriteLine(" >  {0}", y.Text);
                }
                else
                {
                    Console.WriteLine(y.Text);
                }
            }
            Console.WriteLine();
        }


        private void Scroll(int x)
        {
            foreach(cbElement cbElem in Loaded_cbElements)
            {
                cbElem.Position += x;
                cbElem.Text = cbElements[cbElem.Position];
            } 
        }


        public override void update()
        {
            KeyBoardControl();
            MouseControl(); 
        }

        private void MouseControl()
        {
            MouseState currentMouseState = Mouse.GetState();

            if (currentMouseState == oldMouseState)
            {
                return;
            }

            if(currentMouseState.ScrollWheelValue > oldMouseState.ScrollWheelValue)
            {
                ChangeSelection(false);
            }
            else if (currentMouseState.ScrollWheelValue < oldMouseState.ScrollWheelValue)
            {
                ChangeSelection(true);
            }

            oldMouseState = currentMouseState;
        }

        private void KeyBoardControl()
        {
            KeyboardState currentKeyboardState = Keyboard.GetState();

            if (currentKeyboardState == oldKeyboardState)
            {
                return;
            }

            if (currentKeyboardState.IsKeyDown(Keys.W))
            {
                ChangeSelection(false);
            }
            else if (currentKeyboardState.IsKeyDown(Keys.S))
            {
                ChangeSelection(true);
            }
            else if (currentKeyboardState.IsKeyDown(Keys.Enter))
            {
                Close();
            }

            oldKeyboardState = currentKeyboardState;
        }



        public override void Close()
        {
            cbClose.Close(this);
        }

        public override void Open()
        {
            cbOpen.Open(this);
        }



        public string GetValue()
        {
            return this.Text;
        }

        public void ChangeOptions(List<string> options)
        {
            this.cbElements = options;
            this.Text = this.cbElements.First();

            this.Selected = null;
        }

    }
}
