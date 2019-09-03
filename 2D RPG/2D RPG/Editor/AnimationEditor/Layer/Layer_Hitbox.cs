using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2D_RPG.UItools;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace _2D_RPG.Editor.AnimationEditor.Layer
{
    class Layer_Hitbox
    {
        static public Layer_Hitbox lrHitbox;

        private Layer_Instance lrInstance;

        private MouseState oldstate;
        private int Width;
        private int Height;
        private Vector2 Location;
        private Rectangle Hitbox;

        public Layer_Hitbox()
        {
            lrInstance = Layer_Handler.SelectedLayer;

            this.Width = 40;
            this.Height = 40;
            this.Location = lrInstance.Location;

            this.Hitbox = new Rectangle(this.Location.ToPoint(), new Point(this.Width, this.Height));

            Console.WriteLine("Done with Layer_Hitbox! {0}", lrInstance.Location);

            lrHitbox = this;
        }

        public void update()
        {
            MouseState mouseState = Mouse.GetState();
            Vector2 Temp;
            Vector2 Movement = new Vector2(0,0);

            if(new Rectangle(mouseState.Position, new Point(1, 1)).Intersects(Hitbox) && mouseState.LeftButton == ButtonState.Pressed)
            {

                if (oldstate.LeftButton == ButtonState.Pressed && mouseState.LeftButton == ButtonState.Pressed)
                {
                    Movement = oldstate.Position.ToVector2() - mouseState.Position.ToVector2();
                    Temp = this.Location - Movement;
                    Rectangle hbTemp = new Rectangle(Temp.ToPoint(), new Point(this.Width, this.Height));
                    if (Animation_Editor.animationField.Hitbox.Contains(hbTemp))
                    {
                        lrInstance.Location -= Movement;
                        this.Location -= Movement;

                        this.Hitbox = new Rectangle(this.Location.ToPoint(), new Point(this.Width, this.Height));
                    }
                }
            }

            oldstate = mouseState;
        }
    }

}
