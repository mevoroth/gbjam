using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameJam.Settings;

namespace GameJam.Components
{
	class ScrollingBackground : Layer
	{
		private Texture2D texture;
		private int height;
		private int speed;

		public ScrollingBackground(Game game, string asset, int speed, int priority)
			: base(priority)
		{
			texture = game.Content.Load<Texture2D>(asset);
			this.height = texture.Height - Size.HEIGHT;
			this.speed = speed;
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
			//--height;
			height -= speed;
			if (height < -Size.HEIGHT)
			{
				height = texture.Height - Size.HEIGHT;
			}
		}
		public override void Draw(SpriteBatch sb)
		{
			sb.Draw(
				texture,
				new Rectangle(0, 0, Size.WIDTH, Size.HEIGHT),
				new Rectangle(0, height, Size.WIDTH, Size.HEIGHT),
				Color.White
			);
			if (height < 0)
			{
				sb.Draw(
					texture,
					new Rectangle(0, 0, Size.WIDTH, -height),
					new Rectangle(0, texture.Height + height, Size.WIDTH, -height),
					Color.White
				);
			}
		}
	}
}
