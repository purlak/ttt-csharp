using System;

namespace tictactoe
{
  public class Program
  {
    static void Main()
    {
      Welcome();
      DisplayBoard();
    }

    static void Welcome()
    {
      DisplayText.Call(Content.Welcome());
    }

    static void DisplayBoard()
    {
      new Board().DisplayBoard();
    }
  }
}
