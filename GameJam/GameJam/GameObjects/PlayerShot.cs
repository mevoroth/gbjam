using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using GameJam.GameObjects;
using GameJam.Settings;
using GameJam.Components;

namespace GameJam.GameObjects
{
	class PlayerShot : GameObject
	{
		Microsoft.Xna.Framework.Game game;
		GraphicsDeviceManager gdm;
		FixedSprite sprite;

		public PlayerShot(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}
		public override void Initialize()
		{
			sprite = new FixedSprite((Game)game, "shot", 1000);
		}
		public void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
		}
		public override void UnloadContent()
		{
		}
		public override void Update(GameTime gameTime)
		{
			sprite.Position += new Vector2(0, -5);
			sprite.next();
		}
		public override void Draw(GameTime gameTime)
		{
			((Game)game).Layers.Add(sprite);
			//((Game)game).Layers.
			//layer.Draw(SpriteBatch);
			/*SpriteBatch.Draw(
				texture,
				new Rectangle((int)Position.X, (int)Position.Y, texture.Width, texture.Height),
				Color.White
			);*/
		}
	}
}
