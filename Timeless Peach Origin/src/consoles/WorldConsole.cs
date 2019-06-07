using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class WorldConsole : SadConsole.ScrollingConsole {
        public WorldConsole() : base(110, 32, new Rectangle(0,0, 100, 100)) {
            Position = new Point(0, 0);
            FillWithRandomGarbage();
        }

        public void CenterOnPlayer(){
            //this.CenterViewPortOnPoint()
        }
    }
}
