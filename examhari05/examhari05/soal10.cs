using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace examhari05
{
    class soal10 : LogicBase
    {
        public soal10(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = n * 2 - 1;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //value
            //int ganjil = 1;
            //int genap = 2;
            int[] fibo = FunctionBase.Fibonacci(jmlBaris * n);
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = ((n * 2 - 1) / 2) - bgn;

                //ending point
                int endBrs = stBrs + bgn;
                int endKol = stKol + (bgn * 2);
                int angka = 1;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k >= stKol + endBrs && k + endBrs <= b + endKol)
                            //Array2D[b, k] = angka++.ToString();
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, k] = angka.ToString();
                                angka += 2;
                            }
                            else
                            {
                                Array2D[b, k] = fibo[angka-1].ToString();
                                angka++;
                            }
                        //    Array2D[b, k] = bgn % 2 == 0 ? angka++.ToString() : angka--.ToString();
                        //if (bgn % 2 == 0) ganjil += 2; else genap += 2;
                    }
                }
            }
        }
    }
}
