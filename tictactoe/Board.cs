using System;

namespace tictactoe
{
  public class Board
  {
    public string[] DisplayBoard()
    {
      string[] cells = new string[9];
      Console.WriteLine(String.Join(" ", cells));
      return cells;
    }
  }
}
