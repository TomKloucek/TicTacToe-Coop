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

        public int[,] Hraj()
        {
            int[,] volnePole;
            List<int[,]> poleVolnychPoli = new List<int[,]>();
            Random rnd = new Random();
            for (int x = 0; x<3; x++)
            {
                for (int y = 0; y > -3; y--)
                {
                    if (this.hra.Obsazeno(x, y) == false)
                    {
                        volnePole = new int[x, y];
                        poleVolnychPoli.Add(volnePole);
                    }
                }
            }
            int index = rnd.Next(poleVolnychPoli.Count);
            return poleVolnychPoli[index];
        }
    }
}
