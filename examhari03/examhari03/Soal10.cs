using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(JmlhBaris / 2);
            int ascii = 64;
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= JmlhBaris - 1)
                    {
                        //if (b % 2 == 0)
                        //{
                        //    Array2D[b, k] = fibo[b / 2].ToString();
                        //    Array2D[JmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                        //}
                        //else
                        //{
                        //    Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //    Array2D[JmlhBaris - 1 - b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //}
                        Array2D[b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                        Array2D[JmlhBaris - 1 - b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= JmlhBaris - 1)
                    {
                        //Array2D[b, k] = fibo[k / 2].ToString();
                        //Array2D[b, JmlhKolom - 1 - k] = fibo[k / 2].ToString();
                        Array2D[b, k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                        Array2D[b, JmlhKolom - 1 - k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}