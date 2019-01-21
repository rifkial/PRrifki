using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examhari03

{
    class SOAL09:LogicBase 
    {
        public SOAL09(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(JmlBaris / 2);

            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= JmlBaris - 1 && b % 2 == 0)
                    {
                        //Garis bawah
                        Array2D[b, k] = fibo[b / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array2D[JmlBaris - 1 - b, k] = fibo[b / 2].ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= JmlBaris - 1 && k % 2 == 0)
                    {
                        //Garis bawah
                        Array2D[b, k] = fibo[k / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array2D[b, JmlKolom - 1 - k] = fibo[k / 2].ToString();
                    }
                }
            }
        }
    }
}