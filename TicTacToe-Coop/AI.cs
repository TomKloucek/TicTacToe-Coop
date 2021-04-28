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
            bool obsazeno = true;
            int prvni = 0;
            int druha = 0;
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
            while (obsazeno)
            {
                prvni = rnd.Next(hra.velikost);
                druha = rnd.Next(hra.velikost);
                if (this.hra.Obsazeno(prvni, druha) == false)
                {
                    obsazeno = false;
                }
            }
            hra.hraciPole[prvni, druha] = 'O';
        }
    }
}
