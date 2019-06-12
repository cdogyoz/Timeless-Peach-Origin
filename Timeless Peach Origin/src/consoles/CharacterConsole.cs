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
            Print(2, 2, "Dungeon Level: " + gameConsole.GetWorldConsole().GetCurrentLevel() + 1);
            Print(2, 3, "-----------------------------", Color.DarkCyan);
            Print(2, 4, "Health: " + player.getHealth());
            Print(2, 5, "Mana: " + player.getMana());
            Print(2, 7, "Strength: " + player.getStrength());
            Print(2, 8, "Intelligence: " + player.getIntelligence());
            Print(2, 9, "Agility: " + player.getAgility());
            Print(2, 10, "Divinity: " + player.getDivinity());
            Print(2, 11, "Stamina: " + player.getStamina());

            //Inventory display
            Print(2, 26, "Inventory");
            int index = 28;
            foreach (Item x in GameConsole.inventory) {
                Print(2, index, x.name);
                index++;
            }

            base.Update(timeElapsed);
        }
    }
}
