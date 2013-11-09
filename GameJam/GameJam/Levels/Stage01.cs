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

namespace GameJam.Levels
{
	class Stage01 : AbstractStage
	{
		private static Vector2 StartPoint = new Vector2(72, 108);

		public Stage01(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
			: base(g, gdm)
		{
		}
		public void Initialize()
		{
			base.Initialize();
			//LoadMap("stg01_background");
			LoadMap(new Components.Layer[] {
				new Components.FixedSprite((Game)Game, "stg01_layer03", 10000),
				new Components.ScrollingBackground((Game)Game, "stg01_layer02", 3, 9990),
				new Components.ScrollingBackground((Game)Game, "stg01_layer01", 1, 990)
			});
			
			/**
			 * 1ST WAVE
			 */
			Mob m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -20);
			Enemies.AddLast(m);

			/**
			 * 2ND WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(32, -164);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -164);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(112, -164);
			Enemies.AddLast(m);

			/**
			 * 3RD WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(124, -308);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(98, -324);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -340);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(46, -356);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(20, -372);
			Enemies.AddLast(m);

			/**
			 * 4TH WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(20, -452);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(46, -468);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -484);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(98, -500);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(124, -516);
			Enemies.AddLast(m);

			/**
			 * 5TH WAVE
			 */
			// WAVE RIGHT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(80 + 804, -660 * 2 - 144);
			m.Position = new Vector2(884, -1464);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(96 + 804, -692 * 2 - 144);
			m.Position = new Vector2(900, -1528);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(114 + 804, -724 * 2 - 144);
			m.Position = new Vector2(918, -1592);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(132 + 804, -756 * 2 - 144);
			m.Position = new Vector2(936, -1656);
			Enemies.AddLast(m);

			// WAVE LEFT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(10 - 804, -772 * 2 - 144);
			m.Position = new Vector2(-794, -1688);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(28 - 804, -740 * 2 - 144);
			m.Position = new Vector2(-776, -1624);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(46 - 804, -708 * 2 - 144);
			m.Position = new Vector2(-758, -1560);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(64 - 804, -676 * 2 - 144);
			m.Position = new Vector2(-740, -1496);
			Enemies.AddLast(m);

			// WAVE TOP
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(40, -876);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -876);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(104, -876);
			Enemies.AddLast(m);

			/**
			 * 6TH WAVE
			 */
			// FIRST WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1020);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1052);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1084);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1116);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1148);
			Enemies.AddLast(m);
			
			// SECOND WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1276);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1308);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1340);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1372);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1404);
			Enemies.AddLast(m);

		}

		public void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
			Player.Position = StartPoint;
		}

		public override void UnloadContent()
		{
			base.UnloadContent();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			Map.Position += new Vector2(
				0, 1
			);
			if (Map.Position.Y >= 0)
			{
				Stage01_Boss stg = new Stage01_Boss(Game, GraphicsDeviceManager);
				stg.Initialize();
				stg.LoadContent(SpriteBatch);
				//((Game)Game).LoadStage(stg);
			}
		}

		public override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
		}
	}
}
