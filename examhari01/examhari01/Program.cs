using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n=9;
            //int w = 1;
            //for (int i = 1; i < n; i++)
            //{
            //    Console.WriteLine("\t{0}{1}",i,w);

            //}
            //Console.ReadKey();
            string jawab = "t"; // t artinya tidak
            while (jawab == "t")
            {
                Console.Write("----Logic 1----");
                ("\n");

            }
            //soal05 soal02 = new soal05();
            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            //soal06 soal06 = new soal06(val);
            //soal07 soal07 = new soal07(val);
            //soal08 soal08 = new soal08(val);
            soal09 soal09 = new soal09(val);
            //ganjalan
            Console.Write("teka sembarang tombol");
            Console.ReadKey();

        }
    }

   
}
