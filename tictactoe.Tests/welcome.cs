using System;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
  public class ProgramTest
  {
    [Fact]
    public void Welcome()
    {
      var program = new Program();
      Assert.Equal("Welcome to Tic Tac Toe!", program.Welcome());
    }
  }
}
