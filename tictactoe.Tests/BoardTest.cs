using Xunit;

namespace tictactoe.Tests
{
    public class BoardTest
    {
        private MockConsoleInterface console;
        private Board board;
        
        public BoardTest()
        {
            console = new MockConsoleInterface();
            board = new Board(console);   
        }

        [Fact]
        public void DisplayBoardCallsConsole()
        {
            board.DisplayBoard();

            Assert.True(console.NumTimesDisplayTextisCalled > 0);
        }
    }
}