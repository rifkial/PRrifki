using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace examhari07
{
    class pr03:LogicBase
    {
        public pr03(int n)
        {
            jmlBaris = n * 2 + 1;
            jmlKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {

                int stBrs = bgn * 2;

                int endBrs = jmlBaris - 1 - bgn * 2;
                int eKolom =  - 1 - sKolom;
                int angka = 1;
                int nAngka = (eBaris) * 2 + (eKolom - sKolom) + 1;
                for (int b = 0; b <= eBaris; b++)
                {
                    for (int k = sKolom; k <= eKolom; k++)
                    {
                        if (b == eBaris || k == sKolom)
                            Array2d[b, k] = "" + angka++;
                        else if (k == eKolom)
                        {
                            Array2d[b, k] = "" + nAngka--;
                        }
                    }
                }
            }
        }


    }
    }
}
