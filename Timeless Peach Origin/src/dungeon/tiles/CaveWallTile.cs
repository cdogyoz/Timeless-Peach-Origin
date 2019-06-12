using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.dungeon.tiles {
    class CaveWallTile : Tile {

        public CaveWallTile() : base(Color.SaddleBrown, Color.Black, (int)'#', "cave_wall", true) {
            solid = true;
        }
    }
}
