using System;
using SadConsole;
using Microsoft.Xna.Framework;
using GoRogue;

namespace Timeless_Peach_Origin.src.constructs {
    public abstract class Construct : SadConsole.Entities.Entity, GoRogue.IHasID {

        public uint ID { get; private set; }

        public Construct(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph) {

        }

    }
}
