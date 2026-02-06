using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;
using TicTacToeGame_LLD.Players;
using TicTacToeGame_LLD.Strategies;

namespace TicTacToeGame_LLD.Game
{
    public class TicTacToeGame
    {
        private readonly TicTacToeGame_LLD.Board.Board _board;
        private readonly List<Player> _players;
        private readonly List<IWinningStrategy> _strategies;
        private int _currentPlayerIndex;

        public TicTacToeGame(int size, List<Player> players)
        {
            _board = new TicTacToeGame_LLD.Board.Board(size);
            _players = players;
            _currentPlayerIndex = 0;

            _strategies = new()
            {
                new RowWinningStrategy(),
                new ColumnWinningStrategy(),
                new DiagonalWinningStrategy()
            };
        }

        public void Start()
        {
            while (true)
            {
                _board.Print();
                var player = _players[_currentPlayerIndex];

                var (row, col) = player.GetMove();
                if (!_board.IsCellEmpty(row, col))
                {
                    Console.WriteLine("Invalid move");
                    continue;
                }

                _board.MakeMove(row, col, player.Symbol);

                if (CheckWinner(player.Symbol))
                {
                    _board.Print();
                    Console.WriteLine($"{player.Name} wins!");
                    break;
                }

                if (_board.IsFull())
                {
                    _board.Print();
                    Console.WriteLine("Game Draw!");
                    break;
                }

                _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
            }
        }

        private bool CheckWinner(Symbol symbol)
        {
            return _strategies.Any(s => s.CheckWinner(_board, symbol));
        }
    }
}
