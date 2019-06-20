using Xunit;

namespace tictactoe.Tests
{
    public class BoardTest
    {
        private MockConsoleInterface console;
        private Board board;
        private Player currentPlayer;

        public BoardTest()
        {
            console = new MockConsoleInterface();
            board = new Board(console);
            currentPlayer = new Player("X", console);
        }

        [Fact]
        public void UpdateBoardTest()
        {
            int input = 5;

            board.UpdateBoard(input, currentPlayer);

            Assert.Equal("X", board.cells[4]);
        }
    }
}