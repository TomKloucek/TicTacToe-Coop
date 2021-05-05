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
            Doplnovacka(ref obsazeno, ref prvni, ref druha);
            hra.hraciPole[prvni, druha] = 'O';
            return hra.Konec(prvni, druha, 'O');
        }

        private void Doplnovacka(ref bool obsazeno, ref int prvni, ref int druha)
        {
            Random rnd = new Random();
            while (obsazeno)
            {
                if (this.hra.posledniX == 0 && this.hra.posledniY == 0)
                {
                    prvni = 0;
                    druha = 1;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 1 && this.hra.posledniY == 0)
                {
                    prvni = 1;
                    druha = 1;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 2 && this.hra.posledniY == 0)
                {
                    prvni = 2;
                    druha = 1;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 0 && this.hra.posledniY == 1)
                {
                    prvni = 0;
                    druha = 2;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 1 && this.hra.posledniY == 1)
                {
                    prvni = 1;
                    druha = 2;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 2 && this.hra.posledniY == 1)
                {
                    prvni = 2;
                    druha = 2;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 0 && this.hra.posledniY == 2)
                {
                    prvni = 0;
                    druha = 0;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 1 && this.hra.posledniY == 2)
                {
                    prvni = 1;
                    druha = 0;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else if (this.hra.posledniX == 2 && this.hra.posledniY == 2)
                {
                    prvni = 2;
                    druha = 0;
                    if (this.hra.Obsazeno(prvni, druha) == false)
                    {
                        obsazeno = false;
                    }
                    else
                    {
                        prvni = rnd.Next(hra.velikost);
                        druha = rnd.Next(hra.velikost);
                        if (this.hra.Obsazeno(prvni, druha) == false)
                        {
                            obsazeno = false;
                        }
                        else
                        {
                            prvni = rnd.Next(hra.velikost);
                            druha = rnd.Next(hra.velikost);
                            if (this.hra.Obsazeno(prvni, druha) == false)
                            {
                                obsazeno = false;
                            }
                        }
                    }
                }
                else
                {
                    prvni = rnd.Next(hra.velikost);
                    druha = rnd.Next(hra.velikost);
                    obsazeno = false;
                }
            }
        }
    }
}