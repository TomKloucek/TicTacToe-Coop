using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Coop
{
    class Hra
    {
        public int[,] _hraciPole;
        private int[][] winningArrays = new int[][] {
      new int[] {0, 1, 2 },
      new int[] {3, 4, 5 },
      new int[] {6, 7, 8 },
      [6, 3, 0],
      [7, 4, 1],
      [8, 5, 2],
      [8, 4, 0],
      [6, 4, 2],
    };

        public Hra(int velikost)
        {
            this._hraciPole = new int[velikost,velikost];
        }

        public void Hraj()
        {
            while(!Konec())
            {

            }
        }

        public bool Obasazeno()
        {
            return false;
        }

        public bool Konec()
        {

        }

    }
}
