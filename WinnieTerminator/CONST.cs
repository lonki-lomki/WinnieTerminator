
namespace WinnieTerminator
{
    /// <summary>
    /// Класс для хранения постоянных параметров (констант)
    /// </summary>
    class CONST
    {
        public static readonly int WIND_WIDTH = 1024;
        public static readonly int WIND_HEIGHT = 600;

        // TODO пока константой: размер игрового мира (потом надо перенести в калсс, описывающий этап)
        public static readonly int WORLD_WIDTH = 10240;
        public static readonly int WORLD_HEIGHT = 600;

        public static readonly float PHYS_GRAVITY = 90.0f;      // Гравитация для физ. движка
    }
}
