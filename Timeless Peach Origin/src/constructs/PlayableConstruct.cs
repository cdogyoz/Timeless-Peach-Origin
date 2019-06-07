using System;
using SadConsole;
using Microsoft.Xna.Framework;


namespace Timeless_Peach_Origin.src.constructs {
    class PlayableConstruct : Construct{

        public PlayableConstruct(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph, name) {
            IsVisible = true;
            Position = new Point(10, 10);
        }

    }
}
