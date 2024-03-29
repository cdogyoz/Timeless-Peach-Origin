﻿using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.dungeon;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class WorldConsole : SadConsole.ScrollingConsole {

        //Inventory testing
        private static Item healingPotion = new Item(Color.Purple, Color.Yellow, '&', "Healing Potion");
        //Inventory testing

        private int curLevel = 0;
        private PlayableConstruct player;
        private EscConsole escConsole;
        private int xPos = 10;
        private int yPos = 10;
        private GameConsole game;
        Dungeon dungeon;

        public WorldConsole(PlayableConstruct player, GameConsole game) : base(110, 32, SadConsole.Global.FontDefault.Master.GetFont(Font.FontSizes.Two), new Rectangle(0,0,55, 16)) {
            Position = new Point(0, 0);
            this.player = player;
            this.game = game;
            dungeon = new Dungeon();
            Cell[] level = dungeon.dungeon[curLevel].GetLevel();
            SetSurface(level, dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
            dungeon.dungeon[curLevel].Add(player);

            //Inventory testing
            dungeon.dungeon[curLevel].Add(healingPotion);
            //Inventory testing
        }

        public void CenterOnPlayer(){
            this.CenterViewPortOnPoint(new Point(player.Position.X, player.Position.Y));
        }

        public override void Update(TimeSpan timeElapsed) {
            SyncMapEntities();
            PlayerMovement();
            CenterOnPlayer();
            UpdatePlayerFOV();
            base.Update(timeElapsed);
        }

        private void UpdatePlayerFOV() {
            player.InitializeFOV(dungeon, curLevel);
            for(int x = 0; x < dungeon.dungeon[curLevel].Width; x++) {
                for(int y = 0; y < dungeon.dungeon[curLevel].Height; y++) {
                    if(player.GetFOV().BooleanFOV[x, y] == true) {
                        dungeon.dungeon[curLevel].GetLevel()[x, y].SetRevealed(true);
                    }
                    if(player.GetFOV().BooleanFOV[x, y] == false) {
                        dungeon.dungeon[curLevel].GetLevel()[x, y].SetRevealed(false);
                    }
                }
            }

            SetSurface(dungeon.dungeon[curLevel].GetLevel(), dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
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

        private void UpLevel() {
            if(curLevel > 0) {
                curLevel--;
                Cell[] level = dungeon.dungeon[curLevel].GetLevel();
                Clear();
                SetSurface(level, dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
                dungeon.dungeon[curLevel].Add(player);
            }
        }

        private void DownLevel() {
            if(curLevel < 4) {
                curLevel++;
                Cell[] level = dungeon.dungeon[curLevel].GetLevel();
                Clear();
                SetSurface(level, dungeon.dungeon[curLevel].Width, dungeon.dungeon[curLevel].Height);
                dungeon.dungeon[curLevel].Add(player);
            }
        }

        private void PlayerMovement() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Escape)) {
                escConsole = new EscConsole(TimelessPeach.width, TimelessPeach.height, game);
                Children.Add(escConsole);
                SadConsole.Global.CurrentScreen = escConsole;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.D)) {
                if (GetGlyph(player.Position.X, player.Position.Y) == '<') {
                    DownLevel();
                }
                if (GetGlyph(player.Position.X, player.Position.Y) == '>') {
                    UpLevel();
                }
                //Inventory testing
                if(GetGlyph(player.Position.X, player.Position.Y) == '&') {
                    GameConsole.inventory.Add(healingPotion);
                }
                //Inventory testing
            }

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