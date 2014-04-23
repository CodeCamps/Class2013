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
        List<ActorEnemy> enemies = new List<ActorEnemy>();
        List<Actor> enemyShots = new List<Actor>();
        List<Actor> playerShots = new List<Actor>();
        List<Actor> rocks = new List<Actor>();

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
            player = new ActorPlayer();
            player.SrcRectStraight = new Rectangle(396, 79, 99, 75);
            player.SrcRectLeft = new Rectangle(258, 246, 90, 77);
            player.SrcRectRight = new Rectangle(258, 167, 90, 77);

            player.SecondsBetweenShots = 1.2;

            // player can move around entire screen?
            player.Bounds = this.GraphicsDevice.Viewport.Bounds;
            
            // nope, just bottom half
            player.Bounds.Y = player.Bounds.Height / 2;
            player.Bounds.Height /= 2;
            
            // adjust bounds for player sprite width
            player.Bounds.Width -= player.SrcRectStraight.Width;
            player.Bounds.Height -= player.SrcRectStraight.Height;

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            var gamepad = GamePad.GetState(PlayerIndex.One);
            
            player.Update(gameTime, gamepad);
            
            foreach (var shot in playerShots)
            {
                shot.Update(gameTime, gamepad);
            }

            AddEnemy(gameTime);
            foreach (var enemy in enemies)
            {
                enemy.Update(gameTime, gamepad);
                AddEnemyShot(gameTime, enemy);
            }
            
            foreach (var shot in enemyShots)
            {
                shot.Update(gameTime, gamepad);
            }

            playerShotCoolDown -= gameTime.ElapsedGameTime.TotalSeconds;
            addEnemyCoolDown -= gameTime.ElapsedGameTime.TotalSeconds;

            if (gamepad.Buttons.A == ButtonState.Pressed)
            {
                AddPlayerShot(gameTime);
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
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);

            // draw player & shots
            player.Draw(gameTime, spriteBatch, sprites);
            
            foreach (var shot in playerShots)
            {
                shot.Draw(gameTime, spriteBatch, sprites);
            }

            // draw enemies & shots
            foreach (var enemy in enemies)
            {
                enemy.Draw(gameTime, spriteBatch, sprites);
            }

            foreach (var shot in enemyShots)
            {
                shot.Draw(gameTime, spriteBatch, sprites);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        protected double playerShotCoolDown = 0.0;
        protected void AddPlayerShot(GameTime gameTime)
        {
            if (playerShotCoolDown <= 0)
            {
                var shot = new Actor();
                shot.SrcRect = new Rectangle(497, 37, 9, 33);
                shot.Location.X = player.Location.X;
                shot.Location.Y = player.Location.Y;
                shot.Speed.Y = -200.0f;
                playerShots.Add(shot);
                playerShotCoolDown = player.SecondsBetweenShots;
            }

            int i = 0;
            while (i < playerShots.Count)
            {
                if (playerShots[i].Location.Y < -playerShots[i].SrcRect.Height)
                {
                    playerShots.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        protected Random rand = new Random();

        protected double addEnemyCoolDown = 3.0;
        protected float lastEnemyY = 0.0f;
        protected void AddEnemy(GameTime gameTime)
        {
            if (addEnemyCoolDown <= 0)
            {
                var enemy = new ActorEnemy();
                enemy.SrcRect = new Rectangle(258, 115, 98, 50);
                enemy.ShotCoolDown = rand.NextDouble() * 3.0 + 1.0;
                enemy.Speed.X = (float)rand.NextDouble() * 25.0f + 10.0f;
                enemy.Location.Y = (float)rand.NextDouble() * 150.0f;
                enemies.Add(enemy);
                addEnemyCoolDown = rand.NextDouble() * 3.0 + 3.0;
            }
        }

        protected void AddEnemyShot(GameTime gameTime, ActorEnemy enemy)
        {
            if (enemy.ShotCoolDown <= 0)
            {
                var shot = new Actor();
                shot.SrcRect = new Rectangle(497, 2, 9, 33);
                shot.Location.X = enemy.Location.X;
                shot.Location.Y = enemy.Location.Y;
                shot.Speed.Y = 200.0f;
                enemy.ShotCoolDown = enemy.SecondsBetweenShots;
                enemyShots.Add(shot);
            }

            int i = 0;
            while (i < enemyShots.Count)
            {
                if (enemyShots[i].Location.Y > player.Bounds.Bottom)
                {
                    enemyShots.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
