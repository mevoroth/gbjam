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

namespace GameJam.Levels
{
	class Menu : Stage
	{
		private SoundEffectInstance bgm;
		private int time = 0;

		public Menu(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
			: base(g, gdm)
		{
		}

		public override void Initialize()
		{
			bgm = Game.Content.Load<SoundEffect>("title").CreateInstance();
			bgm.Volume = 0.0f;
			bgm.IsLooped = true;
			bgm.Play();
		}

		public override void UnloadContent()
		{
		}

		public override void Update(GameTime gameTime)
		{
			if (time > 60000)
			{
				float vol = bgm.Volume;
				vol -= 0.05f;
				if (vol <= 0f)
				{
					vol = 0f;
				}
				bgm.Volume = vol;
				if (time > 62000)
				{
					time = 0;
				}
			}
			else
			{
				float vol = bgm.Volume;
				vol += 0.05f;
				if (vol >= 1f)
				{
					vol = 1f;
				}
				bgm.Volume = vol;
			}
			bgm.Stop();
			//Stage01_Boss stg01 = new Stage01_Boss(this.Game, GraphicsDeviceManager);
			Stage01 stg01 = new Stage01(this.Game, GraphicsDeviceManager);
			stg01.Initialize();
			stg01.LoadContent(SpriteBatch);
			((Game)this.Game).LoadStage(stg01);
		}

		public override void Draw(GameTime gameTime)
		{
		}
	}
}
