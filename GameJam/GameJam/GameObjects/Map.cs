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
using GameJam.Components;

namespace GameJam.GameObjects
{
	class Map : GameObject
	{
		Microsoft.Xna.Framework.Game game;
		GraphicsDeviceManager gdm;
		//Texture2D texture;
		//ScrollingBackground layer;
		LinkedList<Layer> layers;

		public Map(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
		{
			game = g;
			this.gdm = gdm;
		}
		public override void Initialize()
		{
		}
		public void Initialize(string map)
		{
			/*texture = game.Content.Load<Texture2D>(map);
			Position = new Vector2(
				0, Settings.Size.HEIGHT - texture.Height
			);*/
			//layer = new ScrollingBackground((Game)game, map, 1);
		}
		public void Initialize(Layer[] layers)
		{
			this.layers = new LinkedList<Layer>(layers);
		}
		public void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
		}
		public override void UnloadContent()
		{
		}
		public override void Update(GameTime gameTime)
		{
			for (int i = 0, c = layers.Count; i < c; ++i)
			{
				layers.ElementAt<Layer>(i).next();
			}
		}
		public override void Draw(GameTime gameTime)
		{
			for (int i = 0, c = layers.Count; i < c; ++i)
			{
				((Game)game).Layers.Add(layers.ElementAt<Layer>(i));
			}
			//((Game)game).Layers.
			//layer.Draw(SpriteBatch);
			/*SpriteBatch.Draw(
				texture,
				new Rectangle((int)Position.X, (int)Position.Y, texture.Width, texture.Height),
				Color.White
			);*/
		}
	}
}
