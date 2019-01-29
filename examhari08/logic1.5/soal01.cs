using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic1._5
{
    class soal01 : LogicBase
    {
        public soal01(int n)
        {
            jmlBaris = 2;
            jmlKolom = n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n);

            for (int k = 0; k < jmlKolom; k++)
            {
                Array2D[0, k] = fibo[k].ToString();
                Array2D[1, k] = GetValue(k+1,fibo[k]);

            }
        }

        private string GetValue(int kol, int val)
        {
            //string result = string.Empty;
            if (kol % 4 == 0)
            {
                return  "44";
            }
            else if (val.ToString().Contains("3"))
            {
                return  "999";
            }
            else
                return  "0";
            //return result;
        }
    }
}
