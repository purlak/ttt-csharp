using System;

namespace tictactoe
{
    public class StartGame

    {
        private Game game;
        private IUserInterface _console;

        public StartGame(IUserInterface console)
        {
            game = new Game();
            _console = console;
        }

        public void Menu() 
        {
            GetWelcome();
            GetUserInput();
        }

        public void GetUserInput()
        {
            _console.Call(Content.GameOptions());
            _console.Call(Content.Menu());
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    game.Play();
                    break;

                default:
                    _console.Call(Content.InvalidOption());
                    GetUserInput();
                    break;
            }

        }

        public void GetWelcome()
        {
            _console.Call(Content.Welcome());
        }
    }
}
