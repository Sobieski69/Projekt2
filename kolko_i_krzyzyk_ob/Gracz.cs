using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Gracz
    {
        string figura;

        public Gracz(string figura) 
        {
            this.figura =  figura;
        }

        public string GetFigura()
        {
            return figura;
        }
        
        public void SetFigura()
        {
            if (figura == "X") figura = "O";
            else figura = "X";
        }

        
    }
}
