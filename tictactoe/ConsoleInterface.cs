using System;

namespace tictactoe
{
    public class ConsoleInterface : IUserInterface
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void DisplayBoard(Board board)
        {
            DisplayText($" {board.cells[0]} | {board.cells[1]} | {board.cells[2]} ");
            DisplayText("-----------");
            DisplayText($" {board.cells[3]} | {board.cells[4]} | {board.cells[5]} ");
            DisplayText("-----------");
            DisplayText($" {board.cells[6]} | {board.cells[7]} | {board.cells[8]} ");
        }
    }
}