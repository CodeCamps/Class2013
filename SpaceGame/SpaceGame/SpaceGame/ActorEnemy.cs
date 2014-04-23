using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class ActorEnemy : Actor
    {
        public double SecondsBetweenShots = 3.0;
        public double ShotCoolDown = 0.0;

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Input.GamePadState gamepad)
        {
            base.Update(gameTime, gamepad);
            this.ShotCoolDown -= gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
