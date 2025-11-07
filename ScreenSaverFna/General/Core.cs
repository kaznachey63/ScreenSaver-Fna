using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ScreenSaverFna.Additions;
using ScreenSaverFna.Models;

namespace ScreenSaverFna.General
{
    /// <summary>
    /// Класс логики программы
    /// </summary>
    public class Core
    {
        private List<Snowflake> snowflakes = new();
        private readonly Random random = new();
        private Texture2D sf = null!;
        private Texture2D bg = null!;
        private GraphicsDeviceManager graphics = null!;

        public Core(GraphicsDeviceManager graphicsDeviceManager, ContentManager content)
        {
            graphics = graphicsDeviceManager;
            sf = content.Load<Texture2D>("snowflake.png");
            bg = content.Load<Texture2D>("cherry.jpg");

            GenerateSnowflakes(Constants.NumberOfSnowflake);
        }

        /// <summary>
        /// Генерация снежинок
        /// </summary>
        /// <param name="amount">Количество снежинок</param>
        private void GenerateSnowflakes(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                int newDX = random.Next(Constants.MinNumberForNewDx, Constants.WindowWidth);
                int newDY = random.Next(-Constants.WindowHeight, Constants.MaxNumberForNewDy);
                int speed = random.Next(Constants.MinValueForSpeed, Constants.MaxValueForSpeed);

                Snowflake snowflake = new Snowflake
                {
                    Image = sf,
                    Speed = speed,
                    X = newDX,
                    Y = newDY,
                    Width = Constants.SnowflakeWidth,
                    Height = Constants.SnowflakeHeight,
                    Color = Color.White,
                };

                snowflakes.Add(snowflake);
            }
        }

        /// <summary>
        /// Отображение снежинок
        /// </summary>
        public void ShowSnoflakes(SpriteBatch spriteBatch)
        {
            foreach (var snowflake in snowflakes)
            {
                spriteBatch.Draw(snowflake.Image, snowflake.Rectangle, snowflake.Color);
            }
        }

        /// <summary>
        /// Отображение заднего фона
        /// </summary>
        public void ShowBg(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg, new Rectangle(Constants.DxForBg, Constants.DyForBg, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White);  //.Draw(image, new Vector2(0, 0), Color.White);
        }

        /// <summary>
        /// Смещение снежинки
        /// </summary>        
        public void OffsetSnowflake()
        {
            foreach (var snowflake in snowflakes)
            {
                int DX = snowflake.X;
                int newDY = snowflake.Y + snowflake.Speed;

                if (newDY > graphics.PreferredBackBufferHeight)
                {
                    newDY = random.Next(Constants.MinNumberForNewDy, Constants.MaxNumberForNewDy);
                    DX = random.Next(Constants.MinNumberForDx, graphics.PreferredBackBufferWidth);
                }

                snowflake.X = DX;
                snowflake.Y = newDY;
            }
        }
    }
}