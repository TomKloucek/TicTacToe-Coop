using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Coop
{
    class Hra
    {
        AI ai;
        public char[,] hraciPole;
        public int velikost;
        public Hra(int velikost)
        {
            this.hraciPole = this.Napln(velikost);
            this.velikost = velikost;
        }

        public void Hraj()
        {
            bool winHrac = false;
            bool winAI = false;
            this.ai = new AI(this);
          while(winHrac == false && winAI == false)
            {
                winHrac = Hrac();
                winAI = ai.Hraj();
                this.Vypis();
            }
          if (winAI == true)
            {
                Console.WriteLine("Vyhralo AIcko");
            }
            else
            {
                Console.WriteLine("Vyhral jsi");
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

        public bool Hrac()
        {
            bool pouzitelny = false;
            int x = 0;
            int y = 0;
            while(!pouzitelny)
            {
                Console.WriteLine("Zadej souradnice ve tvaru y a x");
                string[] tah = Console.ReadLine().Split();
                Console.WriteLine(tah[1]);
                y = int.Parse(tah[0]);
                x = int.Parse(tah[1]);
                if (!Obsazeno(y, x))
                {
                    pouzitelny = true;
                }
            }
            this.hraciPole[x, y] = 'X';
            return Konec(x, y);
        }
        public bool Konec(int x,int y)
        {         
            return VyhralX(x,y);
        }

        public bool VyhralX(int x,int y)
        {
            int pocet = 1;
            for (int i = 1; i < 3; i++)
            {
                if (!(x - i >= 0 && y + i < this.velikost-1))
                {
                    break;
                }
                if (hraciPole[x - i, y + i] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 3; i++)
            {
                if (!(x + i >= 0 && y - i < this.velikost-1 && y-i >= 0))
                {
                    break;
                }
                if (hraciPole[x + i, y - i] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            if (pocet >= 3)
            {
                return true;
            }
            pocet = 1;
            for (int i = 1; i < 3; i++)
            {
                if (!(x + i >= 0 && y + i < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x + i, y + i] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 3; i++)
            {
                if (!(x - i >= 0 && y - i < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x - i, y - i] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            if (pocet >= 3)
            {
                return true;
            }
            pocet = 1;
            for (int i = 1; i < 3; i++)
            {
                if (!(x + i >= 0 && y < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x+i, y] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 3; i++)
            {
                if (!(x - i >= 0 && y < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x - i, y] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            if (pocet >= 3)
            {
                return true;
            }
            pocet = 1;
            for (int i = 1; i < 3; i++)
            {
                if (!(x >= 0 && y - i < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x, y-1] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 3; i++)
            {
                if (!(x >= 0 && y + i < this.velikost-1 && y - i >= 0))
                {
                    break;
                }
                if (hraciPole[x , y+1] == 'X') { pocet++; }
                else
                {
                    break;
                }
            }
            if(x >= 3)
            {
                return true;
            }
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
