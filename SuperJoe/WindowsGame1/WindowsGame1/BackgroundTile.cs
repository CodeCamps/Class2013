using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1
{
    public class BackgroundTile
    {
        public float rate = 1.0f;
        public Texture2D texture;
        public Vector2 location;
        public Color color;

        public BackgroundTile(float rate, Texture2D texture, Vector2 location, Color color)
        {
            this.rate = rate;
            this.texture = texture;
            this.location = location;
            this.color = color;
        }

        private float X
        {
            get { return this.location.X; }
            set
            {
                this.location.X = value;
                if (value < -this.texture.Width)
                {
                    this.location.X += this.texture.Width;
                }
                else if (value > 0)
                {
                    this.location.X -= this.texture.Width;
                }
            }
        }

        public void deltaX(float dx)
        {
            this.X -= dx * this.rate;
        }

        public void Draw(SpriteBatch batch, int screenWidth)
        {
            Vector2 loc = this.location;
            while (loc.X < screenWidth)
            {
                batch.Draw(this.texture, loc, this.color);
                loc.X += this.texture.Width;
            }
        }
    }
}
