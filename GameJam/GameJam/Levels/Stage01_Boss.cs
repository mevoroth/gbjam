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
	class Stage01_Boss : AbstractStage
	{
		private static Vector2 StartPoint = new Vector2(72, 108);

		public Stage01_Boss(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
			: base(g, gdm)
		{
		}
		public override void Initialize()
		{
			base.Initialize();
		}

		public void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
			Player.Position = StartPoint;
			LoadMap(new Components.Layer[] {
				new Components.ScrollableBackground((Game)Game, "stg01boss_layer01", 10000),
				new Components.ScrollableBackground((Game)Game, "stg01boss_layer02", 9990),
				new Components.ScrollableBackground((Game)Game, "stg01boss_layer03", 9980)
			});

			InitializeBGM("bgm_off", "bgm_on");
			Bgm1.Play();
			Bgm2.Play();
		}

		public override void UnloadContent()
		{
			base.UnloadContent();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);

			float x = 0;
			float y = 0;

			if (Player.Position.X > Size.WIDTH - 21)
			{
				x = 1;
			}
			else if (Player.Position.X < 21)
			{
				x = -1;
			}

			if (Player.Position.Y > Size.HEIGHT - 21)
			{
				y = 1;
			}
			else if (Player.Position.Y < 21)
			{
				y = -1;
			}

			Map.Position += new Vector2(
				x, y
			);
		}

		public override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
		}
	}
}
