using System;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterConsole : SadConsole.Console{

        private GameConsole gameConsole;

        public CharacterConsole(GameConsole gameConsole) : base(30, 40) {
            int border = 0;
            this.gameConsole = gameConsole;
            Position = new Point(100, 0);
            Fill(Color.PeachPuff, Color.Black, (int)' ', null);
            Print(0, 0, "Character Info".Align(HorizontalAlignment.Center, 30));
            while (border < 40) {
                Print(0, border, "|", Color.Black, Color.DarkCyan);
                border++;
            }
        }

        public override void Update(TimeSpan timeElapsed) {
            Print(1, 2, "Dungeon Level: " + gameConsole.GetWorldConsole().GetCurrentLevel() + 1);
            base.Update(timeElapsed);
        }
    }
}
