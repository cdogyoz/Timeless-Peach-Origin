using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.dungeon {
    class Tile : Cell{

        private string name;
        protected bool solid;

        public Tile(Color foreground, Color background, int glyph, string name) {
            Foreground = foreground;
            Background = background;
            Glyph = glyph;
            this.name = name;
        }

    }
}
