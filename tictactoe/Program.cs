using System;

namespace tictactoe
{
    public class Program
    {
        static void Main()
        {
            ConsoleInterface console = new ConsoleInterface();
            GameRules rules = new GameRules();
            Game game = new Game(console, rules);
            game.Menu();
        }
    }
}
