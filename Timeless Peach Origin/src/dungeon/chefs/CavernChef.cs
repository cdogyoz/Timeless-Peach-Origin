using System;
using System.Collections.Generic;
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
        }

        public Tile[] CreateLevel() {

            Random r = new Random();

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    int randNum = r.Next(0, 125);

                    if (randNum <= 33) {
                       // cavern[x, y] = new Tile(Color.White, Color.Black, (int)'#', true, "wall"); //Create classes for these
                    } else {
                       // cavern[x, y] = new Tile(Color.White, Color.Black, (int)'-', false, "ground");
                    }
                }
            }

            return new Tile[3];

        }

    }
}
