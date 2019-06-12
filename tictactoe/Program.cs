namespace tictactoe
{
    public class Program
    {
        static void Main()
        {
            Welcome();
            DisplayBoard();
        }

        static string Welcome()
        {
            DisplayText.Call(Content.Welcome());
            return ("Welcome to Tic Tac Toe!");
        }

        static void DisplayBoard() => new Board().DisplayBoard();
    }
}
