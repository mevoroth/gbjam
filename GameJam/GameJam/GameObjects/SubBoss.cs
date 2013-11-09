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
	class SubBoss : Mob
	{
		private AnimatedSprite sprite;
		public Vector2 Position
		{
			get { return base.Position; }
			set
			{
				sprite.Position = value;
				//hitsprite.Position = value; 
				base.Position = value;
			}
		}

		public SubBoss(Game g, GraphicsDeviceManager gdm, Movement mv)
			: base(g, gdm, mv)
		{
		}

		public override void Initialize()
		{
			base.Initialize("oculusbat_big", "oculusbat_hit", 32);
			//sprite = new AnimatedSprite((Game)Game, "oculusbat_big", 16, 900);
		}

		public override void UnloadContent()
		{
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			//Position += Behaviour.getMovement(this, gameTime);
			//sprite.next();
		}

		public override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
			//((Game)Game).Layers.Add(sprite);
		}

		public override void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
		}
	}
}
