using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame_LLD.Enums;
using TicTacToeGame_LLD.Players;

namespace TicTacToeGame_LLD.Game
{
    public class GameResult
    {
        public GameState State { get; private set; }
        public Player Winner { get; private set; }

        private GameResult(GameState state, Player winner = null)
        {
            State = state;
            Winner = winner;
        }

        public static GameResult InProgress()
        {
            return new GameResult(GameState.InProgress);
        }

        public static GameResult Draw()
        {
            return new GameResult(GameState.Draw);
        }

        public static GameResult Win(Player winner)
        {
            return new GameResult(GameState.Finished, winner);
        }
    }
}
