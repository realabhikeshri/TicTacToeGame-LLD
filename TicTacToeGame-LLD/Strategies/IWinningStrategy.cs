using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Strategies
{
    public interface IWinningStrategy
    {
        bool CheckWinner(TicTacToeGame_LLD.Board.Board board, Symbol symbol);
    }
}
