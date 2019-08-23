using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace _2D_RPG.UItools.TextInput
{
    public class tibInstance : UI_ActiveBox
    {
        private string Infotext;
        KeyboardState oldkeyboardState;

        public tibInstance(Point location, int width, int height, string text, string id)
        {
            this.Location = location;
            this.Width = width;
            this.Height = height;

            this.Infotext = text;
            this.Text = Infotext;
            this.ID = id;

            this.Hitbox = new Rectangle(this.Location, new Point(this.Width, this.Height));
        }

        public override void Open()
        {
            if (this.Active)
            {
                return;
            }

            this.Active = true;
            if (this.Text == this.Infotext)
            {
                this.Text = "";
            }
            UI_ActiveBox.ActiveUIBoxes.Add(this);
        }

        public override void Close()
        {
            if(this.Text == "")
            {
                this.Text = this.Infotext;
            }
        }

        public override void update()
        {
            //CHECK HERE FOR USER INPUT
            //CURSOR POSITION
            // MAX WORD LIMIT ??

            var currentKeyboardState = Keyboard.GetState();
            var keys = currentKeyboardState.GetPressedKeys();

            foreach(var key in keys)
            {
                if (oldkeyboardState.IsKeyUp(key))
                {
                    if (key == Keys.Back && Text.Length > 0)
                    {
                        Text = Text.Remove(Text.Length - 1, 1);
                    }
                    else if (key == Keys.Space)
                    {
                        Text = Text.Insert(Text.Length, " ");
                    }
                    else
                        {
                        string keyString = key.ToString();
                        bool isUpperCase = false;

                        if (currentKeyboardState.IsKeyDown(Keys.LeftShift)){
                            isUpperCase = true;
                        }

                        if (keyString.Length == 1)
                        {
                            Text += isUpperCase ? keyString.ToUpper() : keyString.ToLower();
                            Console.WriteLine(Text);
                        }
                    }
                }
            }

            oldkeyboardState = currentKeyboardState;
        } 
    }
}
