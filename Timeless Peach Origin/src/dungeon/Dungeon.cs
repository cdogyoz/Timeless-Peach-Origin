using System;
using System.Collections.Generic;

namespace Timeless_Peach_Origin.src.dungeon {
    class Dungeon {

        public List<Level> dungeon;

        //Create a new dungeon
        public Dungeon() {
            dungeon = new List<Level>();
            BuildDungeon();
        }

        private void BuildDungeon() {
            //Build cavern levels
            //First five 
            for (int i = 0; i < 5; i++) {
                dungeon.Add(new Level(LevelTypes.CAVERNS));
            }
        }
    }
}
