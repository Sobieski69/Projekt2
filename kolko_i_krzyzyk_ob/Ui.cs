using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Ui : Plansza
    {
        string input;
        int ruch;
        int x;
        int y;
        
        
        public void setRuch()
        {
            input = Console.ReadLine();
            try
            {
                ruch = int.Parse(input);
            }
            catch (Exception)
            {

                Console.WriteLine("Podaj liczbe od 1-9");
            }
        }

        public void wykonajRuch(Gracz gracz)
        {
            string figura = gracz.GetFigura();
            if (ruch % 2 == 0)
            {
                x = (14 % ruch)/2;
                if (x > 2) x = 2;

                y = (101 % (ruch + 1) - 1);
            }
            else
            {
                x = 321 % ruch;
                if (x > 2) x = 2;

                y = 56 % ruch;
                
            }
            setPlansza(x, y, figura);
        }
        public void WyczyscKonsole()
        {
            Console.Clear();
        }
        public int GetRuch()
        {
            
            return ruch;
        }
    }
}

