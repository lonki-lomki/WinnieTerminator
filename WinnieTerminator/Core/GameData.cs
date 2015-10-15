using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

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

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        private GameData()
        {
            player = new Player();
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
