using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class PlayableConstruct : Construct{
        public int xPos = 10;
        public int yPos = 10;

        public PlayableConstruct(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph, name) {
            IsVisible = true;
            Position = new Point(xPos, yPos);
        }
    }
}
