using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach_Origin.src.consoles;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterCreate : SadConsole.Console {

        private int selectChoice = 0;
        static public string currentRace = "You choose Human.";

        public CharacterCreate(int width, int height) : base(TimelessPeach.width, TimelessPeach.height) {

        }

        public override void Update(TimeSpan timeElapsed) {
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            Print(0, 1, "CHARACTER CREATE".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White, Color.Black);
            Print(0, 22, "Press space or enter to play".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);
            if (selectChoice == 0) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.PeachPuff);
            }
            else if (selectChoice == 1) {
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
            else if (selectChoice == 3) {
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
                    //name = EnterName();
                }
                if (selectChoice == 1) {
                    //name = EnterName();
                    selectChoice = 0;
                }
                if (selectChoice == 2) {
                    //name = EnterName();
                    selectChoice = 0;
                }
                if (selectChoice == 3) {
                    //name = EnterName();
                    selectChoice = 0;
                }
            }
        }
    }
}