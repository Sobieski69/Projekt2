using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Board
    {

        private string[,] board = new string[3, 3]{
            {" "," "," "},
            {" "," "," "},
            {" "," "," "}
        };

private string buildRow(string position1, string position2, string position3)
        {
            return position1 + " | " + position2 + " | " + position3;
        }

        private String buildSeparator()
        {
            return "-------";
        }

        public String buildBoardToPrint()
        {
            string boardTxt =
             buildRow(board[0, 0], board[0, 1], board[0, 2])
            + "\n"
            + buildSeparator()
            + "\n"
            +  buildRow(board[1, 0], board[1, 1], board[1, 2])
            + "\n"
            + buildSeparator()
            + buildRow(board[2, 0], board[2, 1], board[2, 2]);


            return boardTxt;
        }

        


        private int calculateRowIndex(int position)
        {
            int index;
            if(position%2 == 0)
            {
                index = (101 % (position + 1) - 1);
            }
            else
            {
                index = 56 % position;
            }
            return index;
        }

        private int calculateColumnIndex(int position)
        {
            return (position + 2) % 3;
        }

        public void updateBoard(int position, Player player)
        {
            board[calculateRowIndex(position), calculateColumnIndex(position)] = player.GetFigure();
        }

        public bool isAllowed(int position)
        {
            return board[calculateRowIndex(position), calculateColumnIndex(position)]== " ";
        }
        public string GetIndexValue(int x, int y)
        {
            return board[x, y];
        }

    }
}