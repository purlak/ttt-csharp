using System;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
  public class BoardTest
  {
    [Fact]
    public void DisplayBoard()
    {
      var board = new Board();
      Assert.Equal(new string[9], board.DisplayBoard());
    }
  }
}
