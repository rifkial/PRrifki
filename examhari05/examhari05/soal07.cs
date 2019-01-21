using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace examhari05
{
    class soal07:LogicBase
    {
        public soal07(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = (n * n + n) / 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = jmlKolom - 1 - stBrs;

                //ending point
                int endBrs = stBrs + bgn;
                int endKol = jmlKolom - 1 - endBrs;
                int angka = 1;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k >= endKol; k--)
                    {
                        Array2D[b, k] = angka++.ToString();
                    }
                }
            }
        }
    }
    }

