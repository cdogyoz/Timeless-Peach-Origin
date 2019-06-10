using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class HumanConstruct : PlayableConstruct {

        public HumanConstruct() : base(Color.White, Color.Black, (int) '@', "Human Player") {
            IsVisible = true;
            base.strength = 10;
            base.agility = 10;
            base.intelligence = 10;
            base.divinity = 10;
            base.stamina = 100;
        }
    }
}
