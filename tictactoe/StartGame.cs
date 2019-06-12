using System;

namespace tictactoe
{
    public class StartGame

    {
        private Game game;
        private DisplayText displayText;

        public StartGame()
        {
            game = new Game();
            displayText = new DisplayText();
        }

        public void Menu() 
        {
            GetWelcome();
            GetUserInput();
        }

        private void GetUserInput()
        {
            displayText.Call("Game Options:");
            displayText.Call("1. Human v. Human");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    game.Play();
                    break;

                default:
                    displayText.Call("Invalid Option. Try again.");
                    GetUserInput();
                    break;
            }

        }

        public void GetWelcome()
        {
            displayText.Call(Content.Welcome());
        }
    }
}
