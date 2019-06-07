using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterConsole : SadConsole.Console{

        public CharacterConsole() : base(30, 40) {
            Position = new Point(100, 0);
            Fill(Color.Blue, Color.White, (int)'=', null);
        }

    }
}
