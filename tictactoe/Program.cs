using System;

namespace tictactoe
{
    public class Program
    {
        static void Main()
        {
            ConsoleInterface console = new ConsoleInterface();
            GameRules rules = new GameRules();
            Player player1 = new Player("X", console);
            Player player2 = new Player("O", console);
            Game game = new Game(console, rules, player1, player2);
            game.Menu();
        }
    }
}
