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
            int prvni = 0;
            int druha = 0;
            Random rnd = new Random();
            while (obsazeno)
            {
               /* if (this.hra.Obsazeno(0, 0) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 0;
                    druha = 1;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(1, 0) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 1;
                    druha = 1;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(2, 0) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 2;
                    druha = 1;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(0, 1) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 0;
                    druha = 2;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(1, 1) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 1;
                    druha = 2;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(2, 1) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 2;
                    druha = 2;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(0, 2) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 0;
                    druha = 0;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(1, 2) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 1;
                    druha = 0;
                    obsazeno = false;
                }
                else if (this.hra.Obsazeno(2, 2) == false || this.hra.Obsazeno(prvni, druha) == false)
                {
                    prvni = 2;
                    druha = 0;
                    obsazeno = false;
                }*/

                /*for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++) 
                    {
                        prvni = i;
                        druha = j;
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                            break;
                        }
                    }
                    if (obsazeno == false)
                    {
                        break;
                    }
                }*/

                /*prvni = rnd.Next(hra.velikost);
                druha = rnd.Next(hra.velikost);
                if (this.hra.Obsazeno(prvni, druha) == false)
                {
                    obsazeno = false;
                }*/

            }
            hra.hraciPole[prvni, druha] = 'O';
            return hra.Konec(prvni, druha,'O');
        }
    }
}
