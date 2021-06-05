using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    class Plansza : Zmienne
    {
        public string[,] plansza = new string[3, 3];
        
        public Plansza()
            {
               for (int i =0; i < 3; i++)
               {
                    for (int j = 0; j < 3; j++)
                    {
                    plansza[i, j] = " ";
                    }
               }
            Zmienne.runda = 0;
            }

        public string getPlansza(int x, int y)
        {
            return plansza[x, y];
        }
        public void setPlansza(int x, int y)
        {
            this.plansza[x, y] = Zmienne.figura;
        }

        public string[,] wypiszPlansze()
        {
            Console.Write(this.plansza[0, 0] + " | " + this.plansza[0, 1] + " | " + this.plansza[0, 2] + "\n" + "--+---+--" + "\n" + this.plansza[1, 0] + " | " + this.plansza[1, 1] + " | " + this.plansza[1, 2] + "\n" + "--+---+--" + "\n" + this.plansza[2, 0] + " | " + this.plansza[2, 1] + " | " + this.plansza[2, 2] + "\n");
            return this.plansza;
        }

        public void resetPlansza()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    plansza[i, j] = " ";
                }
            }
            Zmienne.runda = 0;
        }
    }
}
