﻿using System;
using SadConsole;
using SadConsole.Controls;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach_Origin.src.consoles;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterCreate : SadConsole.Console {
        private int selectChoice = 0;
        private GameConsole game;
        static public string currentRace = "You choose Human.";

        public CharacterCreate(int width, int height, GameConsole game) : base(TimelessPeach.width, TimelessPeach.height) {
            this.game = game;
        }

        public override void Update(TimeSpan timeElapsed) {
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            Print(0, 0, " ".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);
            Print(0, 2, " ".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);
            Print(0, 1, "CHARACTER CREATE".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);
            Print(0, 30, "Press space or enter to play".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);

            if (selectChoice == 0) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.PeachPuff);
            }

            if (selectChoice == 1) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.PeachPuff);
            }

            if (selectChoice == 2) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.PeachPuff);
            }

            if (selectChoice == 3) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.PeachPuff);
            }
        }

        private void CheckInput() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)) {
                if (selectChoice < 3) {
                    selectChoice++;
                }
                else {
                    selectChoice = 0;
                }

                if (selectChoice == 0) {
                    currentRace = "You choose Human.";
                }

                if (selectChoice == 1) {
                    currentRace = "You choose Kimi.";
                }

                if (selectChoice == 2) {
                    currentRace = "You choose High Uvese.";
                }

                if (selectChoice == 3) {
                    currentRace = "You choose Bronk.";
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice > 0) {
                    selectChoice--;
                }
                else {
                    selectChoice = 3;
                }

                if (selectChoice == 0) {
                    currentRace = "You choose Human.";
                }
                if (selectChoice == 1) {
                    currentRace = "You choose Kimi.";
                }
                if (selectChoice == 2) {
                    currentRace = "You choose High Uvese.";
                }
                if (selectChoice == 3) {
                    currentRace = "You choose Bronk.";
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                    game.SetPlayer(new HumanConstruct());
                }

                if (selectChoice == 1) {
                    game.SetPlayer(new KimiConstruct());
                    selectChoice = 0;
                }

                if (selectChoice == 2) {
                    PlayableConstruct player = new HighUveseConstruct();
                    game.SetPlayer(player);
                    selectChoice = 0;
                }

                if (selectChoice == 3) {
                    game.SetPlayer(new BronkConstruct());
                    selectChoice = 0;
                }
            }
        }
    }
}