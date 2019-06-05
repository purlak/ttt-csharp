using System;

namespace tictactoe
{
  public class Program
  {
    static void Main(string[] args)
    {
      var program = new Program();
      program.Welcome();

      var board = new Board();
      board.DisplayBoard();
    }

    public string Welcome()
    {
      Console.WriteLine("Welcome to Tic Tac Toe!");
      return "Welcome to Tic Tac Toe!";
    }
  }
}
