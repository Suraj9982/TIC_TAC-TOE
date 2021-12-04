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
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
        }
    }
}
