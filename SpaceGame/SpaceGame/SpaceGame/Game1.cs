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

namespace SpaceGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D sprites;

        ActorPlayer player;

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

            // create our player
            player = ActorPlayer.Create(this.GraphicsDevice.Viewport.Bounds);

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
            sprites = Content.Load<Texture2D>("sprites");
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
            // Allows the game to exit
            var gamepad = GamePad.GetState(PlayerIndex.One);
            if (gamepad.Buttons.Back == ButtonState.Pressed)
            {
                // end game
                this.Exit();
            }
            else if (gamepad.Buttons.Start == ButtonState.Pressed)
            {
                // new game
                player.Color = Color.White;
            }

            player.Update(gameTime, gamepad);
            ActorBullet.UpdateAllBullets(gameTime);
            ActorRock.UpdateAllRocks(gameTime);
            ActorEnemy.UpdateAllEnemies(gameTime);

            ActorEnemy.TryToAddEnemy(gameTime);
            ActorRock.TryToAddRock(gameTime);

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
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);

            ActorRock.DrawAllRocks(gameTime, spriteBatch, sprites);
            ActorBullet.DrawAllBullets(gameTime, spriteBatch, sprites);
            player.Draw(gameTime, spriteBatch, sprites);
            ActorEnemy.DrawAllEnemies(gameTime, spriteBatch, sprites);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
