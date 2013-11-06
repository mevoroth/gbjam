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

using GameJam.Settings;

namespace GameJam.GameObjects
{
	class Player : GameObject
	{
		const int HP = 1;

		Texture2D sprite;

		private Microsoft.Xna.Framework.Game game;
		private GraphicsDeviceManager gdm;

		public Player(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}
		public override void Initialize()
		{
			sprite = game.Content.Load<Texture2D>("player");
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
			int x = 0;
			int y = 0;

			/**
			 * CONTROLS
			 */
			if (Keyboard.GetState().IsKeyDown(Controls.Get.Forward))
			{
				--y;
			}
			if (Keyboard.GetState().IsKeyDown(Controls.Get.Backward))
			{
				++y;
			}
			if (Keyboard.GetState().IsKeyDown(Controls.Get.MoveLeft))
			{
				--x;
			}
			if (Keyboard.GetState().IsKeyDown(Controls.Get.MoveRight))
			{
				++x;
			}
			if (Keyboard.GetState().IsKeyDown(Controls.Get.Primary))
			{
				// PRIMARY WEAPON
			}
			if (Keyboard.GetState().IsKeyDown(Controls.Get.Secondary))
			{
				// SECONDARY WEAPON
			}
		}
		public override void Draw(GameTime gameTime)
		{
			SpriteBatch.Draw(
				sprite,
				new Rectangle(0, 0, sprite.Width, sprite.Height),
				Color.White
			);
		}
	}
}
