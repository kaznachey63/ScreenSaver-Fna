using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScreenSaverFna
{
    /// <summary>
    /// Модель снежинки
    /// </summary>
    public class Snowflake
    {
        public Snowflake() { }

        /// <summary>
        /// Картинка снежинки
        /// </summary>
        public Texture2D Image { get; set; } = default!;

        /// <summary>
        /// Скорость падения снежинки в пикселях
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Х координата снежинки
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// У координата снежинки
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Ширина снежинки 
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота снежинки
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Прямоугольник для отображения снежинки
        /// </summary>
        public Rectangle Rectangle => new (X, Y, Width, Height);

        /// <summary>
        /// Цвет фона для отображения снежинки
        /// </summary>
        public Color Color { get; set; }
    }
}