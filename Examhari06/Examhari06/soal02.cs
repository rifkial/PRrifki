using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Examhari06
{
    class soal02 : LogicBase
    {
        public soal02(int n)
        {
            jmlBaris = n * n;
            jmlKolom = (n * 2 - 1) * 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n * 2);
            int fb = 0;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = n * bgn;
                int stKol = bgn % 2 * (n * 2 - 1);
                int endBrs = stBrs + (n - 1);
                int endKol = stKol + 2 * (n - 1);

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k >= stKol + endBrs && k + endBrs <= b + endKol)
                        { Array2D[b, k] = fibo[fb++].ToString(); }
                    }

                }
            }
        }
    }
}
