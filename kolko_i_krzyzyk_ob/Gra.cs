using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Gra
    {
        int runda;
        
        Gracz gracz;
        Plansza plansza;
        Ui ui;

       
        public Gra()
        {
            runda = 0;
            plansza = new Plansza();
            gracz = new Gracz("X");
            ui = new Ui();
            
        }

        public int GetRunda()
        {
            return runda;
        }
        
        public void Reset()
        {
            plansza.resetPlansza();
            runda = 0;
        }

        

        public void Graj()
        {
            do
            {



                Console.WriteLine("a");
                


            } while ( true);
        }

        
    }
}
