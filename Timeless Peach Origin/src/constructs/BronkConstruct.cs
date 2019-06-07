using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class BronkConstruct : PlayableConstruct {

        public BronkConstruct() : base(Color.Red, Color.Black, (int)'@', "Bronk Player") {
            IsVisible = true;
        }

    }
}
