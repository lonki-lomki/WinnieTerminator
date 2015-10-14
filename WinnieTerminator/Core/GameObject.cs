using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Базовый класс для описания игрового объекта
    /// </summary>
    public class GameObject
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        private string id;

        /// <summary>
        /// Координаты объекта в игровом мире
        /// </summary>
        public Vector2 position;

        /// <summary>
        /// Угол поворота объекта в градусах (0 угол - это положительное направление оси Х)
        /// Положительный угол - поворот по часовой стрелке, отрицательный - против часовой стрелки
        /// </summary>
        private float angle = 0.0f;

        /// <summary>
        /// Скорость движения объекта
        /// </summary>
        Vector2 velocity;

        /// <summary>
        /// Флаг, указывающий, действует ли на данный объект гравитация
        /// </summary>
        private bool isGravity = true;


        public List<Component> components = new List<Component>();
        public List<RenderComponent> renderComponents = new List<RenderComponent>();

        /// <summary>
        /// Конструктор 1
        /// </summary>
        public GameObject()
        {
        }

        /// <summary>
        /// Конструктор 2
        /// </summary>
        /// <param name="id"></param>
        public GameObject(string id)
        {
            this.id = id;
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Velocity
        {
            get { return position; }
            set { position = value; }
        }

        public void addComponent(Component c)
        {
            components.Add(c);
        }

        public void addComponent(RenderComponent rc)
        {
            // Добавить компонент в список локальных компонентов отображения
            renderComponents.Add(rc);
        }

        virtual public void Draw(SpriteBatch sb)
        {  }
    }
}
