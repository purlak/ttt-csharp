﻿using System;

namespace tictactoe
{
    public class GameRules
    {
        private Moves moves;
        public GameRules()
        {
            moves = new Moves();
        }

        public bool Won(Board board)
        {
            if (
                board.cells[0] == board.cells[1] &&
                board.cells[1] == board.cells[2] &&
                board.cells[0] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[3] == board.cells[4] &&
                board.cells[4] == board.cells[5] &&
                board.cells[3] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[6] == board.cells[7] &&
                board.cells[7] == board.cells[8] &&
                board.cells[6] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[0] == board.cells[3] &&
                board.cells[3] == board.cells[6] &&
                board.cells[0] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[1] == board.cells[4] &&
                board.cells[4] == board.cells[7] &&
                board.cells[1] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[2] == board.cells[5] &&
                board.cells[5] == board.cells[8] &&
                board.cells[2] != " "
                )
            {
                return true;
            }

            else if (
                board.cells[0] == board.cells[4] &&
                board.cells[4] == board.cells[8] &&
                board.cells[0] != " "
                )
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool Over(Board board)
        {
            return Won(board) || Draw(board);
        }

        public bool Draw(Board board)
        {
            return moves.Full(board.cells);
        }
    }
}
