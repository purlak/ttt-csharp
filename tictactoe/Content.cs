using System;

namespace tictactoe
{
    public static class Content
    {
        public static string Welcome()
        {
            return "\nWelcome to Tic Tac Toe!";
        }

        public static string GameDraws()
        {
            return "\nGame Draws.";
        }

        public static string GameOver(string marker)
        {
            return ($"Game Over.Winner is {marker}.");
        }

        public static string GetPosition()
        {
            return "Enter board position [1-9]: ";
        }

        public static string Menu()
        {
            return "1. Human v. Human";
        }

        public static string GameOptions()
        {
            return "\nGame Options:";
        }

        public static string InvalidMove()
        {
            return "\nThis move is not valid. Try again.";
        }

        internal static string InvalidOption()
        {
            return "\nThis option is invalid. Try again";
        }

        public static string Taken()
        {
            return "\nLooks like that position is taken. Try again.";
        }

        public static string Turn(string marker)
        {
            return $"It's now {marker}'s turn.";
        }
    }
}
