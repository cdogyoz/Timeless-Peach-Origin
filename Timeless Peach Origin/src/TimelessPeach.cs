using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach_Origin.src.consoles;

namespace Timeless_Peach_Origin {

    class TimelessPeach {

        public const int width = 130;
        public const int height = 40;

        static void Main(string[] args) {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(width, height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;
            SadConsole.Game.OnUpdate = Update;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        //update function
        private static void Update(GameTime t) {

        }

        private static void Init() {
            // Begins the game 
            ConsoleManager game = new ConsoleManager(width, height);

        }
    }
}
