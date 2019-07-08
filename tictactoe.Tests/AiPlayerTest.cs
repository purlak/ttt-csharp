using Xunit;

namespace tictactoe.Tests
{
    public class AiPlayerTest 
    {
        private Board board;
        private MockConsoleInterface console;
        private AiPlayer aiPlayer;

        public AiPlayerTest()
        {
            console = new MockConsoleInterface();
            board = new Board();
            aiPlayer = new AiPlayer("O", console);
        }

        [Fact]
        public void AiPlayerReturns5IfCentreIsNotOccupied()
        {
            board.cells = new string[] {
                    "X", " ", " ",
                    " ", " ", " ",
                    " ", " ", " "};
            
            Assert.Equal(5, aiPlayer.GetMove(board));
        }
    }
}
