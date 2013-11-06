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
			LoadMap("stg01_background");
		}

		public override void UnloadContent()
		{
			base.UnloadContent();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
		}
	}
}
