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
            // Цикл расчета новых координат игровых объектов
            foreach (GameObject item in objects)
            {

            }
        }
    }
}
