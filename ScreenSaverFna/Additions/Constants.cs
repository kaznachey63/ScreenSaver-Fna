namespace ScreenSaverFna.Additions
{
    /// <summary>
    /// Класс для констант
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Количество генерируемых снежинок
        /// </summary>
        public const int NumberOfSnowflake = 100;

        /// <summary>
        /// Ширина окна
        /// </summary>
        public const int WindowWidth = 1200;

        /// <summary>
        /// Высота окна
        /// </summary>
        public const int WindowHeight = 720;

        /// <summary>
        /// Ширина снежинки
        /// </summary>
        public const int SnowflakeWidth = 35;

        /// <summary>
        /// Высота картинки
        /// </summary>
        public const int SnowflakeHeight = 35;

        /// <summary>
        /// Макс. число для новой коордианты по У
        /// </summary>
        public const int MaxNumberForNewDy = -10;

        /// <summary>
        /// Мин. число для новой коордианты по У
        /// </summary>
        public const int MinNumberForNewDy = -100;

        /// <summary>
        /// Мин. число для новой коордианты по Х
        /// </summary>
        public const int MinNumberForNewDx = 0;

        /// <summary>
        /// Мин. число для коордианты по Х
        /// </summary>
        public const int MinNumberForDx = 0;

        /// <summary>
        /// Мин. значение для скорости
        /// </summary>
        public const int MinValueForSpeed = 25;

        /// <summary>
        /// Макс. значение для скорости
        /// </summary>
        public const int MaxValueForSpeed = 75;

        /// <summary>
        /// Координата по Х для фоновой картинки
        /// </summary>
        public const int DxForBg = 0;

        /// <summary>
        /// Координата по У для фоновой картинки
        /// </summary>
        public const int DyForBg = 0;
    }
}