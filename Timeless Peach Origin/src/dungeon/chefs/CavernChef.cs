using System;
using System.Collections.Generic;
using Timeless_Peach_Origin.src.dungeon.tiles;
using GoRogue;
using GoRogue.MapGeneration;
using GoRogue.MapViews;
using Troschuetz.Random;
using Troschuetz.Random.Generators;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.dungeon.chefs {
    class CavernChef {

        private int width, height;
        private int seed = DateTime.Now.Millisecond;
        ArrayMap<Tile> cavern;

        public CavernChef(int width, int height, Level level) {
            this.width = width;
            this.height = height;
            cavern = new ArrayMap<Tile>(width, height);
        }

        public Tile[] CreateLevel() {

            Random r = new Random(seed);

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    int randNum = r.Next(0, 125);

                    if (randNum <= 33) {
                        Tile tile = new CaveWallTile();
                        cavern[x, y] = tile; //Create classes for these
                    } else {
                        Tile tile = new FloorTile();
                        cavern[x, y] = tile;
                    }
                }
            }

            return cavern;

        }

    }
}
