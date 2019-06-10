using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.dungeon;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class WorldConsole : SadConsole.ScrollingConsole {
        private int curLevel = 0;
        private PlayableConstruct player;
        private int xPos = 10;
        private int yPos = 10;
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
            this.CenterViewPortOnPoint(player.Position);
        }

        public override void Update(TimeSpan timeElapsed) {
            SyncMapEntities();
            PlayerMovement();
            CenterOnPlayer();
            base.Update(timeElapsed);
        }

        private void SyncMapEntities() {
            //remove all entities from console
            Children.Clear();

            foreach (Construct construct in dungeon.dungeon[curLevel].entities.Items) {
                this.Children.Add(construct);
            }
        }

        public int GetCurrentLevel() {
            return curLevel;
        }

        private void PlayerMovement() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad2))) {
                if (GetGlyph(xPos, yPos + 1) != '#') {
                    yPos++;
                    player.Position = new Point(xPos, yPos);
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad8))) {
                if (GetGlyph(xPos, yPos - 1) != '#') {
                    yPos--;
                    player.Position = new Point(xPos, yPos);
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad4))) {
                if (GetGlyph(xPos - 1, yPos) != '#') {
                    xPos--;
                    player.Position = new Point(xPos, yPos);
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad6))) {
                if (GetGlyph(xPos + 1, yPos) != '#') {
                    xPos++;
                    player.Position = new Point(xPos, yPos);
                }
            }
        }
    }
}
