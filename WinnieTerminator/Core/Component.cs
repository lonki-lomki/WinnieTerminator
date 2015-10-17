
using Microsoft.Xna.Framework;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Базовый класс для компонентов
    /// </summary>
    public abstract class Component
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
        /// Абстрактный класс обновления состояния компонента
        /// </summary>
        /// <param name="gameTime">время, прошедшее после предыдущего вызова этого метода</param>
        public abstract void update(GameTime gameTime);

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"></param>
        /// <param name="owner"></param>
        public Component(string id, GameObject owner)
        {
            this.id = id;
            this.owner = owner;
        }
    }
}
