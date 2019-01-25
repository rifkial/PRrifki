using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;


namespace Examhari06
{
    class soalPR2:LogicBase
    {
        public soalPR2(int n)
        {
            jmlBaris = 3 + (n - 1);
            jmlKolom = (n * 3 + (n * n - 1) / 2);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);       
        }

        private void IsiArray(int n)
        {
            int deret = 1;
            int angka = 1;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = n - bgn - 1;
                int stKol = (bgn * 3) + (bgn * (bgn - 1) / 2);
                int endBrs = n + 1;
                int endKol = stKol + 2 + bgn;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b - k == stBrs - stKol || k == endKol || b == endBrs)
                        {
                            Array2D[b, jmlKolom - 1 - k] = angka.ToString();
                        }
                        angka++;
                    }
                }
                deret = angka;
            }
        }
    }
}
