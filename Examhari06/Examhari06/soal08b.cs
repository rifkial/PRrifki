﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Examhari06
{
    class soal08b : LogicBase
    {
        public soal08b(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2D = new String[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int deret = (n + 1) / 2;

            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int stBrs = bb * n;
                        int stKol = bk * n;
                        int endBrs = stBrs + n - 1;
                        int endKol = stKol + n - 1;
                        bool kanan = true;
                        //int ganjil = 1;
                        //int genap = 2;

                        for (int b = stBrs; b <= endBrs; b++)
                        {
                            int angka = deret;
                            for (int k = stKol; k <= endKol; k++)
                            {
                                //if (b+k>=stBrs+(stKol+endKol)/2 && (k-stKol)-(b-stBrs)<=n/2 && (b-stBrs)-(k-stKol)<=n/2)
                                //{
                                if (b + k >= stBrs + ((stKol + endKol) / 2) && (k - stKol) - (b - stBrs) <= n / 2 && b <= (stBrs + endBrs) / 2)
                                {
                                    if (k < (stKol + endKol) / 2)
                                    {
                                        Array2D[b, k] = angka.ToString();
                                        Array2D[endBrs - b + stBrs, k] = angka.ToString();
                                        angka--;
                                    }
                                    else
                                    {
                                        Array2D[b, k] = angka.ToString();
                                        Array2D[endBrs - b + stBrs, k] = angka.ToString();
                                        angka++;
                                    }


                                }


                            }
                        }
                        kanan = !kanan;
                    }
                }

            }
        }
    }
}



