using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.dungeon;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class CharacterConsole : SadConsole.Console{

        private GameConsole gameConsole;
        private PlayableConstruct player;

        public CharacterConsole(GameConsole gameConsole, PlayableConstruct player) : base(30, 40) {
            int border = 0;
            this.gameConsole = gameConsole;
            this.player = player;
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
            Print(1, 3, "-----------------------------", Color.DarkCyan);
            Print(1, 4, "Health: " + player.getHealth());
            Print(1, 5, "Mana: " + player.getMana());
            Print(1, 7, "Strength: " + player.getStrength());
            Print(1, 8, "Intelligence: " + player.getIntelligence());
            Print(1, 9, "Agility: " + player.getAgility());
            Print(1, 10, "Divinity: " + player.getDivinity());
            Print(1, 11, "Stamina: " + player.getStamina());
            base.Update(timeElapsed);
        }
    }
}
