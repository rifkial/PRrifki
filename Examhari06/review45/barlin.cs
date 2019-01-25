using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace review45
{
    class barlin:LogicBase
    {
        public barlin(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = (n * n + n) / 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 1;
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = jmlKolom - 1 - stBrs-bgn;

                //ending point
                int endBrs = stBrs + bgn;
                int endKol = stKol +bgn;
                
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b-stBrs <= k-stKol)
                        Array2D[b, k] = angka++.ToString();
                        else Array2D[b,k]="";
                    }
                }
            }
        }
    }
}
