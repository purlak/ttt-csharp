namespace tictactoe
{
    public interface IUserInterface
    {
        void DisplayText(string text);
        string GetInput();
        void DisplayBoard(Board board);
    }
}