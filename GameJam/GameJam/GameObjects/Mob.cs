using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameJam.Components;

namespace GameJam.GameObjects
{
	class Mob : GameObject
	{
		public interface Movement
		{
			Vector2 getMovement();
		}

		public class Typical : Movement
		{
			#region Movement Membres

			private Vector2 mv = new Vector2(0, 1);

			public Vector2 getMovement()
			{
				return mv;
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
			Position += mv.getMovement();
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
