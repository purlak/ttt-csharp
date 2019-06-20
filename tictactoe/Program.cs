using System;

namespace tictactoe
{
    public class Program
    {
        static void Main()
        {
            ConsoleInterface console = new ConsoleInterface();
            Game game = new Game(console);
            game.Menu();
        }
    }
}
