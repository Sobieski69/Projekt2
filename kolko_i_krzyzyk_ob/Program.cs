using System;



namespace kolko_i_krzyzyk
{
    enum TypGracza
    {
        X,
        O,
        puste
    }

    public static class Zmienne
    {
        public static int runda = 0;
        public static string figura;
    }
    class Program
    {

        public static void Main(string[] args)
        {

            int i = 1;
            do
            {
                TypGracza Gracz;

                Zmienne.figura = "O";

                string[,] plansza = new string[3, 3];
                Reset(plansza);

                do
                {
                    Zmienne.figura = ZmienFigure();
                    if (Zmienne.figura == "O")
                    {
                        Gracz = TypGracza.O;
                    }
                    else
                    {
                        Gracz = TypGracza.X;
                    }
                    Console.WriteLine("Ruch gracza: " + Gracz);
                    WykonajRuch(plansza, Gracz);

                    Console.Clear();
                    Zmienne.runda++;
                    if (Zmienne.runda == 9 && CzyGraczWygrał(plansza, Gracz) == false)
                    {
                        Console.WriteLine("Mecz nierozstrzygnięty");
                        break;
                    }
                    Console.WriteLine("runda: " + Zmienne.runda);


                } while (!CzyGraczWygrał(plansza, Gracz));
                Console.WriteLine("chesz zagrac jeszcze raz? (ENTER) / Zakończ program(ESC)");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            } while (i == 1);


        }

        public static string[,] PoleGry(string[,] plansza)
        {



            Console.Write(plansza[0, 0] + " | " + plansza[0, 1] + " | " + plansza[0, 2] + "\n" + "--+---+--" + "\n" + plansza[1, 0] + " | " + plansza[1, 1] + " | " + plansza[1, 2] + "\n" + "--+---+--" + "\n" + plansza[2, 0] + " | " + plansza[2, 1] + " | " + plansza[2, 2] + "\n");
            return plansza;

        }







        public static void Reset(string[,] plansza)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    plansza[i, j] = " ";

                }
            }
            Zmienne.runda = 0;
            Console.Clear();

        }
        public static bool CzyGraczWygrał(string[,] plansza, TypGracza Gracz)
        {
            Wynik WynikX = new Wynik(0);
            Wynik WynikO = new Wynik(0);
            int punkt = 1;
            for (int zestaw = 0; zestaw <= 21; zestaw += 3)
            {
                if (CzyZestawNaPlanszy(zestaw, plansza))
                {
                    Console.Beep();

                    Console.WriteLine("wygral " + Gracz);



                    return true;
                }


            }
            ZmienFigure();
            return false;
        }
        public static bool CzyZestawNaPlanszy(int indexZestawu, string[,] plansza)
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

            int ileZgodnych = 0;

            for (int pozycja = 0; pozycja <= 2; pozycja++)
            {
                int x = zestawWygrywajacy[indexZestawu + pozycja, 0];
                int y = zestawWygrywajacy[indexZestawu + pozycja, 1];
                if (plansza[x, y] == Zmienne.figura)
                {
                    ileZgodnych++;
                    if (ileZgodnych == 3)
                    {
                        return true;
                    }

                }
                else
                {
                    return false;
                }
            }
            return false;


        }
        public static string ZmienFigure()
        {

            if (Zmienne.figura == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public static void WykonajRuch(string[,] plansza, TypGracza Gracz)
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Gdzie chcesz się ruszyć? \n\n Wpisz help jeśli potrzebujesz pomocy\n\n");
                PoleGry(plansza);
                string ruch = Console.ReadLine();



                if (int.TryParse(ruch, out _))
                {
                    valid = true;
                    int ruch1 = int.Parse(ruch);
                    if (ruch1 <= 9 && ruch1 >= 1)
                    {
                        switch (ruch1)
                        {
                            case 1:
                                if (plansza[2, 0] == " ")
                                {
                                    plansza[2, 0] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 2:
                                if (plansza[2, 1] == " ")
                                {
                                    plansza[2, 1] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 3:
                                if (plansza[2, 2] == " ")
                                {
                                    plansza[2, 2] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajete");

                                    valid = false;

                                    break;
                                }

                            case 4:
                                if (plansza[1, 0] == " ")
                                {
                                    plansza[1, 0] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 5:
                                if (plansza[1, 1] == " ")
                                {
                                    plansza[1, 1] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 6:
                                if (plansza[1, 2] == " ")
                                {
                                    plansza[1, 2] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 7:
                                if (plansza[0, 0] == " ")
                                {
                                    plansza[0, 0] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 8:
                                if (plansza[0, 1] == " ")
                                {
                                    plansza[0, 1] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            case 9:
                                if (plansza[0, 2] == " ")
                                {
                                    plansza[0, 2] = Zmienne.figura;
                                    PoleGry(plansza);
                                    CzyGraczWygrał(plansza, Gracz);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pole jest zajęte");

                                    valid = false;

                                    break;
                                }

                            default:
                                Console.WriteLine("Podałeś zły typ zmiennej");
                                break;

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Podano niewłaściwy typ danych. Wpisz wartość od 1-9. ");
                        Console.WriteLine("Ruch gracza: " + Gracz);
                        valid = false;
                    }

                }
                else if (ruch == "help" || ruch == "reset" || ruch == "autorzy")
                {
                    switch (ruch)
                    {
                        case "help":
                            Console.Clear();
                            Console.WriteLine(" -Klawisze na klawiaturze numerycznej odpowiadaja polom na planszy \n -Wpisz reset aby zresetowac \n -Jeśli chcesz się dowiedzieć kto wykonał aplikacje wpisz autorzy\n\n");

                            Console.WriteLine("Ruch gracza: " + Gracz);
                            valid = false;
                            break;

                        case "reset":
                            Reset(plansza);
                            valid = false;
                            Zmienne.figura = "X";
                            Console.WriteLine("Ruch gracza: " + Zmienne.figura);

                            break;

                        case "autorzy":
                            Console.Clear();
                            Console.WriteLine(" Jakub Sobczyński \n Wojciech Jezierski \n Klasa 2b \n\n");

                            Console.WriteLine("Ruch gracza: " + Gracz);
                            valid = false;
                            break;

                        default:
                            Console.WriteLine(" ");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Podano niewłaściwy typ danych. Wpisz wartość od 1-9. ");
                    Console.WriteLine("Ruch gracza: " + Gracz);
                    valid = false;
                }

            } while (!valid);

        }
    }
    public class Wynik
    {
        int iloscPunktow = 0;

        public Wynik(int iloscPunktow)
        {
            this.iloscPunktow = iloscPunktow;
        }

        public void setWynik()
        {
            iloscPunktow++;
        }

    }

}

