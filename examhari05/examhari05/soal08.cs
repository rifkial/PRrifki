using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace examhari05
{
    class soal08:LogicBase
    {
        public soal08(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = (n * n + n) / 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //value
            int ganjil = 1;
            int genap = 2;

            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = stBrs;

                //ending point
                int endBrs = stBrs + bgn;
                int endKol = endBrs;

                bool kanan = true;
                for (int b = stBrs; b <= endBrs; b++)
                {

                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (kanan)
                        {
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, k] = ganjil.ToString();

                            }
                            else Array2D[b, k] = genap.ToString();
                        }
                        else
                        {
                            if (bgn%2==0)
                            {
                                Array2D[b, endKol - k + stKol] = ganjil.ToString();
                            }
                            else
                            {
                                Array2D[b, endKol - k + stKol] = genap.ToString();
                            }
                        }
                        if (bgn % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;


                        //Array2D[b, kanan ? k: endKol -k +stKol] = bgn % 2 == 0 ? ganjil.ToString() : genap.ToString();
                        //if (bgn % 2 == 0) ganjil += 2; else genap += 2;
                    }
                    kanan = !kanan;
                }
            }
        }

    }
}
