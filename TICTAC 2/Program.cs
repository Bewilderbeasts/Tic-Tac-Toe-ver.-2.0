using System;

namespace TICTAC_2
{
    class Tablica
    {
        static void Main(string[] args)
        {
            string[] plansza = new string[9];
            int rowLength = plansza.GetLength(0);
            //int colLength = plansza.GetLength(1);

            for (int i = 0; i < plansza.Length; i++)
            {
                plansza[i] = "-";
            }
            bool checkWinnerX()
            {
                // check rows
                if (plansza[0] == "X" && plansza[1] == "X" && plansza[2] == "X") { return true; }
                if (plansza[3] == "X" && plansza[4] == "X" && plansza[5] == "X") { return true; }
                if (plansza[6] == "X" && plansza[7] == "X" && plansza[8] == "X") { return true; }

                if (plansza[0] == "X" && plansza[3] == "X" && plansza[6] == "X") { return true; }
                if (plansza[1] == "X" && plansza[4] == "X" && plansza[7] == "X") { return true; }
                if (plansza[2] == "X" && plansza[5] == "X" && plansza[8] == "X") { return true; }
                
                if (plansza[0] == "X" && plansza[4] == "X" && plansza[8] == "X") { return true; }
                if (plansza[2] == "X" && plansza[4] == "X" && plansza[6] == "X") { return true; }



                return false;
            }

            bool checkWinnerO()
            {
                if (plansza[0] == "O" && plansza[1] == "O" && plansza[2] == "O") { return true; }
                if (plansza[3] == "O" && plansza[4] == "O" && plansza[5] == "O") { return true; }
                if (plansza[6] == "O" && plansza[7] == "O" && plansza[8] == "O") { return true; }

                if (plansza[0] == "O" && plansza[3] == "O" && plansza[6] == "O") { return true; }
                if (plansza[1] == "O" && plansza[4] == "O" && plansza[7] == "O") { return true; }
                if (plansza[2] == "O" && plansza[5] == "O" && plansza[8] == "O") { return true; }

                if (plansza[0] == "O" && plansza[4] == "X" && plansza[8] == "O") { return true; }
                if (plansza[2] == "O" && plansza[4] == "O" && plansza[6] == "O") { return true; }


                return false;
            }
            int ruch = 1;
            if (ruch >9)
            {
                Console.WriteLine();
            }
            while (ruch <10)
            {
                for (int i = 0; i < plansza.Length; i++)
                {
                    Console.Write(plansza[i] + " ");
                    if ((i + 1) % 3 == 0)
                        Console.WriteLine();

                }
                Console.WriteLine("");
                Console.WriteLine("Wybierz pozycje (1-9): ");
                string wybor = Console.ReadLine();
                int wybor2 = int.Parse(wybor);
                int wybor3 = --wybor2;

                if (plansza[wybor3] == "-")
                {
                    if (ruch % 2 != 0)
                    {
                        if (wybor3 < 10 && wybor3 > -1)
                        {
                            plansza[wybor3] = "X";
                            ruch = ruch + 1;
                            Console.Clear();                    
                        }
                    }
                    else
                    {
                        if (wybor3 < 10 && wybor3 > -1)
                        {
                            plansza[wybor3] = "O";
                            ruch = ruch + 1;
                            Console.Clear();
                        }
                    }
                }
                else { Console.Clear(); Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); Console.WriteLine("\n"); continue; }

                if (checkWinnerO())
                {
                    Console.Clear();
                    Console.WriteLine("Wygrał pan od O");
                    break;
                }
                else if (checkWinnerX())
                {
                    Console.Clear();
                    Console.WriteLine("Wygrał pan od X");
                    break;
                }
                else
                {
                    Console.WriteLine("Twój ruch!");
                    Console.WriteLine("");
                }
                
                   
            }

        }
    }
}
