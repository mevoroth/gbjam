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
				new Components.ScrollingBackground((Game)Game, "stg01_layer02", 2, 990),
				new Components.ScrollingBackground((Game)Game, "stg01_layer01", 6, 9990)
			});

			InitializeBGM("bgm_off", "bgm_on");
			Bgm1.Play();
			Bgm2.Play();

			/**
			 * 1ST WAVE
			 */
			Mob m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -20);
			Enemies.AddLast(m);

			/**
			 * 2ND WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(32, -164);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -452);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(112, -308);
			Enemies.AddLast(m);

			/**
			 * 3RD WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(124, -596);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(98, -612);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -628);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(46, -644);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(20, -660);
			Enemies.AddLast(m);

			/**
			 * 4TH WAVE
			 */
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(20, -740);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(46, -756);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -772);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(98, -788);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(124, -804);
			Enemies.AddLast(m);

			/**
			 * 5TH WAVE
			 */
			// WAVE RIGHT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(80 + 804, -660 * 2 - 144);
			m.Position = new Vector2(1252, -2040);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(96 + 804, -692 * 2 - 144);
			m.Position = new Vector2(1268, -2104);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(114 + 804, -724 * 2 - 144);
			m.Position = new Vector2(1206, -2168);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownLeft());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(132 + 804, -756 * 2 - 144);
			m.Position = new Vector2(1224, -2232);
			Enemies.AddLast(m);

			// WAVE LEFT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(10 - 804, -772 * 2 - 144);
			m.Position = new Vector2(-1082, -2264);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(28 - 804, -740 * 2 - 144);
			m.Position = new Vector2(-1004, -2200);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(46 - 804, -708 * 2 - 144);
			m.Position = new Vector2(-1046, -2136);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.DownRight());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			//m.Position = new Vector2(64 - 804, -676 * 2 - 144);
			m.Position = new Vector2(-1028, -2072);
			Enemies.AddLast(m);

			// WAVE TOP
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(40, -1164);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1164);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(104, -1164);
			Enemies.AddLast(m);

			/**
			 * 6TH WAVE
			 */
			// FIRST WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1308);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1340);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1372);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1404);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1436);
			Enemies.AddLast(m);
			
			// SECOND WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1564);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1596);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1628);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1660);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.U());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(120, -1692);
			Enemies.AddLast(m);

			/**
			 * SEVENTH WAVE
			 */
			// FIRST WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1836);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1868);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1900);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1932);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1974);
			Enemies.AddLast(m);

			// SECOND WAVE
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S(-1));
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1836);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S(-1));
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1868);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S(-1));
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1900);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S(-1));
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1932);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.S(-1));
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -1974);
			Enemies.AddLast(m);

			/**
			 * EIGHTH WAVE
			 */
			m = new SubBoss((Game)Game, GraphicsDeviceManager, new Mob.Typical());
			m.Initialize();
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(64, -2206);
			Enemies.AddLast(m);

			//TOP
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -2230);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(88, -2206);
			Enemies.AddLast(m);

			//RIGHT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(104, -2198);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(88, -2206);
			Enemies.AddLast(m);

			//BOTTOM
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(72, -2166);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(56, -2206);
			Enemies.AddLast(m);

			//LEFT
			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(42, -2198);
			Enemies.AddLast(m);

			m = new Mob((Game)Game, GraphicsDeviceManager, new Mob.O());
			m.Initialize("oculusbat", 16, "oculusbat_hit", 16, "oculusbat_death", 32);
			m.LoadContent(SpriteBatch);
			m.Position = new Vector2(56, -2206);
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
			if (Enemies.Last.Value.Position.Y > Settings.Size.HEIGHT)
			{
				Stage01_Boss stg = new Stage01_Boss(Game, GraphicsDeviceManager);
				stg.Initialize();
				stg.LoadContent(SpriteBatch);
				((Game)Game).LoadStage(stg);
			}
			//if (Map.Position.Y >= 0)
			//{
			//    Stage01_Boss stg = new Stage01_Boss(Game, GraphicsDeviceManager);
			//    stg.Initialize();
			//    stg.LoadContent(SpriteBatch);
			//    //((Game)Game).LoadStage(stg);
			//}
		}

		public override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
		}
	}
}

