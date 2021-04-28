using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Coop
{
    class Hra
    {
        
        public char[,] hraciPole;
        public Hra(int velikost)
        {
            this.hraciPole = this.Napln(velikost);
        }

        public void Hraj()
        {
          while(!Konec())
            {
                
            }
        }

        public bool Obasazeno(int y, int x)
    {
        if (hraciPole[y,x] == '-')
            {
                return false;
            }
        else
            {
                return true;
            }
    }

        public Object[] Hrac()
        {
            Console.WriteLine("Zadej souradnice ve tvaru y a x");
            string[] tah = Console.ReadLine().Split();
            int y = int.Parse(tah[0]);
            int x = int.Parse(tah[1]);

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
