using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Player
    {

        String name;
        String figure;
        int numberOfWins = 0;

        public Player(String name, String figure)
        {
            this.figure = figure;
            this.name = name;
        }

        public void increaseWinningScore()
        {
            numberOfWins++;
        }

        public int getNumberOfWins()
        {
            return numberOfWins;
        }

        public string GetFigure()
        {
            return figure;
        }

        public string GetName()
        {
            return name;
        }
    }
}
