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
            string player1, player2;
            int player = 1;
            Console.WriteLine("Enter the player1 name");
            player1 = Console.ReadLine();
            Console.WriteLine("Enter the player2 name");
            player2 = Console.ReadLine();
            if (player % 2 == 0)
            {
                Console.WriteLine("palyer 1 is chance");
                player1 = "X";
            }
            else
            {
                Console.WriteLine("palyer 2 is chance");
                player2 = "O";
            }
        }
    }
}
