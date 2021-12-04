using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE
{
    class TicTacToeGame
    {
        static char[] board = new char[10];
        public void GameBoard()
        { 
            for(int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            } 
        }
        public char ChooseInput()
        {
            Console.WriteLine("Enter the input X Or Y");
            char Input = Convert.ToChar(Console.ReadLine());
            char choose = char.ToUpper(Input);
            if (choose == 'X')
            {
                return Input;
            }
            if (choose == 'O')
            {
                return Input;
            }
            else
                return 'w';
        }
        public void DisplayBoard()
        {
            this.GameBoard();
            Console.WriteLine("   |     |    ");
            Console.WriteLine(" {0}  | {1}    |  {2}  ",board[1],board[2],board[3]);
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine(" {0}  | {1}    |  {2}  ",board[4], board[5], board[6]);
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine(" {0}  |  {1}   |  {2}  ",board[4], board[5], board[6]);
        }
    }
}
