using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceGame.Screens
{
    public class TitleScreen : Screen
    {
        private SpriteFont font;

        public TitleScreen(Game parent) : base(parent) { }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
            batch.GraphicsDevice.Clear(Color.Purple);
            batch.DrawString(font, "Space Shooter!", Vector2.One * 100.0f, Color.White);
            base.Draw(gameTime, batch);
        }

        bool wasBackPressed = true;
        public override void Update(GameTime gameTime, GamePadState padState)
        {
            bool isBackPressed = padState.Buttons.Back == ButtonState.Pressed;
            if (padState.Buttons.Start == ButtonState.Pressed)
            {
                ScreenManager.SetCurrentScreen(new GameScreen(Parent));
            }
            else if (!wasBackPressed && isBackPressed)
            {
                Parent.Exit();
            }
            wasBackPressed = isBackPressed;
            base.Update(gameTime, padState);
        }

        public override void Showing()
        {
            font = Parent.Content.Load<SpriteFont>("FontTitle");
            base.Showing();
        }
    }
}
