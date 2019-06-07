using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class KimiConstruct : PlayableConstruct {

        public KimiConstruct() : base(Color.Green, Color.Black, (int)'@', "Kimi Player") {
            IsVisible = true;
        }

    }
}
