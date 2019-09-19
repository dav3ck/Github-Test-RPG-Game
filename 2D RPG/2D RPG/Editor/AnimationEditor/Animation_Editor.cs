using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2D_RPG.UItools.ComboBox;
using _2D_RPG.UItools;
using _2D_RPG.UItools.Button;
using _2D_RPG.UItools.TextInput;
using _2D_RPG.UItools.Switch;



namespace _2D_RPG.Editor.AnimationEditor
{
    public class Animation_Editor
    {
        public static AnimationField animationField = new AnimationField("animationField", new Point(200,200), new Point(300, 50));

        public Animation_Editor()
        {
            Initialize();
        }

        private void Initialize()
        {
            
        }

        public void Update()
        {

        }

        public void Draw()
        {
            animationField.Draw();
        }
    }
}
