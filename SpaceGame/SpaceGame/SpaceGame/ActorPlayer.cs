using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceGame
{
    public class ActorPlayer : Actor
    {
        public Rectangle Bounds = Rectangle.Empty;
        public double SecondsBetweenShots = 3.0;
        public Rectangle SrcRectStraight = Rectangle.Empty;
        public Rectangle SrcRectLeft = Rectangle.Empty;
        public Rectangle SrcRectRight = Rectangle.Empty;

        public override void Update(GameTime gameTime, GamePadState gamepad)
        {
            // assume no buttons are pressed
            var speed = Vector2.Zero;
            this.SrcRect = this.SrcRectStraight;

            // get initial values from thumbsticks
            speed.X = gamepad.ThumbSticks.Left.X;
            speed.Y = -gamepad.ThumbSticks.Left.Y;

            // check DPad buttons (Up/Down)
            if (gamepad.DPad.Up == ButtonState.Pressed)
            {
                speed.Y = -1.0f;
            }
            else if (gamepad.DPad.Down == ButtonState.Pressed)
            {
                speed.Y = 1.0f;
            }

            // check DPad buttons (Left/Right)
            if (gamepad.DPad.Left == ButtonState.Pressed)
            {
                speed.X = -1.0f;
            }
            else if (gamepad.DPad.Right == ButtonState.Pressed)
            {
                speed.X = 1.0f;
            }

            // animate ship when moving left or right
            if (speed.X < 0)
            {
                this.SrcRect = this.SrcRectLeft;
            }
            else if (speed.X > 0)
            {
                this.SrcRect = this.SrcRectRight;
            }

            // move at 5 pixels per second
            this.Speed = speed * 150.0f;

            // call back to Actor.Update for location calculation
            base.Update(gameTime, gamepad);

            // keep ship in bounds
            if (!Rectangle.Empty.Equals(this.Bounds))
            {
                if (this.Location.X < this.Bounds.X)
                {
                    this.Location.X = this.Bounds.X;
                }

                if (this.Location.X > this.Bounds.Right)
                {
                    this.Location.X = this.Bounds.Right;
                }

                if (this.Location.Y < this.Bounds.Y)
                {
                    this.Location.Y = this.Bounds.Y;
                }

                if (this.Location.Y > this.Bounds.Bottom)
                {
                    this.Location.Y = this.Bounds.Bottom;
                }
            }
        }
    }
}
