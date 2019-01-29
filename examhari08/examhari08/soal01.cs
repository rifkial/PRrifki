using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace examhari08
{
    class soal01 : LogicBase
    {
        public soal01(int n)
        {
            jmlBaris = n * 2;
            jmlKolom = (n * 2 - 1) * n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int[] fibo = FunctionBase.Fibonacci(n * n);
                int[] tribo = FunctionBase.Tribonacci(n * n);
                int angka = 0;
                int stBrs = n * (bgn % 2);
                int stKol = (n * 2 - 1) * bgn;
                int endBrs = stBrs+n- 1;
                int endKol = stKol+(n*2-1)-1;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k >= stKol + endBrs && k + endBrs <= b + endKol && bgn % 2 == 0)
                            Array2D[b, k] = fibo[angka++].ToString();
                        else if ((b - stBrs) <= (k - stKol) && (b - stBrs) + (k - stKol) <= endKol - stKol && bgn % 2 == 1)
                            Array2D[b, k] = tribo[angka++].ToString();
                    }
                }

            }
        }
    }
}
