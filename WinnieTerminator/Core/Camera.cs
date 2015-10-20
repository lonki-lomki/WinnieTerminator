
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
        /// Смещение камеры относительно игрового мира по Х
        /// </summary>
        public int x;

        /// <summary>
        /// Смещение камеры относительно игрового мира по У
        /// </summary>
        public int y;
    }
}
