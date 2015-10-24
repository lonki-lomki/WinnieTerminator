using Microsoft.Xna.Framework.Graphics;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Базовый класс для компонентов - визуализаторов
    /// </summary>
    public abstract class RenderComponent : Component
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">идентификатор компонента</param>
        /// <param name="owner">объект-владелец</param>
        /// <param name="game"></param>
        /// <param name="image">ссылка на изображение</param>
        public RenderComponent(string id, GameObject owner) : base(id, owner)
        {

        }

        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта
        /// </summary>
        public abstract void render();


        public abstract void render(SpriteBatch sb);



        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта через камеру
        /// </summary>
        /// <param name="cam_x">координата Х камеры</param>
        /// <param name="cam_y">координата У камеры</param>
        public abstract void render(SpriteBatch sb, float cam_x, float cam_y);


    }
}
