using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Board
{
    public class Board
    {
        public int Size { get; }
        private readonly Cell[,] _grid;

        public Board(int size)
        {
            Size = size;
            _grid = new Cell[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    _grid[i, j] = new Cell(i, j);
        }

        public bool IsCellEmpty(int row, int col) =>
            _grid[row, col].Symbol == Symbol.Empty;

        public void MakeMove(int row, int col, Symbol symbol) =>
            _grid[row, col].SetSymbol(symbol);

        public Symbol GetSymbol(int row, int col) =>
            _grid[row, col].Symbol;

        public bool IsFull()
        {
            foreach (var cell in _grid)
                if (cell.Symbol == Symbol.Empty)
                    return false;
            return true;
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    Console.Write(_grid[i, j].Symbol + " ");
                Console.WriteLine();
            }
        }
    }
}
