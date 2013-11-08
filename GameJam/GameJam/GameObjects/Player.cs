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
using GameJam.Components;

namespace GameJam.GameObjects
{
	class Player : GameObject
	{
		const int HP = 1;
		const float SPEED = 2f;

		//AnimatedSprite sprite;
		FixedSprite sprite_idle;
		FixedSprite sprite_forward;
		FixedSprite sprite_backward;
		FixedSprite sprite_left;
		FixedSprite sprite_right;

		private Microsoft.Xna.Framework.Game game;
		private GraphicsDeviceManager gdm;

		public Player(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}
		public override void Initialize()
		{
			//sprite = new FixedSprite((Game)game, "player", 1000);
			sprite_idle = new FixedSprite((Game)game, "player_idle", 1000);
			sprite_forward = new FixedSprite((Game)game, "player_forward", 1000);
			sprite_backward = new FixedSprite((Game)game, "player_backward", 1000);
			sprite_left = new FixedSprite((Game)game, "player_left", 1000);
			sprite_right = new FixedSprite((Game)game, "player_right", 1000);
			//sprite = game.Content.Load<Texture2D>("player");
			Size = new Vector2(
				sprite.Width,
				sprite.Height
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
			float x = 0;
			float y = 0;

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

			/**
			 * UPDATE
			 */
			// POSITION
			Position = new Vector2(
				Position.X + x*SPEED,
				Position.Y + y*SPEED
			);
			sprite.SetPosition(Position);
			// NEXT FRAME
			sprite.next();
		}
		public override void Draw(GameTime gameTime)
		{
			//sprite.Draw(SpriteBatch);
			((Game)game).Layers.Add(sprite);
			//SpriteBatch.Draw(
			//    sprite.Texture,
			//    new Rectangle((int)Position.X, (int)Position.Y, sprite.Width, sprite.Height),
			//    sprite.getFrame(),
			//    Color.White
			//);
		}
	}
}
