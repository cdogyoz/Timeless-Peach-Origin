using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class BronkConstruct : PlayableConstruct {

        public BronkConstruct() : base(Color.Red, Color.Black, (int)'@', "Bronk Player") {
            IsVisible = true;
            base.strength = 15;
            base.agility = 5;
            base.intelligence = 10;
            base.divinity = 7;
            base.stamina = 100;
        }

    }
}
