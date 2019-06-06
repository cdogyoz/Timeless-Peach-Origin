using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class GameConsole : SadConsole.ContainerConsole{

        private CharacterCreate charCreate;


        public GameConsole(int width, int height) {

            CreateCharacter();

        }
        
        private void CreateCharacter() {
            charCreate = new CharacterCreate(Width, Height);
            Children.Add(charCreate);
        }

    }
}
