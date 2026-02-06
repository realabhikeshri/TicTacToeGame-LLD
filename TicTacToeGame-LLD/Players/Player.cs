using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Players
{
    public abstract class Player
    {
        public string Name { get; }
        public Symbol Symbol { get; }

        protected Player(string name, Symbol symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public abstract (int row, int col) GetMove();
    }
}
