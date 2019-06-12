using Xunit;

namespace tictactoe.Tests
{
    public class BoardTest
    {
        [Fact]
        public void DisplayBoard()
        {
            var board = new Board();
            string[] cells = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Assert.Equal(cells, board.DisplayBoard());
        }
    }
}
