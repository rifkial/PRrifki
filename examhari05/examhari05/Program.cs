using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari05
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("masukan nilai n");
            //Console.Readline

            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            soalposttest soal06 = new soalposttest(val);
            Console.Write("tekan aku sesuka masnya ajah");
            Console.ReadKey();
        }
    }
}
