using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Strategies
{
    public class DiagonalWinningStrategy : IWinningStrategy
    {
        public bool CheckWinner(TicTacToeGame_LLD.Board.Board board, Symbol symbol)
        {
            bool left = true, right = true;

            for (int i = 0; i < board.Size; i++)
            {
                left &= board.GetSymbol(i, i) == symbol;
                right &= board.GetSymbol(i, board.Size - i - 1) == symbol;
            }

            return left || right;
        }
    }
}
