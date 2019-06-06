using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class MainMenuConsole : SadConsole.Console {

        private const string title = "Timeless Peach: Origin";
        private int selectChoice = 0;
        private ConsoleManager conMan;

        public MainMenuConsole(int width, int height, ConsoleManager conMan) : base(width, height) {
            this.conMan = conMan;
            IsFocused = true;
            IsVisible = true;
        }

        public override void Update(TimeSpan timeElapsed) {
            Clear();
            CheckInput();
            DrawMenuOptions();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            Print(0, 0, " ".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.Pink);
            Print(0, 2, " ".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.Pink);
            Print(0, 1, title.Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Black, Color.Pink);
            if (selectChoice == 0) {
                Print(0, 18, "Play".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
                Print(0, 20, "Quit".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
            } else if (selectChoice == 1) {
                Print(0, 18, "Play".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.White);
                Print(0, 20, "Quit".Align(HorizontalAlignment.Center, TimelessPeach.width), Color.Red);
            }
        }

        private void CheckInput() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice == 0)
                    selectChoice = 1;
                else if (selectChoice == 1)
                    selectChoice = 0;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                    conMan.ChangeState(GameState.PLAYING);
                } else if (selectChoice == 1) {
                    System.Environment.Exit(1);
                }
            }
        }

    }
}
