using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Ui{

           public void displayMessage(String message)
            {
                Console.WriteLine(message);
            }


            public void displayWinner(Player winner)
            {
                if (winner.GetName == "Remis")
            {
                Console.WriteLine("Remis");
            } 
            else
            {
                Console.WriteLine("wygrał " + winner.getName);
            }
    }

    public void displayBoard(String board)
            {
                Console.WriteLine(board);
            }

            public String inputyourName()
            {
                return Console.ReadLine();
            }

            public int makeMove()
            {
                return int.Parse(Console.ReadLine());
            }

    }
}


