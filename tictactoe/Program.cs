namespace tictactoe
{
    public class Program
    {
        public static void Main()
        {
            ConsoleInterface displayText = new ConsoleInterface();
            StartGame startGame = new StartGame(displayText);
            startGame.Menu();
        }
    }
}
