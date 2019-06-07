using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.dungeon;

namespace Timeless_Peach_Origin.src.consoles {
    class WorldConsole : SadConsole.ScrollingConsole {

        private int curLevel = 0;

        Dungeon dungeon;


        public WorldConsole() : base(110, 32, new Rectangle(0,0, 100, 100)) {
            Position = new Point(0, 0);
            dungeon = new Dungeon();
            Cell[] level = dungeon.dungeon[curLevel].GetLevel();
            SetSurface(level, dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
        }

        public void CenterOnPlayer(){
            //this.CenterViewPortOnPoint()
        }
    }
}
