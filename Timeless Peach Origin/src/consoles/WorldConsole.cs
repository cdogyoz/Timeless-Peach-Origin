using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.dungeon;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class WorldConsole : SadConsole.ScrollingConsole {

        private int curLevel = 0;
        private PlayableConstruct player;

        Dungeon dungeon;
        

        public WorldConsole(PlayableConstruct player) : base(110, 32, new Rectangle(0,0, 100, 100)) {
            Position = new Point(0, 0);
            this.player = player;
            dungeon = new Dungeon();
            Cell[] level = dungeon.dungeon[curLevel].GetLevel();
            SetSurface(level, dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
            dungeon.dungeon[curLevel].Add(player);

        }

        public void CenterOnPlayer(){
            //this.CenterViewPortOnPoint()
        }

        public override void Update(TimeSpan timeElapsed) {
            SyncMapEntities();
            base.Update(timeElapsed);
        }

        private void SyncMapEntities() {

            //remove all entities from console
            Children.Clear();

            foreach (Construct construct in dungeon.dungeon[curLevel].entities.Items) {
                this.Children.Add(construct);
            }
        }
    }
}
