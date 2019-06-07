using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterConsole : SadConsole.Console{

        public CharacterConsole() : base(30, 40) {
            int border = 0;
            Position = new Point(100, 0);
            Fill(Color.PeachPuff, Color.Black, (int)' ', null);
            Print(0, 0, "Character Info".Align(HorizontalAlignment.Center, 30));
            while (border < 40) {
                Print(0, border, "|", Color.Black, Color.DarkCyan);
                border++;
            }
        }

    }
}
