using Xunit;

namespace tictactoe.Tests
{
    public class StartGameTest 
    {
        [Fact]
        public void GetWelcomeCallsDisplayTextCall()
        {
            MockConsoleInterface console = new MockConsoleInterface();
            StartGame startgame = new StartGame(console);
            startgame.GetWelcome();
            Assert.Equal(1, console.NumTimesCallisCalled);
        }

    }
}
