using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameJam.Components;
using GameJam.Settings;

namespace GameJam.GameObjects
{
	class Mob : GameObject
	{
		public interface Movement
		{
			Vector2 getMovement(Mob m, GameTime gt);
		}

		public class Typical : Movement
		{
			private Vector2 mv = new Vector2(0, 1);

			#region Movement Membres

			public Vector2 getMovement(Mob m, GameTime gt)
			{
				return mv;
			}

			#endregion
		}

		public class DownLeft : Movement
		{
			private Vector2 mv = new Vector2(-1, 2);

			#region Movement Membres

			public Vector2 getMovement(Mob m, GameTime gt)
			{
				return mv;
			}

			#endregion
		}

		public class DownRight : Movement
		{
			private Vector2 mv = new Vector2(1, 2);

			#region Movement Membres

			public Vector2 getMovement(Mob m, GameTime gt)
			{
				return mv;
			}

			#endregion
		}

		public class U : Movement
		{
			private enum State
			{
				RIGHT_BRANCH,
				TRANSITION,
				LEFT_BRANCH
			}
			private U.State state = State.RIGHT_BRANCH;

			private Mob.Typical typ = new Mob.Typical();
			private Vector2 left = new Vector2(-1, 0);
			private Vector2 forward = new Vector2(0, -1);

			#region Movement Membres

			public Vector2 getMovement(Mob m, GameTime gt)
			{
				switch (state)
				{
					case State.RIGHT_BRANCH:
						if (m.Position.Y >= Settings.Size.HEIGHT - 24)
						{
							state = State.TRANSITION;
						}
						return typ.getMovement(m, gt);
						break;
					
					case State.TRANSITION:
						if (m.Position.X <= 24)
						{
							state = State.LEFT_BRANCH;
						}
						return left;
						break;

					default: // LEFT_BRANCH
						return forward;
						break;
				}
			}

			#endregion
		}

		public class S : Movement
		{
			private Mob.Typical typ = new Mob.Typical();

			private int start = -1;
			private int dir = 1;
			#region Movement Membres

			public S() { }

			public S(int dir)
			{
				this.dir = dir;
			}

			public Vector2 getMovement(Mob m, GameTime gt)
			{
				if (m.Position.Y > Settings.Size.HEIGHT)
				{
					return typ.getMovement(m, gt);
				}
				if (m.Position.Y > 0)
				{
					if (start < 0)
					{
						start = 0;
					}
					start += gt.ElapsedGameTime.Milliseconds;
					return new Vector2((float)(dir * Math.Cos(start / 350f)), 1);
				}
				return typ.getMovement(m, gt);
			}

			#endregion
		}

		Game game;
		GraphicsDeviceManager gdm;

		Movement mv;
		
		AnimatedSprite sprite;
		AnimatedSprite hitsprite;

		public Vector2 Position
		{
			get { return base.Position; }
			set
			{
				sprite.Position = value;
				hitsprite.Position = value; 
				base.Position = value;
			}
		}

		public Mob(Game g, GraphicsDeviceManager gdm, Movement mv)
		{
			game = g;
			this.gdm = gdm;
			this.mv = mv;
		}

		public override void Initialize()
		{
			sprite = new AnimatedSprite((Game)game, "oculusbat", 16, 900);
			hitsprite = new AnimatedSprite((Game)game, "oculusbat_hit", 16, 900);
		}

		public override void UnloadContent()
		{
		}

		public override void Update(GameTime gameTime)
		{
			Position += mv.getMovement(this, gameTime);
			sprite.next();
		}

		public override void Draw(GameTime gameTime)
		{
			((Game)game).Layers.Add(sprite);
		}

		public override void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
		}
	}
}
