using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;


namespace examhari08
{
    class soal03:LogicBase
    {
        public soal03(int n1,int n2)
        {
            jmlBaris = n1 * 2;
            jmlKolom = n2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n1,n2);
            FunctionBase.CetakArray(Array2D);

        }

        private void IsiArray(int n1,int n2)
        {

            for (int bgn = 0; bgn < n2; bgn++)
            {
                int stBrs = bgn;
                int endBrs = stBrs + n1-1;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = bgn; k <= bgn; k++)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
