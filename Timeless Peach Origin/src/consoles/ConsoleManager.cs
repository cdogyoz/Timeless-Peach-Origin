using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach_Origin.src.consoles;

namespace Timeless_Peach_Origin.src.consoles {

    //Stores all of the info about consoles and controls the game state

    class ConsoleManager : ContainerConsole {

        public static MainMenuConsole mainMenu;
        public static GameConsole game;
        public static CharacterCreate characterCreate;

        private int gameWidth, gameHeight;
        private GameState gameState = new GameState();

        public ConsoleManager(int gameWidth, int gameHeight) {
            mainMenu = new MainMenuConsole(gameWidth, gameHeight, this);
            gameState = GameState.MAIN_MENU;
            Children.Add(mainMenu);
            SadConsole.Global.CurrentScreen = mainMenu;
        }

        public override void Update(TimeSpan timeElapsed) {
            base.Update(timeElapsed);
        }

        public void ChangeState(GameState gameState) {
            this.gameState = gameState;

            if (gameState == GameState.MAIN_MENU) {
                SadConsole.Global.CurrentScreen = mainMenu;
            }

            if (gameState == GameState.PLAYING) {

                if(SadConsole.Global.CurrentScreen == mainMenu) {
                    game = new GameConsole(gameWidth, gameHeight);
                    Children.Add(game);
                    SadConsole.Global.CurrentScreen = game;
                }
            }

        }

    }
}
