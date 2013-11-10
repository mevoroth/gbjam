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

		private SoundEffectInstance bgm1;
		private SoundEffectInstance bgm2;

		private int bgmtoken = -1;

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

		public void InitializeBGM(string bgm1, string bgm2)
		{
			/**
			 * Loading sound
			 */
			this.bgm1 = Game.Content.Load<SoundEffect>(bgm1).CreateInstance();
			this.bgm2 = Game.Content.Load<SoundEffect>(bgm2).CreateInstance();

			this.bgm1.Volume = 1f;
			this.bgm2.Volume = 0f;

			this.bgm1.IsLooped = true;
			this.bgm2.IsLooped = true;
		}

		public SoundEffectInstance Bgm1
		{
			get { return bgm1; }
		}

		public SoundEffectInstance Bgm2
		{
			get { return bgm2; }
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

			if (((Player)player).Primary)
			{
				PlayerShot ps = new PlayerShot(Game, GraphicsDeviceManager);
				ps.Initialize();
				ps.LoadContent(SpriteBatch);
				ps.Position = player.Position + new Vector2(
					6, -8
				);
				playershots.AddLast(ps);
				bgmtoken = 0;
			}


			if (bgmtoken > 500)
			{
				float bgm1vol = bgm1.Volume;
				float bgm2vol = bgm2.Volume;

				bgm1vol += 0.01f;
				bgm2vol -= 0.01f;

				if (bgm1vol > 1f || bgm2vol < 0f)
				{
					bgm1vol = 1f;
					bgm2vol = 0f;

					bgmtoken = -1;
				}

				bgm1.Volume = bgm1vol;
				bgm2.Volume = bgm2vol;
			}
			else if (bgmtoken >= 0)
			{
				bgmtoken += gameTime.ElapsedGameTime.Milliseconds;
				float bgm1vol = bgm1.Volume;
				float bgm2vol = bgm2.Volume;

				bgm1vol -= 0.01f;
				bgm2vol += 0.01f;

				if (bgm1vol < 0f || bgm2vol > 1f)
				{
					bgm1vol = 0f;
					bgm2vol = 1f;
				}

				bgm1.Volume = bgm1vol;
				bgm2.Volume = bgm2vol;
			}

			foreach (GameObject go in enemies)
			{
				go.Update(gameTime);
			}

			foreach (GameObject go in playershots)
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
				LinkedList<GameObject> shots = new LinkedList<GameObject>();
				LinkedList<GameObject> mobs = new LinkedList<GameObject>();
				foreach (GameObject shot in playershots)
				{
					if (shot.Position.Y < 0)
					{
						shots.AddLast(shot);
						continue;
					}
					foreach (GameObject enemy in enemies)
					{
						if (shot.collide(enemy)
							|| enemy.collide(shot))
						{
							--((Mob)enemy).Hp;
							if (((Mob)enemy).Hp <= 0)
							{
								shots.AddLast(shot);
							}
						}
					}
				}
				foreach (GameObject enemy in enemies)
				{
					if (enemy.Position.Y > Settings.Size.HEIGHT)
					{
						mobs.AddLast(enemy);
						continue;
					}
				}
				foreach (GameObject shot in shots)
				{
					playershots.Remove(shot);
				}
				foreach (GameObject mob in mobs)
				{
					enemies.Remove(mob);
				}
				shots = null;
				mobs = null;
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
			foreach (GameObject go in playershots)
			{
				go.Draw(gameTime);
			}
		}
	}
}

