using TicTacToeGame_LLD.Enums;
using TicTacToeGame_LLD.Game;
using TicTacToeGame_LLD.Players;

class Program
{
    static void Main()
    {
        var players = new List<Player>
        {
            new HumanPlayer("Player1", Symbol.X),
            new HumanPlayer("Player2", Symbol.O)
        };

        var game = new TicTacToeGame(3, players);
        game.Start();
    }
}
