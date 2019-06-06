using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class GameConsole : SadConsole.ContainerConsole{


        public GameConsole(int width, int height) {

            CharacterCreation();

            SadConsole.Console garbage = new SadConsole.Console(10, 10);
            garbage.FillWithRandomGarbage();
            garbage.Position = new Point(10, 10);
            Children.Add(garbage);
        }
        
        private void CharacterCreation() {
            //Fill in the character create stuff here
        }

    }
}
