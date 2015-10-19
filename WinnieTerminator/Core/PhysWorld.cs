using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace WinnieTerminator.Core
{
    class PhysWorld
    {
        public List<GameObject> objects = new List<GameObject>();

        /// <summary>
        /// Добавить еще один объект в физический мир
        /// </summary>
        /// <param name="go">игровой объект</param>
        public void Add(GameObject go)
        {
            objects.Add(go);
        }

        /// <summary>
        /// Обновлене состояния объектов физического мира
        /// </summary>
        /// <param name="gameTime"></param>
        public void Update(GameTime gameTime)
        {
            // Получить количество милисекунд, прошедших с прошлого выполнения данной функции
            float delta = (float) gameTime.ElapsedGameTime.TotalMilliseconds;

            // Цикл расчета новых координат игровых объектов
            foreach (GameObject item in objects)
            {
                // 1. Вычислить силу тяжести (и другие силы, если они есть)
                float gravityForce = (item.hasGravity() == true) ? CONST.PHYS_GRAVITY : 0.0f;

                // Все действующие силы без силы тяжести
                Vector2 allForces = new Vector2(0.0f, 0.0f);

                // 2. Изменить скорость объекта с учётом инерции (взять текущую скорость и откорректировать в зависимости от
                // результирующей силы).
                // TODO Необходимо учесть ограничение максимальной скорости (может быть не надо?)
                Vector2 currVelocity = item.Velocity;

                if (currVelocity.X >= allForces.X)
                {
                    // Скорость больше максимально возможной - уменьшаем
                    currVelocity.X -= (currVelocity.X - allForces.X) * delta / 1000;
                }
                else
                {
                    // Скорость меньше - увеличиваем
                    currVelocity.X += (allForces.X - currVelocity.X) * delta / 1000;
                }

                if (currVelocity.Y >= allForces.Y)
                {
                    // Скорость больше максимально возможной - уменьшаем
                    currVelocity.Y -= (currVelocity.Y - allForces.Y) * delta / 1000;
                }
                else
                {
                    // Скорость меньше - увеличиваем
                    currVelocity.Y += (allForces.Y - currVelocity.Y) * delta / 1000;
                }

                // Скорость вычислена.
                item.Velocity = new Vector2(currVelocity.X, currVelocity.Y);

                // Добавить ускорение свободного падения
                item.addVelocity(new Vector2(0.0f, 0 - gravityForce * delta / 1000));

                // 3. Рассчитать новое положение объекта
                //item.Update(gameTime);
            }
        }
    }
}
