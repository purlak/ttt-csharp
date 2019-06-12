namespace tictactoe
{
    public class Game
    {
        private Board board;

        public Game()
        {
            board = new Board();
        }
       
        public void Play()
        {
            //Menu();
            board.DisplayBoard();

        }

        public void Menu()
        {
            //DisplayText.Call("Select Game:");
            //DisplayText.Call("1. Human v. Human");
            //int userInput = Console.ReadLine();


        }
    }
}
