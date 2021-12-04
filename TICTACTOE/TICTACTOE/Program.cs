using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TIC-TAC-TOE game");
            TicTacToeGame game = new TicTacToeGame();
            game.GameBoard();
            game.ChooseInput();
        }
    }
}
