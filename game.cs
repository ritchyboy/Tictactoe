using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Tictactoe
{
    internal class game
    { 
        board tab=new board();
        string player1 = "X";
        string player2 = "O";
        int inputNumber;
       
        
        
        public game()
        {
            bool winner=tab.checkWinner();
            tab.printBoard();
            while (true)
            {
                Console.WriteLine("player 1: Choose the index");
                try
                {
                    inputNumber = int.Parse(Console.ReadLine());
                    tab.changeBoardValue(inputNumber, player1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                if(tab.checkWinner())
                {
                    Console.Clear();
                    tab.printBoard();
                    Console.WriteLine("Player 1 has won");
                    tab.replay("Do you want to replay.Enter Y to replay or N to exit");
                }
                tab.updateBoard();
                Console.WriteLine("player 2: Choose the index");
                try
                {
                    inputNumber = int.Parse(Console.ReadLine());
                    tab.changeBoardValue(inputNumber, player2);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                if(tab.checkWinner())
                {
                    Console.Clear();
                    tab.printBoard();
                    Console.WriteLine("Player 2 has won");
                    tab.replay("Do you want to replay.Enter Y to replay or N to exit");
                }
                tab.updateBoard();
            }
        }
    }
}
