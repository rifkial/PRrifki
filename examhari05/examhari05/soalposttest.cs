using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace examhari05
{
    class soalposttest:LogicBase
    {
        public soalposttest(int n)
        {
            jmlBaris = n;
            jmlKolom = n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(8* 8);
            int angka = 0;
            bool triger = true;
            for (int b = 0; b < jmlBaris; b++)
            {
                for (int k = 0; k < jmlKolom; k++)
                {
                    if (triger)
                    {
                        if (b % 2 == 0)
                        {
                            Array2D[b, k] = fibo[angka++].ToString();

                        }
                        else if (k == jmlKolom - 1)
                        {
                            Array2D[b, k] = fibo[angka++].ToString();
                            triger = !triger;
                        }
                    }
                    else
                    {
                        if (b % 2 == 0)
                        {
                            Array2D[b, jmlKolom - 1 - k] = fibo[angka++].ToString();
                        }
                        else if (k == jmlKolom - 1)
                        {
                            Array2D[b, jmlKolom - 1 - k] = fibo[angka++].ToString();
                            triger = !triger;
                        }
                    }
                        
                    
                }

            }
        }
    }
}
