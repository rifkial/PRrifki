﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Eval
{
    class soal01 : LogicBase
    {
        public soal01(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;

            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn <= 4; bgn++)
            {
                

                    for (int bb = 0; bb < n; bb++)
                    {
                        for (int bk = 0; bk < n; bk++)
                        {


                            int stBrs = bb * n;
                            int endBrs = stBrs + n - 1;
                            int stKol = bk * n;
                            int endKol = stKol + n - 1;

                            for (int b = stBrs; b <= endBrs; b++)
                            {
                                for (int k = stKol; k<= endKol; k++)
                                {
                                if (bgn % 2 != 0)
                                {
                                    if ((b - stBrs) + (k - stKol) >= n / 2 && (k - stKol) - (b - stBrs) <= n / 2 && b - stBrs <= n / 2)
                                    {
                                        Array2D[b, k] = "*";
                                        Array2D[endBrs - b + stBrs, k] = "*";
                                    }
                                }
                            }
                        }
                    }

                }
                               
            }
        }
    }
}




