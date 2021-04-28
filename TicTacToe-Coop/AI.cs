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

        public bool Hraj()
        {
            bool obsazeno = true;
            int prvniDohrana = 0;
            int druhaDohrana = 0;
            int prvni = 0;
            int druha = 0;
            Random rnd = new Random();
            while (obsazeno)
            {
                prvni = rnd.Next(hra.velikost);
                druha = rnd.Next(hra.velikost);
                if (this.hra.Obsazeno(prvni, druha) == false)
                {
                    obsazeno = false;
                }
            }
            

            /*while (obsazeno)
            {
                prvniDohrana = hra.posledni[0];
                druhaDohrana = hra.posledni[1];
                druha = rnd.Next(hra.velikost);
                if (this.hra.Obsazeno(prvni, druha) == false)
                {
                    obsazeno = false;
                }
            }*/


            hra.hraciPole[prvni, druha] = 'O';
            return hra.Konec(prvni, druha,'O');
        }
    }
}
