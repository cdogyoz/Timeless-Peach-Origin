using System;
using SadConsole;
using SadConsole.Components;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.constructs;


namespace Timeless_Peach_Origin.src.constructs {
    class Item : Construct{
        internal string name;

        public Item(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph, name) {
            this.name = name;
        }
    }
}
