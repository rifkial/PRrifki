using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Eval
{
    class soal02 : LogicBase
    {
        public soal02(int n)
        {
            jmlBaris = n * 2 - 1;
            jmlKolom = n * 3;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn < 3; bgn++)
            {
                int stBrs = (bgn % 2) * (n - 1);
                int stKol = n * bgn;
                int endBrs = stBrs + n - 1;
                int endKol = stKol + n - 1;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (bgn % 2 == 0)
                        {
                            if ((b - stBrs) + (k - stKol) >= endBrs - stBrs)
                            {
                                Array2D[b, k] = "*";
                            }
                        }
                        else
                        {
                            if ((b - stBrs) + (k - stKol) <= endBrs - stBrs)
                            {
                                Array2D[b, k] = "*";
                            }
                        }
                    }
                }
            }
        }

    }
}