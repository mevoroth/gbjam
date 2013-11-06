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

namespace GameJam.GameObjects
{
	abstract class GameObject
	{
		private SpriteBatch spriteBatch;
		private Vector2 position;
		private Vector2 size;

		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}
		public Vector2 Size
		{
			get { return size; }
			set { size = value; }
		}

		public SpriteBatch SpriteBatch
		{
			get { return spriteBatch; }
		}

		abstract public void Initialize();
		public void LoadContent(SpriteBatch sb)
		{
			spriteBatch = sb;
		}
		abstract public void UnloadContent();
		abstract public void Update(GameTime gameTime);
		abstract public void Draw(GameTime gameTime);


		private bool isIn(Vector2 v)
		{
			return v.X >= position.X && v.X <= position.X + size.X
				&& v.Y >= position.Y && v.Y <= position.Y + size.Y;
		}
		public bool collide(GameObject go)
		{
			return isIn(go.position)
				|| isIn(go.position + new Vector2(go.size.X, 0f))
				|| isIn(go.position + new Vector2(0f, go.size.Y))
				|| isIn(go.position + new Vector2(go.size.X, go.size.Y));
		}
	}
}
