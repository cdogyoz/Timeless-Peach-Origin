using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class MessageConsole : ScrollingConsole {

        public MessageConsole() : base(100, 12) {
            int border = 0;
            Position = new Point(0, 31);
            Fill(Color.PeachPuff, Color.Black, (int)' ', null);
            //Keep spaces before and after strings for aesthetics
            Print(34, 1, " MESSAGE CONSOLE ", Color.PeachPuff);
            Print(0, 2, " Welcome to Timeless Peach! ", Color.PeachPuff);
            while (border < 100) {
                Print(border, 0, "-", Color.DarkCyan, Color.Black);
                border++;
            }
        }

    }
}
