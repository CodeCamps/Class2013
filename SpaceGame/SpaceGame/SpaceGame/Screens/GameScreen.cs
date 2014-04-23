using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceGame.Screens
{
    public class GameScreen : Screen
    {
        Texture2D sprites;
        ActorPlayer player;

        public GameScreen(Game parent) : base(parent) { }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
            ActorBackground.Draw(gameTime, batch, sprites);
            ActorRock.DrawAllRocks(gameTime, batch, sprites);
            ActorBullet.DrawAllBullets(gameTime, batch, sprites);
            player.Draw(gameTime, batch, sprites);
            ActorEnemy.DrawAllEnemies(gameTime, batch, sprites);

            base.Draw(gameTime, batch);
        }

        public override void Update(GameTime gameTime, GamePadState padState)
        {
            // Allows the game to exit
            //var gamepad = GamePad.GetState(PlayerIndex.One);
            //GamePad.SetVibration(PlayerIndex.One, 1.0f, 1.0f);
            if (padState.Buttons.Back == ButtonState.Pressed)
            {
                // end game
                ScreenManager.SetCurrentScreen(new TitleScreen(Parent));
            }
            //else if (padState.Buttons.Start == ButtonState.Pressed)
            //{
            //    // new game
            //    player.Color = Color.White;
            //}

            ActorBackground.Update(gameTime);

            if (!player.Update(gameTime, padState))
            {
                ScreenManager.SetCurrentScreen(new GameOverScreen(Parent));
            }
            
            ActorBullet.UpdateAllBullets(gameTime);
            ActorRock.UpdateAllRocks(gameTime);
            ActorEnemy.UpdateAllEnemies(gameTime);

            ActorEnemy.TryToAddEnemy(gameTime);
            ActorRock.TryToAddRock(gameTime);

            base.Update(gameTime, padState);
        }

        public override void Showing()
        {
            // create our player
            sprites = Parent.Content.Load<Texture2D>("sprites");
            player = ActorPlayer.Create(Parent.GraphicsDevice.Viewport.Bounds);
            ActorRock.RemoveAllRocks();
            ActorBullet.RemoveAllBullets();
            ActorEnemy.RemoveAllEnemies();
        }
    }
}
