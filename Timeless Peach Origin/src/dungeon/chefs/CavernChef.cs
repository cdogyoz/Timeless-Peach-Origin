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
        private Level level;
        ArrayMap<Tile> cavern;

        public CavernChef(int width, int height, Level level) {
            this.width = width;
            this.height = height;
            this.level = level;
            cavern = new ArrayMap<Tile>(width, height);
        }

        public ArrayMap<Tile> CreateLevel() {
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

            int smooths = 3;
            for (int s = 0; s < smooths; s++) {
                ArrayMap<Tile> smoothedLevel = new ArrayMap<Tile>(width, height);

                for (int x = 0; x < width; x++) {
                    for (int y = 0; y < height; y++) {
                        //Count amount of walls in 3x3 area
                        //The tile becomes a wall if 5 or more neighbor tiles are walls
                        int walls = 0;

                        if (level.IsValidCell(x, y) && cavern[x, y].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x - 1, y - 1) && cavern[x - 1, y - 1].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x, y - 1) && cavern[x, y - 1].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x + 1, y - 1) && cavern[x + 1, y - 1].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x - 1, y) && cavern[x - 1, y].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x + 1, y) && cavern[x + 1, y].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x - 1, y + 1) && cavern[x - 1, y + 1].GetName() == "cave_wall") {
                            walls++;
                        }
                        if (level.IsValidCell(x, y + 1)) {
                            if (cavern[x, y + 1].GetName() == "cave_wall") {
                                walls++;
                            }

                        }
                        if (level.IsValidCell(x + 1, y + 1) && cavern[x + 1, y + 1].GetName() == "cave_wall") {
                            walls++;
                        }

                        //Check if walls are greater than or equal to 5
                        if (walls >= 4) {
                            smoothedLevel[x, y] = new CaveWallTile();
                            //level.fovMap[x, y] = false;

                        } else {
                            smoothedLevel[x, y] = new FloorTile();
                            //level.fovMap[x, y] = true;
                        }
                    }
                }

                for (int x = 0; x < width; x++) {
                    for (int y = 0; y < height; y++) {
                        cavern[x, y] = smoothedLevel[x, y];
                    }
                }
            }

            //Create the boundaries
            for (int x = 0; x < width; x++) {
                cavern[x, 0] = new CaveWallTile();
                cavern[x, height - 1] = new CaveWallTile();

            }

            for (int y = 0; y < height; y++) {
                cavern[0, y] = new CaveWallTile();
                cavern[width - 1, y] = new CaveWallTile();
            }

            bool stairPlaced = false;
            while(stairPlaced == false) {
                int x1 = r.Next(0, width - 1);
                int y1 = r.Next(1, height - 1);
                int x2 = r.Next(1, width - 1);
                int y2 = r.Next(1, height - 1);
                if(cavern[x1, y1].IsSolid() != true && cavern[x2, y2].IsSolid() != true) {
                    cavern[x1, y1] = new DownstairTile();
                    cavern[x2, y2] = new UpstairTile();
                    stairPlaced = true;
                }
            }

            return cavern;
        }
    }
}
