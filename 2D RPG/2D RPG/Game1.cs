﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2D_RPG.Editor.AnimationEditor;
using _2D_RPG.UItools.ComboBox;
using _2D_RPG.UItools;
using _2D_RPG.UItools.Button;
using _2D_RPG.UItools.TextInput;
using _2D_RPG.UItools.Switch;
using _2D_RPG.Editor.AnimationEditor.Classes;
using _2D_RPG.Editor.AnimationEditor.Layer;
using _2D_RPG.UItools.SpritesheetBox;

namespace _2D_RPG
{
    /// <summary>
    /// This is the main type for your game.
    /// 
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch, backSpriteBatch;
        public static GameContent texture;
        public cbInstance TestComboBox, TestComboBox1;
        public tibInstance TestInputbox;
        public sbInstance TestSwitchBox;

        public static Animation_Editor AnimEditor;

        public btInstance Testbutton;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();

            foreach (Initialize_Spritesheet_Config.SpritesheetFiles x in Initialize_Spritesheet_Config.Spritesheet_Data_File)
            {
                Console.WriteLine("Name: {0} -- Path: {1}", x.name, x.path);
            }

            Initialize_Spritesheet.Load("Test Spritesheet");

            foreach(var x in Basecl.all_classes)
            {
                Console.WriteLine("Name: {0}", x.Name);
            }

            this.IsMouseVisible = true;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 

        public void test() { Console.WriteLine("LOL!"); }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            backSpriteBatch = new SpriteBatch(GraphicsDevice);
            texture = new GameContent(Content);

            AnimEditor = new Animation_Editor();

            /*
            List<string> testlist = new List<string>();
            testlist.Add("FEE");
            testlist.Add("FAA");
            testlist.Add("FOO");
            testlist.Add("FO1");
            testlist.Add("FO2");
            testlist.Add("FO3");
            testlist.Add("FO4");
            testlist.Add("FO5");
            testlist.Add("FO6");
            testlist.Add("FO7");
            TestComboBox = new cbInstance(new Point(100, 100), testlist, "TestCB");

            TestInputbox = new tibInstance(new Point(300, 100), 150, 20, "INPUT HIER!", "TestTIB");
            Testbutton = new btInstance(new Point(210, 100), 50, 20, "Test", new btInstance.Action(test), "TESTBT"); */

            Class_Handler.Class_Handler_Initialize();

            //TestSwitchBox = new sbInstance(new Point(50, 350), Initialize_Spritesheet.AssignSpritesheet("Test Spritesheet 2"), "Test", new Point(200, 100));

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            UI_Box.Update();
            if (Layer_Hitbox.lrHitbox != null)
            {
                Layer_Hitbox.lrHitbox.update();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.Black);
            backSpriteBatch.Begin();
            AnimEditor.Draw();
            backSpriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(texture.SpriteSheet_Test, new Rectangle(0,0,40,40), Color.White);
            foreach(UI_Box ui_box in UI_Box.UIboxList)
            {
                ui_box.draw();
            }

            Layer_Handler.draw();
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
