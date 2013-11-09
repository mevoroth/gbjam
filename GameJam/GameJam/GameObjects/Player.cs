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
		public enum StateX
		{
			IDLE,
			L,
			R
		}
		public enum StateY
		{
			IDLE,
			F,
			B
		}

		const int HP = 1;
		const float SPEED = 2f;

		//AnimatedSprite sprite;
		FixedSprite sprite_idle;
		FixedSprite sprite_forward;
		FixedSprite sprite_backward;
		FixedSprite sprite_left;
		FixedSprite sprite_right;
		FixedSprite sprite_backward_left;
		FixedSprite sprite_backward_right;

		private StateX s_x = StateX.IDLE;
		private StateY s_y = StateY.IDLE;

		private Microsoft.Xna.Framework.Game game;
		private GraphicsDeviceManager gdm;

		public Player(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}

		public Vector2 Position
		{
			set
			{
				sprite_idle.Position = value;
				sprite_forward.Position = value;
				sprite_backward.Position = value;
				sprite_left.Position = value;
				sprite_right.Position = value;
				sprite_backward_left.Position = value;
				sprite_backward_right.Position = value;
				base.Position = value;
			}
		}

		public override void Initialize()
		{
			//sprite = new FixedSprite((Game)game, "player", 1000);
			sprite_idle = new FixedSprite((Game)game, "player_idle", 1000);
			sprite_forward = new FixedSprite((Game)game, "player_forward", 1000);
			sprite_backward = new FixedSprite((Game)game, "player_backward", 1000);
			sprite_left = new FixedSprite((Game)game, "player_left", 999);
			sprite_right = new FixedSprite((Game)game, "player_right", 999);
			sprite_backward_left = new FixedSprite((Game)game, "player_backward_left", 1000);
			sprite_backward_right = new FixedSprite((Game)game, "player_backward_right", 1000);
			//sprite = game.Content.Load<Texture2D>("player");

			Size = new Vector2(
				sprite_forward.Width,
				sprite_forward.Height
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
			// STATE
			if (y > 0f)
			{
				s_y = StateY.B;
			}
			else if (y < 0)
			{
				s_y = StateY.F;
			}
			else
			{
				s_y = StateY.IDLE;
			}

			if (x > 0)
			{
				s_x = StateX.R;
			}
			else if (x < 0)
			{
				s_x = StateX.L;
			}
			else
			{
				s_x = StateX.IDLE;
			}

			// POSITION
			Position = new Vector2(
				base.Position.X + x*SPEED,
				base.Position.Y + y*SPEED
			);
			//current_sprite.Position = base.Position;

			// NEXT FRAME
			//current_sprite.next();
		}
		public override void Draw(GameTime gameTime)
		{
			//sprite.Draw(SpriteBatch);
			//((Game)game).Layers.Add(current_sprite);
			if (s_y != StateY.B)
			{
				if (s_y == StateY.F)
				{
					((Game)game).Layers.Add(sprite_forward);
				}
				else
				{
					((Game)game).Layers.Add(sprite_idle);
				}

				if (s_x == StateX.L)
				{
					((Game)game).Layers.Add(sprite_left);
				}
				else if (s_x == StateX.R)
				{
					((Game)game).Layers.Add(sprite_right);
				}
			}
			else
			{
				if (s_x == StateX.L)
				{
					((Game)game).Layers.Add(sprite_backward_left);
				}
				else if (s_x == StateX.R)
				{
					((Game)game).Layers.Add(sprite_backward_right);
				}
				else
				{
					((Game)game).Layers.Add(sprite_backward);
				}
			}

			//SpriteBatch.Draw(
			//    sprite.Texture,
			//    new Rectangle((int)Position.X, (int)Position.Y, sprite.Width, sprite.Height),
			//    sprite.getFrame(),
			//    Color.White
			//);
		}
	}
}
