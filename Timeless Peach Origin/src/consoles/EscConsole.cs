using System;
using SadConsole;
using SadConsole.Controls;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach_Origin.src.consoles;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class EscConsole : SadConsole.Console {
        private int selectChoice = 0;
        private GameConsole game;

        public EscConsole(int width, int height, GameConsole game) : base(TimelessPeach.width, TimelessPeach.height) {
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
            Print(0, 1, "MENU".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.PeachPuff);
            if (selectChoice == 0) {
                Print(0, 18, "Continue".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 20, "Return to main menu".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
            } else if (selectChoice == 1) {
                Print(0, 18, "Continue".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 20, "Return to main menu".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
            }
        }

        private void CheckInput() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)) {
                if (selectChoice < 1) {
                    selectChoice++;
                } else {
                    selectChoice = 0;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice > 0) {
                    selectChoice--;
                } else {
                    selectChoice = 1;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                }
                if (selectChoice == 1) {
                }
            }
        }
    }
}