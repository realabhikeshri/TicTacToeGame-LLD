using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;

namespace TicTacToeGame_LLD.Players
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, Symbol symbol)
            : base(name, symbol) { }

        public override (int row, int col) GetMove()
        {
            Console.Write("Enter row and column: ");
            var input = Console.ReadLine().Split();
            return (int.Parse(input[0]), int.Parse(input[1]));
        }
    }
}
