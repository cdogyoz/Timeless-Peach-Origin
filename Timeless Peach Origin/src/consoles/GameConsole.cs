using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach_Origin.src.constructs;

namespace Timeless_Peach_Origin.src.consoles {
    class GameConsole : SadConsole.ContainerConsole{

        private CharacterCreate charCreate;
        private PlayableConstruct player;

        //Consoles
        private CharacterConsole charConsole;
        private WorldConsole worldConsole;
        private MessageConsole messageConsole;


        public GameConsole(int width, int height) {

            CreateCharacter();

        }

        public override void Update(TimeSpan timeElapsed) {
            
            if(player != null) {
                //Once the character has been made then we can start logic
            }

            base.Update(timeElapsed);
        }

        //Runs the character create screen
        private void CreateCharacter() {
            charCreate = new CharacterCreate(Width, Height, this);
            Children.Add(charCreate);
        }

        private void CreateGameConsoles() {
            charConsole = new CharacterConsole();
            messageConsole = new MessageConsole();
            worldConsole = new WorldConsole();
            Children.Add(worldConsole);
            Children.Add(messageConsole);
            Children.Add(charConsole);
        }

        //Sets the player from character create then removes the create screen
        public void SetPlayer(PlayableConstruct player) {
            this.player = player;
            player.Position = new Point(10, 10);
            Children.Remove(charCreate);
            Children.Add(player);
            CreateGameConsoles();
        }

    }
}
