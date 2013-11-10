using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.Components
{
	class ScrollableBackground : Layer
	{
		private Game game;
		private Texture2D texture;
		private Vector2 camera;

		public override Vector2 Position
		{
			set
			{
				//Vector2 tmp = base.Position + value;
				value += new Vector2((texture.Width - Settings.Size.WIDTH) / 2, 0);
				if (value.X > texture.Width - Settings.Size.WIDTH)
				{
					value.X = texture.Width - Settings.Size.WIDTH;
				}
				else if (value.X <= 0)
				{
					value.X = 0;
				}
				if (value.Y > texture.Height - Settings.Size.HEIGHT)
				{
					value.Y = texture.Height - Settings.Size.HEIGHT;
				}
				else if (value.Y <= 0)
				{
					value.Y = 0;
				}
				camera = value;
				base.Position = value;
			}
		}

		public ScrollableBackground(Game game, string asset, int priority)
			: base(priority)
		{
			this.game = game;
			texture = game.Content.Load<Texture2D>(asset);
			camera = new Vector2(
				(texture.Width - Settings.Size.WIDTH)/2,
				0
			);
			Position = camera;
		}
		public override void next()
		{
			
		}

		public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
		{
			sb.Draw(
				texture,
				new Rectangle(0, 0, Settings.Size.WIDTH, Settings.Size.HEIGHT),
				new Rectangle((int)camera.X, (int)camera.Y, Settings.Size.WIDTH, Settings.Size.HEIGHT),
				Color.White
			);
		}
	}
}
