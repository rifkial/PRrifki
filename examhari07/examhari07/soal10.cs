using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;


namespace examhari07
{
    class soal10:LogicBase
    {
        public soal10(int n)
        {
            jmlBaris = n * n;
            jmlKolom = jmlBaris;
            Array2D = new string[jmlBaris,jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 1;

            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == 0 || bk == 0 || bb == n - 1 || bk == n - 1)
                    {
                        int stBrs = bb * n;
                        int stKol = bk * n;
                        int endBrs = stBrs + n - 1;
                        int endKol = stKol + n - 1;
                        for (int b = stBrs; b <= endBrs; b++)
                        {
                            for (int k = stKol; k <= endKol; k++)
                            {
                                if (b - stBrs >= k - stKol)
                                    Array2D[b, k] = angka.ToString();
                            }
                        }
                        angka++;
                    }
                }
            }
        }

    }
}

