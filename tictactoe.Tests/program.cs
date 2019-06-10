using System;
using Xunit;
using Xunit.Abstractions;
using tictactoe;

namespace tictactoe.Tests
{
  public class ProgramTest
  {
    private readonly ITestOutputHelper output;

    public MyTestClass(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    [Fact]
    public void Welcome()
    {
      var program = new Program();
      Assert.Equal("Welcome to Tic Tac Toe!", program.Welcome());
    }
  }
}
