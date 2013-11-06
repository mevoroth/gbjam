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
		public Menu(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
			: base(g, gdm)
		{
		}

		public override void Initialize()
		{
		}

		public override void UnloadContent()
		{
		}

		public override void Update(GameTime gameTime)
		{
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
