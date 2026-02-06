using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Strategies
{
    public class ColumnWinningStrategy : IWinningStrategy
    {
        public bool CheckWinner(TicTacToeGame_LLD.Board.Board board, Symbol symbol)
        {
            for (int j = 0; j < board.Size; j++)
            {
                bool win = true;
                for (int i = 0; i < board.Size; i++)
                    win &= board.GetSymbol(i, j) == symbol;

                if (win) return true;
            }
            return false;
        }
    }
}
