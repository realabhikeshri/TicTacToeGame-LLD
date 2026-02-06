using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Board
{
    public class Cell
    {
        public int Row { get; }
        public int Col { get; }
        public Symbol Symbol { get; private set; }

        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
            Symbol = Symbol.Empty;
        }

        public void SetSymbol(Symbol symbol)
        {
            if (Symbol != Symbol.Empty)
                throw new InvalidOperationException("Cell already occupied");

            Symbol = symbol;
        }
    }
}
