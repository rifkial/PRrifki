using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Examhari06
{
    class soal05 : LogicBase
    {
        public soal05(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2D = new String[jmlBaris, jmlKolom];
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
                    if (bb + bk==n-1)
                    {
                        int stBrs = bb * n;
                        int stKol = bk * n;
                        int endBrs = stBrs + n - 1;
                        int endKol = stKol + n - 1;
                        bool kanan = true;

                        for (int b = stBrs; b <= endBrs; b++)
                        {
                            for (int k = stKol; k <= endKol; k++)
                            {

                                if (kanan)
                                {
                                    Array2D[b, kanan ? k : endKol - k + stKol] = angka.ToString();
                                    angka += 2;
                                }
                                else
                                {
                                    Array2D[b, kanan ? k : endKol - k + stKol] = angka.ToString();
                                    angka += 2;
                                }
                            }
                            kanan = !kanan;
                        }
                    }

                }
            }
        }
    }
}
