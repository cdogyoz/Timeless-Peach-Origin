using System;
using SadConsole;
using Microsoft.Xna.Framework;
using GoRogue;

namespace Timeless_Peach_Origin.src.constructs {
    public abstract class Construct : SadConsole.Entities.Entity, GoRogue.IHasID {
        public int strength;
        public int agility;
        public int intelligence;
        public int divinity;
        public int stamina;

        public uint ID { get; private set; }

        public Construct(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph) {

        }

        public int getHealth() {
            return strength * 4;
        }

        public int getMana() {
            return divinity * 4;
        }

        public int getStrength() {
            return strength;
        }

        public int getAgility() {
            return agility;
        }

        public int getIntelligence() {
            return intelligence;
        }

        public int getDivinity() {
            return divinity;
        }

        public int getStamina() {
            return stamina;
        }

    }
}
