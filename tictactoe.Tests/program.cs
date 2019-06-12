using Xunit;

namespace tictactoe.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void GetWelcome()
        {
            Assert.Equal("Welcome to Tic Tac Toe!", Program.GetWelcome());
        }
    }
}
