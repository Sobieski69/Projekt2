using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Plansza 
    {

        //Plansza[,] plansza = new Plansza[3, 3];
        string[,] plansza1 = new string[3, 3]
        {
            {"X","X","X"},
            {"X","X","X"},
            {"X","X","X"}
        };

        public Plansza()
            {

            
            
            }

        public string getPole(int x, int y)
        {
            plansza1[0, 0] = "X";
            return plansza1[x, y];
        }
        public string[,] getPlansza()
        {
            return plansza1;
        }
        public void setPlansza(int x, int y, string figura)
        {
            
            plansza1[x, y] = figura;
        }

        public string[,] wypiszPlansze()
        {
            Console.Write(plansza1[2, 0] + " | " + plansza1[2, 1] + " | " + plansza1[2, 2] + "\n" + "--+---+--" + "\n" + plansza1[1, 0] + " | " + plansza1[1, 1] + " | " + plansza1[1, 2] + "\n" + "--+---+--" + "\n" + plansza1[0, 0] + " | " + plansza1[0, 1] + " | " + plansza1[0, 2] + "\n");
            return plansza1;
        }

        public void resetPlansza()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    plansza1[i, j] = " ";
                }
            }
            
        }
    }
}
