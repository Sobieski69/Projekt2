using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk_ob
{
    public class Game
    {
        Player player1;
        Player player2;
        Player draw;
        Ui ui;

        Player winner;
        int roundNumber = 0;

        Player activePlayer;
        Board board = new Board();
        int move;

        public Game(Player player1, Player player2, Player draw, Ui ui)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.draw = draw;
            this.ui = ui;
        }

        public Player start(Player player1, Player player2, Ui ui)
        {

            do
            {
                roundNumber++;

                ui.displayBoard(board.buildBoardToPrint());
                activePlayer = changeActivePlayer();
                ui.displayMessage("ruch wykonuje gracz " + activePlayer.GetName());
                do
                {
                    move = ui.makeMove();
                } while (!board.isAllowed(move));
                board.updateBoard(move, activePlayer);


                if (isWinningState())
                {
                    winner = activePlayer;
                }
                else if (roundNumber == 9 || winner == null)
                {
                    winner = draw;//remis
                }

            } while (winner != null);


            return winner;
        }

        private  Player changeActivePlayer()
        {
            if (activePlayer == player2 || activePlayer == null) 
            {
                activePlayer = player1;
            }
            else
            {
                activePlayer = player2;
            }
            return activePlayer;
        }

        private bool isWinningState()
        {
            {
                for (int set = 0; set <= 21; set += 3)
                {
                    if (isWinner(player1, set))
                    {
                        return true;
                    }
                }
                return false;
            }
        }


        private bool isWinner(Player player, int setIndex)
        {
            int[,] zestawWygrywajacy = new int[24, 2]
            {
                {0,0},
                {0,1},
                {0,2},

                {1,0},
                {1,1},
                {1,2},

                {2,0},
                {2,1},
                {2,2},

                {0,0},
                {1,0},
                {2,0},

                {0,0},
                {1,1},
                {2,2},

                {0,1},
                {1,1},
                {2,1},

                {0,2},
                {1,2},
                {2,2},

                {0,2},
                {1,1},
                {2,0}
            };
            for (int row = setIndex; row < 3; row++)
            {
                if (!(board.GetIndexValue(zestawWygrywajacy[row, 0], zestawWygrywajacy[row, 1]) ==player.GetFigure()))
                {
                    return false;
                    }
            }
            return true;
            }

    } }