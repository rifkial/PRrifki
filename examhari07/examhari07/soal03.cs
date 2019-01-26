using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace examhari07
{
    class soal03:LogicBase
    {
        public soal03(int n)
        {
            jmlBaris = n * 2 + 1;
            jmlKolom = (n * 2) + (n * 2 - 1);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray( int n)
        {
            //int angka = 1;
            int tengah = jmlKolom / 2;

            for (int bgn= 0; bgn < n; bgn++)
            {
                int stBrs = bgn * 2;
                int stKol = stBrs;
                for (int b = stBrs; b < jmlBaris; b++)
                {
                    for (int k   = stKol; k <= tengah; k++)
                    {
                        if (b==stBrs || k==stKol)
                        {
                            Array2D[b, k] = "*";
                            Array2D[b, jmlKolom - 1 - k] = "*";
                            Array2D[jmlBaris-1-b, k] = "*";
                        }
                        
                    }
                }
            }
        }
    }
}
