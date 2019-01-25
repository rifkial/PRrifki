using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;


namespace review45
{
    class rifki:LogicBase
    {
        

        public rifki(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = n*n;
            Array2D = new string  [jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n*n*2);
            int[] tribo = FunctionBase.Tribonacci(n*n*2);
            int fb = 0;
            int tb = 0;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = jmlBaris-1-(bgn*bgn+bgn)/2-bgn ;
                int stKol = jmlKolom-1-(bgn*bgn)-bgn*2;
                int endBrs = stBrs + bgn;
                int endKol = stKol+bgn*2;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b - stBrs <= k- stKol && (b-stBrs)+(k-stKol)<=endKol-stKol)
                        {
                            Array2D[b, k] = bgn % 2 == 0 ? tribo[tb++].ToString() : fibo[fb++].ToString();
                        }

                    }

                }

            }
        }
    }
}
