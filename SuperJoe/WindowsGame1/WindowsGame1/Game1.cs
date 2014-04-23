using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        double angle = 0;

        const float FLY_SPEED = 10.0f;

        const float RATE_CLOUDS = 0.1f;
        const float RATE_CITY_BACKGROUND = 0.2f;
        const float RATE_CITY_FOREGROUND = 0.3f;
        const float RATE_TREES = 0.4f;
        const float RATE_PLAYER = 1.0f;

        BackgroundTile bgClouds;
        BackgroundTile bgCityBG;
        BackgroundTile bgCityFG;

        Texture2D texSolidColor;
        Rectangle rectGrass;
        Color colGrass = Color.DarkGreen;

        Texture2D texJoeFly;
        Texture2D texJoeHover;
        Texture2D texJoeKick;
        Texture2D texJoeCurrent;
        Vector2 locJoe;

        Texture2D texEnemy;
        Vector2 locEnemy;

        List<Texture2D> texTrees = new List<Texture2D>();
        List<Vector2> locTrees = new List<Vector2>();

        int ScreenWidth;
        int ScreenHeight;

        public Game1()
        {
            ScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            ScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            graphics = new GraphicsDeviceManager(this);
            
            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = ScreenWidth;
            graphics.PreferredBackBufferHeight = ScreenHeight;

            rectGrass = new Rectangle(0, 512, ScreenWidth, ScreenHeight - 256);

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
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            texSolidColor = Content.Load<Texture2D>("images/SolidColor");

            texJoeFly = Content.Load<Texture2D>("images/JoeFly");
            texJoeHover = Content.Load<Texture2D>("images/JoeHover");
            texJoeKick = Content.Load<Texture2D>("images/JoeKick");
            texJoeCurrent = texJoeHover;
            locJoe = Vector2.Zero;

            texEnemy = Content.Load<Texture2D>("images/EnemyRed");
            locEnemy = Vector2.Zero;

            bgClouds = new BackgroundTile(
                RATE_CLOUDS,
                Content.Load<Texture2D>("images/Clouds"),
                Vector2.Zero,
                new Color(0x66, 0x66, 0x66, 0x66));

            bgCityBG = new BackgroundTile(
                RATE_CITY_BACKGROUND,
                Content.Load<Texture2D>("images/City2"),
                new Vector2(0, 256),
                new Color(0x44, 0x44, 0x66, 0xff));

            bgCityFG = new BackgroundTile(
                RATE_CITY_FOREGROUND,
                Content.Load<Texture2D>("images/City1"),
                new Vector2(0, 256),
                new Color(0x00, 0x00, 0x33, 0xff));

            texTrees.Add(Content.Load<Texture2D>("images/Tree1"));
            texTrees.Add(Content.Load<Texture2D>("images/Tree2"));
            texTrees.Add(Content.Load<Texture2D>("images/Tree3"));
            texTrees.Add(Content.Load<Texture2D>("images/Tree4"));
            List<Vector2> locTrees = new List<Vector2>();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            var gamepad1 = GamePad.GetState(PlayerIndex.One);
            var keystate = Keyboard.GetState();

            bool exit = 
                gamepad1.Buttons.Back == ButtonState.Pressed ||
                keystate.IsKeyDown(Keys.Escape);

            if (exit) { this.Exit(); }

            float dx = gamepad1.ThumbSticks.Left.X * FLY_SPEED;
            float dy = gamepad1.ThumbSticks.Left.Y * FLY_SPEED;

            if (keystate.IsKeyDown(Keys.Up))
            {
                dy = FLY_SPEED;
            }
            else if (keystate.IsKeyDown(Keys.Down))
            {
                dy = -FLY_SPEED;
            }

            if (keystate.IsKeyDown(Keys.Left))
            {
                dx = -FLY_SPEED;
            }
            else if (keystate.IsKeyDown(Keys.Right))
            {
                dx = FLY_SPEED;
            } 

            bgClouds.deltaX(dx);
            bgCityBG.deltaX(dx);
            bgCityFG.deltaX(dx);

            locJoe.Y -= dy;

            locEnemy.X = 200;
            locEnemy.Y = 200.0f + 200.0f * (float)Math.Sin(angle);
            angle += 0.01;

            if (dx < 0)
            {
                texJoeCurrent = texJoeKick;
            }
            else if (dx > 0)
            {
                texJoeCurrent = texJoeFly;
            }
            else
            {
                texJoeCurrent = texJoeHover;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            bgClouds.Draw(spriteBatch, ScreenWidth);
            bgCityBG.Draw(spriteBatch, ScreenWidth);
            bgCityFG.Draw(spriteBatch, ScreenWidth);

            spriteBatch.Draw(texSolidColor, rectGrass, colGrass);

            spriteBatch.Draw(texJoeCurrent, locJoe, Color.White);

            spriteBatch.Draw(texEnemy, locEnemy, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
