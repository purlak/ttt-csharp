using System;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
  public class Test
  {
    [Fact]
    public void Test2()
    {
      var program = new Program();
      Assert.Equal("Welcome to Tic Tac Toe!", program.Welcome());
    }
  }
}
