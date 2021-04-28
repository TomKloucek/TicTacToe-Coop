using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Coop
{
    class Hra
    {
        AI ai;
        public char[,] hraciPole;
        public Hra(int velikost)
        {
            this.hraciPole = this.Napln(velikost);
        }

        public void Hraj()
        {
            this.ai = new AI(this);
          while(!Konec())
            {
                Hrac();
                ai.Hraj();
            }
        }

        public bool Obsazeno(int y, int x)
    {
        if (hraciPole[x,y] == '-')
            {
                return false;
            }
        else
            {
                return true;
            }
    }

        public void Hrac()
        {
            bool pouzitelny = false;
            int x = 0;
            int y = 0;
            while(!pouzitelny)
            {
                Console.WriteLine("Zadej souradnice ve tvaru y a x");
                string[] tah = Console.ReadLine().Split();
                y = int.Parse(tah[0]);
                x = int.Parse(tah[1]);
                if (!Obsazeno(y, x))
                {
                    pouzitelny = true;
                }
            }
            this.hraciPole[x, y] = 'X';
        }
        public bool Konec()
        {
            return false;
        }

        public void Vypis()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(this.hraciPole[i, j]);
                }
                Console.WriteLine();
            }
        }

        public char[,] Napln(int velikost)
        {
            char[,] pole = new char[velikost, velikost];
            for (int y = 0; y < velikost; y++)
            {
                for (int x = 0; x < velikost; x++)
                {
                    pole[y, x] = '-';
                }
            }
            return pole;
        }

    }
}
