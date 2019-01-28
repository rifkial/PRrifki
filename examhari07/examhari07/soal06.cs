using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace examhari07
{
    class soal06 : LogicBase
    {
        public soal06(int n)
        {
            jmlBaris = n;
            jmlKolom = (n * n) + (n - 1);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //int angka = 1;
            int nAngka = (n - 1) * 4;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stKol = (n + 1) * bgn;
                int endKol = stKol + n - 1;


                for (int b = 0; b < n; b++)
                {
                    for (int k = 0; k <= jmlKolom; k++)
                    {
                        if (b == 0 || b == jmlBaris - 1 || k == stKol || k == endKol)
                        {
                            Array2D[b, k] = "*";
                        }
                    }

                }

            }


        }
    }
}
