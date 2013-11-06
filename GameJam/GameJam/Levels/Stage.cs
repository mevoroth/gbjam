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
	abstract public class Stage
	{
		private Microsoft.Xna.Framework.Game game;
		private GraphicsDeviceManager graphics;
		private SpriteBatch spriteBatch;

		public Microsoft.Xna.Framework.Game Game
		{
			get { return game; }
		}
		public GraphicsDeviceManager GraphicsDeviceManager
		{
			get { return graphics; }
		}
		public SpriteBatch SpriteBatch
		{
			get { return spriteBatch; }
		}

		public Stage(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			graphics = gdm;
		}

		abstract public void Initialize();
		public void LoadContent(SpriteBatch sb)
		{
			spriteBatch = sb;
		}
		abstract public void UnloadContent();
		abstract public void Update(GameTime gameTime);
		abstract public void Draw(GameTime gameTime);
	}
}
