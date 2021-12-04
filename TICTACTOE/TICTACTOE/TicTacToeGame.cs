using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE
{
    class TicTacToeGame
    {
        public void GameBoard()
        {
            char[] board = new char[10];
            for(int i = 1; i <= board.Length; i++)
            {
                Console.WriteLine("Enter the spaces of board");
                board[i] = ' ';
            }
        }
    }
}
