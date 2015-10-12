
using Microsoft.Xna.Framework.Graphics;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Класс, описывающий главного героя
    /// </summary>
    class Player : GameObject
    {
        private Texture2D picture;

        public Player(GameData gd)
        {
            LoadContent(gd);
        }

        /// <summary>
        /// Загрузка спрайтов игрока и звуков
        /// </summary>
        public void LoadContent(GameData gd)
        {
            picture = gd.content.Load<Texture2D>("Images/winnie");
        }
    }
}
