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

        /// <summary>
        /// Здоровье объекта. Количество пунктов здоровья.
        /// </summary>
        private int hp;

        /// <summary>
        /// Признак того, что объект имеет пункты здоровья
        /// </summary>
        private bool hasHP = false;

        /// <summary>
        /// Время жизни объекта в милисекундах. Значение -999 означает неограниченное время жизни.
        /// </summary>
        private float lifeTime = -999.0f;



        
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

        /// <summary>
        /// Изменить скорость объекта
        /// </summary>
        /// <param name="diff">добавка к скорости</param>
        virtual public void addVelocity(Vector2 diff)
        {
            velocity.X += diff.X;
            velocity.Y += diff.Y;
        }

        public bool hasGravity()
        {
            return isGravity;
        }

        public void setGravity(bool value)
        {
            isGravity = value;
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

        virtual public void Update(GameTime gameTime)
        {
            float delta = (float) gameTime.ElapsedGameTime.TotalMilliseconds;
            // delta - (в милисекундах) время, прошедшее после прошлого запуска функции
            position = new Vector2(position.X + (velocity.X / 1000.0f) * delta, position.Y + (velocity.Y / 1000.0f) * delta);

            // Обновить состояния компонентов этого объекта
            foreach (Component c in components)
            {
                c.update(gameTime);
            }

        }

        /// <summary>
        /// Отрисовка данного игрового объекта
        /// </summary>
        /// <param name="sb">инструмент для отрисовки спрайтов</param>
        virtual public void Draw(SpriteBatch sb)
        {
            foreach (RenderComponent rc in renderComponents)
            {
                rc.render(sb, GameData.Instance.camera.position.X, GameData.Instance.camera.position.Y);
            }
        }
    }
}
