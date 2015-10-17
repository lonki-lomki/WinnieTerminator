using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using WinnieTerminator.Core;

namespace WinnieTerminator
{

    // TODO Создать класс GameObject - базовый для игровых объектов
    // TODO Создать класс ГГ
    // TODO Движение ГГ по клавишам вправо и влево
    // TODO Добавить гравитацию
    // TODO Ландшафт ломаной линией
    // TODO Коллизия ГГ с ландшафтом

    // INFO По умолчанию, частота вызова методов Update и Draw равна 30 раз в секунду
    // Частоту вызова одного и другого метода можно настроить независимо.

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D image;

        /// <summary>
        /// Для хранения состояния игры
        /// </summary>
        GameData gd;

        /// <summary>
        /// Список игровых объектов на сцене
        /// </summary>
        List<GameObject> gameObjects = new List<GameObject>();
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            gd = GameData.Instance;
            gd.content = Content;
            gd.game = this;

            // Добавить игрока в список игровых объектов
            gameObjects.Add(gd.player);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            this.IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = CONST.WIND_WIDTH;
            graphics.PreferredBackBufferHeight = CONST.WIND_HEIGHT;
            graphics.ApplyChanges();

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //image = Content.Load<Texture2D>("Images/winnie");

            gd.player.LoadContent();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Обработка действий игрока
            HandleInput(gameTime);

            // Обновление всех игровых объектов
            foreach (GameObject item in gameObjects)
            {
                item.Update(gameTime);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// Обработка пользовательского ввода
        /// </summary>
        /// <param name="gameTime">текущая порция игрового времени</param>
        private void HandleInput(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, null);

            //GameData.Instance.player.Draw(spriteBatch);

            //gd.player.Draw(spriteBatch);

            // Отрисовка всех игровых объектов
            foreach (GameObject item in gameObjects)
            {
                item.Draw(spriteBatch);
            }

            DrawHud();

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Отрисовка элементов экранной индикации
        /// </summary>
        private void DrawHud()
        {

        }
    }
}
