using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.dungeon {
    class Tile : Cell{
        private string name;
        protected bool solid;
        protected bool revealed;
        protected Color mainForeground, mainBackground;
        protected int mainGlyph;

        protected bool revealedBefore = false;

        public Tile(Color foreground, Color background, int glyph, string name, bool solid) {
            Foreground = foreground;
            Background = background;
            Glyph = glyph;
            this.name = name;
            this.solid = solid;
            mainForeground = foreground;
            mainBackground = background;
            mainGlyph = glyph;
        }

        public string GetName() {
            return name;
        }

        public bool IsSolid() {
            return solid;
        }

        public void SetRevealed(bool revealed) {
            if(revealed == true) {
                Foreground = mainForeground;
                Background = mainBackground;
                revealedBefore = true;
            }
            if(revealed == false) {
                Foreground = Color.Black;
                Background = Color.Black;
                if(revealedBefore == true) {
                    Foreground = Color.Black;
                    Background = Color.DarkGray;
                }
            }
        }
    }
}
