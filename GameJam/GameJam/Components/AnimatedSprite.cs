using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.Components
{
	class AnimatedSprite
	{
		private Texture2D texture;
		private int frames;
		private int currentFrame = 0;
		private int width;

		public AnimatedSprite(Game game, string asset, int width)
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
		public void next()
		{
			currentFrame = (currentFrame + 1) % frames;
		}
		public Rectangle getFrame()
		{
			return new Rectangle(
				currentFrame*width,
				0,
				width,
				texture.Height
			);
		}
	}
}
