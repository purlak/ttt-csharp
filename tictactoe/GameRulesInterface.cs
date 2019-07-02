namespace tictactoe
{
    public interface IGameRulesInterface
    {
        bool Draw(Board board);
        bool Over(Board board);
        bool Won(Board board);
    }
}
