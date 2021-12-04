using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION- 1-Create Game Board, 2-Player Input, 3-Display ,4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                TicTacToeGame game = new TicTacToeGame();
                switch (choice)
                {
                    case 1:
                        game.GameBoard();
                        break;
                    case 2:
                        game.ChooseInput();
                        Console.WriteLine("Player Position is:" + game.ChooseInput());
                        break;
                    case 3:
                        game.DisplayBoard();
                        break;
                    case 4:
                        flag = false;
                        break;
                        
                }
            }
        }
    }
}
