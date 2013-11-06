﻿using System;
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

namespace GameJam.GameObjects
{
	class Map : GameObject
	{
		Microsoft.Xna.Framework.Game game;
		GraphicsDeviceManager gdm;
		Texture2D texture;

		public Map(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}
		public override void Initialize()
		{
			
		}
		public void Initialize(string map)
		{
			texture = game.Content.Load<Texture2D>(map);
			Position = new Vector2(
				0, Settings.Size.HEIGHT - texture.Height
			);
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
		}
		public override void Draw(GameTime gameTime)
		{
			SpriteBatch.Draw(
				texture,
				new Rectangle((int)Position.X, (int)Position.Y, texture.Width, texture.Height),
				Color.White
			);
		}
	}
}
