﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace examhari07
{
    class soal01 : LogicBase
    {
        public soal01(int n)
        {
            jmlBaris = ((n * 2) - 1) + (n * 2);
            jmlKolom = jmlBaris;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //int ganjil = 1;
            //int[] fibo = FunctionBase.Fibonacci(jmlKolom * jmlBaris);
            //int[] tribo = FunctionBase.Tribonacci(jmlKolom * jmlBaris);
            //int index1 = 0;
            //int index2 = 0;

            for (int b = 0; b < jmlBaris; b++)
            {
                for (int k = 0; k < jmlKolom; k++)
                {
                    //atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2D[b, k] = "*";

                    }
                    //bawah
                    else if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= jmlBaris - n)
                    {
                        Array2D[b, k] = "*";

                    }
                    //kiri
                    else if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2D[b, k] = "*";
                    }
                    //kanan
                    else if (k - b <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= jmlKolom - n)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}



