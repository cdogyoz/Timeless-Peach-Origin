using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterConsole : SadConsole.Console{

        public CharacterConsole(int width, int height) : base(width, height) {
            FillWithRandomGarbage();
        }

    }
}
