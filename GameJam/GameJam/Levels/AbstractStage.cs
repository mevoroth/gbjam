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
using GameJam.Components;

namespace GameJam.Levels
{
	abstract class AbstractStage : Stage
	{
		GameObject player;
		GameObject map;
		LinkedList<GameObject> playershots = new LinkedList<GameObject>();
		LinkedList<GameObject> enemies = new LinkedList<GameObject>();
		LinkedList<GameObject> enemiesshots = new LinkedList<GameObject>();

		public GameObject Player
		{
			get { return player; }
		}

		public AbstractStage(Microsoft.Xna.Framework.Game g, GraphicsDeviceManager gdm)
			: base(g, gdm)
		{
		}

		public void LoadMap(string asset)
		{
			((Map)map).Initialize(asset);
		}

		public void LoadMap(Layer[] layers)
		{
			((Map)map).Initialize(layers);
		}

		public Map Map
		{
			get { return (Map)map; }
		}

		public LinkedList<GameObject> Enemies
		{
			get { return enemies; }
		}

		public LinkedList<GameObject> PlayerShots
		{
			get { return playershots; }
		}

		public override void Initialize()
		{
			player = new Player(this.Game, this.GraphicsDeviceManager);
			map = new Map(this.Game, this.GraphicsDeviceManager);
			player.Initialize();
		}

		public void LoadContent(SpriteBatch sb)
		{
			base.LoadContent(sb);
			player.LoadContent(sb);
			map.LoadContent(sb);
		}

		public override void UnloadContent()
		{
		}

		public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
		{
			map.Update(gameTime);
			player.Update(gameTime);
			foreach (GameObject go in enemies)
			{
				go.Update(gameTime);
			}

			/**
			 * COLLISION
			 */
			// OUT OF BORDER
			Vector2 pos = player.Position;
			if (pos.X < 0)
			{
				pos.X = 0;
			}
			else if (pos.X + player.Size.X >= Size.WIDTH)
			{
				pos.X = Size.WIDTH - player.Size.X;
			}

			if (pos.Y < 0)
			{
				pos.Y = 0;
			}
			else if (pos.Y + player.Size.Y >= Size.HEIGHT)
			{
				pos.Y = Size.HEIGHT - player.Size.Y;
			}

			// SHOTS
			if (enemies.Count > 0)
			{
				foreach (GameObject shot in playershots)
				{
					foreach (GameObject enemy in enemies)
					{
						if (shot.collide(enemy)
							|| enemy.collide(shot))
						{
							// APPLY DAMAGE
						}
					}
				}
			}

			foreach (GameObject shot in enemiesshots)
			{
				if (shot.collide(player)
					|| player.collide(shot))
				{
					// APPLY DAMAGE
				}
			}

			/**
			 * UPDATE
			 */
			player.Position = pos;
		}

		public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
		{
			map.Draw(gameTime);
			player.Draw(gameTime);
			foreach (GameObject go in enemies)
			{
				go.Draw(gameTime);
			}
		}
	}
}
