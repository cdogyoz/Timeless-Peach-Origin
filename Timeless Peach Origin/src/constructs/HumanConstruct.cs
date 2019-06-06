using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class HumanConstruct : PlayableConstruct{

        public HumanConstruct() : base(Color.White, Color.Black, (int) '@', "Human Player") {
            IsVisible = true;
        }

    }
}
