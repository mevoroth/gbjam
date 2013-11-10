using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.Components
{
	class AnimatedSprite : Layer
	{
		private Texture2D texture;
		private int frames;
		private int currentFrame = 0;
		private int width;

		private int framelength = 10;

		private bool loop = true;

		public bool Loop
		{
			set { loop = value; }
		}

		public AnimatedSprite(Game game, string asset, int width, int priority)
			: base(priority)
		{
			texture = game.Content.Load<Texture2D>(asset);
			this.width = width;
			frames = texture.Width / width;
		}

		public int Width
		{
			get { return width; }
		}
		public int Height
		{
			get { return texture.Height; }
		}

		public Texture2D Texture
		{
			get { return texture; }
		}
		public override void next()
		{
			if (loop)
			{
				currentFrame = (currentFrame + 1) % (frames * framelength);
			}
			else
			{
				if (currentFrame < frames * framelength - 1)
				{
					++currentFrame;
				}
			}
		}
		public Rectangle getFrame()
		{
			return new Rectangle(
				(int)(currentFrame / framelength) * width,
				0,
				width,
				texture.Height
			);
		}
		public override void Draw(SpriteBatch sb)
		{
			sb.Draw(
				texture,
				new Rectangle((int)Position.X, (int)Position.Y, width, texture.Height),
				getFrame(),
				Color.White
			);
		}
	}
}
