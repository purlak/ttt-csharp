using System;

namespace tictactoe
{
    public class Game
    {
        private ConsoleInterface console;

        public Game()
        {
            console = new ConsoleInterface();
        }

        public void Menu()
        {
            console.DisplayText("Welcome to TicTacToe!");
            console.DisplayText("Game Options:");
            console.DisplayText("1. Human v. Human");
        }
    }
}