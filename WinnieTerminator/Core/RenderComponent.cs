
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
        /// <param name="id"></param>
        /// <param name="owner"></param>
        public RenderComponent(string id, GameObject owner):base(id, owner) { }

        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта
        /// </summary>
        public abstract void render();

        /// <summary>
        /// Абстрактный класс для отрисовки связанного игрового объекта (через камеру)
        /// </summary>
        /// <param name="cam_x">координата Х камеры</param>
        /// <param name="cam_y">координата У камеры</param>
        public abstract void render(int cam_x, int cam_y);
    }
}
