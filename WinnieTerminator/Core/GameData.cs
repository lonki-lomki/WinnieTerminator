using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Класс, содержащий текущее состояние игры
    /// </summary>
    class GameData
    {

        private static GameData instance;

        public Game game;

        public Player player;

        public ContentManager content;

        public KeyboardState keyboardState;

        public PhysWorld world;

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        private GameData()
        {
            // Создать физический мир
            world = new PhysWorld();
            // Создать игрока
            player = new Player();
            // Добавить игрока в физический мир
            world.Add(player);
        }

        /// <summary>
        /// Статический метод создания или получения единственного экземпляра данного класса
        /// </summary>
        public static GameData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameData();
                }
                return instance;
            }
        }

    }
}
