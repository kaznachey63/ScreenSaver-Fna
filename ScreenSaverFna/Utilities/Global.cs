using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ScreenSaverFna
{
    static class Global
    {
        public static ScreenSaver screenSaver = null!;
        public static Random random = new ();
        public static string levelName = null!;

        public static void Initialize(ScreenSaver inputGame)
        {
            screenSaver = inputGame;
        }
    }
}
