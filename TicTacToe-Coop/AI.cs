using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Coop
{
    class AI
    {
        public Hra hra { get; set; }

        public AI(Hra hra)
        {
            this.hra = hra;
        }

        public void Hraj()
        {
            int[] volnePole;
            List<int[]> poleVolnychPoli = new List<int[]>();
            Random rnd = new Random();
            /*for (int x = 0; x<hra.velikost; x++)
            {
                for (int y = 0; y < hra.velikost; y++)
                {
                    if (this.hra.Obsazeno(x, y) == false)
                    {
                        volnePole = new int[] {1,2};
                        poleVolnychPoli.Add(volnePole);
                    }
                }
            }
            int index = rnd.Next(poleVolnychPoli.Count);*/
            hra.hraciPole[rnd.Next(hra.velikost), rnd.Next(hra.velikost)] = 'O';
        }
    }
}
