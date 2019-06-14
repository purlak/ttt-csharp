using Xunit;

namespace tictactoe.Tests
{
    public class BoardTest
    {
        private MockConsoleInterface console;
        private Board board;
        private HumanPlayer currentPlayer;

        public BoardTest()
        {
            console = new MockConsoleInterface();
            board = new Board(console);
            currentPlayer = new HumanPlayer("X");
        }

        [Fact]
        public void DisplayBoardCallsDisplayTextCall()
        {
            board.DisplayBoard();

            Assert.True(console.NumTimesCallisCalled > 0);
        }

        [Fact]
        public void UpdateBoardPlacesMarkerOnTheCell()
        {
            int input = 5;
           
            board.UpdateBoard(input, currentPlayer);

            Assert.Equal("X", board.cells[4]);
        }
    }
}
