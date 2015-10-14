
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Базовый класс для компонентов - визуализаторов
    /// </summary>
    public abstract class RenderComponent : DrawableGameComponent
    {
        /// <summary>
        /// Идентификатор компонента
        /// </summary>
        public string id;

        /// <summary>
        /// Объект-владелец данного компонента
        /// </summary>
        public GameObject owner;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">идентификатор компонента</param>
        /// <param name="owner">объект-владелец</param>
        /// <param name="game"></param>
        /// <param name="image">ссылка на изображение</param>
        public RenderComponent(string id, GameObject owner, Game game, ref Texture2D image) : base(game)
        {
            this.id = id;
            this.owner = owner;
        }

        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта
        /// </summary>
        public abstract void render();

        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта через камеру
        /// </summary>
        /// <param name="cam_x">координата Х камеры</param>
        /// <param name="cam_y">координата У камеры</param>
        public abstract void render(int cam_x, int cam_y);
    }
}
