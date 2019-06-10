using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class HighUveseConstruct : PlayableConstruct {

        public HighUveseConstruct() : base(Color.Blue, Color.Black, (int)'@', "High Uvese Player") {
            IsVisible = true;
            base.strength = 7;
            base.agility = 7;
            base.intelligence = 12;
            base.divinity = 15;
            base.stamina = 100;
        }
    }
}
