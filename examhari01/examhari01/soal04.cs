using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class soal04
    {
        public soal04()
        {

            Console.WriteLine("masukan nilai n :");

            int n = int.Parse(Console.ReadLine());
            //baris
            for (int b = 0; b < n; b++)
            {
                Console.WriteLine("\n");

                //kolom
                for (int k = 0; k < n; k++)
                {

                    //pindahkolom
                    if (b == k || b + k == n - 1 ||b == 4||k == 4)
                    {
                        Console.Write("\t{0}|{1}", b, k);
                    }
                    else
                    {
                        Console.Write("\t*");
                    }
                }

                //Console.WriteLine("\t*");
                Console.WriteLine("\n");
            }
            Console.WriteLine("tekan sembarang tombol");
            Console.ReadKey();

        
        }
    }
}
