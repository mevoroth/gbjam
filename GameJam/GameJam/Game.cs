using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using GameJam.Settings;
using GameJam.Levels;

namespace GameJam
{
	/// <summary>
	/// Type principal pour votre jeu
	/// </summary>
	public class Game : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		Levels.Stage stage;

		public Game()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			stage = new Levels.Menu(this, graphics);
		}

		/// <summary>
		/// Permet au jeu de s’initialiser avant le démarrage.
		/// Emplacement pour la demande de services nécessaires et le chargement de contenu
		/// non graphique. Calling base.Initialize passe en revue les composants
		/// et les initialise.
		/// </summary>
		protected override void Initialize()
		{
			// TODO : ajouter la logique d’initialisation ici
			graphics.PreferredBackBufferWidth = Size.WIDTH;
			graphics.PreferredBackBufferHeight = Size.HEIGHT;
			graphics.ApplyChanges();
			this.IsFixedTimeStep = true;

			stage.Initialize();

			base.Initialize();
		}

		/// <summary>
		/// LoadContent est appelé une fois par partie. Emplacement de chargement
		/// de tout votre contenu.
		/// </summary>
		protected override void LoadContent()
		{
			// Créer un SpriteBatch, qui peut être utilisé pour dessiner des textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO : utiliser this.Content pour charger le contenu de jeu ici
			stage.LoadContent(spriteBatch);
		}

		/// <summary>
		/// UnloadContent est appelé une fois par partie. Emplacement de déchargement
		/// de tout votre contenu.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO : décharger tout le contenu non-ContentManager ici
			stage.UnloadContent();
		}

		/// <summary>
		/// Permet au jeu d’exécuter la logique de mise à jour du monde,
		/// de vérifier les collisions, de gérer les entrées et de lire l’audio.
		/// </summary>
		/// <param name="gameTime">Fournit un aperçu des valeurs de temps.</param>
		protected override void Update(GameTime gameTime)
		{
			// Permet au jeu de se fermer
			//if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
			//    this.Exit();

			// TODO : ajouter la logique de mise à jour ici
			stage.Update(gameTime);

			base.Update(gameTime);
		}

		/// <summary>
		/// Appelé quand le jeu doit se dessiner.
		/// </summary>
		/// <param name="gameTime">Fournit un aperçu des valeurs de temps.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);
			spriteBatch.Begin();
			// TODO : ajouter le code de dessin ici
			stage.Draw(gameTime);

			base.Draw(gameTime);
			spriteBatch.End();
		}

		public void LoadStage(Stage stg)
		{
			stage = stg;
		}
	}
}
