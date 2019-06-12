using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.dungeon {
    class Tile : Cell{
        private string name;
        protected bool solid;

        public Tile(Color foreground, Color background, int glyph, string name, bool solid) {
            Foreground = foreground;
            Background = background;
            Glyph = glyph;
            this.name = name;
            this.solid = solid;
        }

        public string GetName() {
            return name;
        }

        public bool IsSolid() {
            return solid;
        }
    }
}
