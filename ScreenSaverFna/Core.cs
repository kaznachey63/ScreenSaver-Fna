using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ScreenSaverFna
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

            GenerateSnowflakes(100);
        }

        /// <summary>
        /// Генерация снежинок
        /// </summary>
        /// <param name="amount">Количество снежинок</param>
        private void GenerateSnowflakes(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                int newDX = random.Next(0, graphics.PreferredBackBufferWidth);
                int newDY = random.Next(-graphics.PreferredBackBufferHeight, -10);
                int speed = random.Next(25, 75);

                Snowflake snowflake = new Snowflake
                {
                    Image = sf,
                    Speed = speed,
                    X = newDX,
                    Y = newDY,
                    Width = 35,
                    Height = 35,
                    Color = Color.White,
                };

                snowflakes.Add(snowflake);
            }
        }

        /// <summary>
        /// Отображение снежинок
        /// </summary>
        /// <param name="spriteBatch"></param>
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
        /// <param name="spriteBatch"></param>
        public void ShowBg(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg, new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White);  //.Draw(image, new Vector2(0, 0), Color.White);
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
                    newDY = random.Next(-100, -20);
                    DX = random.Next(0, graphics.PreferredBackBufferWidth);
                }

                snowflake.X = DX;
                snowflake.Y = newDY;
            }
        }
    }
}