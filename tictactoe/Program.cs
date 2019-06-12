using System;

namespace tictactoe
{
    public class Program
    {
        public static void Main()
        {
            GetWelcome();
            DisplayBoard();
        }

        public static string GetWelcome()
        {
            DisplayText.Call(Content.Welcome());
            return "Welcome to Tic Tac Toe!";
        }

        private static void DisplayBoard()
        {
            new Board().DisplayBoard();
        }
    }
}
