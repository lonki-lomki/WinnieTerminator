using Microsoft.Xna.Framework;
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
        public Point position;

        /// <summary>
        /// Текущий поворот объекта
        /// </summary>
        protected float rotation;

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
    }
}
