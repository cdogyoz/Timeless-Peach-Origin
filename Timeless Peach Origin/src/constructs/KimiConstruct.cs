using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class KimiConstruct : PlayableConstruct {

        public KimiConstruct() : base(Color.SandyBrown, Color.Black, (int)'@', "Kimi Player") {
            IsVisible = true;
            base.strength = 8;
            base.agility = 13;
            base.intelligence = 12;
            base.divinity = 7;
            base.stamina = 100;
        }

    }
}
