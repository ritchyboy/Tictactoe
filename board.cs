using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal class board
    {
      public string[] OriginalBoard= { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
      public string[] boards = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
      public bool hasWon=false;

        public void printBoard()
        {
            Console.WriteLine("     |     |      |");
            Console.WriteLine("  " + boards[0] + "  |  " + boards[1] + "  |   " + boards[2] + "  | ");
            Console.WriteLine("     |     |      |");
            Console.WriteLine("_____|_____|______|");
            Console.WriteLine("     |     |      |");
            Console.WriteLine("  " + boards[3] + "  |  " + boards[4] + "  |   " + boards[5] + "  | ");
            Console.WriteLine("     |     |      |");
            Console.WriteLine("_____|_____|______|");
            Console.WriteLine("     |     |      |");
            Console.WriteLine("  " + boards[6] + "  |  " + boards[7] + "  |   " + boards[8] + "  | ");
            Console.WriteLine("     |     |      |");
            Console.WriteLine("_____|_____|______|");
        }
        public bool checkWinner()
        {

            //Vertical Verification//
            if (boards[0] == boards[3] && boards[0] == boards[6])
            {
                Console.Clear();
                hasWon= true;
                return true;
            }
            if (boards[1] == boards[4] && boards[1] == boards[7])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            if (boards[2] == boards[5] && boards[2] == boards[8])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            //Horizontal Verification//
            if (boards[0] == boards[1] && boards[0] == boards[2])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            if (boards[3] == boards[4] && boards[3] == boards[5])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            if (boards[6] == boards[7] && boards[6] == boards[8])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            //diagonal Verification//
            if (boards[0] == boards[4] && boards[0] == boards[8])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }
            if (boards[2] == boards[4] && boards[2] == boards[6])
            {
                Console.Clear();
                hasWon = true;
                return true;
            }

            else
                return false;
            
        }
        public void changeBoardValue(int value, string player)
        {

            while(boards[value] == "X" || boards[value] == "O")
            {
                Console.WriteLine("A player has already played there");
                Console.WriteLine("Enter a new value");
                value = int.Parse(Console.ReadLine());
            }
                boards[value] = player;
        }
        public void checkBoardFill()
        {
            bool[]isFill= new bool[9];
            for (int i=0;i<boards.Length;i++)
            {
                if (boards[i] == "X" || boards[i] == "O")
                {
                    isFill[i] = true;
                }
                else
                    isFill[i] = false;                
            }
            for (int i = 0; i < isFill.Length; i++)
            {
                if (Array.Exists(isFill, element => element == false))
                {
                    break;
                }
                else
                    replay("It a draw.Enter Y to replay or N to exit");
              
                
            }
           
        }
        public void updateBoard()
        {
            Console.Clear();
            printBoard();
            checkBoardFill();
   
        }
        public void replay(string message)
        {
            string gameInput = Console.ReadLine();
            while (string.IsNullOrEmpty(gameInput) || gameInput.ToUpper() != "Y" || gameInput.ToUpper() != "N")
            {
                Console.WriteLine(message);
                gameInput = Console.ReadLine();
                if (gameInput.ToUpper() == "Y")
                {
                    Console.Clear();
                    game Game = new game();
                }
                else if (gameInput.ToUpper() == "N")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
