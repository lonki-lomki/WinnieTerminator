using Microsoft.Xna.Framework;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Класс для управления камерой, отображающей выбранную область игрового мира
    /// </summary>
    class Camera
    {
        /// <summary>
        /// Ширина окна камеры
        /// </summary>
        private int width;

        /// <summary>
        /// Высота окна камеры
        /// </summary>
        private int height;

        /// <summary>
        /// Смещение камеры относительно игрового мира.
        /// </summary>
        public Vector2 position;

        /// <summary>
        /// Объект, за которым следит камера
        /// </summary>
        //private GameObject obj;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="width">Ширина камеры</param>
        /// <param name="height">Высота камеры</param>
        public Camera(int width, int height)
        {
            this.width = width;
            this.height = height;
            position = new Vector2(0.0f, 0.0f);
        }

        /// <summary>
        /// Переместить камеру в указанную позицию
        /// </summary>
        /// <param name="value">новая позиция камеры</param>
        public void setPosition(Vector2 value)
        {
            position = value;
        }

        /// <summary>
        /// Переместить камеру в указанную позицию
        /// </summary>
        /// <param name="x">координата Х новой позиции камеры</param>
        /// <param name="y">координата У новой позиции камеры</param>
        public void setPosition(float x, float y)
        {
            setPosition(new Vector2(x, y));
        }

        /// <summary>
        /// Переместить камеру относительно указанного игрового объекта
        /// (камера должна держать объект в центре)
        /// TODO сделать инерцию в перемещении камеры
        /// </summary>
        /// <param name="obj">игровой объект</param>
        public void setPosition(GameObject obj)
        {
            // Получить предварительную координату камеры
            float tmp_x = obj.Position.X - width/2;
            // TODO координату У не проверяем и не меняем - принимаем высоту игрового мира равной высоте камеры
            //float tmp_y = obj.Position.Y - height/2;

            // Проверка выхода за пределы размеров игрового мира
            if (tmp_x < 0)
            {
                tmp_x = 0;
            }
            if (tmp_x > (CONST.WORLD_WIDTH - width))
            {
                tmp_x = CONST.WORLD_WIDTH - width;
            }

            // Установка новой позиции камеры
            setPosition(new Vector2(tmp_x, 0));
        }
    }
}
