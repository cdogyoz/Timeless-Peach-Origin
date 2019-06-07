using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class MessageConsole : ScrollingConsole {

        public MessageConsole() : base(100, 9) {
            Position = new Point(0, 34);
            Fill(Color.Coral, Color.Coral, (int)' ', null);
            Print(34, 0, "LOG CONSOLE", Color.White, Color.Black);
            Print(0, 1, "Welcome to Timeless Peach!", Color.Green, Color.Blue);
        }

    }
}
