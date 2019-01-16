using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari02
{
    class soal01
    {
        public soal01(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
            int ganjil = 1;
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (b == k)
                    {
                        Console.Write("{0}\t", ganjil);
                        ganjil += 2;
                    }
                    //prepare yg kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public void ContohPublic(int val)
        {
            Console.WriteLine("Masukan val : " + val);
            Console.ReadLine();
        }

        public static void ContohStatic(int val)
        {
            Console.WriteLine("Masukan val : " + val);
            Console.ReadLine();
        }
    }
}
