using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.Components
{
	class FixedSprite : Layer
	{
		private Texture2D texture;

		public FixedSprite(Game game, string asset, int priority)
			: base(priority)
		{
			texture = game.Content.Load<Texture2D>(asset);
		}

		public int Width
		{
			get { return texture.Width; }
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
		}
		public Rectangle getFrame()
		{
			return new Rectangle(
				(int)Position.X,
				(int)Position.Y,
				texture.Width,
				texture.Height
			);
		}

		public override void Draw(SpriteBatch sb)
		{
			sb.Draw(texture, getFrame(), Color.White);
		}
	}
}
