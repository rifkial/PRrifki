using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            soal01 soal06 = new soal01(val);
            Console.Write("tekan aku sesuka masnya ajah");
            Console.ReadKey();
        }
    }
}
