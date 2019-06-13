using System;
using SadConsole;
using SadConsole.Components;
using Microsoft.Xna.Framework;
using GoRogue;
using GoRogue.MapGeneration;
using GoRogue.MapViews;
using Timeless_Peach_Origin.src.dungeon;

namespace Timeless_Peach_Origin.src.constructs {
    class PlayableConstruct : Construct{
        public int xPos = 10;
        public int yPos = 10;
        protected ArrayMap<bool> fovMap;
        protected FOV fov;

        public PlayableConstruct(Color foreground, Color background, int glyph, string name) : base(foreground, background, glyph, name) {
            IsVisible = true;
            Position = new Point(xPos, yPos);
        }

        public override void Update(TimeSpan timeElapsed) {
            base.Update(timeElapsed);
        }

        public FOV GetFOV() {
            return fov;
        }

        public void InitializeFOV(Dungeon dungeon, int level) {
            int mapWidth = dungeon.dungeon[level].Width;
            int mapHeight = dungeon.dungeon[level].Height;
            fovMap = new ArrayMap<bool>(mapWidth, mapHeight);
            ArrayMap<Tile> map = dungeon.dungeon[level].GetLevel();

            for (int x = 0; x < mapWidth; x++) {
                for(int y = 0; y < mapHeight; y++) {
                    if(map[x, y].IsSolid() == true) {
                        fovMap[x, y] = false; //set to false if it does block FOV
                    } else {
                        fovMap[x, y] = true;
                    }
                }
            }

            fov = new FOV(fovMap);
            fov.Calculate(new Point(Position.X, Position.Y), 12);
        }
    }
}
